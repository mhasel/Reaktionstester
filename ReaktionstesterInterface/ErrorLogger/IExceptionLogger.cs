namespace ErrorLogger
{
    // Extracted interface. May not declare instance data.
    // Allows complete abstraction of classes without multiple inheritance (which is not supported in C#). 
    // Enables plug-and-play and allows to include behaviour from multiple sources in a class.
    // https://www.educba.com/c-sharp-interface/
    public interface IExceptionLogger
    {
        void Log(string sMessage, string sFilename = "Log.txt", bool bAddDateTime = true);
        void Log(string sMessage, string sMessageType, string sFilename, bool bAddDateTime = true);
    }
}
