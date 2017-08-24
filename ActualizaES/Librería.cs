using System;
using System.IO;

namespace ActualizaES
{
    public static class Librería
    {
        public static void WriteErrorLog(Exception ex)
        {
            StreamWriter wr = null;
            try
            {
                wr = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\LogFile.txt", true);
                wr.WriteLine(DateTime.Now.ToString() + ": " + ex.Source.ToString().Trim() + "; " + ex.Message.ToString().Trim());
                wr.Flush();
                wr.Close();
            }
            catch
            {

            }
        }
        public static void WriteErrorLog(string Message)
        {
            StreamWriter wr = null;
            try
            {
                wr = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\LogFile.txt", true);
                wr.WriteLine(DateTime.Now.ToString() + ": " + Message);
                wr.Flush();
                wr.Close();
            }
            catch
            {

            }

        }
    }
}
