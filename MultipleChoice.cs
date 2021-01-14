using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ch7Studio
{
    public class MultipleChoice : Question
    {
        public string UserAnswer { get; set; }
        public MultipleChoice(string prompt)
        {
            this.Prompt = prompt;
            this.Answers = new Dictionary<string, bool>();
        }
        public override void AskQuestion()
        {
            Console.WriteLine("Multiple choice: Enter number of answer.");
            Console.WriteLine(Prompt + "?");

            int i = 1;
            foreach (var answer in this.Answers.Keys)
            {
                Console.WriteLine(i + " - " + answer);
                i++;
            }
            Console.Write("\nA: ");
            this.UserAnswer = Console.ReadLine();

            while(int.Parse(this.UserAnswer) > Answers.Count)
            {
                Console.Write("\nNot a Choice, try again. A: ");
                this.UserAnswer = Console.ReadLine();
            }
        }

        public override double CheckAnswer()
        {
            return this.Answers.Values.ElementAt(int.Parse(UserAnswer) - 1) ? 1.0 : 0.0;
        }
    }
}
