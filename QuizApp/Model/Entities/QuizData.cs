namespace Model.Entities
{
    public class QuizData
    {
        public string Title { get; set; }
        public List<Question> Questions { get; set; }
        public int TimeLimitSeconds { get; set; }
        public QuizData()
        {
            this.Title = String.Empty;
            this.Questions = new List<Question>();
            this.TimeLimitSeconds = 0;
        }
        public QuizData(string title, List<Question> questions, int timeLimitSeconds)
        {
            this.Title = title;
            this.Questions = questions;
            this.TimeLimitSeconds = timeLimitSeconds;
        }
    }
}
