using System;
using System.Collections.Generic;
using System.Text;

namespace Question
{
    public class TrueFalse : Question
    {
        public string UserAnswer { get; set; }

        public TrueFalse(string prompt, bool correctAnswer) : base(prompt)
        {
            this.AddAnswer("True", correctAnswer);
            this.AddAnswer("False", !correctAnswer);
            this.Prompt = prompt;
        }

        public override void AskQuestion()
        {
            Console.WriteLine("True or false?");
            Console.WriteLine(Prompt + "?");
            foreach(var answer in this.Answers.Keys)
            {
                Console.WriteLine(" - " + answer);
            }
            Console.Write("\nA: ");
            this.UserAnswer = Console.ReadLine();

        }

        public override double CheckAnswer()
        {
            foreach(KeyValuePair<string, bool> answer in this.Answers)
            {
                if(this.UserAnswer.ToLower() == answer.Key.ToLower())
                {
                    return answer.Value ? 1.0 : 0.0;
                }
            }

            return 0.0;
        }

    }
}
