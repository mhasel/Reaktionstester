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
        private static IExceptionLogger Logger = new ExceptionLogger();
        public static void UpdateHighscores(this Dictionary<string, int> oDict, string sName, int iTime)
        {
            if (oDict.ContainsKey(sName))
            {
                if(oDict[sName].CompareTo(iTime) < 0)
                {
                    oDict[sName] = iTime;
                }
            }
            else
            {
                oDict.Add(sName, iTime);
            }

            oDict = oDict.OrderBy(oKeyValuePair => oKeyValuePair.Value).ToDictionary(sKey => sKey.Key, iValue => iValue.Value);
            
            if (oDict.Count > 10)
            {
                // TODO: TESTING
                oDict = (Dictionary<string, int>)oDict.Take(10);
            }
         }

        public static List<string> ReadFile(string sFilename = "Highscores.txt")
        {
            string sReadLine;
            List<string> oLines = new List<string>();

            if (File.Exists(sFilename) == false)
            {
                // TODO
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

        public static Dictionary<string, int> ParseHighscores(this List<string> oList, char cSeparator = '|')
        {
            Dictionary<string, int> oDict = new Dictionary<string, int>();            

            try
            {
                // filter out possible invalid entries
                oList = oList.Where(sItem => sItem.Contains(cSeparator)).ToList();
                oList.ForEach(sItem =>
                     {
                         string sKey;
                         string sValue;
                         char[] cToTrim = new char[] { };     
                                             
                         // divide string in list into key and value parts, divided by the separator character
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

            //// same code as above, without lambdas
            //string sKey;
            //int iValue;
            //
            //foreach (string sItem in oList)
            //{                
            //    if (sItem.Contains(cSeparator))
            //    {
            //        try
            //        {
            //            sKey = sItem.Substring(0, sItem.IndexOf(cSeparator));
            //            iValue = Convert.ToInt32(sItem.Substring(sItem.IndexOf(cSeparator) + 1));
            //            oDict.Add(sKey, iValue);
            //        }
            //        catch (Exception oEx)
            //        {
            //            Logger.LogError(oEx.ToString());
            //        }
            //    }
            //}

            return oDict;
        }

        public static void WriteFile
        (
            this Dictionary<string, int> oDict,
            string sFilename = "Highscores.txt",
            char cSeparator = '|'
        )
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
