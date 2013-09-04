using System;
using System.Windows.Forms;
using DevExpress.LookAndFeel;

namespace ge.sql.corectsched.proto
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DevExpress.Skins.SkinManager.EnableFormSkins();
            UserLookAndFeel.Default.SetSkinStyle("Office 2013");

            Application.Run(new Form1());
        }
    }
}