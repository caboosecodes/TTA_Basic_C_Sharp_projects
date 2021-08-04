using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class TwentyOneRules
    {
        // when something is only used inside its class then mark it private
        // naming convention is private classes is to use underscores infront of it
        private static Dictionary<Face, int> _cardValues = new Dictionary<Face, int>() 
        {
            [Face.Two] = 2,
            [Face.Three] = 3,
            [Face.Four] =  4,
            [Face.Five] = 5,
            [Face.Six] = 6,
            [Face.Seven] = 7,
            [Face.Eight] = 8,
            [Face.Nine] = 9,
            [Face.Ten] = 10,
            [Face.Jack] = 10,
            [Face.Queen] = 10,
            [Face.King] = 10,
            [Face.Ace] = 1
        };

        // Mehtods
        private static int[] GetAllPossibleHandValues(List<Card> Hand)
        {
            int aceCount = Hand.Count(x => x.Face == Face.Ace);
            // when you instantiate an array you have to declare how big it is
            // how big the array going to be is going to be determined by HOW MANY ACES ARE IN THE HAND PLUS ONE
            // plus one because if you have two aces in a hand their values could be (1,1) or (1,11) or (11,11)
            int[] result = new int[aceCount + 1];
            int value = Hand.Sum(x => _cardValues[x.Face]);
            
            // adding value to the array at index zero
            result[0] = value;
            
            // for short if statements you can wirte them on a single line
            // if the length of array is equal to 1, return the array (because there IS NO ACES IN THE HAND)
            if (result.Length == 1) return result;
            
            // IF THERE ARE ACES IN HAND:
            // the array result already has an element at index 0, the integer variable value; so i starts at 1
            // REMEMBER: result is an array whose length is determined by the number of Aces in hand

            for (int i = 1; i < result.Length; i++)
            {
                //if i is less than the length of the ARRAY result then
                // add i times 10 to value
                value += (i * 10);
                // places value at index i
                result[i] = value;
            }
            return result;
        }

        public static bool CheckForBlackJack(List<Card> Hand)
        {
            int[] possibleValues = GetAllPossibleHandValues(Hand);
            int value = possibleValues.Max();
            if (value == 21) return true;
            else return false;

        }

        public static bool IsBusted(List<Card> Hand)
        {
            int value = GetAllPossibleHandValues(Hand).Min();
            if (value > 21) return true;
            else return false;
        }

        public static bool ShouldDealerStay(List<Card> Hand)
        {
            int[] possibleHandValues = GetAllPossibleHandValues(Hand);
            foreach (int value in possibleHandValues)
            {
                if (value > 16 && value < 22)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool? CompareHands(List<Card> PlayerHand, List<Card> DealerHand)
        {
            int[] playerResults = GetAllPossibleHandValues(PlayerHand);
            int[] dealerResults = GetAllPossibleHandValues(DealerHand);

            // gotta find the highest value but that is less than 21
            int playerScore = playerResults.Where(x => x < 22).Max();
            int dealerScore = dealerResults.Where(x => x < 22).Max();

            if (playerScore > dealerScore) return true;
            else if (playerScore < dealerScore) return false;
            else return null;
        }
    }
}
