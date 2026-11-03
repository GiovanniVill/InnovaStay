using System;
using System.Windows.Forms;

namespace UI
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            while (true)
            {
                using var loginForm = new LoginForm();
                DialogResult loginResult = loginForm.ShowDialog();

                if (loginResult != DialogResult.OK)
                {
                    break;
                }

                string role = LoginForm.LoggedInRole ?? "FrontDesk";

                Form mainDashboard = role.Equals("Admin", StringComparison.OrdinalIgnoreCase)
                    ? new AdminDashboardForm()
                    : new FrontDeskDashboardForm();

                Application.Run(mainDashboard);
            }
        }
    }
}