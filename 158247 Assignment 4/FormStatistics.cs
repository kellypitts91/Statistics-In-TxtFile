using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace _158247_Assignment_4
{
    public partial class FormStatistics : System.Windows.Forms.Form
    {
        public FormStatistics()
        {
            InitializeComponent();
        }

        //declaring global variables
        public Dictionary<string, int> dictMostCommonGlobal = new Dictionary<string, int>();
        public Dictionary<string, int> dictWordLengthGlobal = new Dictionary<string, int>();

        private void fileMenuItemClick(object sender, EventArgs e)
        {
            List<string> uniqueList = new List<string>();
            List<string> fileList = new List<string>();
            //clearing all text boxes so can open a new file.
            ResetTextBoxes();
            //opening file and storing every word into a list
            fileList = openFile();
            if (fileList == null)
            {
                //ensures program does not continue if a file is not choosen 
                lblErrorMessage.Text = "Choose a file to display stats.";
                return;
            } else if (fileList.Count == 0)
            {
                //exits the function if there is no text in the file so it will not enter any further functions
                lblErrorMessage.Text = "Error: No text in file.";
                return;
            }
            uniqueList = UniqueWords(fileList);
            DisplayAllStats(uniqueList, fileList);
        }

        private void ResetTextBoxes()
        {
            //resets all textboxes to empty so can load another file.
            txtbMostCommon.Text = "";
            txtbLongestWord.Text = "";
            txtbShortestWords.Text = "";
            txtbSearchWord.Text = "";
            txtbSearchWordDisplay.Text = "";
            txtbSearchLen.Text = "";
            txtbSearchLenDisplay.Text = "";
            txtbDisplayUnique.Text = "";
            txtbAvgLen.Text = "";
            lblErrorMessage.Text = "";
        }

        private List<string> openFile()
        {
            string fileText = "";
            //opens file, shows only txt files to choose from
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "txt files (*.txt)|*.txt";
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    //Opens the file for reading. Stores as a string then splits the string into a list.
                    StreamReader reader = new StreamReader(dialog.FileName);
                    List<string> fileList = new List<string>();
                    List<string> uniqueList = new List<string>();
                    fileText = reader.ReadToEnd();
                    fileList = fileText.Split(new Char[] { ' ', '\r', '\n', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();

                    reader.Close();
                    return fileList;
                }
                catch (Exception fe)
                {
                    lblErrorMessage.Text = fe.ToString();
                    return null;
                }
            }
            else
            {
                return null;
            }
        }

        public List<string> UniqueWords(List<string> myList)
        {
            List<string> uniqueList = new List<string>();
            foreach (string item1 in myList)
            {
                foreach (string item2 in myList)
                {
                    //creates a dictionary of just unique words.
                    if (item1.ToLower() != item2.ToLower() && !uniqueList.Contains(item1.ToLower()))
                    {
                        uniqueList.Add(item1.ToLower());
                    }
                }
            }
            return uniqueList;
        }

        private void DisplayAllStats(List<string> uniqueList, List<string> fileList)
        {
            //declaring local variables
            Dictionary<string, int> dictUnique = new Dictionary<string, int>();
            Dictionary<string, int> dictMostCommonWords = new Dictionary<string, int>();
            Dictionary<string, int> dictLongestWords = new Dictionary<string, int>();
            Dictionary<string, int> dictShortestWords = new Dictionary<string, int>();
            double avgWordLen = 0;

            //writing all unique words to text box
            for (int i = 0; i < uniqueList.Count(); i++)
            {
                txtbDisplayUnique.Text += uniqueList[i].ToString() + ", ";
            }

            dictUnique = ConvertListToDictionary(uniqueList);
            dictLongestWords = LongestWords(fileList, uniqueList, dictUnique);
            dictShortestWords = ShortestWords(fileList, uniqueList, dictUnique);

            //calling this function twice to reset all int values of the dictionary to 0
            dictUnique = ConvertListToDictionary(uniqueList);
            dictMostCommonWords = MostCommonWords(fileList, uniqueList, dictUnique);
            avgWordLen = AverageWordLength(uniqueList);

            int wordResult = fileList.Count;
            double lenResult = AverageWordLength(fileList);
            //Displaying stats above chart
            lblAbsoluteNumberStats.Text = "Absolute number of all words " + wordResult.ToString()
                + ". Average word length of all words is: " + lenResult.ToString();

            AddingDataPointsToChart(dictUnique);

            //Displaying most common words
            string statMostCommonWords = DisplayStats("Frequency", dictMostCommonWords, "max", "times.");
            txtbMostCommon.Text += statMostCommonWords;
            txtbMostCommon.Text += DisplayKeys(dictMostCommonWords);

            //Displaying Longest words
            string statLongestWords = DisplayStats("Longest", dictLongestWords, "max", "letters.");
            txtbLongestWord.Text += statLongestWords;
            txtbLongestWord.Text += DisplayKeys(dictLongestWords);

            //Displaying Shortest words
            string statShortestWords = DisplayStats("Shortest", dictShortestWords, "min", "letters.");
            txtbShortestWords.Text += statShortestWords;
            txtbShortestWords.Text += DisplayKeys(dictShortestWords);

            //Displaying Average word length
            txtbAvgLen.Text = (Math.Round(avgWordLen * 100) / 100).ToString();
        }

        public Dictionary<string, int> ConvertListToDictionary(List<string> uniqueList)
        {
            Dictionary<string, int> dictConvert = new Dictionary<string, int>();
            //Converts list into a dictionary
            for (int i = 0; i < uniqueList.Count(); i++)
            {
                dictConvert.Add(uniqueList[i], 0);
            }
            return dictConvert;
        }

        public Dictionary<string, int> LongestWords(List<string> myList, List<string> uniqueList, Dictionary<string, int> dictLongestWords)
        {
            //adding the length of each word to the dictionary to compare.
            dictWordLengthGlobal = AddWordLengthToDict(uniqueList, dictLongestWords);
            //getting the max value from the dictionary.
            int max = dictLongestWords.Values.Max();
            Dictionary<string, int> maxDictionary = new Dictionary<string, int>();
            foreach (KeyValuePair<string, int> items in dictWordLengthGlobal)
            {
                if (items.Value == max)
                {
                    //If the value is the same as the max, adds it to a new dictionary
                    //to display all words with the same length
                    maxDictionary.Add(items.Key, items.Value);
                }
            }
            return maxDictionary;
        }

        public Dictionary<string, int> ShortestWords(List<string> myList, List<string> uniqueList, Dictionary<string, int> dictShortestWord)
        {
            dictWordLengthGlobal = AddWordLengthToDict(uniqueList, dictShortestWord);
            //Creating new dictionary with the shortest words
            int min = dictShortestWord.Values.Min();
            Dictionary<string, int> minDictionary = new Dictionary<string, int>();
            foreach (KeyValuePair<string, int> items in dictShortestWord)
            {
                if (items.Value == min)
                {
                    minDictionary.Add(items.Key, items.Value);
                }
            }
            return minDictionary;
        }

        public Dictionary<string, int> AddWordLengthToDict(List<string> uniqueList, Dictionary<string, int> dictWordlength)
        {
            foreach (string item in uniqueList)
            {
                dictWordlength[item] = item.Length;
            }
            return dictWordlength;
        }

        public Dictionary<string, int> MostCommonWords(List<string> myList, List<string> uniqueList, Dictionary<string, int> dictCommonWords)
        {
            //adding the word count of each word to the dictionary to compare.
            dictMostCommonGlobal = AddingWordCountToDict(myList, uniqueList, dictCommonWords);
            //getting the max value from the dictionary.
            int max = dictCommonWords.Values.Max();
            Dictionary<string, int> maxDictionary = new Dictionary<string, int>();
            foreach (KeyValuePair<string, int> items in dictMostCommonGlobal)
            {
                //If the value is the same as the max, adds it to a new dictionary
                //to display all words with the same word count
                if (items.Value == max)
                {
                    maxDictionary.Add(items.Key, items.Value);
                }
            }
            return maxDictionary;
        }

        public Dictionary<string, int> AddingWordCountToDict(List<string> myList, List<string> uniqueList, Dictionary<string, int> dictWordCount)
        {
            int wordCount = 0;
            foreach (string item1 in uniqueList)
            {
                foreach (string item2 in myList)
                {
                    if (item1.ToLower() == item2.ToLower())
                    {
                        //adding 1 to the word count for every word in the dictionary
                        wordCount++;
                    }
                }
                dictWordCount[item1] = wordCount;
                wordCount = 0;
            }
            return dictWordCount;
        }

        public double AverageWordLength(List<string> myList)
        {
            double avgWordLen = 0;
            try
            {
                //loops through the list
                foreach (string item in myList)
                {
                    //adding the length of each word
                    avgWordLen += item.Length;
                }
                //diving by how many words are in the list
                avgWordLen /= myList.Count;
            }
            catch (DivideByZeroException)
            {
                //if divide by zero, throws an exception (this should never be reached as 
                //being handled in an earlier exception)
                lblErrorMessage.Text = "There is no text in the file.";
            }
            //rounding to 2 decimal places
            return (Math.Round(avgWordLen * 100) / 100);
        }

        private void AddingDataPointsToChart(Dictionary<string, int> dictUnique)
        {
            //claring chart before adding anything new
            chartWords.Series.Clear();
            chartWords.Series.Add("Words");
            chartWords.ChartAreas["Words"].AxisX.LabelStyle.Interval = 1;
            int count = 0;
            foreach (KeyValuePair<string, int> item in dictUnique)
            {
                //shows first 50 words on the graph
                if (count >= 50)
                {
                    return;
                }
                DataPoint dp = new DataPoint();
                dp.SetValueXY(item.Key, item.Value);
                chartWords.Series["Words"].Points.Add(dp);
                count++;
            }
        }

        public string DisplayStats(string start, Dictionary<string, int> stat, string maxOrMin, string end)
        {
            if(maxOrMin == "max")
            {
                //returns the stats with max value
                return (start + ": " + stat.Values.Max().ToString() + " " + end + Environment.NewLine);
            }
            //returns the stats with a min value
            return (start + ": " + stat.Values.Min().ToString() + " " + end + Environment.NewLine);
        }

        public string DisplayKeys(Dictionary<string, int> stat)
        {
            string keys = "";
            int count = 1;
            foreach (KeyValuePair<string, int> items in stat)
            {
                //displays last word in the dictionary with no comma
                if (count == stat.Count)
                {
                    keys += items.Key.ToString() + " ";
                    break;
                }
                //seperates the keys with a comma
                keys += items.Key.ToString() + ", ";
                count++;
            }
            return keys;
        }    

        private void btnSearchWordClick(object sender, EventArgs e)
        {
            //getting the word typed into the search word box
            //then gets the number of occurences and finally displays in the textbox
            string searchWord = txtbSearchWord.Text;
            string display = SearchWordOccurence(searchWord);
            txtbSearchWordDisplay.Text = display;
        }

        public string SearchWordOccurence(string searchWord)
        {
            //using a boolean to determine if the search word is infact in the file.
            bool keyFound = false;
            int numberEntered = 0;
            foreach (KeyValuePair<string, int> items in dictMostCommonGlobal)
            {
                if (items.Key == searchWord)
                {
                    keyFound = true;
                    return  ("Number of occurences: " + items.Value.ToString());
                }
            }
            if (!keyFound)
            {
                try
                {
                    numberEntered = Int32.Parse(searchWord);
                } catch
                {
                    return (searchWord + " does not appear in the text.");
                }
                return "Please enter a valid word.";
            }
            return null; //Should not reach this point
        }

        private void BtnSearchLenClick(object sender, EventArgs e)
        {
            lblErrorMessage.Text = "";
            //checking if a valid number has been entered in the search length box.
            int searchLength;
            bool result = Int32.TryParse(txtbSearchLen.Text, out searchLength);
            if(result)
            {
                string display = SearchLength(searchLength);
                txtbSearchLenDisplay.Text = display;
            }
            else
            {
                txtbSearchLenDisplay.Text = "Please enter a valid number.";
            }
        }

        public string SearchLength(int searchLength)
        {
            lblErrorMessage.Text = "";
            //Using a boolean to determine if there are any words in the file that have the length specified
            bool keyFound = false;
            List<string> listKeys = new List<string>();
            foreach (KeyValuePair<string, int> items in dictWordLengthGlobal)
            {
                //finds all words with the length entered
                if (items.Value == searchLength)
                {
                    listKeys.Add(items.Key);
                    keyFound = true;
                }
            }
            if (!keyFound)
            {
                return ("there is no words in the text with " + searchLength + " letters.");
            }
            //Sorts the list alphabetically and returns as string
            return SortList(listKeys);
        }

        public string SortList(List<string> listKeys)
        {
            listKeys.Sort();
            int count = 1;
            string keysAsString = "";
            foreach (string items in listKeys)
            {
                if (count == listKeys.Count)
                {
                    keysAsString += items + " ";
                }
                else
                {
                    keysAsString += items + ", ";
                }
                count++;
            }
            return keysAsString;
        }
    }
}
