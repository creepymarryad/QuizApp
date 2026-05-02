namespace Creator.Interfaces
{
    public interface IAddQuestionView
    {
        string QuestionText { get; }
        List<string> AnswerTexts { get; }
        List<bool> IsCorrectFlags { get; }
        void ShowError(string message);
        void CloseView();
        event Action AddBtnClicked;
    }
}
