using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseRaceSim
{
    class Player
    {
        /***** CONSTANTS SECTION *****/
        private const double DEFAULT_TOTAL_WINNINGS = 0;
        private const int DEFAULT_BET = 0;
        private const String DEFAULT_HORSE = "";
	    private const int DEFAULT_WAGER_TYPE = 1;
 
        /***** INITIALIZATION SECTION *****/
        public int PlayerBet { set; get; }
        public string PlayerHorse { set; get; }
        public double PlayerTotalWinnings { set; get; }
        public int PlayerWagerType { set; get; }
        public double total;

        /***** CONSTRUCTOR *****/

        // Default Constructor
        // DESCRIPTION:    all object parameters given default values
        // PRECONDITIONS:  n/a
        // POSTCONDITIONS: all object parameters given default values
        public Player()
        {
            setAll(DEFAULT_BET, DEFAULT_TOTAL_WINNINGS, DEFAULT_HORSE, DEFAULT_WAGER_TYPE);
        }

        // Default Full Constructor
        // DESCRIPTION:    set all using individual setters with each parameter
        // PRECONDITIONS:  n/a
        // POSTCONDITIONS: object is created with all arguments 
        public Player(int bet, String playerHorse, int wagerType)
        {
            setAll(bet, DEFAULT_TOTAL_WINNINGS, playerHorse, wagerType);
        }

        /***** MUTATOR METHOD *****/
        // Set All
        // DESCRIPTION:    uses individual set methods 
        // PRECONDITIONS:  n/a
        // POSTCONDITIONS: all set arguments are passed to individual setters
        private void setAll(int bet, double winnings, String horseName, int wagerType)
        {
            PlayerBet = bet;
            PlayerHorse = horseName;
            setPlayerTotal(winnings);
            PlayerWagerType = wagerType;
        }

        public void setPlayerTotal(double value)
        {
            total += value;
        }

        public double getPlayerTotal()
        {
            return total;
        }

        public static bool isValidBet(int bet)
        {
            return bet > 0;
        }

        // DESCRIPTION:    returns true if horsenum is valid
        // PRECONDITIONS:  n/a
        // POSTCONDITIONS: no data changed by useage
        public static bool isValidHorseNum(int horseNum)
        {
            return horseNum > 0;
        }

        /***** REQUIRED METHODS *****/

        // TOSTRING METHOD
        public String toString()
        {
            return "\n Bet: " + PlayerBet + "\n Player Winnings: " + getPlayerTotal() + "\n Player Horse: " + PlayerHorse;
        }
    }
}

