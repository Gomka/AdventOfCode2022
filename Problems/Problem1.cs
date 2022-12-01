namespace advent2022 {
    public class Problem1 {

        public string Question1() {
            string[] lines = System.IO.File.ReadAllLines(@"Data\input1.1.txt");

            int maxCal = 0;
            int localCal = 0;

            foreach (string str in lines)
            {
                if(str.Length == 0) {
                    if(localCal > maxCal) maxCal = localCal;
                    localCal = 0;
                } else {
                    localCal += Int32.Parse(str);  
                }
            }
            
            return maxCal.ToString();
        }

        public string Question2() {
            string[] lines = System.IO.File.ReadAllLines(@"Data\input1.1.txt");

            var calList = new List<int>();
            int localCal = 0;

            foreach (string str in lines)
            {
                if(str.Length == 0) {
                    calList.Add(localCal);
                    localCal = 0;
                } else {
                    localCal += Int32.Parse(str);  
                }
            }

            calList.Sort();

            return (calList.ElementAt(calList.Count()-1) + calList.ElementAt(calList.Count()-2) + calList.ElementAt(calList.Count()-3)).ToString();
        }
    }
}
