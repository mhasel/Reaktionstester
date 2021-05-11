namespace ErrorLogger
{
    public interface IExceptionLogger
    {
        void Log(string sMessage, string sFilename = "Log.txt", bool bAddDateTime = true);
        void Log(string sMessage, string sMessageType, string sFilename, bool bAddDateTime = true);
    }
}
