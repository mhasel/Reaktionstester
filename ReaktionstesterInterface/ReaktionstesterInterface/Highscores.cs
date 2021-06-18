using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ErrorLogger;

namespace HighscoreFileHandling
{
    public static class Highscores
    {
        static readonly ExceptionLogger Logger = new ExceptionLogger();

        /// <summary>
        /// Extends Dictionary<string,int>. Allows adding a new entry to dictionary, if there are duplicates, selects smallest value.
        /// Dictionary is then sorted in ascending order and all but the lowest (=best) ten values are discarded.
        /// </summary>
        /// <param name="oDict">Dictionary to be extended, sorted and trimmed</param>
        /// <param name="sName">Key of type string to be added</param>
        /// <param name="iTime">Value of type integer to be added</param>
        /// <returns>Dictionary<string, int> containing the 10 lowest values, sorted in ascending order.</returns>
        public static Dictionary<string, int> UpdateHighscores(this Dictionary<string, int> oDict, string sName, int iTime)
        {
            if (oDict.ContainsKey(sName))
            {
                if(oDict[sName].CompareTo(iTime) > 0)
                {
                    oDict[sName] = iTime;
                }
            }
            else
            {
                oDict.Add(sName, iTime);
            }

            oDict = oDict.OrderBy(oKeyValuePair => oKeyValuePair.Value)
                         .ToDictionary(oKVP => oKVP.Key, oKVP => oKVP.Value);
            
            if (oDict.Count > 10)
            {    
                oDict = oDict.Take(10)
                             .ToDictionary(oKVP => oKVP.Key, oKVP => oKVP.Value);

                //// different approach, same result:
                //oDict.Skip(10)
                //     .ToList()
                //     .ForEach(oKVP =>
                //     {
                //         oDict.Remove(oKVP.Key);
                //     });
            }
            return oDict;
         }

        /// <summary>
        /// Import highscores from file.
        /// </summary>
        /// <param name="sFilename">Name of file to import.</param>
        /// <returns>List containing each line of imported file.</returns>
        public static List<string> ReadFile(string sFilename = "Highscores.txt")
        {
            string sReadLine;
            List<string> oLines = new List<string>();

            if (!File.Exists(sFilename))
            {
                return oLines;
            }

            try
            {
                using (StreamReader Input = new StreamReader(sFilename))
                {
                    while ((sReadLine = Input.ReadLine()) != null)
                    {
                        oLines.Add(sReadLine);
                    }
                }
            }
            catch (Exception oEx)
            {
                Logger.LogError(oEx.ToString());
            }

            return oLines;
        }

        /// <summary>
        /// This method is used to parse a list of strings containing highscores in the format of name, seperator, time
        /// </summary>
        /// <param name="oList">The list to parse.</param>
        /// <param name="cSeparator">Character that is used to separate name and time</param>
        /// <returns>A dictionary containing the name as key and the time as value.</returns>
        public static Dictionary<string, int> ParseHighscores(this List<string> oList, char cSeparator = '|')
        {
            Dictionary<string, int> oDict = new Dictionary<string, int>();            

            try
            {
                // filter out invalid entries
                oList = oList.Where(sItem => sItem.Contains(cSeparator)).ToList();

                oList.ForEach(sItem =>
                     {
                         string sKey;
                         string sValue;   
                                                                      
                         // split string into key and value parts, divided by the separator character
                         sKey = sItem.Substring(0, sItem.IndexOf(cSeparator)).Trim();
                         sValue = sItem.Substring(sItem.IndexOf(cSeparator));
                         // filter value string for digit characters (in case of suffix)
                         sValue = new string(sValue.Where(cChar => char.IsDigit(cChar)).ToArray());
 
                         // add new keyvaluepair to dictionary
                         oDict.Add(sKey, Convert.ToInt32(sValue));
                     });
            }
            catch (Exception oEx)
            {
                Logger.LogError(oEx.ToString());
            }            

            return oDict;
        }
        
        /// <summary>
        /// Write highscores to file.
        /// </summary>
        /// <param name="oDict">The dictionary containing highscores.</param>
        /// <param name="sFilename">Name of the file to write to.</param>
        /// <param name="cSeparator">Character separating name(key) and time(value).</param>
        public static void WriteFile (this Dictionary<string, int> oDict, string sFilename = "Highscores.txt", char cSeparator = '|')
        {
            try
            {
                using (StreamWriter Output = new StreamWriter(sFilename))
                {
                    foreach (KeyValuePair<string, int> oPair in oDict)
                    {
                        Output.WriteLine($"{oPair.Key}{cSeparator}{oPair.Value}");
                    }
                }
            }
            catch (Exception oEx)
            {
                Logger.LogError(oEx.ToString());
            }
        }
    }
}
