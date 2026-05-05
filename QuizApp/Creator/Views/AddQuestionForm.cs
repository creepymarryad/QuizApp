using Creator.Interfaces;
using System.ComponentModel;

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
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string QuestionText
        {
            get => QuestionTextBox.Text.Trim();
            set => QuestionTextBox.Text = value;
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<string> AnswerTexts
        {
            get => new List<string> {
                QuestionAnswer1TextBox.Text.Trim(),
                QuestionAnswer2TextBox.Text.Trim(),
                QuestionAnswer3TextBox.Text.Trim(),
                QuestionAnswer4TextBox.Text.Trim()
            };
            set
            {
                QuestionAnswer1TextBox.Text = value[0];
                QuestionAnswer2TextBox.Text = value[1];
                QuestionAnswer3TextBox.Text = value[2];
                QuestionAnswer4TextBox.Text = value[3];
            }
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<bool> IsCorrectFlags
        {
            get => new List<bool> {
                IsCorrectAnswer1CheckBox.Checked,
                IsCorrectAnswer2CheckBox.Checked,
                IsCorrectAnswer3CheckBox.Checked,
                IsCorrectAnswer4CheckBox.Checked
            };
            set
            {
                IsCorrectAnswer1CheckBox.Checked = value[0];
                IsCorrectAnswer2CheckBox.Checked = value[1];
                IsCorrectAnswer3CheckBox.Checked = value[2];
                IsCorrectAnswer4CheckBox.Checked = value[3];
            }
        }
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
