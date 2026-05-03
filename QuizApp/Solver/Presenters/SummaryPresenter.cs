using Model.Entities;
using Model.Services;
using Solver.Interfaces;
using System.Text;

namespace Solver.Presenters
{
    public class SummaryPresenter
    {
        private readonly ISummaryView _view;
        private readonly QuizData _quiz;
        private readonly List<List<int>> _userAnswers;
        private readonly QuizEvaluatorService _evaluator;

        public event EventHandler ReturnRequested;

        public SummaryPresenter(ISummaryView view, QuizData quiz, List<List<int>> userAnswers, int timeSpentSeconds, QuizEvaluatorService evaluator)
        {
            _view = view;
            _quiz = quiz;
            _userAnswers = userAnswers;
            _evaluator = evaluator;

            _view.ReturnToMenuClicked += (s, e) => ReturnRequested?.Invoke(this, EventArgs.Empty);

            GenerateSummary(timeSpentSeconds);
        }

        private void GenerateSummary(int timeSpentSeconds)
        {
            var result = _evaluator.Evaluate(_quiz, _userAnswers);

            _view.QuizTitle = _quiz.Title;
            _view.ScoreText = $"Score: {result.Score} / {result.MaxScore}";
            TimeSpan t = TimeSpan.FromSeconds(timeSpentSeconds);
            _view.TimeTakenText = $"Time: {t.ToString(@"mm\:ss")}";

            StringBuilder sb = new StringBuilder();
            var highlights = new List<(int start, int length, Color color)>();

            for (int i = 0; i < _quiz.Questions.Count; i++)
            {
                var q = _quiz.Questions[i];
                var userIndices = _userAnswers[i];
                var correctIndices = q.Answers.Select((a, idx) => new { a, idx })
                                              .Where(x => x.a.IsCorrect).Select(x => x.idx).ToList();

                sb.Append($"{i + 1}: {q.Text}" + "\n");

                bool isCorrect = userIndices.OrderBy(x => x).SequenceEqual(correctIndices.OrderBy(x => x));

                int start = sb.Length;
                string status = isCorrect ? "GOOD" : "MISTAKE";
                sb.Append(status + "\n");
                highlights.Add((start, status.Length, isCorrect ? Color.Green : Color.Red));

                sb.Append("Your answer(s): "
                    + (userIndices.Any() ? string.Join(", ", userIndices.Select(idx => q.Answers[idx].Text)) : "None")
                    + "\n");

                if (!isCorrect)
                {
                    sb.Append("Correct answer(s): " + string.Join(", ", correctIndices.Select(idx => q.Answers[idx].Text)) + "\n");
                }
                sb.Append("\n");
            }

            _view.DisplayReview(sb.ToString(), highlights);
        }
    }
}