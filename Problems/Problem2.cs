namespace advent2022 {
    public class Problem2 {

        public string Question1() {
            string[] lines = System.IO.File.ReadAllLines(@"Data\input2.1.txt");

            int score = 0;
            char currentPlay;

            foreach (string str in lines)
            {
                currentPlay = str.ElementAt(2);

                switch (currentPlay)
                {
                    case 'X':
                        score += 1;
                        break;
                    case 'Y':
                        score += 2;
                        break;
                    case 'Z':
                        score += 3;
                        break;
                    default:
                        break;
                }

                if(str.ElementAt(0) == 'A' && currentPlay == 'X' || str.ElementAt(0) == 'B' && currentPlay == 'Y' || str.ElementAt(0) == 'C' && currentPlay == 'Z') {
                    score += 3;
                } else if (str.ElementAt(0) == 'A' && currentPlay == 'Y' || str.ElementAt(0) == 'B' && currentPlay == 'Z' || str.ElementAt(0) == 'C' && currentPlay == 'X') {
                    score += 6;
                }
            }

            return score.ToString();
        }

        public string Question2() {
            string[] lines = System.IO.File.ReadAllLines(@"Data\input2.1.txt");

            int score = 0;
            char currentPlay;

            foreach (string str in lines)
            {
                currentPlay = str.ElementAt(2);

                switch (currentPlay)
                {
                    case 'X': //lose
                        if(str.ElementAt(0) == 'A') {
                            score += 3;
                        } else if(str.ElementAt(0) == 'B') {
                            score += 1;
                        } else {
                            score += 2;
                        }
                        break;
                    case 'Y': //draw
                        if(str.ElementAt(0) == 'A') {
                            score += 4;
                        } else if(str.ElementAt(0) == 'B') {
                            score += 5;
                        } else {
                            score += 6;
                        }
                        break;
                    case 'Z': //win
                        if(str.ElementAt(0) == 'A') {
                            score += 8;
                        } else if(str.ElementAt(0) == 'B') {
                            score += 9;
                        } else {
                            score += 7;
                        }
                        break;
                    default:
                        break;
                }
            }

            return score.ToString();
        }
    }
}
