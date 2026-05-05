namespace Creator.Interfaces
{
    public interface IAddQuestionView
    {
        string QuestionText { get; set; }
        List<string> AnswerTexts { get; set; }
        List<bool> IsCorrectFlags { get; set; }
        void ShowError(string message);
        void CloseView();
        event Action AddBtnClicked;
    }
}
