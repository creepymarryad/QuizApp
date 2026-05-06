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

            SaveQuizBtn.BackgroundImage = UI.Properties.Resources.mc_tile;
            SaveQuizBtn.BackgroundImageLayout = ImageLayout.Stretch;
            LoadQuizBtn.BackgroundImage = UI.Properties.Resources.mc_tile;
            LoadQuizBtn.BackgroundImageLayout = ImageLayout.Stretch;
            ChangeQuestionBtn.BackgroundImage = UI.Properties.Resources.mc_tile;
            ChangeQuestionBtn.BackgroundImageLayout = ImageLayout.Stretch;
            AddQuestionBtn.BackgroundImage = UI.Properties.Resources.mc_tile;
            AddQuestionBtn.BackgroundImageLayout = ImageLayout.Stretch;
            RemoveQuestionBtn.BackgroundImage = UI.Properties.Resources.mc_tile;
            RemoveQuestionBtn.BackgroundImageLayout = ImageLayout.Stretch;

            UI.FontManager.LoadFontFromResource("Monocraft.ttf");

            label3.Font = UI.FontManager.GetFont(28f, 0);
            this.Font = UI.FontManager.GetFont(14f, 0);
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
