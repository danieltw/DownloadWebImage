using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DownloadWebImage
{
    public partial class MainForm : Form
    {
        #region 自定變數
        /// <summary>
        /// 下載狀態
        /// </summary>
        public bool DownloadRunning { get; set; }

        /// <summary>
        /// 檔案清單資料集
        /// </summary>
        public List<FileListModel> lstFileList = new List<FileListModel>();

        public List<Thread> lstProcPools = new List<Thread>();
        #endregion

        public MainForm()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.MainIcon;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cbxFileExt.SelectedIndex = 0;
            cbxConCurrentAction.SelectedIndex = 0;
            dgvFileList.DataSource = new BindingList<FileListModel>(lstFileList);
            DownloadRunning = false;
        }

        /// <summary>
        /// 只允許輸入數字
        /// </summary>
        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8)
                e.Handled = true;
            else
                e.Handled = false;
        }

        /// <summary>
        /// 顯示訊息
        /// </summary>
        /// <param name="ShowText">訊息文字</param>
        public void ShowPopupText(string ShowText)
        {
            if (this.InvokeRequired)
            {
                Action action = () =>
                {
                    MessageBox.Show(ShowText, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                };
                this.Invoke(action);
            }
            else
            {
                MessageBox.Show(ShowText, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); ;
            }
        }

        /// <summary>
        /// 切換表單狀態
        /// </summary>
        /// <param name="IsActive">是否啟用控制項</param>
        private void ToggleFormStatus(bool IsActive)
        {
            btnBrowseSavePath.Enabled = IsActive;
            btnAddImageURL.Enabled = IsActive;
            btnCreateFileList.Enabled = IsActive;
            btnClearFileList.Enabled = IsActive;
            btnDeleteSelect.Enabled = IsActive;
            btnStartDownload.Enabled = IsActive;
            btnStopDownload.Enabled = !IsActive;

            cbxFileExt.Enabled = IsActive;
            cbxConCurrentAction.Enabled = IsActive;

            txtImageURL.ReadOnly = !IsActive;
            txtBatchImageURL.ReadOnly = !IsActive;
            txtPrefixFileName.ReadOnly = !IsActive;
            txtSuffixFileName.ReadOnly = !IsActive;
            txtSerialStart.ReadOnly = !IsActive;
            txtSerialStop.ReadOnly = !IsActive;
            txtSerialLength.ReadOnly = !IsActive;

            cmsFileList.Enabled = IsActive;
        }

        #region 按鍵處理
        /// <summary>
        /// 選取存放路徑
        /// </summary>
        private void btnBrowseSavePath_Click(object sender, EventArgs e)
        {
            if (dlgSelectFolder.ShowDialog() != DialogResult.OK) return;
            txtSavePath.Text = dlgSelectFolder.SelectedPath;
        }

        /// <summary>
        /// 加入網址
        /// </summary>
        private void btnAddImageURL_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSavePath.Text))
            {
                ShowPopupText("請先輸入存放路徑!");
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtImageURL.Text))
            {
                ShowPopupText("請先輸入圖片網址!");
                return;
            }

            string savePath = txtSavePath.Text.Trim();
            string sFileName = txtImageURL.Text.Trim();

            sFileName = sFileName.Split(new string[] { "/" }, StringSplitOptions.RemoveEmptyEntries).Last();
            if (!savePath.EndsWith("\\")) savePath += "\\";

            FileListModel tmpAdd = new FileListModel()
            {
                Selected = false,
                Status = FileStatusENUM.None,
                Url = txtImageURL.Text,
                FileName = sFileName,
                SavePath = savePath
            };

            if (lstFileList.Any())
                tmpAdd.SerialID = lstFileList.Max(x => x.SerialID) + 1;
            else
                tmpAdd.SerialID = 1;

            lstFileList.Add(tmpAdd);
            dgvFileList.DataSource = new BindingList<FileListModel>(lstFileList);
        }

        /// <summary>
        /// 批次加入網址
        /// </summary>
        private void btnCreateFileList_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSavePath.Text))
            {
                ShowPopupText("請先輸入存放路徑!");
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtBatchImageURL.Text))
            {
                ShowPopupText("請先輸入批次的圖片網址!");
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtSerialStart.Text) || string.IsNullOrWhiteSpace(txtSerialStop.Text))
            {
                ShowPopupText("請先輸入流水號的起迄值!");
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtSerialLength.Text))
            {
                ShowPopupText("請先輸入流水號的長度值!");
                return;
            }

            int iStart = Convert.ToInt32(txtSerialStart.Text.Trim());
            int iStop = Convert.ToInt32(txtSerialStop.Text.Trim());
            int iLength = Convert.ToInt32(txtSerialLength.Text.Trim());

            if (iStart > iStop)
            {
                ShowPopupText("流水號的起值不能大於迄值!");
                return;
            }

            string rootURL = txtBatchImageURL.Text.Trim();
            if (!rootURL.EndsWith("/")) rootURL += "/";

            string savePath = txtSavePath.Text.Trim();
            string _prfix = txtPrefixFileName.Text.Trim();
            string _suffix = txtSuffixFileName.Text.Trim();
            string _ext = cbxFileExt.Text;
            string zero = "";

            for (int i = 0; i < iLength; i++)
            {
                zero += "0";
            }

            if (!savePath.EndsWith("\\")) savePath += "\\";

            int _Serial = lstFileList.Any() ? lstFileList.Max(x => x.SerialID) + 1 : 1;
            for (int i = iStart; i <= iStop; i++)
            {
                string _fileName = string.Format("{0}{1}{2}{3}", _prfix, i.ToString(zero), _suffix, _ext);
                lstFileList.Add(new FileListModel()
                {
                    Selected = false,
                    Status = FileStatusENUM.None,
                    FileName = _fileName,
                    Url = string.Format("{0}{1}", rootURL, _fileName),
                    SerialID = _Serial,
                    SavePath = savePath
                });
                _Serial += 1;
            }

            dgvFileList.DataSource = new BindingList<FileListModel>(lstFileList);
        }

        /// <summary>
        /// 開始下載
        /// </summary>
        private void btnStartDownload_Click(object sender, EventArgs e)
        {
            if (DownloadRunning) return;
            DownloadRunning = true;

            ToggleFormStatus(false);
            int iMaxProcess = Convert.ToInt32(cbxConCurrentAction.Text);

            lstFileList.Where(x => x.Status == FileStatusENUM.None || x.Status == FileStatusENUM.Error).ToList().ForEach(x => { x.Status = FileStatusENUM.Wait; });

            for (int i = 0; i < iMaxProcess; i++)
            {
                string _name = "Proc" + i.ToString();
                Thread tmpThread = new Thread(() => { ExecuteProcess(_name); });
                tmpThread.Name = _name;
                lstProcPools.Add(tmpThread);
                tmpThread.Start();

                Program.WaitSeconds(0.1);
            }
        }

        /// <summary>
        /// 終止下載
        /// </summary>
        private void btnStopDownload_Click(object sender, EventArgs e)
        {
            if (lstProcPools.Any())
            {
                lstProcPools.ForEach(x => { x.Abort(); x = null; });
                lstProcPools = new List<Thread>();
            }
            DownloadRunning = false;
            ToggleFormStatus(true);

        }
        #endregion

        #region Popup 選單
        /// <summary>
        /// 顯示視窗前
        /// </summary>
        private void cmsFileList_Opening(object sender, CancelEventArgs e)
        {
            if (DownloadRunning) e.Cancel = true;
        }

        /// <summary>
        /// 全部選取
        /// </summary>
        private void tsmSelectAll_Click(object sender, EventArgs e)
        {
            lstFileList.Where(x => !x.Selected).ToList().ForEach(x => { x.Selected = true; });
            dgvFileList.Refresh();
        }

        /// <summary>
        /// 全部取消
        /// </summary>
        private void tsmUnSelectAll_Click(object sender, EventArgs e)
        {
            lstFileList.Where(x => x.Selected).ToList().ForEach(x => { x.Selected = false; });
            dgvFileList.Refresh();
        }

        /// <summary>
        /// 反向選取
        /// </summary>
        private void tsmToggleSelect_Click(object sender, EventArgs e)
        {
            lstFileList.ForEach(x => { x.Selected = !x.Selected; });
            dgvFileList.Refresh();
        }

        #endregion

        #region 網址清單處理
        /// <summary>
        /// 清除網址清單
        /// </summary>
        private void btnClearFileList_Click(object sender, EventArgs e)
        {
            lstFileList = new List<FileListModel>();
            dgvFileList.DataSource = new BindingList<FileListModel>(lstFileList);
        }

        /// <summary>
        /// 刪除已選取的網址
        /// </summary>
        private void btnDeleteSelect_Click(object sender, EventArgs e)
        {
            lstFileList.RemoveAll(x => x.Selected);

            int iSerial = 1;
            lstFileList.ForEach(x => { x.SerialID = iSerial; iSerial += 1; });
            dgvFileList.DataSource = new BindingList<FileListModel>(lstFileList);
        }

        /// <summary>
        /// 檔案清單選取
        /// </summary>
        private void dgvFileList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != 0 || DownloadRunning) return;
            lstFileList[e.RowIndex].Selected = !lstFileList[e.RowIndex].Selected;
        }

        /// <summary>
        /// 更新項目的下載狀態
        /// </summary>
        /// <param name="SerialID">編號</param>
        /// <param name="newStatus">新狀態</param>
        private void UpdateStatus()
        {
            if (this.InvokeRequired)
            {
                Action action = () =>
                {
                    dgvFileList.Refresh();
                };
                this.Invoke(action);
            }
            else
            {
                dgvFileList.Refresh();
            }
        }
        #endregion

        /// <summary>
        /// 下載檔案
        /// </summary>
        /// <param name="ProcName">執行緒名稱</param>
        private void ExecuteProcess(string ProcName)
        {
            while (lstFileList.Any(x => x.Status == FileStatusENUM.Wait))
            {
                var work = lstFileList.Where(x => x.Status == FileStatusENUM.Wait).FirstOrDefault();
                if (work == null) break;
                var tmpFileItem = lstFileList.Single(x => x.SerialID == work.SerialID);
                try
                {
                    tmpFileItem.Status = FileStatusENUM.Downloading;
                    UpdateStatus();

                    HttpWebRequest httpRequest = (HttpWebRequest)WebRequest.Create(work.Url);
                    HttpWebResponse httpResponse = (HttpWebResponse)httpRequest.GetResponse();

                    System.IO.Stream dataStream = httpResponse.GetResponseStream();
                    byte[] buffer = new byte[8192];

                    if (!Directory.Exists(work.SavePath)) Directory.CreateDirectory(work.SavePath);

                    using (FileStream fs = new FileStream(work.SaveFileName, FileMode.Create, FileAccess.Write))
                    {
                        int size = dataStream.Read(buffer, 0, buffer.Length);
                        while (size > 0)
                        {
                            fs.Write(buffer, 0, size);
                            size = dataStream.Read(buffer, 0, buffer.Length);
                        }
                    }

                    httpResponse.Close();

                    tmpFileItem.Status = FileStatusENUM.Finish;
                }
                catch
                {
                    tmpFileItem.Status = FileStatusENUM.Error;
                }
                finally
                {
                    UpdateStatus();
                }
            }

            lstProcPools.RemoveAll(x => x.Name == ProcName);

            if (!lstProcPools.Any())
            {
                if (this.InvokeRequired)
                {
                    Action action = () =>
                    {
                        DownloadRunning = false;
                        ToggleFormStatus(true);
                    };
                    this.Invoke(action);
                }
                else
                {
                    DownloadRunning = false;
                    ToggleFormStatus(true);
                }
            }
        }
    }
}
