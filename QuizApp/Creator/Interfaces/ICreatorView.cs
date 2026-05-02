namespace Creator.Interfaces
{
    public interface ICreatorView
    {
        string QuizTitle { get; }
        int TimeLimitSeconds { get; }
        int SelectedQuestion { get; }
        void DisplayQuestions(List<string> questionTexts);
        void ShowMessage(string message);
        event Action? AddQuestionBtnClicked;
        event Action? RemoveQuestionBtnClicked;
        event Action? SaveQuizBtnClicked;
    }
}
