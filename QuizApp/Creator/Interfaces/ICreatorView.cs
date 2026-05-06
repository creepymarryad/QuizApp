namespace Creator.Interfaces
{
    public interface ICreatorView
    {
        string QuizTitle { get; set; }
        int TimeLimitSeconds { get; set; }
        int SelectedQuestion { get; }
        void DisplayQuestions(List<string> questionTexts);
        void ShowMessage(string message);
        event Action? AddQuestionBtnClicked;
        event Action? ChangeQuestionBtnClicked;
        event Action? RemoveQuestionBtnClicked;
        event Action? SaveQuizBtnClicked;
        event Action? LoadQuizBtnClicked;
    }
}
