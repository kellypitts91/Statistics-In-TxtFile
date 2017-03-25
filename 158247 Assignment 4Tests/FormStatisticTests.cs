using Microsoft.VisualStudio.TestTools.UnitTesting;
using _158247_Assignment_4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _158247_Assignment_4.Tests
{
    [TestClass()]
    public class Form1Tests
    {
        [TestMethod()]
        public void UniqueWordsTest()
        {
            //Testing function for creating a list of unique words.
            FormStatistics f = new FormStatistics();
            List<string> s1 = new List<string>()
            {
                "hello", "world", "hello", "world"
            };
            List<string> expected = new List<string>()
            {
                "hello", "world"
            };
            List<string> actual = new List<string>();
            actual = f.UniqueWords(s1);
            CollectionAssert.AreEquivalent(expected, actual);
        }

        [TestMethod()]
        public void ConvertListToDictionaryTest()
        {
            //Testing function for converting a list into a dictionary with 0 values for the int
            FormStatistics f = new FormStatistics();
            List<string> s1 = new List<string>()
            {
                "hello", "world"
            };
            Dictionary<string, int> expected = new Dictionary<string, int>()
            {
                { "hello", 0 }, { "world", 0 }
            };
            Dictionary<string, int> actual = new Dictionary<string, int>();
            actual = f.ConvertListToDictionary(s1);
            CollectionAssert.AreEquivalent(expected, actual);
        }

        [TestMethod()]
        public void LongestWordsTest()
        {
            //Testing function that returns a dictionary of all the longest words in the file.
            FormStatistics f = new FormStatistics();
            List<string> s1 = new List<string>()
            {
                "hello", "world", "hello", "world"
            };
            List<string> s2 = new List<string>()
            {
                "hello", "world"
            };
            Dictionary<string, int> d1 = new Dictionary<string, int>()
            {
                { "hello", 5}, { "world", 5 }
            };
            Dictionary<string, int> expected = new Dictionary<string, int>()
            {
                { "hello", 5}, { "world", 5 }
            };

            Dictionary<string, int> actual = new Dictionary<string, int>();
            actual = f.LongestWords(s1, s2, d1);
            CollectionAssert.AreEquivalent(expected, actual);
        }

        [TestMethod()]
        public void ShortestWordsTest()
        {
            //Testing function that returns a dictionary of all the shortest words in the file.
            FormStatistics f = new FormStatistics();
            List<string> s1 = new List<string>()
            {
                "hello", "my", "hello", "world"
            };
            List<string> s2 = new List<string>()
            {
                "hello", "my", "world"
            };
            Dictionary<string, int> d1 = new Dictionary<string, int>()
            {
                { "hello", 5}, { "my", 2 }, { "world", 5 }
            };
            Dictionary<string, int> expected = new Dictionary<string, int>()
            {
                { "my", 2 }
            };

            Dictionary<string, int> actual = new Dictionary<string, int>();
            actual = f.ShortestWords(s1, s2, d1);
            CollectionAssert.AreEquivalent(expected, actual);
        }

        [TestMethod()]
        public void AddWordLengthToDictTest()
        {
            //Testing function that adds the word length to the dictionary in the int value
            //corresponding to the key (word).
            FormStatistics f = new FormStatistics();
            List<string> s1 = new List<string>()
            {
                "hello", "the", "world", "my"
            };
            Dictionary<string, int> d1 = new Dictionary<string, int>()
            {
                { "hello", 0 }, { "the", 0 }, { "world", 0 }, { "my", 0 }
            };
            Dictionary<string, int> expected = new Dictionary<string, int>()
            {
                { "hello", 5}, { "the", 3 }, { "world", 5 }, { "my", 2 }
            };
            Dictionary<string, int> actual = new Dictionary<string, int>();
            actual = f.AddWordLengthToDict(s1, d1);
            CollectionAssert.AreEquivalent(expected, actual);
        }

        [TestMethod()]
        public void MostCommonWordsTest()
        {
            //Testing function that finds all the words that appear the most in the file
            FormStatistics f = new FormStatistics();
            List<string> s1 = new List<string>()
            {
                "hello", "world", "hello", "world", "hello"
            };
            List<string> s2 = new List<string>()
            {
                "hello", "world"
            };
            Dictionary<string, int> d1 = new Dictionary<string, int>()
            {
                { "hello", 3 }, { "world", 2 }
            };
            Dictionary<string, int> expected = new Dictionary<string, int>()
            {
                { "hello", 3 }
            };

            Dictionary<string, int> actual = new Dictionary<string, int>();
            actual = f.MostCommonWords(s1, s2, d1);
            CollectionAssert.AreEquivalent(expected, actual);
        }

        [TestMethod()]
        public void AddingWordCountToDictTest()
        {
            //Testing function that adds the number of occurences of each word that appears in the file
            //to the dictionary in the int value corresponding to the key (word).
            FormStatistics f = new FormStatistics();
            List<string> s1 = new List<string>()
            {
                "hello", "the", "world","the", "hello", "world", "my", "the"
            };
            List<string> s2 = new List<string>()
            {
                "hello", "the", "world", "my"
            };
            Dictionary<string, int> d1 = new Dictionary<string, int>()
            {
                { "hello", 0 }, { "the", 0 }, { "world", 0 }, { "my", 0 }
            };
            Dictionary<string, int> expected = new Dictionary<string, int>()
            {
                { "hello", 2 }, { "the", 3 }, { "world", 2 }, { "my", 1 }
            };
            Dictionary<string, int> actual = new Dictionary<string, int>();
            actual = f.AddingWordCountToDict(s1, s2, d1);
            CollectionAssert.AreEquivalent(expected, actual);
        }

        [TestMethod()]
        public void AverageWordLengthTest()
        {
            //Testing function that calculates the average word length of unique words only
            FormStatistics f = new FormStatistics();
            List<string> s1 = new List<string>()
            {
                "hello", "my", "world"
            };
            double expected = 4.00;
            double actual = f.AverageWordLength(s1);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void DisplayStatsTest()
        {
            //Testing function that returns the correct stat to display
            FormStatistics f = new FormStatistics();
            Dictionary<string, int> d1 = new Dictionary<string, int>()
            {
                { "hello", 2 }, { "world", 4 }
            };
            string expected = "Frequency: 4 letters." + Environment.NewLine;
            string actual = f.DisplayStats("Frequency", d1, "max", "letters.");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void DisplayKeysTest()
        {
            //Testing function that returns a string of all unique words in the file
            FormStatistics f = new FormStatistics();
            Dictionary<string, int> d1 = new Dictionary<string, int>()
            {
                { "hello", 4 }, { "world", 4 }
            };
            string expected = "hello, world ";
            string actual = f.DisplayKeys(d1);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SearchWordOccurenceTest()
        {
            //Testing function if string entered is not in the file
            FormStatistics f = new FormStatistics();
            string s1 = "hello";
            string expected = "hello does not appear in the text.";
            string actual = f.SearchWordOccurence(s1);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SearchLengthTest()
        {
            //Testing function if no words with the length entered are in the file
            FormStatistics f = new FormStatistics();
            int i1 = 5;
            string expected = "there is no words in the text with 5 letters.";
            string actual = f.SearchLength(i1);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SortListTest()
        {
            //Testing function that returns the list sorted
            FormStatistics f = new FormStatistics();
            List<string> s1 = new List<string>()
            {
                { "hello" }, { "world" }, { "the" }
            };
            string expected = "hello, the, world ";
            string actual = f.SortList(s1);
            Assert.AreEqual(expected, actual);
        }
    }
}