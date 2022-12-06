using System.Collections.Generic;

namespace advent2022 {
    public class Problem6 {

        public string Question1() {
            string[] lines = System.IO.File.ReadAllLines(@"Data\input6.1.txt");
            char[] chars = new char[4];
            int count = 4;

            for (int i = 3; i < lines[0].Length; i++) {

                chars[0] = lines[0][i-3];
                chars[1] = lines[0][i-2];
                chars[2] = lines[0][i-1];           
                chars[3] = lines[0][i];

                if(chars[0] == chars[1] || chars[0] == chars[2] || chars[0] == chars[3] || chars[1] == chars[2] || chars[1] == chars[3] || chars[2] == chars[3]) {
                    count++;
                } else {
                    break;
                }

            }


            return count.ToString();
        }

        public string Question2() {
            string[] lines = System.IO.File.ReadAllLines(@"Data\input6.1.txt");
            HashSet<char> chars = new HashSet<char>();
            int count = 14;

            for (int i = 13; i < lines[0].Length; i++) {

                for (int j = 0; j < 14; j++)
                {
                    chars.Add(lines[0][i-j]);
                }
                
                if(chars.Count == 14) {
                    break;
                } else {
                    chars.Clear();
                    count++;
                }

            }

            return count.ToString();
        }
    }
}
