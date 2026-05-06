using Solver.Interfaces;

namespace Solver.Views
{
    public partial class SummaryView : UserControl, ISummaryView
    {
        public SummaryView() 
        { 
            InitializeComponent();

            this.BackgroundImage = UI.Properties.Resources.mc_bg;
            this.BackgroundImageLayout = ImageLayout.Stretch;

            label_QuizTitle.Font = UI.FontManager.GetFont(18f, 0, FontStyle.Bold);
            label_QuizTitle.ForeColor = Color.Yellow;
            label_QuizTitle.BackColor = Color.DimGray;

            label_Score.Font = UI.FontManager.GetFont(16f, 0);
            label_Score.ForeColor = Color.Yellow;
            label_Score.BackColor = Color.DimGray;

            label_Summary.Font = UI.FontManager.GetFont(30f, 0, FontStyle.Bold);
            label_Summary.ForeColor = Color.White;
            label_Summary.BackColor = Color.DimGray;

            label_Time.Font = UI.FontManager.GetFont(16f, 0);
            label_Time.ForeColor = Color.Yellow;
            label_Time.BackColor = Color.DimGray;

            rtb_Review.BackColor = Color.DimGray;
            rtb_Review.Font = UI.FontManager.GetFont(14f);
            rtb_Review.ForeColor = Color.White;

            button1.BackgroundImage = UI.Properties.Resources.mc_tile;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Font = UI.FontManager.GetFont(14f);
            button1.ForeColor  = Color.White;


        }

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
