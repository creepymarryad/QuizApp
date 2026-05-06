
using Solver.Interfaces;

namespace Solver.Views
{
    public partial class SolvingView : UserControl, ISolvingView
    {
        private List<CheckBox> _currentCheckBoxes = new List<CheckBox>();

        public SolvingView() 
        { 
            InitializeComponent();

            this.DoubleBuffered = true;

            this.BackgroundImage = UI.Properties.Resources.mc_bg;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            label_Progress.Font = UI.FontManager.GetFont(14f);
            label_Progress.ForeColor = Color.Yellow;
            label_Progress.BackColor  = Color.Transparent;

            label_Timer.Font = UI.FontManager.GetFont(14f);
            label_Timer.ForeColor = Color.Yellow;
            label_Timer.BackColor = Color.Transparent;

            label_QuestionText.Font = UI.FontManager.GetFont(16f);
            label_QuestionText.BackColor = Color.Transparent;
            label_QuestionText.ForeColor = Color.White;

            label_QuizTitle.Font = UI.FontManager.GetFont(25f, 0, FontStyle.Bold);
            label_QuizTitle.BackColor = Color.DimGray;
            label_QuizTitle.ForeColor = Color.Yellow;

            answersPanel.BackColor = Color.Transparent;

            button_Next.BackgroundImage = UI.Properties.Resources.mc_tile;
            button_Next.BackgroundImageLayout = ImageLayout.Stretch;
            button_Next.Font = UI.FontManager.GetFont(12f);
            button_Next.ForeColor = Color.White;
            button_Next.FlatStyle = FlatStyle.Flat;
            button_Next.FlatAppearance.BorderSize = 0;

            btnPrevious.BackgroundImage = UI.Properties.Resources.mc_tile;
            btnPrevious.BackgroundImageLayout = ImageLayout.Stretch;
            btnPrevious.Font = UI.FontManager.GetFont(12f);
            btnPrevious.ForeColor = Color.White;
            btnPrevious.FlatStyle = FlatStyle.Flat;
            btnPrevious.FlatAppearance.BorderSize = 0;

            button2.BackgroundImage = UI.Properties.Resources.mc_tile;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Font = UI.FontManager.GetFont(14f);
            button2.ForeColor = Color.Yellow;
            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 0;

        }

        public string QuizTitle { set => label_QuizTitle.Text = value; }
        public string QuestionText { set => label_QuestionText.Text = value; }
        public string TimerText { set => label_Timer.Text = value; }
        public string ProgressText { set => label_Progress.Text = value; }

        public event EventHandler NextClicked;
        public event EventHandler StopClicked;
        public event EventHandler PreviousClicked;
        private void btnPrevious_Click(object sender, EventArgs e) => 
            PreviousClicked?.Invoke(this, EventArgs.Empty);

        public bool PreviousButtonEnabled { set => btnPrevious.Enabled = value; }
        public bool NextButtonEnabled { set => button_Next.Enabled = value; }

        private void btnNext_Click(object sender, EventArgs e) => 
            NextClicked?.Invoke(this, EventArgs.Empty);
        private void btnStop_Click(object sender, EventArgs e) => 
            StopClicked?.Invoke(this, EventArgs.Empty);

        public bool ConfirmStop(int unansweredCount)
        {
            string msg = unansweredCount > 0
            ? $"You have left {unansweredCount} question(s) without answers.\nAre you sure you want to stop the test?"
            : "Are you sure you want to stop the test?";
            return MessageBox.Show(msg, "Warning", MessageBoxButtons.YesNo) == DialogResult.Yes;
        }

        public void DisplayAnswers(List<string> answers)
        {
            answersPanel.Visible = false;
            answersPanel.Controls.Clear();
            _currentCheckBoxes.Clear();

            answersPanel.RowStyles.Clear();
            int rowCount = (answers.Count + 1) / 2;
            for (int i = 0; i < rowCount; i++)
            {
                answersPanel.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            }

            int cbWidth = (answersPanel.Width / 2) - 20;

            for (int i = 0; i < answers.Count; i++)
            {
                CheckBox cb = new CheckBox();
                cb.Text = answers[i];
                //cb.Font = new Font("Segoe UI", 12);

                cb.Font = UI.FontManager.GetFont(10f);
                cb.BackColor = Color.Transparent;
                cb.ForeColor = Color.White;

                cb.AutoSize = false;
                cb.Dock = DockStyle.None;

                cb.Width = cbWidth;

                Size textSize = TextRenderer.MeasureText(cb.Text, cb.Font, new Size(cbWidth - 35, int.MaxValue), TextFormatFlags.WordBreak);

                cb.Height = textSize.Height + 15;

                cb.CheckAlign = ContentAlignment.TopLeft;
                cb.TextAlign = ContentAlignment.TopLeft;
                cb.Margin = new Padding(10);

                _currentCheckBoxes.Add(cb);
                answersPanel.Controls.Add(cb);

            }
            answersPanel.Visible = true;
        }

        public List<int> GetSelectedAnswerIndices()
        {
            List<int> selected = new List<int>();
            for (int i = 0; i < _currentCheckBoxes.Count; i++)
            {
                if (_currentCheckBoxes[i].Checked) selected.Add(i);
            }
            return selected;
        }

        public void ShowMessage(string message) => MessageBox.Show(message);

        public void RestoreSelectedAnswers(List<int> selectedIndices)
        {
            foreach (int index in selectedIndices)
            {
                if (index >= 0 && index < _currentCheckBoxes.Count)
                {
                    _currentCheckBoxes[index].Checked = true;
                }
            }
        }
    }
}
