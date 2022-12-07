using System.Text.RegularExpressions;

namespace advent2022
{
    public class Problem7
    {

        public string Question1()
        {
            string[] lines = System.IO.File.ReadAllLines(@"Data\input7.1.txt");
            Dictionary<string, int> sizes = new Dictionary<string, int>();
            string currDir = "/";
            sizes[currDir] = 0;

            foreach (string line in lines)
            {
                if (line.StartsWith("$"))
                {
                    // Extract the command and argument from the line
                    string[] tokens = line.Split(' ');
                    string command = tokens[1];
                    string arg = tokens.Length >= 3 ? tokens[2] : "";

                    // Update the current directory
                    if (command == "cd")
                    {
                        if (arg == "..")
                        {
                            // Move up one level
                            int i = currDir.LastIndexOf('/');
                            currDir = currDir.Substring(0, i);
                        }
                        else if (arg == "/")
                        {
                            // Move to the root directory
                            currDir = "/";
                        }
                        else
                        {
                            // Move down one level
                            currDir += "/" + arg;
                        }
                    }
                }
                else
                {
                    // Extract the name and size from the line
                    string[] tokens = line.Split(' ');
                    int size = 0;
                    if(tokens[0] != "dir") {
                        size = int.Parse(tokens[0]);

                        // Add the size to the total size of the current directory
                        sizes.TryAdd(currDir, 0);
                        sizes[currDir] += size;
                    } 
                }
            }

            HashSet<string> valuesToAdd = new HashSet<string>();
            foreach (KeyValuePair<string, int> entry in sizes) // first iteration, collecting directories within directories
            {
                int i = entry.Key.LastIndexOf('/');
                currDir = entry.Key.Substring(0, i);

                if(currDir.Length > 0) {
                    string[] address = currDir.Split("/");
                    if(address.Length > 0) {
                        if(!sizes.ContainsKey(currDir)) {
                            valuesToAdd.Add(currDir);
                        } 
                    }
                }
            }

            foreach (string str in valuesToAdd) // nested directories initialized
            {
                sizes.TryAdd(str, 0);
            }

            foreach (KeyValuePair<string, int> entry in sizes) // all directories' size added including nested directories
            {

                int i = entry.Key.LastIndexOf('/');
                currDir = entry.Key.Substring(0, i);

                if(currDir.Length > 0) {
                    string[] address = currDir.Split("/");
                    if(address.Length > 0  && entry.Value > 0) {
                        if(sizes.ContainsKey(currDir)) {
                            sizes[currDir] += entry.Value;   
                        } else {
                            Console.WriteLine(entry);
                            sizes[entry.Key] += entry.Value;
                        }
                     
                    }
                } 
            }

            int result = 0;
            foreach (KeyValuePair<string, int> entry in sizes) // Getting size of the desired ones
            {
                if (entry.Value <= 100000)
                {
                    result += entry.Value;
                }
            }

            return result.ToString();
        }

        public string Question2()
        {
            return "";
        }

    }
}
