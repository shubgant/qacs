using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskContinuation
{
    public class ConditionalTaskContinuation
    {
        public static async Task Demo(string keyword)
        {
            try
            {
                // Start the task to fetch data
                Task<string> fetchDataTask = FetchDataAsync("https://jsonplaceholder.typicode.com/todos");

                // Continue with different tasks based on the outcome of the fetch task
                await fetchDataTask.ContinueWith(async task =>
                {
                    if (task.IsFaulted)
                    {
                        // Handle the case where the fetch task failed
                        Console.WriteLine($"Error fetching data: {task.Exception.InnerException.Message}");
                    }
                    else
                    {
                        // Handle the case where the fetch task succeeded
                        string data = await task;

                        // Execute additional task based on the fetched data
                        if (data.Contains(keyword))
                        {
                            // Execute task to process important data
                            await ProcessImportantDataAsync(data);
                        }
                        else
                        {
                            // Execute task to process no match found in data
                            await ProcessNoMatchAsync(data);
                        }
                    }
                });

                // Continue with other tasks or logic...

            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        static async Task<string> FetchDataAsync(string url)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode(); // Ensure successful response

                return await response.Content.ReadAsStringAsync();
            }
        }

        static async Task ProcessImportantDataAsync(string data)
        {
            // Simulate processing of important data asynchronously
            await Task.Delay(2000); // Simulate processing time
            Console.WriteLine("Important data processed: " + data);
        }

        static async Task ProcessNoMatchAsync(string data)
        {
            // Simulate processing of regular data asynchronously
            await Task.Delay(1000); // Simulate processing time
            Console.WriteLine("No match found" );
        }
    }
}
