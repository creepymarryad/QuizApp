using Model.Entities;
using Model.Interfaces;
using Model.Services;

using Solver.Interfaces;

namespace Solver.Presenters
{
    public class MainMenuPresenter
    {
        private readonly IMainMenuView _view;
        private readonly IQuizFileService _fileService;
        private readonly QuizEvaluatorService _evaluator;

        public QuizData LoadedQuiz { get; private set; }

        public event Action<QuizData> StartRequested;

        public MainMenuPresenter(IMainMenuView view, IQuizFileService fileService, QuizEvaluatorService evaluator)
        {
            _view = view;
            _fileService = fileService;
            _evaluator = evaluator;

            _view.LoadFileClicked += OnLoadFile;

            _view.StartQuizClicked += (s, e) => {
                if (LoadedQuiz != null) StartRequested?.Invoke(LoadedQuiz);
            };
        }

        private void OnLoadFile(object sender, EventArgs e)
        {
            string path = _view.SelectFile();
            if (string.IsNullOrEmpty(path)) return;

            try
            {
                var quiz = _fileService.Load(path, _view.Password);

                var dummyAnswers = new List<List<int>>();
                foreach (var q in quiz.Questions) 
                    dummyAnswers.Add(new List<int>());
                var resultInfo = _evaluator.Evaluate(quiz, dummyAnswers);

                _view.QuizTitle = quiz.Title;
                _view.QuizTime = $"{quiz.TimeLimitSeconds / 60} min";
                _view.QuizQuestionsCount = $"{quiz.Questions.Count}";
                _view.QuizMaxScore = $"{resultInfo.MaxScore}";

                _view.QuizInfoVisible = true;
                _view.StartButtonEnabled = true;

                LoadedQuiz = quiz;
            }
            catch (Exception)
            {
                _view.ShowError("Failed to load the file. Incorrect password or corrupt file.");
            }
        }
    }
}