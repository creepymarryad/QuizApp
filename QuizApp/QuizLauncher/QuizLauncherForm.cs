using System.Diagnostics;

namespace QuizLauncher
{
    public partial class QuizLauncherForm : Form
    {
        public QuizLauncherForm()
        {
            InitializeComponent();
            this.BackgroundImage = UI.Properties.Resources.mc_bg;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            RunCreatorBtn.BackgroundImage = UI.Properties.Resources.mc_tile;
            RunCreatorBtn.BackgroundImageLayout = ImageLayout.Stretch;

            RunSolverBtn.BackgroundImage = UI.Properties.Resources.mc_tile;
            RunSolverBtn.BackgroundImageLayout = ImageLayout.Stretch;

            UI.FontManager.LoadFontFromResource("Monocraft.ttf");

            LauncherLabel.Font = UI.FontManager.GetFont(28f, 0);
            RunCreatorBtn.Font = UI.FontManager.GetFont(20f, 0);
            RunSolverBtn.Font = UI.FontManager.GetFont(20f, 0);
        }
        private void RunCreatorBtn_Click(object sender, EventArgs e)
        {
            Process[] runningCreators = Process.GetProcessesByName("Creator");
            try
            {
                if (runningCreators.Length == 0)
                {
                    Process.Start(@"Creator.exe");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void RunSolverBtn_Click(object sender, EventArgs e)
        {
            Process[] runningSolvers = Process.GetProcessesByName("Solver");
            try
            {
                if (runningSolvers.Length == 0)
                {
                    Process.Start(@"Solver.exe");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
