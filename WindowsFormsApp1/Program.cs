using System;
using System.Data.Entity;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            using (var db = new UserProfileDBContext())
            {
                db.Database.Initialize(force: true);
            }
            Application.Run(new Form1());
        }
    }
}
