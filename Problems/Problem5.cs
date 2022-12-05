using System.Collections;

namespace advent2022 {
    public class Problem5 {

        public string Question1() {
            string[] lines = System.IO.File.ReadAllLines(@"Data\input5.1.txt");
            string res = "";

            #region stacks
            Stack[] stacks = new Stack[9];
            
            stacks[0] = new Stack();
            stacks[0].Push("H");
            stacks[0].Push("B");
            stacks[0].Push("V");
            stacks[0].Push("W");
            stacks[0].Push("N");
            stacks[0].Push("M");
            stacks[0].Push("L");
            stacks[0].Push("P");

            stacks[1] = new Stack();
            stacks[1].Push("M");
            stacks[1].Push("Q");
            stacks[1].Push("H");

            stacks[2] = new Stack();
            stacks[2].Push("N");
            stacks[2].Push("D");
            stacks[2].Push("B");
            stacks[2].Push("G");
            stacks[2].Push("F");
            stacks[2].Push("Q");
            stacks[2].Push("M");
            stacks[2].Push("L");

            stacks[3] = new Stack();
            stacks[3].Push("Z");
            stacks[3].Push("T");
            stacks[3].Push("F");
            stacks[3].Push("Q");
            stacks[3].Push("M");
            stacks[3].Push("W");
            stacks[3].Push("G");

            stacks[4] = new Stack();
            stacks[4].Push("P");
            stacks[4].Push("H");
            stacks[4].Push("T");
            stacks[4].Push("M");

            stacks[5] = new Stack();
            stacks[5].Push("C");
            stacks[5].Push("B");
            stacks[5].Push("M");
            stacks[5].Push("J");
            stacks[5].Push("D");
            stacks[5].Push("H");
            stacks[5].Push("G");
            stacks[5].Push("T");   

            stacks[6] = new Stack();
            stacks[6].Push("M");
            stacks[6].Push("N");
            stacks[6].Push("B");
            stacks[6].Push("F");
            stacks[6].Push("V");
            stacks[6].Push("R"); 

            stacks[7] = new Stack();
            stacks[7].Push("P");
            stacks[7].Push("L");
            stacks[7].Push("H");
            stacks[7].Push("M");
            stacks[7].Push("R");
            stacks[7].Push("G");  
            stacks[7].Push("S");  

            stacks[8] = new Stack();
            stacks[8].Push("P");
            stacks[8].Push("D");
            stacks[8].Push("B");
            stacks[8].Push("C");  
            stacks[8].Push("N");
            #endregion

            foreach (string str in lines) {
                string[] vals = str.Split(" ");

                for (int i = 0; i < Int32.Parse(vals[1]); i++)
                {
                    if(stacks[Int32.Parse(vals[3]) - 1].Count > 0) {
                        stacks[Int32.Parse(vals[5]) - 1].Push(stacks[Int32.Parse(vals[3]) - 1].Pop());
                    }
                }
            }

            for (int i = 0; i < stacks.Length; i++)
            {
                res += stacks[i].Peek();
            }

            return res;
        }

        public string Question2() {
            return "";
        }

    }
}
