using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
    public class DiceController
    {
        protected DiceUI diceUI;
        protected DiceModel diceModel;
        protected Random randomGenerator;
        protected int randomNumber;

        public DiceController()
        {
            // Create dice model
            this.diceModel = new DiceModel();

            // Create dice UI and inject controller (= this)
            // Injection is necessary in order for the UI to notify something has happened
            this.diceUI = new DiceUI( this );

            // Create new random generator using seed (for absolute random generation)
            this.randomGenerator = new Random(Guid.NewGuid().GetHashCode());
        }

        // Method that returns instance of the view
        public DiceUI view
        {
            get {
                return this.diceUI;
            }
        }

        // Method that throws dice by generating new random number
        public int throwDice()
        {
            // Generate new random number
            randomNumber = this.randomGenerator.Next(1, 7);

            // Update the model
            this.diceModel.value = randomNumber;

            // Return the value
            return randomNumber;
        }

        public int AddUpDice(int DieNumber, int[] myDice)
        {
            int Sum = 0;

            for (int i = 0; i < 5; i++)
            {
                if (myDice[i] == DieNumber)
                {
                    Sum += DieNumber;
                }
            }

            return Sum;
        }

        public int ThreeOfAKind(int[] myDice)
        {
            int Sum = 0;

            bool ThreeOfAKind = false;

            for (int i = 1; i <= 6; i++)
            {
                int Count = 0;
                for (int j = 0; j < 5; j++)
                {
                    if (myDice[j] == i)
                    {
                        Count++;
                    }

                    if (Count > 2)
                    {
                        ThreeOfAKind = true;
                    }
                }
            }

            if (ThreeOfAKind)
            {
                for (int k = 0; k < 5; k++)
                {
                    Sum += myDice[k];
                }
            }

            return Sum;
        }

        public int FourOfAKind(int[] myDice)
        {
            int Sum = 0;

            bool FourOfAKind = false;

            for (int i = 1; i <= 6; i++)
            {
                int Count = 0;
                for (int j = 0; j < 5; j++)
                {
                    if (myDice[j] == i)
                    {
                        Count++;
                    }

                    if (Count > 3)
                    {
                        FourOfAKind = true;
                    }
                }
            }

            if (FourOfAKind)
            {
                for (int k = 0; k < 5; k++)
                {
                    Sum += myDice[k];
                }
            }

            return Sum;
        }

        public int FullHouse(int[] myDice)
        {
            int Sum = 0;

            int[] i = new int[5];

            i[0] = myDice[0];
            i[1] = myDice[1];
            i[2] = myDice[2];
            i[3] = myDice[3];
            i[4] = myDice[4];

            Array.Sort(i);

            if ((((i[0] == i[1]) && (i[1] == i[2])) && // Three of a Kind
                 (i[3] == i[4]) && // Two of a Kind
                 (i[2] != i[3])) ||
                ((i[0] == i[1]) && // Two of a Kind
                 ((i[2] == i[3]) && (i[3] == i[4])) && // Three of a Kind
                 (i[1] != i[2])))
            {
                Sum = 25;
            }

            return Sum;
        }

        public int LargeStraight(int[] myDice)
        {
            int Sum = 0;

            int[] i = new int[5];

            i[0] = myDice[0];
            i[1] = myDice[1];
            i[2] = myDice[2];
            i[3] = myDice[3];
            i[4] = myDice[4];

            Array.Sort(i);

            if (((i[0] == 1) &&
                 (i[1] == 2) &&
                 (i[2] == 3) &&
                 (i[3] == 4) &&
                 (i[4] == 5)) ||
                ((i[0] == 2) &&
                 (i[1] == 3) &&
                 (i[2] == 4) &&
                 (i[3] == 5) &&
                 (i[4] == 6)))
            {
                Sum = 40;
            }

            return Sum;
        }

        public int SmallStraight(int[] myDice)
        {
            int Sum = 0;

            int[] i = new int[5];

            i[0] = myDice[0];
            i[1] = myDice[1];
            i[2] = myDice[2];
            i[3] = myDice[3];
            i[4] = myDice[4];

            Array.Sort(i);

            for (int j = 0; j < 4; j++)
            {
                int temp = 0;
                if (i[j] == i[j + 1])
                {
                    temp = i[j];

                    for (int k = j; k < 4; k++)
                    {
                        i[k] = i[k + 1];
                    }

                    i[4] = temp;
                }
            }

            if (((i[0] == 1) && (i[1] == 2) && (i[2] == 3) && (i[3] == 4)) ||
                ((i[0] == 2) && (i[1] == 3) && (i[2] == 4) && (i[3] == 5)) ||
                ((i[0] == 3) && (i[1] == 4) && (i[2] == 5) && (i[3] == 6)) ||
                ((i[1] == 1) && (i[2] == 2) && (i[3] == 3) && (i[4] == 4)) ||
                ((i[1] == 2) && (i[2] == 3) && (i[3] == 4) && (i[4] == 5)) ||
                ((i[1] == 3) && (i[2] == 4) && (i[3] == 5) && (i[4] == 6)))
            {
                Sum = 30;
            }

            return Sum;
        }

        public int Yahtzee(int[] myDice)
        {
            int Sum = 0;

            for (int i = 1; i <= 6; i++)
            {
                int Count = 0;
                for (int j = 0; j < 5; j++)
                {
                    if (myDice[j] == i)
                        Count++;

                    if (Count > 4)
                        Sum = 50;
                }
            }

            return Sum;
        }

        public int AddUpChance(int[] myDice)
        {
            int Sum = 0;

            for (int i = 0; i < 5; i++)
            {
                Sum += myDice[i];
            }

            return Sum;
        }
    }
}
