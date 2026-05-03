namespace Solver.Interfaces
{
    public interface ISummaryView
    {
        string QuizTitle { set; }
        string ScoreText { set; }
        string TimeTakenText { set; }

        void DisplayReview(string reviewText, List<(int start, int length, Color color)> highlights);

        event EventHandler ReturnToMenuClicked;
    }
}