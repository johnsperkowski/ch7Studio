using System;

namespace ch7Studio
{
    class Program
    {
        static void Main(string[] args)
        {
            TrueFalse tfq = new TrueFalse("Gus is still here", false);

            tfq.AskQuestion();
            double score = tfq.CheckAnswer();
            Console.WriteLine(score);

            MultipleChoice mcq = new MultipleChoice("What's my fav color");
            mcq.AddAnswer("blue", false);
            mcq.AddAnswer("red", false);
            mcq.AddAnswer("orange", true);
            mcq.AddAnswer("yellow", false);
            mcq.AskQuestion();
            score += mcq.CheckAnswer();
            Console.WriteLine(score);
        }
    }
}
