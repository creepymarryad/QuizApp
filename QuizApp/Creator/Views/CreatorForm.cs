using Creator.Interfaces;
using System.ComponentModel;

namespace QuizApp
{
    public partial class CreatorForm : Form, ICreatorView
    {
        public CreatorForm()
        {
            InitializeComponent();
            AddQuestionBtn.Click += (sender, e) => AddQuestionBtnClicked?.Invoke();
            ChangeQuestionBtn.Click += (sender, e) => ChangeQuestionBtnClicked?.Invoke();
            RemoveQuestionBtn.Click += (sender, e) => RemoveQuestionBtnClicked?.Invoke();
            SaveQuizBtn.Click += (sender, e) => SaveQuizBtnClicked?.Invoke();
            LoadQuizBtn.Click += (sender, e) => LoadQuizBtnClicked?.Invoke();

            this.BackgroundImage = UI.Properties.Resources.mc_bg;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            UI.FontManager.LoadFontFromResource("Monocraft.ttf");

            //LauncherLabel.Font = UI.FontManager.GetFont(28f, 0);
            SaveQuizBtn.Font = UI.FontManager.GetFont(20f, 0);
            LoadQuizBtn.Font = UI.FontManager.GetFont(20f, 0);
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string QuizTitle
        {
            get => QuizNameTextBox.Text.Trim();
            set => QuizNameTextBox.Text = value;
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int TimeLimitSeconds
        {
            get => (int)QuizTimeLimitNumericUpDown.Value;
            set => QuizTimeLimitNumericUpDown.Value = value;
        }
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
        public event Action? ChangeQuestionBtnClicked;
        public event Action? RemoveQuestionBtnClicked;
        public event Action? SaveQuizBtnClicked;
        public event Action? LoadQuizBtnClicked;
    }
}
