using Model.Entities;
namespace Model.Interfaces
{
    public interface IQuizFileService
    {
        void Save(string filePath, string password, QuizData quiz);
        QuizData Load(string filePath, string password);
    }
}
