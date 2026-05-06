using Solver.Interfaces;

namespace Solver.Views
{
    public partial class MainMenuView : UserControl, IMainMenuView
    {
        public MainMenuView()
        {
            InitializeComponent();

            this.BackgroundImage = UI.Properties.Resources.mc_bg;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            panel_QuizInfo.BackColor = Color.Transparent;
            label_FileSelect.Font = UI.FontManager.GetFont(16f, 0);
            label_FileSelect.ForeColor = Color.White;
            label_FileSelect.BackColor = Color.DimGray;
            label_Password.Font = UI.FontManager.GetFont(16f, 0);
            label_Password.ForeColor = Color.White;
            label_Password.BackColor = Color.DimGray;
            label_QuizMaxScore.Font = UI.FontManager.GetFont(16f, 0);
            label_QuizMaxScore.ForeColor = Color.White;
            label_QuizMaxScore.BackColor = Color.DimGray;
            label_QuizQuestions.Font = UI.FontManager.GetFont(16f, 0);
            label_QuizQuestions.ForeColor = Color.White;
            label_QuizQuestions.BackColor = Color.DimGray;
            label_QuizTime.Font = UI.FontManager.GetFont(16f, 0);
            label_QuizTime.ForeColor = Color.White;
            label_QuizTime.BackColor = Color.DimGray;
            label_QuizTitle.Font = UI.FontManager.GetFont(20f, 0);
            label_QuizTitle.ForeColor = Color.Yellow;
            label_QuizTitle.BackColor = Color.DimGray;
            label_Title.Font = UI.FontManager.GetFont(28f, 0, FontStyle.Bold);
            label_Title.ForeColor = Color.Yellow;
            label_Title.BackColor = Color.DimGray;

            textBox_Password.BackColor = Color.DimGray;
            textBox_Password.ForeColor = Color.White;
            textBox_Password.BorderStyle = BorderStyle.FixedSingle;
            textBox_Password.Font = UI.FontManager.GetFont(16f);

            button_Start.BackgroundImage = UI.Properties.Resources.mc_tile;
            button_Start.BackgroundImageLayout = ImageLayout.Stretch;
            button_Start.Font = UI.FontManager.GetFont(16f);
            button_Start.FlatStyle = FlatStyle.Flat;
            button_Start.FlatAppearance.BorderSize = 0;
            button_Start.ForeColor = Color.White;

            button_SelectFile.BackgroundImage = UI.Properties.Resources.mc_tile;
            button_SelectFile.BackgroundImageLayout = ImageLayout.Stretch;
            button_SelectFile.Font = UI.FontManager.GetFont(14f);
            button_SelectFile.FlatStyle = FlatStyle.Flat;
            button_SelectFile.FlatAppearance.BorderSize = 0;
            button_SelectFile.ForeColor = Color.White;

            
        }

        public string FilePath { get; set; }
        public string Password => textBox_Password.Text;

        public string QuizTitle { set => label_QuizTitle.Text = value; }
        public string QuizTime { set => label_QuizTime.Text = "Time: " + value; }
        public string QuizQuestionsCount { set => label_QuizQuestions.Text = "Questions: " + value; }
        public string QuizMaxScore { set => label_QuizMaxScore.Text = "Max Score: " + value; }
        public bool StartButtonEnabled { set => button_Start.Enabled = value; }
        public bool QuizInfoVisible { set => panel_QuizInfo.Visible = value; }

        public event EventHandler LoadFileClicked;
        public event EventHandler StartQuizClicked;

        private void btnLoad_Click(object sender, EventArgs e) => 
            LoadFileClicked?.Invoke(this, EventArgs.Empty);
        private void btnStart_Click(object sender, EventArgs e) => 
            StartQuizClicked?.Invoke(this, EventArgs.Empty);

        public string SelectFile()
        {
            using var ofd = new OpenFileDialog();
            return ofd.ShowDialog() == DialogResult.OK ? ofd.FileName : null;
        }

        public void ShowError(string message) => 
            MessageBox.Show(message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
