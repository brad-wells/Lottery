// Brad Wells
// CIS 129.7785
// 10/2/18
//This program is a lottery game that accepts 3 numbers as input and matches them against 3 rand generated numbers

//****************************************************************************************************************


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asg4
{
    public partial class Asg4 : Form
    {
        public Asg4()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void TitleLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void PlayButton_Click(object sender, EventArgs e)
        {
            //convert players guesses to int
            int first = Convert.ToInt32(GuessOneTextBox.Text);
            int second = Convert.ToInt32(GuessTwoTextBox.Text);
            int third = Convert.ToInt32(GuessThreeTextBox.Text);

            // generate 3 winning numbers
            Random generateFirst = new Random();
            int firstWinTextBox = generateFirst.Next(1, 4); //Convert.ToInt32(3);   use these to test for jackpot
            WinningOneTextBox.Text = Convert.ToString(firstWinTextBox);

            // Random generateSecond = new Random();
            int secondWinTextBox = generateFirst.Next(1, 4); //Convert.ToInt32(2);
            WinningTwoTextBox.Text = Convert.ToString(secondWinTextBox);

            //Random generateThird = new Random();
            int thirdWinTextBox = generateFirst.Next(1, 4); //Convert.ToInt32(4);
            WinningThreeTextBox.Text =  Convert.ToString(thirdWinTextBox);

            int ctr=0; // this will count how many boxes match
            string phrase = ""; //this will keep track of box order for jackpot

           // ******************************************************************************************************

            //This method matches the first guessed number with the 3 generated numbers
            Boolean checkFirstWinner(int firstGuess, int lottoDraw, int lottoDrawTwo, int lottoDrawThree)
            {
                
                /// if (firstGuess.Equals(lottoDraw) || secondGuess.Equals(lottoDraw) || thirdGuess.Equals(lottoDraw))
                /// {
                ///     ctr += 1;
                // phrase = "W";
                ///     return true;
                /// }
                /// else
                ///     return false;

                  bool foundMatch = false;
                ///  do
                ///   {
                // exit matches if found one already

                ///   } while (!foundMatch);

                ///   int matchCounter = 0;
                ///   do
                ///   {
                ///       matchCounter++;

                ///    } while (matchCounter < 2);
              //  do
              //  {
                    if (firstGuess.Equals(lottoDraw))
                    {
                        //ctr += 1;
                       // return true;
                        foundMatch = true;
                       // break;
                    }
                   if  (firstGuess.Equals(lottoDrawTwo))
                    {
                        //ctr += 1;
                       // return true;
                        foundMatch = true;
                     //   break;
                    }
                   if (firstGuess.Equals(lottoDrawThree))
                    {
                       // ctr += 1;
                        //return true;
                        foundMatch = true;
                      //  break;
                    }

                    if (foundMatch == true)
                {
                    ctr += 1;
                }

             //   } while (!foundMatch);
                return false;
            }

            //This method matches the second guessed number with the 3 generated numbers
            Boolean checkSecondWinner(int secondGuess, int lottoDraw, int lottoDrawTwo, int lottoDrawThree)
            {
                //if (secondGuess.Equals(lottoDraw) || thirdGuess.Equals(lottoDraw) || firstGuess.Equals(lottoDraw))
                //{
                //    ctr += 1;
                //    //phrase += "I";
                //    return true;
                //}
                //else
                //    return false;
                bool foundMatchTwo = false;

               // do
               // {
                    if (secondGuess.Equals(lottoDraw))
                    {
                       // ctr += 1;
                        //return true;
                        foundMatchTwo = true;
                        //break;
                    }
                    if (secondGuess.Equals(lottoDrawTwo))
                    {
                        //ctr += 1;
                        //return true;
                        foundMatchTwo = true;
                       // break;
                    }
                    if (secondGuess.Equals(lottoDrawThree))
                    {
                       // ctr += 1;
                       // return true;
                        foundMatchTwo = true;
                       // break;
                    }
                if (foundMatchTwo)
                {
                    ctr += 1;
                }

                // } while (!foundMatch);
                return false;
            }
        

            //This method matches the third guessed number with the 3 generated numbers
            Boolean checkThirdWinner(int thirdGuess, int lottoDraw, int lottoDrawTwo, int lottoDrawThree)
            {
                //if(thirdGuess.Equals(lottoDraw) || firstGuess.Equals(lottoDraw) || secondGuess.Equals(lottoDraw))
                //{
                //    ctr += 1;
                //   // phrase += "N";
                //    return true;
                //}
                //else
                //    return false;
                bool foundMatchThird = false;
         //   do
         //   {
                if (thirdGuess.Equals(lottoDraw))
                {
                   // ctr += 1;
                   // return true;
                    foundMatchThird = true;
                   // break;
                }
                if (thirdGuess.Equals(lottoDrawTwo))
                {
                   // ctr += 1;
                    //return true;
                    foundMatchThird = true;
                   // break;
                }
                if (thirdGuess.Equals(lottoDrawThree))
                {
                   // ctr += 1;
                    //return true;
                        foundMatchThird = true;
                  //  break;
                    
                }
                if (foundMatchThird)
                {
                    ctr += 1;
                }

                //   } while (!foundMatch);
                return false;


        }

            //********************************************************************************************************

            //This method matches the first guessed number with the first generated number to check for jackpot order
            Boolean checkJackPotOne(int firstGuess, int lottoDrawOne)
            {
                {
                    if (firstGuess.Equals(lottoDrawOne))// && (!secondGuess.Equals(lottoDrawOne)) && (!thirdGuess.Equals(lottoDrawOne)))
                    {
                        phrase += "W";
                    }
                    //if (secondGuess.Equals(lottoDrawTwo) && (!thirdGuess.Equals(lottoDrawTwo)) && (!firstGuess.Equals(lottoDrawTwo)))
                    //{
                    //    phrase += "I";
                    //}
                    //if (thirdGuess.Equals(lottoDrawTwo) && (!firstGuess.Equals(lottoDrawTwo)) && (!secondGuess.Equals(lottoDrawTwo)))
                    //{
                    //    phrase += "N";
                    //}
                    return true;
                }
            }

            //This method matches the second guessed number with the second generated number to check for jackpot order
            Boolean checkJackPotTwo(int secondGuess, int lottoDrawTwo)
            {
                {
                    if (secondGuess.Equals(lottoDrawTwo))
                    {
                        phrase += "I";
                    }
                    return true;
                }
            }

            //This method matches the third guessed number with the third generated number to check for jackpot order
            Boolean checkJackPotThree(int thirdGuess, int lottowDrawThree)
            {
                {
                    if (thirdGuess.Equals(lottowDrawThree))
                    {
                        phrase += "N";
                    }
                    return true;
                }
            }

            //*************************************************************************************************************

            // run methods, 
            checkFirstWinner(first, firstWinTextBox, secondWinTextBox, thirdWinTextBox);
            //if the same value is entered in both, do not run the check to ensure correct payout
            if (second != first)
            {
                checkSecondWinner(second, firstWinTextBox, secondWinTextBox, thirdWinTextBox);
            }
            if (third != second)
            {
                checkThirdWinner(third, firstWinTextBox, secondWinTextBox, thirdWinTextBox);
            }
            checkJackPotOne(first, firstWinTextBox);
            checkJackPotTwo(second, secondWinTextBox);
            checkJackPotThree(third, thirdWinTextBox);

            // based on ctr value, display winning amount
            switch (ctr)
            {
                case 1:
                    DollarLabel.Text = Convert.ToString(10);
                    break;
                case 2:
                    DollarLabel.Text = Convert.ToString(100);
                    break;
                case 3:
                    DollarLabel.Text = Convert.ToString(1000);
                    break;
                default:
                    DollarLabel.Text = Convert.ToString(0);
                    break;

            } // end switch(ctr)


            // if the whole prase "WIN" is spelled out, display jackpot label and change winning amount
            switch (phrase)
            {
                case "WIN":
                    JackPotLabel.Text = "You hit JackPot! ";
                    //int winAmount = 10000;
                    DollarLabel.Text = Convert.ToString(10000);//Console.WriteLine("{0:C}", winAmount);//Convert.ToString("{0:C}", winAmount);
                    break;
                default:
                    JackPotLabel.Text = " ";
                    break;
              
            }
            matchLabel.Text = Convert.ToString(ctr);

            //questions to ask in class
            // easy way to center items on the form?
            // how to display in currency for labels/textboxes?
            // what to use instead of Boolean for methods?







        }
    } // end class Asg4:Form1

}


