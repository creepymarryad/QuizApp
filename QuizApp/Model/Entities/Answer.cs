namespace Model.Entities
{
    public class Answer
    {
        public string Text {  get; set; }
        public bool IsCorrect { get; set; }
        public Answer()
        {
            this.Text = String.Empty;
            this.IsCorrect = false;
        }
        //Zgodnie z wymaganiami musimy zapisywać i wczytywać dane z pliku. Prawdopodobnie użyjemy
        //do tego biblioteki System.Text.Json (wbudowanej w C#).
        //Kiedy ta biblioteka wczytuje zaszyfrowany plik i próbuje odtworzyć z niego z
        //powrotem obiekt(np.QuizData), musi najpierw stworzyć go w pamięci komputera.
        //Biblioteka robi to wywołując właśnie ten pusty konstruktor.
        //Jeśli byśmy go usunęli, a zostawili tylko konstruktor przyjmujący argumenty,
        //biblioteka wyrzuciłaby błąd(tzw.wyjątek), bo nie wiedziałaby,
        //jak od podstaw "zbudować" ten obiekt, żeby móc potem powstawiać w
        //niego odczytane z pliku właściwości.
        public Answer(string text, bool isCorrect) 
        {
            this.Text = text;
            this.IsCorrect = isCorrect;
        }
    }
}
