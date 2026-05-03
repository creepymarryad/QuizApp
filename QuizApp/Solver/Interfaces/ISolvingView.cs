namespace Solver.Interfaces
{
    public interface ISolvingView
    {
        string QuizTitle { set; }
        string QuestionText { set; }
        string TimerText { set; }
        string ProgressText { set; }


        void DisplayAnswers(List<string> answers);

        List<int> GetSelectedAnswerIndices();

        event EventHandler NextClicked;
        event EventHandler StopClicked;
        event EventHandler PreviousClicked;
        bool PreviousButtonEnabled { set; }
        bool NextButtonEnabled { set; }
        void RestoreSelectedAnswers(List<int> selectedIndices);

        bool ConfirmStop(int unansweredCount);
        void ShowMessage(string message);
    }
}
