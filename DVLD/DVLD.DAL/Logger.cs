using System.Diagnostics;

namespace DVLD.DAL
{
    internal static class Logger
    {
        public enum LogEntryType
        {
            Error = 1,
            Warning = 2,
            Information = 4,
            SuccessAudit = 8,
            FailureAudit = 16,
        }

        const string logName = "Application";
        static string sourceName = "TestApp";

        public static void Log(string message, LogEntryType logEntryType)
        {
            EventSourceCreationData eventSourceCreationData = new EventSourceCreationData(sourceName, logName);

            if (!EventLog.SourceExists(sourceName))
                EventLog.CreateEventSource(eventSourceCreationData);

            EventLog.WriteEntry(sourceName, message, (EventLogEntryType)logEntryType);
        }
    }
}
