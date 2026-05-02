using Model.Entities;
namespace Model.Interfaces
{
    public interface IQuizFileService
    {
        void SaveQuiz(QuizData quiz, string filePath, string password);
        QuizData LoadQuiz(string filePath, string password);
    }
}
