using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DownloadWebImage
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        public static void WaitSeconds(double Seconds)
        {
            long _tick1 = DateTime.Now.Ticks;
            long _tick2 = DateTime.Now.Ticks;
            while ((_tick2 - _tick1) < (Seconds * 10000000))
            {
                _tick2 = DateTime.Now.Ticks;
            }
        }

        /// <summary>
        /// 停頓指定時間(毫秒)
        /// </summary>
        /// <param name="Seconds">毫秒數</param>
        public static void WaitMilliSeconds(double Seconds)
        {
            long _tick1 = DateTime.Now.Ticks;
            long _tick2 = DateTime.Now.Ticks;
            while ((_tick2 - _tick1) < (Seconds * 10000))
            {
                _tick2 = DateTime.Now.Ticks;
            }
        }
    }

    /// <summary>
    /// 檔案狀態列舉
    /// </summary>
    public enum FileStatusENUM : int
    {
        /// <summary>
        /// 無
        /// </summary>
        None = 0,
        /// <summary>
        /// 等待下載
        /// </summary>
        Wait = 1,
        /// <summary>
        /// 下載失敗
        /// </summary>
        Error = 2,
        /// <summary>
        /// 下載中
        /// </summary>
        Downloading = 5,
        /// <summary>
        /// 已完成
        /// </summary>
        Finish = 10

    }

    /// <summary>
    /// 檔案清單類別
    /// </summary>
    public class FileListModel
    {
        /// <summary>
        /// 是否選取
        /// </summary>
        public bool Selected { get; set; }

        /// <summary>
        /// 編號
        /// </summary>
        public int SerialID { get; set; }

        /// <summary>
        /// 網址
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// 存檔路徑
        /// </summary>
        public string SavePath { get; set; }

        /// <summary>
        /// 檔案名稱
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// 完整儲存檔名
        /// </summary>
        public string SaveFileName
        {
            get
            {
                if (SavePath.EndsWith("\\"))
                    return SavePath + FileName;
                else
                    return SavePath + "\\" + FileName;
            }
        }

        /// <summary>
        /// 狀態
        /// </summary>
        public FileStatusENUM Status { get; set; }

        /// <summary>
        /// 狀態(文字)
        /// </summary>
        public string DownloadStatus
        {
            get
            {
                if (Status == FileStatusENUM.Wait)
                    return "等待中";
                else if (Status == FileStatusENUM.Downloading)
                    return "下載中";
                else if (Status == FileStatusENUM.Finish)
                    return "已完成";
                else if (Status == FileStatusENUM.Error)
                    return "失敗";
                else
                    return "";
            }
        }
    }

    public class ActionPoolModel
    {
        public Thread ThreadProcess { get; set; }
    }
}
