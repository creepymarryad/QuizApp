using Creator.Presenters;

namespace QuizApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            try
            {
                ApplicationConfiguration.Initialize();
                var mainView = new CreatorForm();
                var presenter = new CreatorPresenter(mainView);
                Application.Run(mainView);
            }
            catch (Exception ex)
            {
                // To okienko zatrzyma program i wypluje nam cały błąd na ekran
                MessageBox.Show($"Błąd krytyczny: {ex.Message}\n\nSzczegóły: {ex.StackTrace}",
                                "Crash Creatora!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

        }
    }
}