using Solver.Interfaces;

namespace Solver.Views
{
    public partial class SummaryView : UserControl, ISummaryView
    {
        public SummaryView() { InitializeComponent(); }

        public string QuizTitle { set => label_QuizTitle.Text = value; }
        public string ScoreText { set => label_Score.Text = value; }
        public string TimeTakenText { set => label_Time.Text = value; }

        public event EventHandler ReturnToMenuClicked;
        private void btnReturn_Click(object sender, EventArgs e) => 
            ReturnToMenuClicked?.Invoke(this, EventArgs.Empty);

        public void DisplayReview(string reviewText, List<(int start, int length, Color color)> highlights)
        {
            rtb_Review.Text = reviewText;
            foreach (var h in highlights)
            {
                rtb_Review.Select(h.start, h.length);
                rtb_Review.SelectionColor = h.color;
                if (h.color == Color.Green || h.color == Color.Red)
                    rtb_Review.SelectionFont = new Font(rtb_Review.Font, FontStyle.Bold);
            }
            rtb_Review.SelectionLength = 0;
        }
    }
}
