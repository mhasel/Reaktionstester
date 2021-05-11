using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighscoreFileHandling
{
    public static class Highscores
    {
        public static void AddItemAndSort(this Dictionary<string, int> oDict, string sName, int iTime)
        {
            oDict.Add(sName, iTime);
            oDict = oDict.OrderBy(oKeyValuePair => oKeyValuePair.Value).ToDictionary(x => x.Key, x => x.Value);
         }

        public static List<string> ReadFile(string sFilename = "Highscores.txt")
        {
            string sReadLine;
            List<string> oLines = new List<string>();
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
                // TODO
                System.Windows.Forms.MessageBox.Show(oEx.ToString());
            }        

            return oLines;
        }

        public static Dictionary<string, int> ParseHighscores(this List<string> oList, char cSeparator = '|')
        {
            Dictionary<string, int> oDict = new Dictionary<string, int>();
            string sKey;
            int iValue;

            foreach (string sItem in oList)
            {                
                if (sItem.Contains(cSeparator))
                {
                    try
                    {
                        sKey = sItem.Substring(0, sItem.IndexOf(cSeparator));
                        iValue = Convert.ToInt32(sItem.Substring(sItem.IndexOf(cSeparator) + 1));
                        oDict.Add(sKey, iValue);
                    }
                    catch
                    {
                        //TODO
                    }                    
                }
            }
            
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
            catch { }
        }


    }
}
