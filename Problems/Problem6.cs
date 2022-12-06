using System.Collections;

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
            return "";
        }
    }
}
