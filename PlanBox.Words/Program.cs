using System;
using System.Collections.Generic;
using System.Linq;

namespace PlanBox.Words
{
    class Program
    {
        static List<Sentence> Sentences;

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Write a sentence :");

                string sentenceInput = Console.ReadLine();

                Sentence sentence = new Sentence(sentenceInput);

                if (!sentence.IsValid)
                {
                    Console.WriteLine("Please enter a sentence with more than one word.");
                }
                else
                {
                    SaveSentence(sentence);

                    foreach (var row in sentence.Words)
                    {
                        Console.WriteLine(row.Key + ": " + row.Value);
                    }
                }

                Console.ReadKey();
            }
        }

        private static void SaveSentence(Sentence sentence)
        {
            if (Sentences == null)
                Sentences = new List<Sentence>();

            Sentences.Add(sentence);
        }

    }
}
