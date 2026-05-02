using Creator.Interfaces;
using Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Creator.Presenters
{
    public class AddQuestionPresenter
    {
        private readonly IAddQuestionView _view;
        private readonly Action<Question> _onQuestionAdded;
        public AddQuestionPresenter(IAddQuestionView view, Action<Question> onQuestionAdded)
        {
            _view = view;
            _onQuestionAdded = onQuestionAdded;
            _view.AddBtnClicked += OnAddBtnClicked;
        }

        private void OnAddBtnClicked()
        {
            string questionText = _view.QuestionText;
            List<string> answersTexts = _view.AnswerTexts;
            List<bool> isCorrectFlags = _view.IsCorrectFlags;
            if (string.IsNullOrWhiteSpace(questionText))
            {
                _view.ShowError("Pytanie musi mieć treść!");
                return;
            }
            foreach (var answer in answersTexts)
            {
                if (string.IsNullOrWhiteSpace(answer))
                {
                    _view.ShowError("Musisz podać wszystkie 4 odpowiedzi!");
                    return;
                }
            }
            if (!isCorrectFlags.Contains(true))
            {
                _view.ShowError("Musisz oznaczyć przynajmniej jedną odpowiedź jaką poprawną!");
                return;
            }
            Question newQuestion = new Question
            {
                Text = questionText,
                Answers = new List<Answer>()
            };
            for (int i = 0; i < 4; i++)
            {
                newQuestion.Answers.Add(new Answer
                {
                    Text = answersTexts[i],
                    IsCorrect = isCorrectFlags[i]
                });
            }
            _onQuestionAdded(newQuestion);
            _view.CloseView();
        }
    }
}
