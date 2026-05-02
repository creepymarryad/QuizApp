using Model.Entities;

namespace Model.Services
{
    public class QuizEvaluatorService
    {
        public QuizResult Evaluate(QuizData quiz, List<List<int>> userAnswers)
// userAnswers zwraca indeksy wybranych przez użytkownika odpowiedzi
        {
            int score = 0;
            int maxScore = 0;
            for (int i = 0; i < quiz.Questions.Count; i++)
            {
                for (int j = 0; j < quiz.Questions[i].Answers.Count; j++)
                {
                    if (quiz.Questions[i].Answers[j].IsCorrect)
                    {
                        maxScore++;
                        if (userAnswers[i].Contains(j))
                        {
                            score++;
                        }
                    }
                }
            }
            return new QuizResult
            {
                Score = score,
                MaxScore = maxScore
            };
        }
    }
}
