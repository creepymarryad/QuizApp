using System;
using System.Collections.Generic;
using System.Text;

namespace Solver.Interfaces
{
    public interface IMainMenuView
    {
        string FilePath { get; set; }
        string Password { get; }

        string QuizTitle { set; }
        string QuizTime { set; }
        string QuizQuestionsCount { set; }
        string QuizMaxScore { set; }

        bool StartButtonEnabled { set; }
        bool QuizInfoVisible { set; }

        event EventHandler LoadFileClicked;
        event EventHandler StartQuizClicked;

        string SelectFile();
        void ShowError(string message);

    }
}
