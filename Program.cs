using System;
using System.Windows.Forms;

namespace GeoBaha
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new Frm_AsnadList_New()); // یا فرم اصلی برنامه‌ات
        }
    }
}
