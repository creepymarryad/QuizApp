using Creator.Interfaces;

namespace QuizApp
{
    public partial class CreatorForm : Form, ICreatorView
    {
        public CreatorForm()
        {
            InitializeComponent();
            AddQuestionBtn.Click += (sender, e) => AddQuestionBtnClicked?.Invoke();
            RemoveQuestionBtn.Click += (sender, e) => RemoveQuestionBtnClicked?.Invoke();
            SaveQuizBtn.Click += (sender, e) => SaveQuizBtnClicked?.Invoke();
        }
        public string QuizTitle => QuizNameTextBox.Text.Trim();
        public int TimeLimitSeconds => (int)QuizTimeLimitNumericUpDown.Value;
        public int SelectedQuestion => QuestionsListBox.SelectedIndex;
        public void DisplayQuestions(List<string> questionTexts)
        {
            QuestionsListBox.Items.Clear();
            foreach (var questionText in questionTexts)
            {
                QuestionsListBox.Items.Add(questionText);
            }
        }
        public void ShowMessage(string message)
        {
            MessageBox.Show(message, "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public event Action? AddQuestionBtnClicked;
        public event Action? RemoveQuestionBtnClicked;
        public event Action? SaveQuizBtnClicked;
    }
}
