namespace advent2022 {
    public class Problem3 {

        public string Question1() {
            string[] lines = System.IO.File.ReadAllLines(@"Data\input3.1.txt");

            int priorities = 0;

            foreach (string str in lines)
            {
                var first = str.Substring(0, (int)(str.Length / 2));
                var last = str.Substring((int)(str.Length / 2), (int)(str.Length / 2));

                var commonChars = first.Intersect(last);

                if(Char.IsLower(commonChars.ElementAt(0))) {
                    priorities += commonChars.ElementAt(0) - 96;
                } else {
                    priorities += commonChars.ElementAt(0) - 38;
                }
            }

            return priorities.ToString();
        }

        public string Question2() {
            string[] lines = System.IO.File.ReadAllLines(@"Data\input3.1.txt");

            int priorities = 0;

            for (int i = 0; i < lines.Length; i+=3)
            {
                string first = lines[i];
                string second = lines[i+1];
                string third = lines[i+2];

                var aux = first.Intersect(second);
                var commonChars = aux.Intersect(third);

                if(Char.IsLower(commonChars.ElementAt(0))) {
                    priorities += commonChars.ElementAt(0) - 96;
                } else {
                    priorities += commonChars.ElementAt(0) - 38;
                }
            }

            return priorities.ToString();
        }
    }
}
