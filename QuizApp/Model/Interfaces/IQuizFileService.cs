using Model.Entities;
namespace Model.Interfaces
{
    public interface IQuizFileService
    {
        void Save(QuizData quiz, string filePath, string password);
        QuizData Load(string filePath, string password);
    }
}
