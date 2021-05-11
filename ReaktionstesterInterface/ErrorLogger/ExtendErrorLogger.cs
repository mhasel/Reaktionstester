using System;

namespace ErrorLogger
{
    // simple third party class extension example
    // pretend SimpleLogger is a third party class/library, the methods of which you do not have control over
    // allows to add new methods/extend existing methods
    public static class ExtendErrorLogger
    {
        public static void LogError(this IExceptionLogger Logger, string sMessage, string sFilename = "Log.txt", bool bAddDateTime = true)
        {
            if (string.IsNullOrWhiteSpace(sFilename))
            {
                throw new ArgumentException($"'{nameof(sFilename)}' cannot be null or whitespace.", nameof(sFilename));
            }
            
            Logger.Log(sMessage, "Error", sFilename, bAddDateTime);
        }
    }
}
