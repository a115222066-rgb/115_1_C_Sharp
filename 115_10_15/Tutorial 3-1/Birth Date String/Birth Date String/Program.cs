using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Birth_Date_String
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            // 啟用 Windows 視覺樣式，讓控制項使用目前的系統外觀。
            Application.EnableVisualStyles();
            // 設定控制項使用較新的文字繪製方式。
            Application.SetCompatibleTextRenderingDefault(false);
            // 建立並顯示主表單，開始執行應用程式訊息迴圈。
            Application.Run(new Form1());
        }
    }
}
