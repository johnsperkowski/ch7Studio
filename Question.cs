using System;
using System.Collections.Generic;
using System.Text;

namespace Question
{
    public abstract class Question
    {
        public string Subject { get; set; }
        public string Prompt { get; set; }
        public Dictionary<string, bool> Answers { get; set; }
        private static Random rng = new Random();

        public Question(string prompt)
        {
            this.Prompt = prompt;
            this.Answers = new Dictionary<string, bool>();
        }

        public Question() { }

        public static void ShuffleAnswers(List<string> answers)
        {
            int n = answers.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                string value = answers[k];
                answers[k] = answers[n];
                answers[n] = value;
            }
        }

        public void AddAnswer(string answer, bool isCorrect)
        {
            this.Answers.Add(answer, isCorrect);
        }

        public abstract void AskQuestion();
        public abstract double CheckAnswer();

    }
}
