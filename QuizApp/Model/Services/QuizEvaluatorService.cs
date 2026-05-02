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
                int correctAnswersInQuestion = 0;
                int userCorrectHits = 0;
                for (int j = 0; j < quiz.Questions[i].Answers.Count; j++)
                {
                    if (quiz.Questions[i].Answers[j].IsCorrect)
                    {
                        correctAnswersInQuestion++;
                        maxScore++;
                        if (userAnswers[i].Contains(j))
                        {
                            userCorrectHits++;
                        }
                    }
                }
                int userSelectionsCount = userAnswers[i].Count;
                int questionScore = userCorrectHits;
                if (userSelectionsCount > correctAnswersInQuestion)
                {
                    int penalty = userSelectionsCount - correctAnswersInQuestion;
                    questionScore -= penalty;
                }
                questionScore = Math.Max(0, questionScore);
                score += questionScore;
            }
            return new QuizResult
            {
                Score = score,
                MaxScore = maxScore
            };
        }
    }
}
