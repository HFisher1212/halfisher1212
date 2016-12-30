using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseRaceSim
{
    class HorseTrackDriver
    {
        private const String COMMA = ",";
        private const String FILE_NAME = "C:/Users/Work Laptop/Desktop/CS112/Final Project/Horse Info.txt";
        private const String FINISH_LINE_ANNOUNCEMET = "\n At The FINISH! ";
        private const String FILE_ERROR = "\n ERROR: File Not Found: ";
        private const String LOSS_ANNOUNCEMENT1 = " Sorry, ";
        private const String LOSS_ANNOUNCEMENT2 = "You Lost: $";
        private const String NUMBER_ERROR = " ERROR: please enter value between ";
        private const String LEADER_ANNOUNCEMENT = "\n The Leader Is: ";
        private const String SECOND_PLACE_ANNOUNCEMENT = "\n In Second is: ";
        private const String THIRD_PLACE_ANNOUNCEMENT = "\n In Third is: ";
        private const String TURN_ONE_ANNOUNCEMENT = "\n And Their Off! \n\n Rounding Turn One! ";
        private const String TURN_TWO_ANNOUNCEMENT = "\n Rounding Turn Two! ";
        private const String TURN_THREE_ANNOUNCEMENT = "\n On The Straight! ";
        private const String WINNER_ANNOUNCEMENT = " You've Won!: $";
        private const String WINNER_ANNOUNCEMENT2 = " The Winner Is: ";
        private const String WINNER_TOTAL_ANNOUNCEMENT = " Your Total so far is: ";
        private const int MAX_BET = 5000;
        private const int MAX_HORSE = 7;
        private const int MIN_BET = 1;
        private const int MIN_HORSE = 1;

        /***** DECLARATION SECTION *****/
        private static List<Horses> horseArray = new List<Horses>();
        private static Random random = new Random();

        // MAINRUN METHOD
        // Runs individual sections of the program
        public static void mainRun(Player player)
        {
            firstHalf(TURN_ONE_ANNOUNCEMENT);
            
            firstHalf(TURN_TWO_ANNOUNCEMENT);
            
            secondHalf(TURN_THREE_ANNOUNCEMENT);
            
            finishLine(FINISH_LINE_ANNOUNCEMET, player);
        }

        // GETHORSEARRAY METHOD
        // Return horse array
        public static void setHorseArray(List<Horses> array)
        {
            horseArray = array;
        }

        // FIRSTHALF METHOD
        // Creates first half of race results
        private static void firstHalf(String announcement)
        {
            MessageBox.Show(announcement);
            calcMath1();
            horseArray.Sort();
            calcResults();
        }

        // SECONDHALF METHOD
        // Creates second half of race results
        private static void secondHalf(String announcement)
        {
            MessageBox.Show(announcement);
            calcMath2();
            horseArray.Sort();
            calcResults();
        }

        // FINISHLINE METHOD
        // Produces finish of race results and winner amounts
        private static void finishLine(String announcement, Player player)
        {
            MessageBox.Show(announcement);
            calcMath2();
            calcResults2();
            horseArray.Sort();
            calcWinner(player);
        }

        /***** OTHER METHODS *****/

        private static void calcMath1()
        {
            int i = 0;

            while(i < horseArray.Count)
            {
                horseArray[i].Rank += random.Next(7, 10) * horseArray[i].Speed;
                i++;
            }
        }

        private static void calcMath2()
        {
            int i = 0;

            while (i < horseArray.Count)
            {
                horseArray[i].Rank += random.Next(7, 10) * horseArray[i].Endurance;
                i++;
            }
        }

        // CalcResults
        // Calculates results of CalcMath1 or CalcMath2
        private static void calcResults()
        {
            MessageBox.Show(LEADER_ANNOUNCEMENT + horseArray[0].Name + "\n" + SECOND_PLACE_ANNOUNCEMENT + horseArray[1].Name + "\n" + THIRD_PLACE_ANNOUNCEMENT + horseArray[2].Name);
        }

        // Calculates Horse Standings Slightly Different for Second half of race
        private static void calcResults2()
        {
            MessageBox.Show( WINNER_ANNOUNCEMENT2 + horseArray[0].Name + "\n" + SECOND_PLACE_ANNOUNCEMENT + horseArray[1].Name + "\n" + THIRD_PLACE_ANNOUNCEMENT + horseArray[2].Name);
        }

        // CALCODDS METHOD
        private static int calcOdds(string name)
        {
            for (int i = 0; i < horseArray.Count; i++)
            {
                if (name.Equals(horseArray[i].Name))
                {
                    return (horseArray[i].Odds);
                }
            }
            return -1;
        }

        // Calculates if Player Won and Payout
        private static void calcWinner(Player player)
        {
            if (player.PlayerHorse.Equals(horseArray[0].Name) && player.PlayerWagerType == 1)
            {
                MessageBox.Show(" Player Horse: " + player.PlayerHorse + " Wager Type: " + player.PlayerWagerType);
                player.setPlayerTotal((player.PlayerBet * calcOdds(player.PlayerHorse)));
                MessageBox.Show((WINNER_ANNOUNCEMENT + decimal.Round((decimal)(player.PlayerBet * calcOdds(player.PlayerHorse)), 2)));
            }
            else if ((player.PlayerHorse.Equals(horseArray[0].Name) || player.PlayerHorse.Equals(horseArray[1].Name)) && player.PlayerWagerType == 2)
            {
                player.setPlayerTotal(player.PlayerBet * (calcOdds(player.PlayerHorse) / 2.0));
                MessageBox.Show((WINNER_ANNOUNCEMENT + decimal.Round((decimal)(player.PlayerBet * (calcOdds(player.PlayerHorse) / 2.0)), 2)));
            }

            else if ((player.PlayerHorse.Equals(horseArray[0].Name) || player.PlayerHorse.Equals(horseArray[1].Name) || player.PlayerHorse.Equals(horseArray[2].Name)) && player.PlayerWagerType == 3)
            {
                player.setPlayerTotal(player.PlayerBet * (calcOdds(player.PlayerHorse) / 3.0));
                MessageBox.Show(WINNER_ANNOUNCEMENT + decimal.Round((decimal)(player.PlayerBet * (calcOdds(player.PlayerHorse) / 3.0)), 2));
            }

            else
            {
                player.setPlayerTotal(-player.PlayerBet);
                MessageBox.Show(LOSS_ANNOUNCEMENT1 + LOSS_ANNOUNCEMENT2 + player.PlayerBet);
            }
        }
    }
}
