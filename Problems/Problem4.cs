namespace advent2022 {
    public class Problem4 {

        public string Question1() {
            string[] lines = System.IO.File.ReadAllLines(@"Data\input4.1.txt");
            int count = 0;

            foreach (string str in lines) {
                string[] parts = str.Split(",");
                string[] first = parts[0].Split("-");
                string[] last = parts[1].Split("-");

                if(Int32.Parse(first[0]) <= Int32.Parse(last[0]) && Int32.Parse(first[1]) >= Int32.Parse(last[1])) {
                    count++;
                } else if(Int32.Parse(last[0]) <= Int32.Parse(first[0]) && Int32.Parse(last[1]) >= Int32.Parse(first[1])) {
                    count++;
                }
            }

            return count.ToString();
        }

        public string Question2() {
            string[] lines = System.IO.File.ReadAllLines(@"Data\input4.1.txt");
            int count = 0;

            foreach (string str in lines) {
                string[] parts = str.Split(",");
                string[] first = parts[0].Split("-");
                string[] last = parts[1].Split("-");

                if(Int32.Parse(last[0]) >= Int32.Parse(first[0]) && Int32.Parse(last[0]) <= Int32.Parse(first[1])) {
                    count++;
                } else if(Int32.Parse(last[1]) >= Int32.Parse(first[0]) && Int32.Parse(last[1]) <= Int32.Parse(first[1])) {
                    count++;
                } else if(Int32.Parse(first[0]) >= Int32.Parse(last[0]) && Int32.Parse(first[0]) <= Int32.Parse(last[1])) {
                    count++;
                } else if(Int32.Parse(first[1]) >= Int32.Parse(last[0]) && Int32.Parse(first[1]) <= Int32.Parse(last[1])) {
                    count++;
                }
            }
            
            return count.ToString();
        }
    }
}
