namespace DownloadWebImage
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvFileList = new System.Windows.Forms.DataGridView();
            this.lblImageURL = new System.Windows.Forms.Label();
            this.btnAddImageURL = new System.Windows.Forms.Button();
            this.lblBatchImageURL = new System.Windows.Forms.Label();
            this.lblPrefixFileName = new System.Windows.Forms.Label();
            this.txtPrefixFileName = new System.Windows.Forms.TextBox();
            this.txtSuffixFileName = new System.Windows.Forms.TextBox();
            this.btnCreateFileList = new System.Windows.Forms.Button();
            this.lblSavePath = new System.Windows.Forms.Label();
            this.btnClearFileList = new System.Windows.Forms.Button();
            this.btnStartDownload = new System.Windows.Forms.Button();
            this.tlpConfig = new System.Windows.Forms.TableLayoutPanel();
            this.btnBrowseSavePath = new System.Windows.Forms.Button();
            this.tlpFileList = new System.Windows.Forms.TableLayoutPanel();
            this.cbxFileExt = new System.Windows.Forms.ComboBox();
            this.lblSuffixFileName = new System.Windows.Forms.Label();
            this.lblCustomFileName = new System.Windows.Forms.Label();
            this.lblSerialNo = new System.Windows.Forms.Label();
            this.txtSerialStart = new System.Windows.Forms.TextBox();
            this.txtSerialStop = new System.Windows.Forms.TextBox();
            this.lblSP = new System.Windows.Forms.Label();
            this.txtBatchImageURL = new System.Windows.Forms.TextBox();
            this.txtImageURL = new System.Windows.Forms.TextBox();
            this.txtSavePath = new System.Windows.Forms.TextBox();
            this.lblSerialStart = new System.Windows.Forms.Label();
            this.lblSerialStop = new System.Windows.Forms.Label();
            this.lblConCurrentAction = new System.Windows.Forms.Label();
            this.cbxConCurrentAction = new System.Windows.Forms.ComboBox();
            this.btnStopDownload = new System.Windows.Forms.Button();
            this.btnDeleteSelect = new System.Windows.Forms.Button();
            this.dlgSelectFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.cmsFileList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUnSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmToggleSelect = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSP = new System.Windows.Forms.ToolStripSeparator();
            this.colSelected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colImageURL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFileList)).BeginInit();
            this.tlpConfig.SuspendLayout();
            this.tlpFileList.SuspendLayout();
            this.cmsFileList.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFileList
            // 
            this.dgvFileList.AllowUserToAddRows = false;
            this.dgvFileList.AllowUserToDeleteRows = false;
            this.dgvFileList.AllowUserToResizeColumns = false;
            this.dgvFileList.AllowUserToResizeRows = false;
            this.dgvFileList.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvFileList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvFileList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSelected,
            this.colImageURL,
            this.colStatus});
            this.dgvFileList.ContextMenuStrip = this.cmsFileList;
            this.dgvFileList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFileList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvFileList.Location = new System.Drawing.Point(3, 3);
            this.dgvFileList.MultiSelect = false;
            this.dgvFileList.Name = "dgvFileList";
            this.dgvFileList.ReadOnly = true;
            this.dgvFileList.RowHeadersVisible = false;
            this.dgvFileList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tlpFileList.SetRowSpan(this.dgvFileList, 8);
            this.dgvFileList.RowTemplate.Height = 24;
            this.dgvFileList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFileList.Size = new System.Drawing.Size(738, 255);
            this.dgvFileList.TabIndex = 0;
            this.dgvFileList.VirtualMode = true;
            // 
            // lblImageURL
            // 
            this.lblImageURL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblImageURL.AutoSize = true;
            this.lblImageURL.Location = new System.Drawing.Point(3, 55);
            this.lblImageURL.Name = "lblImageURL";
            this.lblImageURL.Size = new System.Drawing.Size(109, 14);
            this.lblImageURL.TabIndex = 1;
            this.lblImageURL.Text = "圖片網址：";
            this.lblImageURL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAddImageURL
            // 
            this.btnAddImageURL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddImageURL.Location = new System.Drawing.Point(668, 50);
            this.btnAddImageURL.Name = "btnAddImageURL";
            this.btnAddImageURL.Size = new System.Drawing.Size(74, 25);
            this.btnAddImageURL.TabIndex = 3;
            this.btnAddImageURL.Text = "加入清單";
            this.btnAddImageURL.UseVisualStyleBackColor = true;
            // 
            // lblBatchImageURL
            // 
            this.lblBatchImageURL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBatchImageURL.AutoSize = true;
            this.lblBatchImageURL.Location = new System.Drawing.Point(3, 100);
            this.lblBatchImageURL.Name = "lblBatchImageURL";
            this.lblBatchImageURL.Size = new System.Drawing.Size(109, 14);
            this.lblBatchImageURL.TabIndex = 4;
            this.lblBatchImageURL.Text = "批次圖片網址：";
            this.lblBatchImageURL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPrefixFileName
            // 
            this.lblPrefixFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrefixFileName.AutoSize = true;
            this.lblPrefixFileName.Location = new System.Drawing.Point(118, 135);
            this.lblPrefixFileName.Name = "lblPrefixFileName";
            this.lblPrefixFileName.Size = new System.Drawing.Size(194, 14);
            this.lblPrefixFileName.TabIndex = 11;
            this.lblPrefixFileName.Text = "前置字串：";
            this.lblPrefixFileName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPrefixFileName
            // 
            this.txtPrefixFileName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tlpConfig.SetColumnSpan(this.txtPrefixFileName, 3);
            this.txtPrefixFileName.Location = new System.Drawing.Point(317, 131);
            this.txtPrefixFileName.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrefixFileName.Name = "txtPrefixFileName";
            this.txtPrefixFileName.Size = new System.Drawing.Size(140, 23);
            this.txtPrefixFileName.TabIndex = 12;
            // 
            // txtSuffixFileName
            // 
            this.txtSuffixFileName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tlpConfig.SetColumnSpan(this.txtSuffixFileName, 2);
            this.txtSuffixFileName.Location = new System.Drawing.Point(552, 131);
            this.txtSuffixFileName.Margin = new System.Windows.Forms.Padding(2);
            this.txtSuffixFileName.Name = "txtSuffixFileName";
            this.txtSuffixFileName.Size = new System.Drawing.Size(140, 23);
            this.txtSuffixFileName.TabIndex = 13;
            // 
            // btnCreateFileList
            // 
            this.btnCreateFileList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateFileList.Location = new System.Drawing.Point(668, 165);
            this.btnCreateFileList.Name = "btnCreateFileList";
            this.btnCreateFileList.Size = new System.Drawing.Size(74, 25);
            this.btnCreateFileList.TabIndex = 14;
            this.btnCreateFileList.Text = "產生清單";
            this.btnCreateFileList.UseVisualStyleBackColor = true;
            // 
            // lblSavePath
            // 
            this.lblSavePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSavePath.AutoSize = true;
            this.lblSavePath.Location = new System.Drawing.Point(3, 10);
            this.lblSavePath.Name = "lblSavePath";
            this.lblSavePath.Size = new System.Drawing.Size(109, 14);
            this.lblSavePath.TabIndex = 15;
            this.lblSavePath.Text = "下載存放路徑：";
            this.lblSavePath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnClearFileList
            // 
            this.btnClearFileList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClearFileList.Location = new System.Drawing.Point(760, 3);
            this.btnClearFileList.Name = "btnClearFileList";
            this.btnClearFileList.Size = new System.Drawing.Size(87, 24);
            this.btnClearFileList.TabIndex = 18;
            this.btnClearFileList.Text = "清除清單";
            this.btnClearFileList.UseVisualStyleBackColor = true;
            // 
            // btnStartDownload
            // 
            this.btnStartDownload.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStartDownload.Location = new System.Drawing.Point(760, 133);
            this.btnStartDownload.Name = "btnStartDownload";
            this.btnStartDownload.Size = new System.Drawing.Size(87, 24);
            this.btnStartDownload.TabIndex = 19;
            this.btnStartDownload.Text = "執行下載";
            this.btnStartDownload.UseVisualStyleBackColor = true;
            // 
            // tlpConfig
            // 
            this.tlpConfig.ColumnCount = 10;
            this.tlpConfig.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tlpConfig.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tlpConfig.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tlpConfig.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpConfig.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tlpConfig.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpConfig.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tlpConfig.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tlpConfig.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpConfig.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpConfig.Controls.Add(this.lblSavePath, 0, 0);
            this.tlpConfig.Controls.Add(this.txtSavePath, 1, 0);
            this.tlpConfig.Controls.Add(this.lblImageURL, 0, 2);
            this.tlpConfig.Controls.Add(this.txtImageURL, 1, 2);
            this.tlpConfig.Controls.Add(this.lblBatchImageURL, 0, 4);
            this.tlpConfig.Controls.Add(this.txtBatchImageURL, 1, 4);
            this.tlpConfig.Controls.Add(this.btnAddImageURL, 8, 2);
            this.tlpConfig.Controls.Add(this.btnBrowseSavePath, 8, 0);
            this.tlpConfig.Controls.Add(this.cbxFileExt, 8, 4);
            this.tlpConfig.Controls.Add(this.lblCustomFileName, 7, 4);
            this.tlpConfig.Controls.Add(this.txtSerialStart, 3, 6);
            this.tlpConfig.Controls.Add(this.lblSP, 6, 4);
            this.tlpConfig.Controls.Add(this.lblPrefixFileName, 1, 5);
            this.tlpConfig.Controls.Add(this.lblSerialNo, 1, 6);
            this.tlpConfig.Controls.Add(this.txtSerialStop, 5, 6);
            this.tlpConfig.Controls.Add(this.lblSerialStop, 4, 6);
            this.tlpConfig.Controls.Add(this.lblSerialStart, 2, 6);
            this.tlpConfig.Controls.Add(this.txtPrefixFileName, 2, 5);
            this.tlpConfig.Controls.Add(this.btnCreateFileList, 8, 6);
            this.tlpConfig.Controls.Add(this.txtSuffixFileName, 7, 5);
            this.tlpConfig.Controls.Add(this.lblSuffixFileName, 5, 5);
            this.tlpConfig.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpConfig.Location = new System.Drawing.Point(0, 0);
            this.tlpConfig.Name = "tlpConfig";
            this.tlpConfig.RowCount = 8;
            this.tlpConfig.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpConfig.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpConfig.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpConfig.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpConfig.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpConfig.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpConfig.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpConfig.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpConfig.Size = new System.Drawing.Size(864, 200);
            this.tlpConfig.TabIndex = 20;
            // 
            // btnBrowseSavePath
            // 
            this.btnBrowseSavePath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnBrowseSavePath.Location = new System.Drawing.Point(668, 5);
            this.btnBrowseSavePath.Name = "btnBrowseSavePath";
            this.btnBrowseSavePath.Size = new System.Drawing.Size(50, 25);
            this.btnBrowseSavePath.TabIndex = 18;
            this.btnBrowseSavePath.Text = "瀏覽";
            this.btnBrowseSavePath.UseVisualStyleBackColor = true;
            // 
            // tlpFileList
            // 
            this.tlpFileList.ColumnCount = 2;
            this.tlpFileList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFileList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlpFileList.Controls.Add(this.btnClearFileList, 1, 0);
            this.tlpFileList.Controls.Add(this.dgvFileList, 0, 0);
            this.tlpFileList.Controls.Add(this.btnStartDownload, 1, 5);
            this.tlpFileList.Controls.Add(this.lblConCurrentAction, 1, 3);
            this.tlpFileList.Controls.Add(this.cbxConCurrentAction, 1, 4);
            this.tlpFileList.Controls.Add(this.btnStopDownload, 1, 6);
            this.tlpFileList.Controls.Add(this.btnDeleteSelect, 1, 1);
            this.tlpFileList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFileList.Location = new System.Drawing.Point(0, 200);
            this.tlpFileList.Name = "tlpFileList";
            this.tlpFileList.RowCount = 8;
            this.tlpFileList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpFileList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpFileList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpFileList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpFileList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpFileList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpFileList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpFileList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFileList.Size = new System.Drawing.Size(864, 261);
            this.tlpFileList.TabIndex = 21;
            // 
            // cbxFileExt
            // 
            this.cbxFileExt.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbxFileExt.BackColor = System.Drawing.Color.White;
            this.cbxFileExt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFileExt.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbxFileExt.FormattingEnabled = true;
            this.cbxFileExt.Items.AddRange(new object[] {
            ".jpg",
            ".gif",
            ".png",
            ".bmp"});
            this.cbxFileExt.Location = new System.Drawing.Point(668, 97);
            this.cbxFileExt.Name = "cbxFileExt";
            this.cbxFileExt.Size = new System.Drawing.Size(70, 21);
            this.cbxFileExt.TabIndex = 19;
            // 
            // lblSuffixFileName
            // 
            this.lblSuffixFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSuffixFileName.AutoSize = true;
            this.tlpConfig.SetColumnSpan(this.lblSuffixFileName, 2);
            this.lblSuffixFileName.Location = new System.Drawing.Point(468, 135);
            this.lblSuffixFileName.Name = "lblSuffixFileName";
            this.lblSuffixFileName.Size = new System.Drawing.Size(79, 14);
            this.lblSuffixFileName.TabIndex = 21;
            this.lblSuffixFileName.Text = "後置字串：";
            this.lblSuffixFileName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCustomFileName
            // 
            this.lblCustomFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCustomFileName.AutoSize = true;
            this.lblCustomFileName.Location = new System.Drawing.Point(553, 100);
            this.lblCustomFileName.Name = "lblCustomFileName";
            this.lblCustomFileName.Size = new System.Drawing.Size(109, 14);
            this.lblCustomFileName.TabIndex = 22;
            this.lblCustomFileName.Text = "自定義檔案名稱";
            this.lblCustomFileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSerialNo
            // 
            this.lblSerialNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSerialNo.AutoSize = true;
            this.lblSerialNo.Location = new System.Drawing.Point(118, 170);
            this.lblSerialNo.Name = "lblSerialNo";
            this.lblSerialNo.Size = new System.Drawing.Size(194, 14);
            this.lblSerialNo.TabIndex = 23;
            this.lblSerialNo.Text = "流水號：";
            this.lblSerialNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSerialStart
            // 
            this.txtSerialStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSerialStart.Location = new System.Drawing.Point(363, 166);
            this.txtSerialStart.MaxLength = 6;
            this.txtSerialStart.Name = "txtSerialStart";
            this.txtSerialStart.Size = new System.Drawing.Size(54, 23);
            this.txtSerialStart.TabIndex = 24;
            // 
            // txtSerialStop
            // 
            this.txtSerialStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSerialStop.Location = new System.Drawing.Point(468, 166);
            this.txtSerialStop.MaxLength = 6;
            this.txtSerialStop.Name = "txtSerialStop";
            this.txtSerialStop.Size = new System.Drawing.Size(54, 23);
            this.txtSerialStop.TabIndex = 25;
            // 
            // lblSP
            // 
            this.lblSP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSP.AutoSize = true;
            this.lblSP.Location = new System.Drawing.Point(528, 100);
            this.lblSP.Name = "lblSP";
            this.lblSP.Size = new System.Drawing.Size(19, 14);
            this.lblSP.TabIndex = 26;
            this.lblSP.Text = "\\";
            this.lblSP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBatchImageURL
            // 
            this.txtBatchImageURL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpConfig.SetColumnSpan(this.txtBatchImageURL, 5);
            this.txtBatchImageURL.Location = new System.Drawing.Point(118, 96);
            this.txtBatchImageURL.Name = "txtBatchImageURL";
            this.txtBatchImageURL.Size = new System.Drawing.Size(404, 23);
            this.txtBatchImageURL.TabIndex = 5;
            // 
            // txtImageURL
            // 
            this.txtImageURL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpConfig.SetColumnSpan(this.txtImageURL, 7);
            this.txtImageURL.Location = new System.Drawing.Point(118, 51);
            this.txtImageURL.Name = "txtImageURL";
            this.txtImageURL.Size = new System.Drawing.Size(544, 23);
            this.txtImageURL.TabIndex = 2;
            // 
            // txtSavePath
            // 
            this.txtSavePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSavePath.BackColor = System.Drawing.SystemColors.Window;
            this.tlpConfig.SetColumnSpan(this.txtSavePath, 7);
            this.txtSavePath.Location = new System.Drawing.Point(118, 6);
            this.txtSavePath.Name = "txtSavePath";
            this.txtSavePath.ReadOnly = true;
            this.txtSavePath.Size = new System.Drawing.Size(544, 23);
            this.txtSavePath.TabIndex = 16;
            // 
            // lblSerialStart
            // 
            this.lblSerialStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSerialStart.AutoSize = true;
            this.lblSerialStart.Location = new System.Drawing.Point(320, 170);
            this.lblSerialStart.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblSerialStart.Name = "lblSerialStart";
            this.lblSerialStart.Size = new System.Drawing.Size(40, 14);
            this.lblSerialStart.TabIndex = 27;
            this.lblSerialStart.Text = "起：";
            this.lblSerialStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSerialStop
            // 
            this.lblSerialStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSerialStop.AutoSize = true;
            this.lblSerialStop.Location = new System.Drawing.Point(425, 170);
            this.lblSerialStop.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblSerialStop.Name = "lblSerialStop";
            this.lblSerialStop.Size = new System.Drawing.Size(40, 14);
            this.lblSerialStop.TabIndex = 28;
            this.lblSerialStop.Text = "迄：";
            this.lblSerialStop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblConCurrentAction
            // 
            this.lblConCurrentAction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblConCurrentAction.AutoSize = true;
            this.lblConCurrentAction.Location = new System.Drawing.Point(747, 83);
            this.lblConCurrentAction.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.lblConCurrentAction.Name = "lblConCurrentAction";
            this.lblConCurrentAction.Size = new System.Drawing.Size(114, 14);
            this.lblConCurrentAction.TabIndex = 20;
            this.lblConCurrentAction.Text = "同時下載數量：";
            this.lblConCurrentAction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxConCurrentAction
            // 
            this.cbxConCurrentAction.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbxConCurrentAction.BackColor = System.Drawing.Color.White;
            this.cbxConCurrentAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxConCurrentAction.FormattingEnabled = true;
            this.cbxConCurrentAction.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbxConCurrentAction.Location = new System.Drawing.Point(816, 105);
            this.cbxConCurrentAction.Name = "cbxConCurrentAction";
            this.cbxConCurrentAction.Size = new System.Drawing.Size(45, 21);
            this.cbxConCurrentAction.TabIndex = 21;
            // 
            // btnStopDownload
            // 
            this.btnStopDownload.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStopDownload.Location = new System.Drawing.Point(760, 163);
            this.btnStopDownload.Name = "btnStopDownload";
            this.btnStopDownload.Size = new System.Drawing.Size(87, 24);
            this.btnStopDownload.TabIndex = 22;
            this.btnStopDownload.Text = "下載中止";
            this.btnStopDownload.UseVisualStyleBackColor = true;
            // 
            // btnDeleteSelect
            // 
            this.btnDeleteSelect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteSelect.Location = new System.Drawing.Point(760, 33);
            this.btnDeleteSelect.Name = "btnDeleteSelect";
            this.btnDeleteSelect.Size = new System.Drawing.Size(87, 24);
            this.btnDeleteSelect.TabIndex = 23;
            this.btnDeleteSelect.Text = "刪除選取";
            this.btnDeleteSelect.UseVisualStyleBackColor = true;
            // 
            // dlgSelectFolder
            // 
            this.dlgSelectFolder.Description = "請選取路徑";
            // 
            // cmsFileList
            // 
            this.cmsFileList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSelectAll,
            this.tsmUnSelectAll,
            this.tsmSP,
            this.tsmToggleSelect});
            this.cmsFileList.Name = "cmsFileList";
            this.cmsFileList.ShowImageMargin = false;
            this.cmsFileList.Size = new System.Drawing.Size(98, 76);
            // 
            // tsmSelectAll
            // 
            this.tsmSelectAll.Name = "tsmSelectAll";
            this.tsmSelectAll.Size = new System.Drawing.Size(155, 22);
            this.tsmSelectAll.Text = "全部選取";
            // 
            // tsmUnSelectAll
            // 
            this.tsmUnSelectAll.Name = "tsmUnSelectAll";
            this.tsmUnSelectAll.Size = new System.Drawing.Size(155, 22);
            this.tsmUnSelectAll.Text = "全部取消";
            // 
            // tsmToggleSelect
            // 
            this.tsmToggleSelect.Name = "tsmToggleSelect";
            this.tsmToggleSelect.Size = new System.Drawing.Size(155, 22);
            this.tsmToggleSelect.Text = "反向選取";
            // 
            // tsmSP
            // 
            this.tsmSP.Name = "tsmSP";
            this.tsmSP.Size = new System.Drawing.Size(152, 6);
            // 
            // colSelected
            // 
            this.colSelected.HeaderText = "選取";
            this.colSelected.MinimumWidth = 45;
            this.colSelected.Name = "colSelected";
            this.colSelected.ReadOnly = true;
            this.colSelected.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colSelected.Width = 45;
            // 
            // colImageURL
            // 
            this.colImageURL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colImageURL.HeaderText = "圖片網址";
            this.colImageURL.Name = "colImageURL";
            this.colImageURL.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "狀態";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            this.colStatus.Width = 150;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 461);
            this.Controls.Add(this.tlpFileList);
            this.Controls.Add(this.tlpConfig);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("新細明體", 10F);
            this.Name = "MainForm";
            this.Text = "網站圖片下載器";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFileList)).EndInit();
            this.tlpConfig.ResumeLayout(false);
            this.tlpConfig.PerformLayout();
            this.tlpFileList.ResumeLayout(false);
            this.tlpFileList.PerformLayout();
            this.cmsFileList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFileList;
        private System.Windows.Forms.Label lblImageURL;
        private System.Windows.Forms.Button btnAddImageURL;
        private System.Windows.Forms.Label lblBatchImageURL;
        private System.Windows.Forms.Label lblPrefixFileName;
        private System.Windows.Forms.TextBox txtPrefixFileName;
        private System.Windows.Forms.TextBox txtSuffixFileName;
        private System.Windows.Forms.Button btnCreateFileList;
        private System.Windows.Forms.Label lblSavePath;
        private System.Windows.Forms.Button btnClearFileList;
        private System.Windows.Forms.Button btnStartDownload;
        private System.Windows.Forms.TableLayoutPanel tlpConfig;
        private System.Windows.Forms.TableLayoutPanel tlpFileList;
        private System.Windows.Forms.Button btnBrowseSavePath;
        private System.Windows.Forms.ComboBox cbxFileExt;
        private System.Windows.Forms.TextBox txtSavePath;
        private System.Windows.Forms.TextBox txtImageURL;
        private System.Windows.Forms.TextBox txtBatchImageURL;
        private System.Windows.Forms.Label lblCustomFileName;
        private System.Windows.Forms.Label lblSerialNo;
        private System.Windows.Forms.TextBox txtSerialStart;
        private System.Windows.Forms.TextBox txtSerialStop;
        private System.Windows.Forms.Label lblSP;
        private System.Windows.Forms.Label lblSuffixFileName;
        private System.Windows.Forms.Label lblSerialStop;
        private System.Windows.Forms.Label lblSerialStart;
        private System.Windows.Forms.Label lblConCurrentAction;
        private System.Windows.Forms.ComboBox cbxConCurrentAction;
        private System.Windows.Forms.Button btnStopDownload;
        private System.Windows.Forms.Button btnDeleteSelect;
        private System.Windows.Forms.FolderBrowserDialog dlgSelectFolder;
        private System.Windows.Forms.ContextMenuStrip cmsFileList;
        private System.Windows.Forms.ToolStripMenuItem tsmSelectAll;
        private System.Windows.Forms.ToolStripMenuItem tsmUnSelectAll;
        private System.Windows.Forms.ToolStripSeparator tsmSP;
        private System.Windows.Forms.ToolStripMenuItem tsmToggleSelect;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn colImageURL;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
    }
}

