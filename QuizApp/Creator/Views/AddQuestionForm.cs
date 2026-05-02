using Creator.Interfaces;

namespace Creator.Views
{
    public partial class AddQuestionForm : Form, IAddQuestionView
    {
        public AddQuestionForm()
        {
            InitializeComponent();
            AddBtn.Click += (sender, e) => AddBtnClicked?.Invoke();
            CancelBtn.Click += (sender, e) => this.Close();
        }
        public string QuestionText => QuestionTextBox.Text.Trim();
        public List<string> AnswerTexts => new List<string>
        {
            QuestionAnswer1TextBox.Text.Trim(),
            QuestionAnswer2TextBox.Text.Trim(),
            QuestionAnswer3TextBox.Text.Trim(),
            QuestionAnswer4TextBox.Text.Trim()
        };
        public List<bool> IsCorrectFlags => new List<bool>
        {
            IsCorrectAnswer1CheckBox.Checked,
            IsCorrectAnswer2CheckBox.Checked,
            IsCorrectAnswer3CheckBox.Checked,
            IsCorrectAnswer4CheckBox.Checked
        };
        public void ShowError(string message)
        {
            MessageBox.Show(message, "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public void CloseView()
        {
            this.Close();
        }
        public event Action? AddBtnClicked;
    }
}
