using LiskovSubstitution;
using System;
using System.IO;

public class FileLogger :ILogger
{
    public void Handle(string message)
    {
        using (StreamWriter writer = new StreamWriter("c:\\Temp\\Log.txt", false))
        {
            writer.Write(message.ToString());
        }
    }
}