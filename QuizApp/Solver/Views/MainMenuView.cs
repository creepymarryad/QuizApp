using Solver.Interfaces;

namespace Solver.Views
{
    public partial class MainMenuView : UserControl, IMainMenuView
    {
        public MainMenuView()
        {
            InitializeComponent();
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
