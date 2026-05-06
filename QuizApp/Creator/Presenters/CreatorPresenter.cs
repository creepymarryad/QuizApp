using Creator.Interfaces;
using Model.Entities;
using Model.Services;

namespace Creator.Presenters
{
    public class CreatorPresenter
    {
        private readonly ICreatorView _view;
        private QuizData _quiz;
        public CreatorPresenter(ICreatorView view)
        {
            _view = view;
            _quiz = new QuizData
            {
                Questions = new List<Question>()
            };
            _view.AddQuestionBtnClicked += OnAddQuestionBtnClicked;
            _view.ChangeQuestionBtnClicked += OnChangeQuestionBtnClicked;
            _view.RemoveQuestionBtnClicked += OnRemoveQuestionBtnClicked;
            _view.SaveQuizBtnClicked += OnSaveQuizBtnClicked;
            _view.LoadQuizBtnClicked += OnLoadQuizBtnClicked;
        }
        private void OnAddQuestionBtnClicked()
        {
            IAddQuestionView addQuestionView = new Views.AddQuestionForm();
            var addPresenter = new AddQuestionPresenter(addQuestionView, (q) =>
            {
                _quiz.Questions.Add(q);
                RefreshQuestionList();
            });
            ((Form)addQuestionView).ShowDialog();
        }
        private void OnChangeQuestionBtnClicked()
        {
            int index = _view.SelectedQuestion;
            if (index < 0 || index >= _quiz.Questions.Count)
            {
                _view.ShowMessage("Choose the question you want to edit!");
                return;
            }
            var questionToEdit = _quiz.Questions[index];
            IAddQuestionView changeQuestionView = new Views.AddQuestionForm();
            changeQuestionView.QuestionText = questionToEdit.Text;
            changeQuestionView.AnswerTexts = questionToEdit.Answers.Select(a => a.Text).ToList();
            changeQuestionView.IsCorrectFlags = questionToEdit.Answers.Select(a => a.IsCorrect).ToList();
            var addPresenter = new AddQuestionPresenter(changeQuestionView, (updatedQuestion) =>
            {
                _quiz.Questions[index] = updatedQuestion;
                RefreshQuestionList();
            });
            ((Form)changeQuestionView).ShowDialog();
        }
        private void OnRemoveQuestionBtnClicked()
        {
            int index = _view.SelectedQuestion;
            if (index < 0 || index >= _quiz.Questions.Count)
            { 
                _view.ShowMessage("Choose the question you want to remove!");
                return;
            }
            _quiz.Questions.RemoveAt(index);
            RefreshQuestionList();
        }
        private void OnSaveQuizBtnClicked()
        {
            if (string.IsNullOrWhiteSpace(_view.QuizTitle))
            {
                _view.ShowMessage("Please provide a title to your quiz!");
                return;
            }
            if (_quiz.Questions.Count == 0)
            {
                _view.ShowMessage("Cannot save the empty quiz!");
                return;
            }
            if (_view.TimeLimitSeconds <= 0)
            {
                _view.ShowMessage("Time duration of a quiz has to be a positive number!");
                return;
            }
            _quiz.Title = _view.QuizTitle;
            _quiz.TimeLimitSeconds = _view.TimeLimitSeconds;
            using (var saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Quiz Files (*.quiz)|*.quiz";
                saveFileDialog.Title = "Save Encrypted Quiz";
                saveFileDialog.FileName = $"{_quiz.Title}.quiz";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string password = "Admin67";
                    try
                    {
                        var fileService = new Model.Services.QuizFileService();
                        fileService.Save(saveFileDialog.FileName, password, _quiz);
                        _view.ShowMessage("Pomyślnie zapisano plik!");
                    }
                    catch (Exception ex)
                    {
                        _view.ShowMessage($"Error while writing the file: {ex.Message}");
                    }
                }
            }
        }
        private void OnLoadQuizBtnClicked()
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Quiz Files (*.quiz)|*.quiz";
                openFileDialog.Title = "Open Encrypted Quiz";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string password = "Admin67";
                    try
                    {
                        var fileService = new QuizFileService();
                        _quiz = fileService.Load(openFileDialog.FileName, password);

                        _view.QuizTitle = _quiz.Title;
                        _view.TimeLimitSeconds = _quiz.TimeLimitSeconds;
                        RefreshQuestionList();

                        _view.ShowMessage("Quiz loaded successfully!");
                    }
                    catch (Exception ex)
                    {
                        _view.ShowMessage($"Error: {ex.Message}");
                    }
                }
            }
        }
        private void RefreshQuestionList() 
        {
            List<string> questions = new List<string>();
            for (int i = 0; i < _quiz.Questions.Count; i++) 
            {
                string line = $"{i+1}. {_quiz.Questions[i].Text}";
                questions.Add(line);
            }
            _view.DisplayQuestions(questions);
        }
    }
}
