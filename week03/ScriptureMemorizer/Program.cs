using System;
using System.Collections.Generic;
using System.Linq;

namespace ScriptureHider
{
    // My program works with a library of four scriptures rather than a single one. 
    // It chooses scriptures at random to present to the user.
    
    // Class to represent a single word in the scripture
    class Word
    {
        private string Text { get; set; }
        private bool IsHidden { get; set; }

        public Word(string text)
        {
            Text = text;
            IsHidden = false;
        }

        public void Hide()
        {
            IsHidden = true;
        }

        public override string ToString()
        {
            return IsHidden ? new string('_', Text.Length) : Text;
        }
    }

    // Class to represent a scripture reference
    class Reference
    {
        private string Book { get; }
        private string Chapter { get; }
        private string Verse { get; }

        public Reference(string book, string chapter, string verse)
        {
            Book = book;
            Chapter = chapter;
            Verse = verse;
        }

        public override string ToString()
        {
            return $"{Book} {Chapter}:{Verse}";
        }
    }

    // Class to represent a scripture, including text and reference
    class Scripture
    {
        private Reference Reference { get; }
        private List<Word> Words { get; }

        public Scripture(string book, string chapter, string verse, string text)
        {
            Reference = new Reference(book, chapter, verse);
            Words = text.Split(' ').Select(word => new Word(word)).ToList();
        }

        public bool HideRandomWords(int count)
        {
            var availableWords = Words.Where(word => !word.ToString().Contains("_")).ToList();
            var random = new Random();

            if (availableWords.Count == 0) return false;

            for (int i = 0; i < count && availableWords.Count > 0; i++)
            {
                int index = random.Next(availableWords.Count);
                availableWords[index].Hide();
                availableWords.RemoveAt(index);
            }

            return true;
        }

        public override string ToString()
        {
            return $"{Reference}\n{string.Join(" ", Words)}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var scriptureLibrary = new List<Scripture>
            {
                new Scripture("Proverbs", "3", "5-6", "Trust in the Lord with all your heart and lean not on your own understanding"),
                new Scripture("John", "3", "16", "For God so loved the world that he gave his one and only Son that whoever believes in him shall not perish but have eternal life"),
                new Scripture("Psalm", "23", "1", "The Lord is my shepherd I shall not want"),
                new Scripture("Philippians", "4", "13", "I can do all things through Christ who strengthens me")
            };

            var random = new Random();
            var scripture = scriptureLibrary[random.Next(scriptureLibrary.Count)];

            while (true)
            {
                Console.Clear();
                Console.WriteLine(scripture);
                Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");

                string input = Console.ReadLine();
                if (input?.ToLower() == "quit") break;

                if (!scripture.HideRandomWords(3))
                {
                    Console.Clear();
                    Console.WriteLine("All words are now hidden.");
                    break;
                }
            }
        }
    }
}