using System;
using System.Windows.Forms;


namespace Metro
{

    static class Program
    {
        // Главная точка входа для приложения.
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MetroForm());
            }
            catch (Exception e)
            {
                MessageBox.Show(
                e.Message,
                "Вызвано исключение",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }
    }
}
