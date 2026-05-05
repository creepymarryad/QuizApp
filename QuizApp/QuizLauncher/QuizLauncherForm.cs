using System.Diagnostics;

namespace QuizLauncher
{
    public partial class QuizLauncherForm : Form
    {
        public QuizLauncherForm()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile(@"Images\mc_bg.png");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            RunCreatorBtn.BackgroundImage = Image.FromFile(@"Images\mc_tile.png");
            RunCreatorBtn.BackgroundImageLayout = ImageLayout.Stretch;
            RunSolverBtn.BackgroundImage = Image.FromFile(@"Images\mc_tile.png");
            RunSolverBtn.BackgroundImageLayout = ImageLayout.Stretch;

            FontManager.LoadFont(@"Fonts\Monocraft.ttc");

            LauncherLabel.Font = FontManager.GetFont(28f, 0);
            RunCreatorBtn.Font = FontManager.GetFont(20f, 0);
            RunSolverBtn.Font = FontManager.GetFont(20f, 0);
        }
        private void RunCreatorBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("Creator.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void RunSolverBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("Solver.exe");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
