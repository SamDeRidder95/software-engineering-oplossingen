using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzee
{
    public partial class DiceUI : UserControl
    {
        private DiceController controller;

        private bool keepDice0 = false;
        private bool keepDice1 = false;
        private bool keepDice2 = false;
        private bool keepDice3 = false;
        private bool keepDice4 = false;

        private int turnToTrow = 3;
        private int turnCount = 0;

        private int[] firstP = new int[2];
        private int[] secP = new int[2];
        private int[] totP = new int [2];
        private int playerturn = 0;

        private bool[] aces = new bool[2];
        private bool[] twos = new bool[2];
        private bool[] threes = new bool[2];
        private bool[] fours = new bool[2];
        private bool[] fives = new bool[2];
        private bool[] sixes = new bool[2];
        private bool[] TOAK = new bool[2];
        private bool[] FOAK = new bool[2];
        private bool[] SS = new bool[2];
        private bool[] LS = new bool[2];
        private bool[] FH = new bool[2];
        private bool[] Chance = new bool[2];
        private bool[] Yathzee = new bool[2];
        private bool[] Bonus = new bool[2];

        bool canClick = true;

        public DiceUI( DiceController controller)
        {
            this.controller = controller;
            InitializeComponent();

            aces[0] = true;
            twos[0] = true;
            threes[0] = true;
            fours[0] = true;
            fives[0] = true;
            sixes[0] = true;
            TOAK[0] = true;
            FOAK[0] = true;
            SS[0] = true;
            LS[0] = true;
            FH[0] = true;
            Chance[0] = true;
            Yathzee[0] = true;
            Bonus[0] = true;
            aces[1] = true;
            twos[1] = true;
            threes[1] = true;
            fours[1] = true;
            fives[1] = true;
            sixes[1] = true;
            TOAK[1] = true;
            FOAK[1] = true;
            SS[1] = true;
            LS[1] = true;
            FH[1] = true;
            Chance[1] = true;
            Yathzee[1] = true;
            Bonus[1] = true;

            firstP[0] = 0;
            secP[0] = 0;
            totP[0] = 0;
            firstP[1] = 0;
            secP[1] = 0;
            totP[1] = 0;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (keepDice0 == true)
            {
                keepDice0 = false;

                this.button0.BackColor = System.Drawing.Color.White;
                this.teerlingValue0.BackColor = System.Drawing.Color.White;
            }
            else
            {
                keepDice0 = true;

                this.button0.BackColor = System.Drawing.Color.Gray;
                this.teerlingValue0.BackColor = System.Drawing.Color.Gray;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (keepDice1 == true)
            {
                keepDice1 = false;

                this.button1.BackColor = System.Drawing.Color.White;
                this.teerlingValue1.BackColor = System.Drawing.Color.White;
            }
            else
            {
                keepDice1 = true;

                this.button1.BackColor = System.Drawing.Color.Gray;
                this.teerlingValue1.BackColor = System.Drawing.Color.Gray;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (keepDice2 == true)
            {
                keepDice2 = false;

                this.button2.BackColor = System.Drawing.Color.White;
                this.teerlingValue2.BackColor = System.Drawing.Color.White;
            }
            else
            {
                keepDice2 = true;

                this.button2.BackColor = System.Drawing.Color.Gray;
                this.teerlingValue2.BackColor = System.Drawing.Color.Gray;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (keepDice3 == true)
            {
                keepDice3 = false;

                this.button3.BackColor = System.Drawing.Color.White;
                this.teerlingValue3.BackColor = System.Drawing.Color.White;
            }
            else
            {
                keepDice3 = true;

                this.button3.BackColor = System.Drawing.Color.Gray;
                this.teerlingValue3.BackColor = System.Drawing.Color.Gray;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (keepDice4 == true)
            {
                keepDice4 = false;

                this.button4.BackColor = System.Drawing.Color.White;
                this.teerlingValue4.BackColor = System.Drawing.Color.White;
            }
            else
            {
                keepDice4 = true;

                this.button4.BackColor = System.Drawing.Color.Gray;
                this.teerlingValue4.BackColor = System.Drawing.Color.Gray;
            }
        }

        private void buttonAll_Click(object sender, EventArgs e)
        {
            this.btnEnterScore.Visible = true;
            if (turnToTrow > 0)
            {
                int newValue = this.controller.throwDice();

                if (keepDice0 == false)
                {
                    this.teerlingValue0.Text = newValue.ToString();
                    newValue = this.controller.throwDice();
                    this.button0.Visible = true;
                }
                else
                {
                    this.button0.Visible = false;
                }
                if (keepDice1 == false)
                {
                    this.teerlingValue1.Text = newValue.ToString();
                    newValue = this.controller.throwDice();
                    this.button1.Visible = true;
                }
                else
                {
                    this.button1.Visible = false;
                }
                if (keepDice2 == false)
                {
                    this.teerlingValue2.Text = newValue.ToString();
                    newValue = this.controller.throwDice();
                    this.button2.Visible = true;
                }
                else
                {
                    this.button2.Visible = false;
                }
                if (keepDice3 == false)
                {
                    this.teerlingValue3.Text = newValue.ToString();
                    newValue = this.controller.throwDice();
                    this.button3.Visible = true;
                }
                else
                {
                    this.button3.Visible = false;
                }
                if (keepDice4 == false)
                {
                    this.teerlingValue4.Text = newValue.ToString();
                    newValue = this.controller.throwDice();
                    this.button4.Visible = true;
                }
                else
                {
                    this.button4.Visible = false;
                }
                this.buttonAll.Text = "werp alle overige teerlingen";
                if (turnToTrow < 2)
                {
                    button0.Visible = false;
                    button1.Visible = false;
                    button2.Visible = false;
                    button3.Visible = false;
                    button4.Visible = false;

                    this.teerlingValue0.BackColor = System.Drawing.Color.Gray;
                    this.teerlingValue1.BackColor = System.Drawing.Color.Gray;
                    this.teerlingValue2.BackColor = System.Drawing.Color.Gray;
                    this.teerlingValue3.BackColor = System.Drawing.Color.Gray;
                    this.teerlingValue4.BackColor = System.Drawing.Color.Gray;
                }
                turnToTrow--;
            }
        }

        private void DiceUI_Load(object sender, EventArgs e)
        {

        }

        private void btnEnterScore_Click(object sender, EventArgs e)
        {
            int sum;
            int[] myDice = new int[5];
            myDice[0] = Int32.Parse(this.teerlingValue0.Text);
            myDice[1] = Int32.Parse(this.teerlingValue1.Text);
            myDice[2] = Int32.Parse(this.teerlingValue2.Text);
            myDice[3] = Int32.Parse(this.teerlingValue3.Text);
            myDice[4] = Int32.Parse(this.teerlingValue4.Text);

            if (this.rbAces.Checked == true)
            {
                sum = this.controller.AddUpDice(1, myDice);

                if (playerturn == 0)
                {
                    if (aces[0] == true)
                    {
                        this.lblAces.Text = sum.ToString();
                        firstP[playerturn] += sum;
                        totP[playerturn] += sum;
                        this.lblTotalupper.Text = firstP[playerturn].ToString();
                        this.lblPlayer1.Text = totP[playerturn].ToString();
                        aces[0] = false;
                        canClick = true;
                        turnCount++;
                    }
                    else
                    {
                        canClick = false;
                    }
                }
                else
                {
                    if (aces[1] == true)
                    {
                        this.lblAces2.Text = sum.ToString();
                        firstP[playerturn] += sum;
                        totP[playerturn] += sum;
                        this.lblTotalupper2.Text = firstP[playerturn].ToString();
                        this.lblPlayer2.Text = totP[playerturn].ToString();
                        aces[1] = false;
                        canClick = true;
                        turnCount++;
                    }
                    else
                    {
                        canClick = false;
                    }
                }
            }
            if (this.rbTwos.Checked == true)
            {
                sum = this.controller.AddUpDice(2, myDice);

                if (playerturn == 0)
                {
                    if (twos[0] == true)
                    {
                        this.lblTwos.Text = sum.ToString();
                        firstP[playerturn] += sum;
                        totP[playerturn] += sum;
                        this.lblTotalupper.Text = firstP[playerturn].ToString();
                        this.lblPlayer1.Text = totP[playerturn].ToString();
                        twos[0] = false;
                        canClick = true;
                        turnCount++;
                    }
                    else
                    {
                        canClick = false;
                    }
                }
                else
                {
                    if (twos[1] == true)
                    {
                        this.lblTwos2.Text = sum.ToString();
                        firstP[playerturn] += sum;
                        totP[playerturn] += sum;
                        this.lblTotalupper2.Text = firstP[playerturn].ToString();
                        this.lblPlayer2.Text = totP[playerturn].ToString();
                        twos[1] = false;
                        canClick = true;
                        turnCount++;
                    }
                    else
                    {
                        canClick = false;
                    }
                }
            }
            if (this.rbThrees.Checked == true)
            {
                sum = this.controller.AddUpDice(3, myDice);

                if (playerturn == 0)
                {
                    if (threes[0] == true)
                    {
                        this.lblThrees.Text = sum.ToString();
                        firstP[playerturn] += sum;
                        totP[playerturn] += sum;
                        this.lblTotalupper.Text = firstP[playerturn].ToString();
                        this.lblPlayer1.Text = totP[playerturn].ToString();
                        threes[0] = false;
                        canClick = true;
                        turnCount++;
                    }
                    else
                    {
                        canClick = false;
                    }
                }
                else
                {
                    if (threes[1] == true)
                    {
                        this.lblThrees2.Text = sum.ToString();
                        firstP[playerturn] += sum;
                        totP[playerturn] += sum;
                        this.lblTotalupper2.Text = firstP[playerturn].ToString();
                        this.lblPlayer2.Text = totP[playerturn].ToString();
                        threes[1] = false;
                        canClick = true;
                        turnCount++;
                    }
                    else
                    {
                        canClick = false;
                    }
                }
            }
            if (this.rbFours.Checked == true)
            {
                sum = this.controller.AddUpDice(4, myDice);

                if (playerturn == 0)
                {
                    if (fours[0] == true)
                    {
                        this.lblFours.Text = sum.ToString();
                        firstP[playerturn] += sum;
                        totP[playerturn] += sum;
                        this.lblTotalupper.Text = firstP[playerturn].ToString();
                        this.lblPlayer1.Text = totP[playerturn].ToString();
                        fours[0] = false;
                        canClick = true;
                        turnCount++;
                    }
                    else
                    {
                        canClick = false;
                    }
                }
                else
                {
                    if (fours[1] == true)
                    {
                        this.lblFours2.Text = sum.ToString();
                        firstP[playerturn] += sum;
                        totP[playerturn] += sum;
                        this.lblTotalupper2.Text = firstP[playerturn].ToString();
                        this.lblPlayer2.Text = totP[playerturn].ToString();
                        fours[1] = false;
                        canClick = true;
                        turnCount++;
                    }
                    else
                    {
                        canClick = false;
                    }
                }
            }
            if (this.rbFives.Checked == true)
            {
                sum = this.controller.AddUpDice(5, myDice);
                
                if (playerturn == 0)
                {
                    if (fives[0] == true)
                    {
                        this.lblFives.Text = sum.ToString();
                        firstP[playerturn] += sum;
                        totP[playerturn] += sum;
                        this.lblTotalupper.Text = firstP[playerturn].ToString();
                        this.lblPlayer1.Text = totP[playerturn].ToString();
                        fives[0] = false;
                        canClick = true;
                        turnCount++;
                    }
                    else
                    {
                        canClick = false;
                    }
                }
                else
                {
                    if (fives[1] == true)
                    {
                        this.lblFives2.Text = sum.ToString();
                        firstP[playerturn] += sum;
                        totP[playerturn] += sum;
                        this.lblTotalupper2.Text = firstP[playerturn].ToString();
                        this.lblPlayer2.Text = totP[playerturn].ToString();
                        fives[1] = false;
                        canClick = true;
                        turnCount++;
                    }
                    else
                    {
                        canClick = false;
                    }
                }
            }
            if (this.rbSixes.Checked == true)
            {
                sum = this.controller.AddUpDice(6, myDice);

                if (playerturn == 0)
                {
                    if (sixes[0] == true)
                    {
                        this.lblSixes.Text = sum.ToString();
                        firstP[playerturn] += sum;
                        totP[playerturn] += sum;
                        this.lblTotalupper.Text = firstP[playerturn].ToString();
                        this.lblPlayer1.Text = totP[playerturn].ToString();
                        sixes[0] = false;
                        canClick = true;
                        turnCount++;
                    }
                    else
                    {
                        canClick = false;
                    }
                }
                else
                {
                    if (sixes[1] == true)
                    {
                        this.lblSixes2.Text = sum.ToString();
                        firstP[playerturn] += sum;
                        totP[playerturn] += sum;
                        this.lblTotalupper2.Text = firstP[playerturn].ToString();
                        this.lblPlayer2.Text = totP[playerturn].ToString();
                        sixes[1] = false;
                        canClick = true;
                        turnCount++;
                    }
                    else
                    {
                        canClick = false;
                    }
                }
            }
            if (this.rbTOAK.Checked == true)
            {
                sum = this.controller.ThreeOfAKind(myDice);
                
                if(playerturn == 0)
                {
                    if (TOAK[0] == true)
                    {
                        this.lblTOAK.Text = sum.ToString();
                        secP[playerturn] += sum;
                        totP[playerturn] += sum;
                        this.lblTotalSecond.Text = secP[playerturn].ToString();
                        this.lblPlayer1.Text = totP[playerturn].ToString();
                        TOAK[0] = false;
                        canClick = true;
                        turnCount++;
                    }
                    else
                    {
                        canClick = false;
                    }
                }
                 else
                 {
                    if (TOAK[1] == true)
                    {
                        this.lblTOAK2.Text = sum.ToString();
                        secP[playerturn] += sum;
                        totP[playerturn] += sum;
                        this.lblTotalSecond2.Text = secP[playerturn].ToString();
                        this.lblPlayer2.Text = totP[playerturn].ToString();
                        TOAK[1] = false;
                        canClick = true;
                        turnCount++;
                    }
                    else
                    {
                        canClick = false;
                    }
                }
                
            }
            if (this.rbFOAK.Checked == true)
            {
                sum = this.controller.FourOfAKind(myDice);

                if (playerturn == 0)
                {
                    if (FOAK[0] == true)
                    {
                        this.lblFOAK.Text = sum.ToString();
                        secP[playerturn] += sum;
                        totP[playerturn] += sum;
                        this.lblTotalSecond.Text = secP[playerturn].ToString();
                        this.lblPlayer1.Text = totP[playerturn].ToString();
                        FOAK[0] = false;
                        canClick = true;
                        turnCount++;
                    }
                    else
                    {
                        canClick = false;
                    }
                }
                else
                {
                    if (FOAK[1] == true)
                    {
                        this.lblFOAK2.Text = sum.ToString();
                        secP[playerturn] += sum;
                        totP[playerturn] += sum;
                        this.lblTotalSecond2.Text = secP[playerturn].ToString();
                        this.lblPlayer2.Text = totP[playerturn].ToString();
                        FOAK[1] = false;
                        canClick = true;
                        turnCount++;
                    }
                    else
                    {
                        canClick = false;
                    }
                }
            }
            if (this.rbFullHouse.Checked == true)
            {
                sum = this.controller.FullHouse(myDice);

                if (playerturn == 0)
                {
                    if (FH[0] == true)
                    {
                        this.lblFH.Text = sum.ToString();
                        secP[playerturn] += sum;
                        totP[playerturn] += sum;
                        this.lblTotalSecond.Text = secP[playerturn].ToString();
                        this.lblPlayer1.Text = totP[playerturn].ToString();
                        FH[0] = false;
                        canClick = true;
                        turnCount++;
                    }
                    else
                    {
                        canClick = false;
                    }
                }
                else
                {
                    if (FH[1] == true)
                    {
                        this.lblFH2.Text = sum.ToString();
                        secP[playerturn] += sum;
                        totP[playerturn] += sum;
                        this.lblTotalSecond2.Text = secP[playerturn].ToString();
                        this.lblPlayer2.Text = totP[playerturn].ToString();
                        FH[1] = false;
                        canClick = true;
                        turnCount++;
                    }
                    else
                    {
                        canClick = false;
                    }
                }
            }
            if (this.rbSmStraight.Checked == true)
            {
                sum = this.controller.SmallStraight(myDice);

                if (playerturn == 0)
                {
                    if (SS[0] == true)
                    {
                        this.lblSS.Text = sum.ToString();
                        secP[playerturn] += sum;
                        totP[playerturn] += sum;
                        this.lblTotalSecond.Text = secP[playerturn].ToString();
                        this.lblPlayer1.Text = totP[playerturn].ToString();
                        SS[0] = false;
                        canClick = true;
                        turnCount++;
                    }
                    else
                    {
                        canClick = false;
                    }
                }
                else
                {
                    if (SS[1] == true)
                    {
                        this.lblSS2.Text = sum.ToString();
                        secP[playerturn] += sum;
                        totP[playerturn] += sum;
                        this.lblTotalSecond2.Text = secP[playerturn].ToString();
                        this.lblPlayer2.Text = totP[playerturn].ToString();
                        SS[1] = false;
                        canClick = true;
                        turnCount++;
                    }
                    else
                    {
                        canClick = false;
                    }
                }
            }
            if (this.rbLgStraight.Checked == true)
            {
                sum = this.controller.LargeStraight(myDice);

                if (playerturn == 0)
                {
                    if (LS[0] == true)
                    {
                        this.lblLS.Text = sum.ToString();
                        secP[playerturn] += sum;
                        totP[playerturn] += sum;
                        this.lblTotalSecond.Text = secP[playerturn].ToString();
                        this.lblPlayer1.Text = totP[playerturn].ToString();
                        LS[0] = false;
                        canClick = true;
                        turnCount++;
                    }
                    else
                    {
                        canClick = false;
                    }
                }
            
                else
                {
                    if (LS[1] == true)
                    {
                        this.lblLS2.Text = sum.ToString();
                        secP[playerturn] += sum;
                        totP[playerturn] += sum;
                        this.lblTotalSecond2.Text = secP[playerturn].ToString();
                        this.lblPlayer2.Text = totP[playerturn].ToString();
                        LS[1] = false;
                        canClick = true;
                        turnCount++;
                    }
                    else
                    {
                        canClick = false;
                    }
                }
            }
            if (this.rdYahtzee.Checked == true)
            {
                sum = this.controller.Yahtzee(myDice);

                if (playerturn == 0)
                {
                    if (Yathzee[0] == true)
                    {
                        this.lblYahtzee.Text = sum.ToString();
                        secP[playerturn] += sum;
                        totP[playerturn] += sum;
                        this.lblTotalSecond.Text = secP[playerturn].ToString();
                        this.lblPlayer1.Text = totP[playerturn].ToString();
                        Yathzee[0] = false;
                        canClick = true;
                        turnCount++;
                    }
                    else
                    {
                        canClick = false;
                    }
                }
                else
                {
                    if (Yathzee[1] == true)
                    {
                        this.lblYahtzee2.Text = sum.ToString();
                        secP[playerturn] += sum;
                        totP[playerturn] += sum;
                        this.lblTotalSecond2.Text = secP[playerturn].ToString();
                        this.lblPlayer2.Text = totP[playerturn].ToString();
                        Yathzee[1] = false;
                        canClick = true;
                        turnCount++;
                    }
                    else
                    {
                        canClick = false;
                    }
                }
            }
            if (this.rbChance.Checked == true)
            {

                sum = this.controller.AddUpChance(myDice);

                if (playerturn == 0)
                {
                    if (Chance[0] == true)
                    {
                        this.lblChance.Text = sum.ToString();
                        secP[playerturn] += sum;
                        totP[playerturn] += sum;
                        this.lblTotalSecond.Text = secP[playerturn].ToString();
                        this.lblPlayer1.Text = totP[playerturn].ToString();
                        Chance[0] = false;
                        canClick = true;
                        turnCount++;
                    }
                    else
                    {
                        canClick = false;
                    }
                }
                else
                {
                    if (Chance[1] == true)
                    {
                        this.lblChance2.Text = sum.ToString();
                        secP[playerturn] += sum;
                        totP[playerturn] += sum;
                        this.lblTotalSecond2.Text = secP[playerturn].ToString();
                        this.lblPlayer2.Text = totP[playerturn].ToString();
                        Chance[1] = false;
                        canClick = true;
                        turnCount++;

                    }
                    else
                    {
                        canClick = false;
                    }
                }
            }

            if(firstP[playerturn] >= 63 && Bonus[playerturn])
            {
                Bonus[playerturn] = false;
                if(playerturn == 0)
                {
                    this.lblBonus.Text = "35";
                    firstP[0] += 35;
                    totP[0] += 35;
                    this.lblTotalupper.Text = firstP[playerturn].ToString();
                    this.lblPlayer1.Text = totP[playerturn].ToString();
                }
                else
                {
                    this.lblBonus2.Text = "35";
                    firstP[1] += 35;
                    totP[1] += 35;
                    this.lblTotalupper2.Text = firstP[playerturn].ToString();
                    this.lblPlayer2.Text = totP[playerturn].ToString();
                }
            }

            if (canClick)
            {
                returnDefault();
                turnToTrow = 3;
                if (playerturn == 0)
                {
                    playerturn = 1;
                    this.lblPlayer.Text = "2";
                }
                else
                {
                    playerturn = 0;
                    this.lblPlayer.Text = "1";
                }
            }
            EndGame();
        }

        void returnDefault()
        {
            keepDice0 = false;
            keepDice1 = false;
            keepDice2 = false;
            keepDice3 = false;
            keepDice4 = false;
            this.button0.Visible = false;
            this.button1.Visible = false;
            this.button2.Visible = false;
            this.button3.Visible = false;
            this.button4.Visible = false;
            this.btnEnterScore.Visible = false;
            this.teerlingValue0.BackColor = Color.White;
            this.teerlingValue1.BackColor = Color.White;
            this.teerlingValue2.BackColor = Color.White;
            this.teerlingValue3.BackColor = Color.White;
            this.teerlingValue4.BackColor = Color.White;
            this.button0.BackColor = Color.White;
            this.button1.BackColor = Color.White;
            this.button2.BackColor = Color.White;
            this.button3.BackColor = Color.White;
            this.button4.BackColor = Color.White;
        }

        void EndGame()
        {
            if(turnCount == 26)
            {
                if (totP[0] > totP[1])
                {
                    this.endGame.Text = "Congrats Player 1";
                    this.restart.Visible = true;
                }
                if (totP[1] < totP[0])
                {
                    this.endGame.Text = "Congrats Player 2";
                    this.restart.Visible = true;
                }
                if (totP[0] == totP[1])
                {
                    this.endGame.Text = "Congrats to both players";
                    this.restart.Visible = true;
                }
            }
        }

        private void restart_Click(object sender, EventArgs e)
        {

            aces[0] = true;
            twos[0] = true;
            threes[0] = true;
            fours[0] = true;
            fives[0] = true;
            sixes[0] = true;
            TOAK[0] = true;
            FOAK[0] = true;
            SS[0] = true;
            LS[0] = true;
            FH[0] = true;
            Chance[0] = true;
            Yathzee[0] = true;
            Bonus[0] = true;
            aces[1] = true;
            twos[1] = true;
            threes[1] = true;
            fours[1] = true;
            fives[1] = true;
            sixes[1] = true;
            TOAK[1] = true;
            FOAK[1] = true;
            SS[1] = true;
            LS[1] = true;
            FH[1] = true;
            Chance[1] = true;
            Yathzee[1] = true;
            Bonus[1] = true;

            this.teerlingValue0.Text = "";
            this.teerlingValue1.Text = "";
            this.teerlingValue2.Text = "";
            this.teerlingValue3.Text = "";
            this.teerlingValue4.Text = "";
            this.lblAces.Text = "";
            this.lblTwos.Text = "";
            this.lblThrees.Text = "";
            this.lblFours.Text = "";
            this.lblFives.Text = "";
            this.lblSixes.Text = "";
            this.lblTOAK.Text = "";
            this.lblFOAK.Text = "";
            this.lblFH.Text = "";
            this.lblSS.Text = "";
            this.lblLS.Text = "";
            this.lblYahtzee.Text = "";
            this.lblChance.Text = "";
            this.lblTotalupper.Text = "";
            this.lblTotalSecond.Text = "";
            this.lblPlayer1.Text = "";
            this.lblAces2.Text = "";
            this.lblTwos2.Text = "";
            this.lblThrees2.Text = "";
            this.lblFours2.Text = "";
            this.lblFives2.Text = "";
            this.lblSixes2.Text = "";
            this.lblTOAK2.Text = "";
            this.lblFOAK2.Text = "";
            this.lblFH2.Text = "";
            this.lblSS2.Text = "";
            this.lblLS2.Text = "";
            this.lblYahtzee2.Text = "";
            this.lblChance2.Text = "";
            this.lblTotalupper2.Text = "";
            this.lblTotalSecond2.Text = "";
            this.lblPlayer2.Text = "";
            this.restart.Visible = false;
            this.endGame.Visible = false;
            this.button0.Visible = false;
            this.button1.Visible = false;
            this.button2.Visible = false;
            this.button3.Visible = false;
            this.button4.Visible = false;
            this.btnEnterScore.Visible = false;


            firstP[0] = 0;
            secP[0] = 0;
            totP[0] = 0;
            firstP[1] = 0;
            secP[1] = 0;
            totP[1] = 0;
        }

        private void help_Click(object sender, EventArgs e)
        {
            if(this.helptext.Visible)
            {
                this.helptext.Visible = false;
            }
            else
            {
                this.helptext.Visible = true;
            }
        }
    }
}
