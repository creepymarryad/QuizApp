namespace Model.Entities
{
    public class QuizResult
    {
        public int Score { get; set; }
        public int MaxScore { get; set; }
        public string GetResult()
        {
            return $"{Score}/{MaxScore}";
        }
    }
}
