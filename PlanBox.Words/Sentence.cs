using System.Collections.Generic;
using System.Linq;

namespace PlanBox.Words
{
    public class Sentence
    {
        string _sentence = string.Empty;
        public Sentence(string sentence)
        {
            _sentence = sentence;
            Words = CountAndSort();
        }

        public bool IsValid => GetWords().Count >= 2;
            

        public SortedDictionary<string,int> Words { get; private set; }

        private IList<string> GetWords()
        {
            if (string.IsNullOrEmpty(_sentence))
                return new List<string>();

            return _sentence.Split(" ")
                .Where(s => !string.IsNullOrEmpty(s))
                .Select(s => s.First().ToString().ToUpper() + s.ToLower().Substring(1))
                .ToList();
        }

        private SortedDictionary<string, int> CountAndSort()
        {
            var list = GetWords();

            SortedDictionary<string, int> dictionary = new SortedDictionary<string, int>();

            foreach (string word in list.Distinct())
            {
                dictionary.Add(word, list.Count(w => w == word));
            }

            return dictionary;
        }
    }
}
