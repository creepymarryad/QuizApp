using Model.Entities;
using Solver.Interfaces;
using System.Windows.Forms;

namespace Solver.Presenters
{
    public class SolvingPresenter
    {
        private readonly ISolvingView _view;
        private readonly QuizData _quiz;
        private int _currentQuestionIndex = 0;
        private int _secondsLeft;
        private System.Windows.Forms.Timer _timer;

        private List<List<int>> _allUserAnswers = new List<List<int>>();


        public event EventHandler QuizFinished;

        public SolvingPresenter(ISolvingView view, QuizData quiz)
        {
            _view = view;
            _quiz = quiz;
            _secondsLeft = quiz.TimeLimitSeconds;

            foreach (var q in _quiz.Questions) _allUserAnswers.Add(new List<int>());

            _view.NextClicked += OnNextQuestion;
            _view.StopClicked += OnStopQuiz;
            _view.PreviousClicked += OnPreviousQuestion;

            StartTimer();
            UpdateViewWithCurrentQuestion();
        }

        private void SaveCurrentAnswers()
        {
            _allUserAnswers[_currentQuestionIndex] = _view.GetSelectedAnswerIndices();
        }


        private void StartTimer()
        {
            UpdateTimeDisplay();

            _timer = new System.Windows.Forms.Timer { Interval = 1000 };
            _timer.Tick += (s, e) => {
                _secondsLeft--;
                UpdateTimeDisplay();

                if (_secondsLeft <= 0)
                {
                    _timer.Stop();
                    _view.ShowMessage("Time is up!");
                    FinishQuiz();
                }
            };
            _timer.Start();
        }
        private void UpdateTimeDisplay()
        {
            TimeSpan t = TimeSpan.FromSeconds(_secondsLeft);
            _view.TimerText = $"Timer: {t.ToString(@"mm\:ss")}";
        }

        private void OnNextQuestion(object sender, EventArgs e)
        {
            SaveCurrentAnswers();

            if (_currentQuestionIndex < _quiz.Questions.Count - 1)
            {
                _currentQuestionIndex++;
                UpdateViewWithCurrentQuestion();
            }
        }
        private void OnPreviousQuestion(object sender, EventArgs e)
        {
            SaveCurrentAnswers();

            if (_currentQuestionIndex > 0)
            {
                _currentQuestionIndex--;
                UpdateViewWithCurrentQuestion();
            }
        }

        private void UpdateViewWithCurrentQuestion()
        {
            var q = _quiz.Questions[_currentQuestionIndex];
            _view.QuestionText = q.Text;
            _view.QuizTitle = _quiz.Title;
            _view.ProgressText = $"Question: {_currentQuestionIndex + 1} / {_quiz.Questions.Count}";

            var answerTexts = q.Answers.Select(a => a.Text).ToList();
            _view.DisplayAnswers(answerTexts);

            _view.RestoreSelectedAnswers(_allUserAnswers[_currentQuestionIndex]);

            _view.PreviousButtonEnabled = _currentQuestionIndex > 0;
            _view.NextButtonEnabled = _currentQuestionIndex < _quiz.Questions.Count - 1;
        }

        private void OnStopQuiz(object sender, EventArgs e)
        {
            int unanswered = _allUserAnswers.Count(ans => ans.Count == 0);

            if (_view.ConfirmStop(unanswered))
            {
                _timer.Stop();
                FinishQuiz();
            }
        }

        private void FinishQuiz()
        {
            _timer?.Dispose();
            QuizFinished?.Invoke(this, EventArgs.Empty);
        }

        public List<List<int>> GetFinalAnswers() => _allUserAnswers;
        public int GetTimeSpent() => _quiz.TimeLimitSeconds - _secondsLeft;
    }
}