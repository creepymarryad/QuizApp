using Model.Entities;
using Model.Services;
using Solver;
using Solver.Presenters;
using Solver.Views;

static class Program
{
    private static ShellForm _shell;
    private static QuizFileService _fileService;
    private static QuizEvaluatorService _evaluator;

    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        UI.FontManager.LoadFontFromResource("Monocraft.ttf");

        _fileService = new QuizFileService();
        _evaluator = new QuizEvaluatorService();
        _shell = new ShellForm();

        ShowMenu();

        Application.Run(_shell);
    }

    private static void ShowMenu()
    {
        var menuView = new MainMenuView();
        var menuPresenter = new MainMenuPresenter(menuView, _fileService, _evaluator);

        menuPresenter.StartRequested += (quiz) => {
            ShowSolving(quiz);
        };

        _shell.SetView(menuView);
    }

    private static void ShowSolving(QuizData quiz)
    {
        var solvingView = new SolvingView();
        var solvingPresenter = new SolvingPresenter(solvingView, quiz);

        solvingPresenter.QuizFinished += (s, e) => {
            var answers = solvingPresenter.GetFinalAnswers();
            var time = solvingPresenter.GetTimeSpent();

            ShowSummary(quiz, answers, time);
        };

        _shell.SetView(solvingView);
    }

    private static void ShowSummary(QuizData quiz, List<List<int>> answers, int timeSpent)
    {
        var summaryView = new SummaryView();
        var summaryPresenter = new SummaryPresenter(summaryView, quiz, answers, timeSpent, _evaluator);

        summaryPresenter.ReturnRequested += (s, e) => {
            ShowMenu();
        };

        _shell.SetView(summaryView);
    }
}