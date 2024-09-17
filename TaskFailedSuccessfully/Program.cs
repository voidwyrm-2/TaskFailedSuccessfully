using System;
using System.Windows.Forms;

namespace TaskFailedSuccessfully
{
    static class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MessageBox.Show("Task failed successfully.", "Windows XP", MessageBoxButtons.OK, args.Contains("-e") || args.Contains("--error") ? MessageBoxIcon.Error : MessageBoxIcon.Information);
        }
    }
}
