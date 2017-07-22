using System;
using System.IO;


namespace Directory_Codejam
{
    public class Log
    {
        public static StreamWriter logWriter;
        public static bool LogEntry()
        {
            logWriter = File.AppendText(@"d:\Students_Record\logs.log");
            logWriter.WriteLine("{1}:Added a student - {0}", new StudentInfo().Id(), DateTime.Now.ToString());
            logWriter.Close();
            return true;
        }

    }


}