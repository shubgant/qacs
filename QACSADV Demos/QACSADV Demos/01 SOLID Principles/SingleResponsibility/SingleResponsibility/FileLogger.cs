using System;
using System.IO;

namespace SingleResponsibility
{
    public class FileLogger : ILogger
    {
        public void Handle(string exceptionMesasage)
        {
            using (StreamWriter writer = new StreamWriter("c:\\Temp\\Error.txt", false))
            {
                writer.Write(exceptionMesasage);
            }
        }
    }
}