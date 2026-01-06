namespace ProcAsyncTasksAsTheyComplete
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    public class Program
    {
        public static async Task Main(string[] args)
        {
            // URLs of web APIs to fetch data from
            string[] apiUrls = new string[]
            {
            "https://jsonplaceholder.typicode.com/photos",
            "https://jsonplaceholder.typicode.com/comments",
            "https://jsonplaceholder.typicode.com/todos",
            "https://jsonplaceholder.typicode.com/posts",
            "https://jsonplaceholder.typicode.com/users"
            };

            List<string> results = await GetTypiCodeData(apiUrls);
            results.ForEach(r => Console.WriteLine($"Received data: {r}"));
        }

        public static async Task<List<string>> GetTypiCodeData(string[] apiUrls)
        {
            // List to store the results from each API call
            List<string> results = new List<string>();

            // Create tasks to fetch data asynchronously from each API
            List<Task<string>> fetchDataTasks = new List<Task<string>>();
            foreach (string apiUrl in apiUrls)
            {
                fetchDataTasks.Add(FetchDataAsync(apiUrl));
            }

            // Process tasks as they complete
            while (fetchDataTasks.Count > 0)
            {
                //Awaits a call to WhenAny to identify the first task in the
                //collection that has finished its download.
                Task<string> completedTask = await Task.WhenAny(fetchDataTasks);

                // Remove the completed task from the list
                fetchDataTasks.Remove(completedTask);

                // Await the result of the completed task, which is returned
                // by a call to FetchDataAsync. The completedTask variable is
                // a Task<TResult> where TResult is a string. The task is
                // already complete, but you await it to retrieve the
                // data from the downloaded website
                string result = await completedTask; 

                // Process the result
                results.Add(result);
            }
            return results;
        }

        // Method to fetch data asynchronously from a web API
        public static async Task<string> FetchDataAsync(string apiUrl)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                HttpResponseMessage response = await httpClient.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    //Find final word in url (which specifies the kind of data being returned)
                    string pattern = @"/([^/]+)$"; // Matches the text after the final backslash
                    string textAfterBackslash = "";
                    // Use Regex.Match to find the match in the URL
                    Match match = Regex.Match(apiUrl, pattern);

                    // Check if a match is found
                    if (match.Success)
                    {
                        // Extract the text after the final backslash
                        textAfterBackslash = match.Groups[1].Value;
                    }
                    string result = await response.Content.ReadAsStringAsync();
                    string stars = "\n***********************************\n";
                    return $"{stars}{textAfterBackslash.ToUpper()}{stars} {result}";
                }
                else
                {
                    throw new Exception($"Failed to fetch data from {apiUrl}. Status code: {response.StatusCode}");
                }
            }
        }
    }

}
