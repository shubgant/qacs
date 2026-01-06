using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TaskContinuation
{
    public class BasicContinuation
    {
        public static async Task Demo()
        {
            try
            {
                // Start the download task
                Task<byte[]> downloadTask = DownloadFileAsync("https://jsonplaceholder.typicode.com/todos");

                // Continue with processing once the download is complete
                Task<Task<int>> processTask = downloadTask.ContinueWith(async download =>
                {
                    byte[] fileData = await download; // Retrieve the downloaded file data
                    int fileSize = fileData.Length;   // Get the size of the downloaded file
                    Console.WriteLine($"Downloaded file size: {fileSize} bytes");

                    // Process the downloaded file data (example: count number of lines)
                    int lineCount = CountLines(fileData);
                    Console.WriteLine($"Number of lines in the file: {lineCount}");

                    // Return the line count as the result of the processing task
                    return lineCount;
                });

                // Wait for the processing task to complete
                Task<int> tResult = await processTask;
                int result = await tResult;
                Console.WriteLine($"Processing completed. Number of lines: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        static async Task<byte[]> DownloadFileAsync(string url)
        {
            using (var client = new WebClient())
            {
                return await client.DownloadDataTaskAsync(url);
            }
        }

        static int CountLines(byte[] data)
        {
            using (var stream = new MemoryStream(data))
            using (var reader = new StreamReader(stream))
            {
                int count = 0;
                while (reader.ReadLine() != null)
                {
                    count++;
                }
                return count;
            }
        }
    }
}
