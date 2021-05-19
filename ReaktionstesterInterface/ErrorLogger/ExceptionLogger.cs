using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ErrorLogger
{
    public class ExceptionLogger : IExceptionLogger
    {
        public void Log(string sMessage, string sFilename, bool bAddDateTime)
        {
            string sDirectoryPath;
            string sLogFilePath;
            string sCurrentTime = DateTime.Now.ToString("yyyy-MM-dd_HH.mm");
            List<string> oLines = new List<string>();

            if (bAddDateTime)
            {
                sFilename = $"{sCurrentTime}_{sFilename}";
            }
            // gets the current directory of the executing assembly and adds a verbatim string to access a sub-folder
            sDirectoryPath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\logs\";
            sLogFilePath = sDirectoryPath + sFilename;
            
            if (File.Exists(sLogFilePath))
            {
                string sReadLine;
                try
                {
                    using (StreamReader Input = new StreamReader(sLogFilePath))
                    {
                        while ((sReadLine = Input.ReadLine()) != null)
                        {
                            oLines.Add(sReadLine);
                        }
                    }
                }
                catch (Exception)
                {
                    // TODO: if logger throws exception, then what?
                }
            }
            else if (!Directory.Exists(sDirectoryPath))
            {
                Directory.CreateDirectory(sDirectoryPath);
            }

            oLines.Add(sMessage);

            using (StreamWriter Output = new StreamWriter(sLogFilePath))
            {
                oLines.ForEach(sLine => Output.WriteLine(sLine));
            }

            DirectoryCleanUp(sDirectoryPath);
        }

        public void Log(string sMessage, string sMessageType, string sFilename, bool bAddDateTime)
        {
            Log($"{ sMessageType}: {sMessage}", sFilename, bAddDateTime);
        }

        public static void DirectoryCleanUp(string sPath)
        {
            // selects all files in specified directory, filters them by the time of last access and deletes them if they have not been accessed in at least 1 month
            Directory.GetFiles(sPath)
                     .Select(sFilePath => new FileInfo(sFilePath))
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

