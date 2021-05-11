using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ErrorLogger
{
    public class ExceptionLogger : IExceptionLogger
    {
        public void Log(string sMessage, string sFilename = "Log.txt", bool bAddDateTime = true)
        {
            string sPath;
            List<string> oLines = new List<string>();

            if (bAddDateTime)
            {
                sFilename = $"{DateTime.Now}_{sFilename}";
            }

            // gets the current directory of the executing assembly and adds a verbatim string to access a sub-folder
            sPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location + @"\logs\");

            if (File.Exists(sPath + sFilename))
            {
                string sReadLine;
                try
                {
                    using (StreamReader Input = new StreamReader(sPath + sFilename))
                    {
                        while ((sReadLine = Input.ReadLine()) != null)
                        {
                            oLines.Add(sReadLine);
                        }
                    }
                }
                catch (Exception)
                {
                    // TODO: if logger throws exception, then what? just ignore?
                }
            }

            oLines.Add(sMessage);

            using (StreamWriter Output = new StreamWriter(sPath + sFilename))
            {
                oLines.ForEach(sLine => Output.WriteLine(sLine));
            }

            DirectoryCleanUp(sPath);
        }

        public void Log(string sMessage, string sMessageType, string sFilename, bool bAddDateTime = true)
        {
            Log($"{sMessageType}: {sMessage}", sFilename, bAddDateTime);
        }

        public static void DirectoryCleanUp(string sPath)
        {
            // selects all files in specified directory, filters them by the time of last access and deletes them if they have not been accessed in at least 1 month
            Directory.GetFiles(sPath)
                     .Select(logFile => new FileInfo(logFile))
                     .Where(logFile => logFile.LastAccessTime < DateTime.Now.AddMonths(-1))
                     .ToList()
                     .ForEach(logFile =>
                     {
                         try
                         {
                             logFile.Delete();
                         }
                         catch { }
                     });
        }
    }
}

