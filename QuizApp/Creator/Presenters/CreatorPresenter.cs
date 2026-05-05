using Creator.Interfaces;
using Model.Entities;

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
                _view.ShowMessage("Wybierz pytanie z listy, które chcesz edytować!");
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
            int id = _view.SelectedQuestion;
            if (id >= 0 && id < _quiz.Questions.Count) 
            { 
                _quiz.Questions.RemoveAt(id);
                RefreshQuestionList();
            }
        }
        private void OnSaveQuizBtnClicked()
        {
            if (string.IsNullOrWhiteSpace(_view.QuizTitle))
            {
                _view.ShowMessage("Twój quiz musi mieć tytuł przed zapisaniem!");
                return;
            }
            if (_quiz.Questions.Count == 0)
            {
                _view.ShowMessage("Nie możesz zapisać pustego quizu. Dodaj chociaż jedno pytanie!");
                return;
            }
            if (_view.TimeLimitSeconds <= 0)
            {
                _view.ShowMessage("Czas na quiz musi być większy niż 0!");
                return;
            }
            _quiz.Title = _view.QuizTitle;
            _quiz.TimeLimitSeconds = _view.TimeLimitSeconds;
            using (var saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Pliki Quiz (*.quiz)|*.quiz";
                saveFileDialog.Title = "Zapisz zaszyfrowany quiz";
                saveFileDialog.FileName = $"{_quiz.Title}.quiz";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string password = "Admin67";
                    try
                    {
                        var fileService = new Model.Services.QuizFileService();
                        fileService.Save(saveFileDialog.FileName, password, _quiz);

                        _view.ShowMessage($"Plik powinien być tutaj: {saveFileDialog.FileName}");
                        _view.ShowMessage("Pomyślnie zapisano plik!");
                    }
                    catch (Exception ex)
                    {
                        _view.ShowMessage($"Wystąpił błąd podczas zapisu: {ex.Message}");
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
