namespace Model.Entities
{
    public class Question
    {
        public string Text { get; set; }
        public List<Answer> Answers { get; set; }
        public Question()
        {
            this.Text = String.Empty;
            this.Answers = new List<Answer>();
        }
        public Question(string text, List<Answer> answers)
        {
            this.Text = text;
            this.Answers = answers;
        }
    }
}
