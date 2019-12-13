using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teamMixer
{
    public partial class Form1 : Form
    {
        int MouPosX = 0, MouPosY = 0;
        bool mouseDown = false;
        bool capEntered = false; // Verficar se o botão 1 foi premido
        int timesRemixed = 0;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            MouPosX = e.X;
            MouPosY = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.SetDesktopLocation(MousePosition.X - MouPosX, MousePosition.Y - MouPosY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void labelExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void labelMINIMIZE_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void labelMINIMIZE_MouseHover(object sender, EventArgs e)
        {
            labelMINIMIZE.ForeColor = Color.FromArgb(168, 170, 173);
        }

        private void labelMINIMIZE_MouseLeave(object sender, EventArgs e)
        {
            labelMINIMIZE.ForeColor = Color.FromArgb(255, 255, 255); 
        }

        private void labelExit_MouseHover(object sender, EventArgs e)
        {
            labelExit.ForeColor = Color.FromArgb(168, 170, 173);
        }

        private void labelExit_MouseLeave(object sender, EventArgs e)
        {
            labelExit.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Captain A")
            {
                textBox1.Text = "";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            {
                if (textBox1.Text == "")
                {
                    textBox1.Text = "Captain A";
                }
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Captain B")
            {
                textBox2.Text = "";
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Captain B";
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "Player 1")
            {
                textBox3.Text = "";
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "Player 1";
            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "Player 2")
            {
                textBox4.Text = "";
            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "Player 2";
            }
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            if (textBox5.Text == "Player 3")
            {
                textBox5.Text = "";
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
            {
                textBox5.Text = "Player 3";
            }
        }

        private void textBox6_Enter(object sender, EventArgs e)
        {
            if (textBox6.Text == "Player 4")
            {
                textBox6.Text = "";
            }
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            if (textBox6.Text == "")
            {
                textBox6.Text = "Player 4";
            }
        }

        private void textBox7_Enter(object sender, EventArgs e)
        {
            if (textBox7.Text == "Player 5")
            {
                textBox7.Text = "";
            }
        }

        private void textBox7_Leave(object sender, EventArgs e)
        {
            if (textBox7.Text == "")
            {
                textBox7.Text = "Player 5";
            }
        }

        private void textBox8_Enter(object sender, EventArgs e)
        {
            if (textBox8.Text == "Player 6")
            {
                textBox8.Text = "";
            }
        }

        private void textBox8_Leave(object sender, EventArgs e)
        {
            if (textBox8.Text == "")
            {
                textBox8.Text = "Player 6";
            }
        }

        private void textBox9_Enter(object sender, EventArgs e)
        {
            if (textBox9.Text == "Player 7")
            {
                textBox9.Text = "";
            }
        }

        private void textBox9_Leave(object sender, EventArgs e)
        {
            if (textBox9.Text == "")
            {
                textBox9.Text = "Player 7";
            }
        }

        private void textBox10_Enter(object sender, EventArgs e)
        {
            if (textBox10.Text == "Player 8")
            {
                textBox10.Text = "";
            }
        }

        private void textBox10_Leave(object sender, EventArgs e)
        {
            if (textBox10.Text == "")
            {
                textBox10.Text = "Player 8";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            label23.Text = "No warnings!";

            if (textBox1.Text == "")
            {
                label23.Text = "Enter a valid captain for team A!";
                textBox1.Text = "";
                textBox1.Focus();
            }
            else if (textBox2.Text == "")
            {
                label23.Text = "Enter a valid captain for team B!";
                textBox2.Text = "";
                textBox2.Focus();
            }
            else if (textBox1.Text == "Captain A")
            {
                label23.Text = "Enter a valid captain for team A!";
                textBox1.Text = "";
                textBox1.Focus();
            }
            else if (textBox2.Text == "Captain B")
            {
                label23.Text = "Enter a valid captain for team B!";
                textBox2.Text = "";
                textBox2.Focus();
            }
            else
            {
                string captainA = textBox1.Text;
                string captainB = textBox2.Text;

                if ((captainA.ToLowerInvariant() == captainB.ToLowerInvariant()) || (captainB.ToLowerInvariant() == captainA.ToLowerInvariant()))
                {
                    label23.Text = "You can't have the same captain\non both teams!";
                    textBox2.Text = "";
                    textBox2.Focus();
                }
                else
                {
                    capEntered = true;
                    label6.Text = "" + captainA + " (Captain)";
                    label14.Text = "" + captainB + " (Captain)";
                    button1.Enabled = false;
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox3.Focus();
                    textBox1.ForeColor = Color.Gray;
                    textBox2.ForeColor = Color.Gray;
                    textBox1.LineFocusedColor = Color.Gray;
                    textBox1.LineIdleColor = Color.Gray;
                    textBox1.LineMouseHoverColor = Color.Gray;
                    textBox2.LineFocusedColor = Color.Gray;
                    textBox2.LineIdleColor = Color.Gray;
                    textBox2.LineMouseHoverColor = Color.Gray;
                    label18.ForeColor = Color.White;
                    label18.Text = "Captains successfully inserted ✓";
                }
        }
}
        private void button2_Click(object sender, EventArgs e)
        {
            label23.Text = "No warnings!";

            if ((capEntered == false) || (label6.Text == "Team A Captain") || (label14.Text == "Team B Captain"))
            {
                label23.Text = "Make sure you have sucessfully\ninserted the team captains!";
                button1.Focus();
            }
            else if ((textBox3.Text == "Player 1") || (textBox3.Text == ""))
            {
                label23.Text = "Make sure you have entered a\nvalid nickname for player 1!";
                textBox3.Text = "";
                textBox3.Focus();
            }
            else if ((textBox4.Text == "Player 2") || (textBox4.Text == ""))
            {
                label23.Text = "Make sure you have entered a\nvalid nickname for player 2!";
                textBox4.Text = "";
                textBox4.Focus();
            }
            else if ((textBox5.Text == "Player 3") || (textBox5.Text == ""))
            {
                label23.Text = "Make sure you have entered a\nvalid nickname for player 3!";
                textBox5.Text = "";
                textBox5.Focus();
            }
            else if ((textBox6.Text == "Player 4") || (textBox6.Text == ""))
            {
                label23.Text = "Make sure you have entered a\nvalid nickname for player 4!";
                textBox6.Text = "";
                textBox6.Focus();
            }
            else if ((textBox7.Text == "Player 5") || (textBox7.Text == ""))
            {
                label23.Text = "Make sure you have entered a\nvalid nickname for player 5!";
                textBox7.Text = "";
                textBox7.Focus();
            }
            else if ((textBox8.Text == "Player 6") || (textBox8.Text == ""))
            {
                label23.Text = "Make sure you have entered a\nvalid nickname for player 6!";
                textBox8.Text = "";
                textBox8.Focus();
            }
            else if ((textBox9.Text == "Player 7") || (textBox9.Text == ""))
            {
                label23.Text = "Make sure you have entered a\nvalid nickname for player 7!";
                textBox9.Text = "";
                textBox9.Focus();
            }
            else if ((textBox10.Text == "Player 8") || (textBox10.Text == ""))
            {
                label23.Text = "Make sure you have entered a\nvalid nickname for player 8!";
                textBox10.Text = "";
                textBox10.Focus();
            }
            else
            {
                string captainA = textBox1.Text;

                string captainB = textBox2.Text;

                string player1 = textBox3.Text;

                string player2 = textBox4.Text;

                string player3 = textBox5.Text;

                string player4 = textBox6.Text;

                string player5 = textBox7.Text;

                string player6 = textBox8.Text;

                string player7 = textBox9.Text;

                string player8 = textBox10.Text;

                if ((player1.ToLowerInvariant() == captainA.ToLowerInvariant()) || (player1.ToLowerInvariant() == captainB.ToLowerInvariant()))
                {
                    label23.Text = "" + player1 + " is already the captain!";
                    textBox3.Text = "";
                    textBox3.Focus();
                }
                else if ((player2.ToLowerInvariant() == captainA.ToLowerInvariant()) || (player2.ToLowerInvariant() == captainB.ToLowerInvariant()))
                {
                    label23.Text = "" + player2 + " is already the captain!";
                    textBox4.Text = "";
                    textBox4.Focus();
                }
                else if ((player3.ToLowerInvariant() == captainA.ToLowerInvariant()) || (player3.ToLowerInvariant() == captainB.ToLowerInvariant()))
                {
                    label23.Text = "" + player3 + " is already the captain!";
                    textBox5.Text = "";
                    textBox5.Focus();
                }
                else if ((player4.ToLowerInvariant() == captainA.ToLowerInvariant()) || (player4.ToLowerInvariant() == captainB.ToLowerInvariant()))
                {
                    label23.Text = "" + player4 + " is already the captain!";
                    textBox6.Text = "";
                    textBox6.Focus();
                }
                else if ((player5.ToLowerInvariant() == captainA.ToLowerInvariant()) || (player5.ToLowerInvariant() == captainB.ToLowerInvariant()))
                {
                    label23.Text = "" + player5 + " is already the captain!";
                    textBox7.Text = "";
                    textBox7.Focus();
                }
                else if ((player6.ToLowerInvariant() == captainA.ToLowerInvariant()) || (player6.ToLowerInvariant() == captainB.ToLowerInvariant()))
                {
                    label23.Text = "" + player6 + " is already the captain!";
                    textBox8.Text = "";
                    textBox8.Focus();
                }
                else if ((player7.ToLowerInvariant() == captainA.ToLowerInvariant()) || (player7.ToLowerInvariant() == captainB.ToLowerInvariant()))
                {
                    label23.Text = "" + player7 + " is already the captain!";
                    textBox9.Text = "";
                    textBox9.Focus();
                }
                else if ((player8.ToLowerInvariant() == captainA.ToLowerInvariant()) || (player8.ToLowerInvariant() == captainB.ToLowerInvariant()))
                {
                    label23.Text = "" + player8 + " is already the captain!";
                    textBox10.Text = "";
                    textBox10.Focus();
                }
                else if (player2.ToLowerInvariant() == player1.ToLowerInvariant())
                {
                    label23.Text = "You can't have the same player\nmultiple times!";
                    textBox4.Text = "";
                    textBox4.Focus();
                }
                else if ((player3.ToLowerInvariant() == player2.ToLowerInvariant()) || (player3.ToLowerInvariant() == player1.ToLowerInvariant()))
                {
                    label23.Text = "You can't have the same player\nmultiple times!";
                    textBox5.Text = "";
                    textBox5.Focus();
                }
                else if ((player4.ToLowerInvariant() == player3.ToLowerInvariant()) || (player4.ToLowerInvariant() == player2.ToLowerInvariant()) || (player4.ToLowerInvariant() == player1.ToLowerInvariant()))
                {
                    label23.Text = "You can't have the same player\nmultiple times!";
                    textBox6.Text = "";
                    textBox6.Focus();
                }
                else if ((player5.ToLowerInvariant() == player4.ToLowerInvariant()) || (player5.ToLowerInvariant() == player3.ToLowerInvariant()) || (player5.ToLowerInvariant() == player2.ToLowerInvariant()) || (player5.ToLowerInvariant() == player1.ToLowerInvariant()))
                {
                    label23.Text = "You can't have the same player\nmultiple times!";
                    textBox7.Text = "";
                    textBox7.Focus();
                }
                else if ((player6.ToLowerInvariant() == player5.ToLowerInvariant()) || (player6.ToLowerInvariant() == player4.ToLowerInvariant()) || (player6.ToLowerInvariant() == player3.ToLowerInvariant()) || (player6.ToLowerInvariant() == player2.ToLowerInvariant()) || (player6.ToLowerInvariant() == player1.ToLowerInvariant()))
                {
                    label23.Text = "You can't have the same player\nmultiple times!";
                    textBox8.Text = "";
                    textBox8.Focus();
                }
                else if ((player7.ToLowerInvariant() == player6.ToLowerInvariant()) || (player7.ToLowerInvariant() == player5.ToLowerInvariant()) || (player7.ToLowerInvariant() == player4.ToLowerInvariant()) || (player7.ToLowerInvariant() == player3.ToLowerInvariant()) || (player7.ToLowerInvariant() == player2.ToLowerInvariant()) || (player7.ToLowerInvariant() == player1.ToLowerInvariant()))
                {
                    label23.Text = "You can't have the same player\nmultiple times!";
                    textBox9.Text = "";
                    textBox9.Focus();
                }
                else if ((player8.ToLowerInvariant() == player7.ToLowerInvariant()) || (player8.ToLowerInvariant() == player6.ToLowerInvariant()) || (player8.ToLowerInvariant() == player5.ToLowerInvariant()) || (player8.ToLowerInvariant() == player4.ToLowerInvariant()) || (player8.ToLowerInvariant() == player3.ToLowerInvariant()) || (player8.ToLowerInvariant() == player2.ToLowerInvariant()) || (player8.ToLowerInvariant() == player1.ToLowerInvariant()))
                {
                    label23.Text = "You can't have the same player\nmultiple times!";
                    textBox10.Text = "";
                    textBox10.Focus();
                }
                else
                {
                    button3.Enabled = true;
                    button4.Focus();
                    timesRemixed++;
                    label19.ForeColor = Color.White;
                    label19.Text = "Number of times mixed: " + timesRemixed;
                    label20.ForeColor = Color.White;
                    label20.Text = "Players successfully mixed ✓";

                    Random randomize = new Random();

                    int random1, random2, random3, random4, random5, random6, random7, random8;

                    random1 = randomize.Next(3, 11);

                    do
                    {
                        random2 = randomize.Next(3, 11);
                    } while (random2 == random1);

                    do
                    {
                        random3 = randomize.Next(3, 11);
                    } while ((random3 == random2) || (random3 == random1));

                    do
                    {
                        random4 = randomize.Next(3, 11);
                    } while ((random4 == random3) || (random4 == random2) || (random4 == random1));

                    do
                    {
                        random5 = randomize.Next(3, 11);
                    } while ((random5 == random4) || (random5 == random3) || (random5 == random2) || (random5 == random1));

                    do
                    {
                        random6 = randomize.Next(3, 11);
                    } while ((random6 == random5) || (random6 == random4) || (random6 == random3) || (random6 == random2) || (random6 == random1));

                    do
                    {
                        random7 = randomize.Next(3, 11);
                    } while ((random7 == random6) || (random7 == random5) || (random7 == random4) || (random7 == random3) || (random7 == random2) || (random7 == random1));

                    do
                    {
                        random8 = randomize.Next(3, 11);
                    } while ((random8 == random7) || (random8 == random6) || (random8 == random5) || (random8 == random4) || (random8 == random3) || (random8 == random2) || (random8 == random1));

                    // Matching player ids with the numbers generated

                    // 1st Spot
                    if (random1 == 3)
                    {
                        label7.Text = "" + player1;
                    }
                    else if (random1 == 4)
                    {
                        label7.Text = "" + player2;
                    }
                    else if (random1 == 5)
                    {
                        label7.Text = "" + player3;
                    }
                    else if (random1 == 6)
                    {
                        label7.Text = "" + player4;
                    }
                    else if (random1 == 7)
                    {
                        label7.Text = "" + player5;
                    }
                    else if (random1 == 8)
                    {
                        label7.Text = "" + player6;
                    }
                    else if (random1 == 9)
                    {
                        label7.Text = "" + player7;
                    }
                    else if (random1 == 10)
                    {
                        label7.Text = "" + player8;
                    }

                    // 2nd Spot
                    if (random2 == 3)
                    {
                        label8.Text = "" + player1;
                    }
                    else if (random2 == 4)
                    {
                        label8.Text = "" + player2;
                    }
                    else if (random2 == 5)
                    {
                        label8.Text = "" + player3;
                    }
                    else if (random2 == 6)
                    {
                        label8.Text = "" + player4;
                    }
                    else if (random2 == 7)
                    {
                        label8.Text = "" + player5;
                    }
                    else if (random2 == 8)
                    {
                        label8.Text = "" + player6;
                    }
                    else if (random2 == 9)
                    {
                        label8.Text = "" + player7;
                    }
                    else if (random2 == 10)
                    {
                        label8.Text = "" + player8;
                    }

                    // 3rd Spot
                    if (random3 == 3)
                    {
                        label9.Text = "" + player1;
                    }
                    else if (random3 == 4)
                    {
                        label9.Text = "" + player2;
                    }
                    else if (random3 == 5)
                    {
                        label9.Text = "" + player3;
                    }
                    else if (random3 == 6)
                    {
                        label9.Text = "" + player4;
                    }
                    else if (random3 == 7)
                    {
                        label9.Text = "" + player5;
                    }
                    else if (random3 == 8)
                    {
                        label9.Text = "" + player6;
                    }
                    else if (random3 == 9)
                    {
                        label9.Text = "" + player7;
                    }
                    else if (random3 == 10)
                    {
                        label9.Text = "" + player8;
                    }

                    // 4th Spot
                    if (random4 == 3)
                    {
                        label10.Text = "" + player1;
                    }
                    else if (random4 == 4)
                    {
                        label10.Text = "" + player2;
                    }
                    else if (random4 == 5)
                    {
                        label10.Text = "" + player3;
                    }
                    else if (random4 == 6)
                    {
                        label10.Text = "" + player4;
                    }
                    else if (random4 == 7)
                    {
                        label10.Text = "" + player5;
                    }
                    else if (random4 == 8)
                    {
                        label10.Text = "" + player6;
                    }
                    else if (random4 == 9)
                    {
                        label10.Text = "" + player7;
                    }
                    else if (random4 == 10)
                    {
                        label10.Text = "" + player8;
                    }

                    // 5th Spot
                    if (random5 == 3)
                    {
                        label13.Text = "" + player1;
                    }
                    else if (random5 == 4)
                    {
                        label13.Text = "" + player2;
                    }
                    else if (random5 == 5)
                    {
                        label13.Text = "" + player3;
                    }
                    else if (random5 == 6)
                    {
                        label13.Text = "" + player4;
                    }
                    else if (random5 == 7)
                    {
                        label13.Text = "" + player5;
                    }
                    else if (random5 == 8)
                    {
                        label13.Text = "" + player6;
                    }
                    else if (random5 == 9)
                    {
                        label13.Text = "" + player7;
                    }
                    else if (random5 == 10)
                    {
                        label13.Text = "" + player8;
                    }

                    // 6th Spot
                    if (random6 == 3)
                    {
                        label12.Text = "" + player1;
                    }
                    else if (random6 == 4)
                    {
                        label12.Text = "" + player2;
                    }
                    else if (random6 == 5)
                    {
                        label12.Text = "" + player3;
                    }
                    else if (random6 == 6)
                    {
                        label12.Text = "" + player4;
                    }
                    else if (random6 == 7)
                    {
                        label12.Text = "" + player5;
                    }
                    else if (random6 == 8)
                    {
                        label12.Text = "" + player6;
                    }
                    else if (random6 == 9)
                    {
                        label12.Text = "" + player7;
                    }
                    else if (random6 == 10)
                    {
                        label12.Text = "" + player8;
                    }

                    // 7th Spot
                    if (random7 == 3)
                    {
                        label11.Text = "" + player1;
                    }
                    else if (random7 == 4)
                    {
                        label11.Text = "" + player2;
                    }
                    else if (random7 == 5)
                    {
                        label11.Text = "" + player3;
                    }
                    else if (random7 == 6)
                    {
                        label11.Text = "" + player4;
                    }
                    else if (random7 == 7)
                    {
                        label11.Text = "" + player5;
                    }
                    else if (random7 == 8)
                    {
                        label11.Text = "" + player6;
                    }
                    else if (random7 == 9)
                    {
                        label11.Text = "" + player7;
                    }
                    else if (random7 == 10)
                    {
                        label11.Text = "" + player8;
                    }

                    // 8th Spot
                    if (random8 == 3)
                    {
                        label5.Text = "" + player1;
                    }
                    else if (random8 == 4)
                    {
                        label5.Text = "" + player2;
                    }
                    else if (random8 == 5)
                    {
                        label5.Text = "" + player3;
                    }
                    else if (random8 == 6)
                    {
                        label5.Text = "" + player4;
                    }
                    else if (random8 == 7)
                    {
                        label5.Text = "" + player5;
                    }
                    else if (random8 == 8)
                    {
                        label5.Text = "" + player6;
                    }
                    else if (random8 == 9)
                    {
                        label5.Text = "" + player7;
                    }
                    else if (random8 == 10)
                    {
                        label5.Text = "" + player8;
                    }

                    textBox3.Enabled = false;
                    textBox3.ForeColor = Color.Gray;
                    textBox3.LineFocusedColor = Color.Gray;
                    textBox3.LineIdleColor = Color.Gray;
                    textBox3.LineMouseHoverColor = Color.Gray;
                    textBox4.Enabled = false;
                    textBox4.ForeColor = Color.Gray;
                    textBox4.LineFocusedColor = Color.Gray;
                    textBox4.LineIdleColor = Color.Gray;
                    textBox4.LineMouseHoverColor = Color.Gray;
                    textBox5.Enabled = false;
                    textBox5.ForeColor = Color.Gray;
                    textBox5.LineFocusedColor = Color.Gray;
                    textBox5.LineIdleColor = Color.Gray;
                    textBox5.LineMouseHoverColor = Color.Gray;
                    textBox6.Enabled = false;
                    textBox6.ForeColor = Color.Gray;
                    textBox6.LineFocusedColor = Color.Gray;
                    textBox6.LineIdleColor = Color.Gray;
                    textBox6.LineMouseHoverColor = Color.Gray;
                    textBox7.Enabled = false;
                    textBox7.ForeColor = Color.Gray;
                    textBox7.LineFocusedColor = Color.Gray;
                    textBox7.LineIdleColor = Color.Gray;
                    textBox7.LineMouseHoverColor = Color.Gray;
                    textBox8.Enabled = false;
                    textBox8.ForeColor = Color.Gray;
                    textBox8.LineFocusedColor = Color.Gray;
                    textBox8.LineIdleColor = Color.Gray;
                    textBox8.LineMouseHoverColor = Color.Gray;
                    textBox9.Enabled = false;
                    textBox9.ForeColor = Color.Gray;
                    textBox9.LineFocusedColor = Color.Gray;
                    textBox9.LineIdleColor = Color.Gray;
                    textBox9.LineMouseHoverColor = Color.Gray;
                    textBox10.Enabled = false;
                    textBox10.ForeColor = Color.Gray;
                    textBox10.LineFocusedColor = Color.Gray;
                    textBox10.LineIdleColor = Color.Gray;
                    textBox10.LineMouseHoverColor = Color.Gray;
                    button2.Enabled = false;
                    button3.Focus();
                }
            }
        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {
            dynamic btn = (Button)sender;
            dynamic drawBrush = new SolidBrush(btn.ForeColor);
            dynamic sf = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            button1.Text = string.Empty;
            e.Graphics.DrawString("Insert Captains", btn.Font, drawBrush, e.ClipRectangle, sf);
            drawBrush.Dispose();
            sf.Dispose();
        }

        private void button1_EnabledChanged(object sender, EventArgs e)
        {
            button1.BackColor = Color.Gray;
            button1.ForeColor = Color.White;
        }

        private void button3_EnabledChanged(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            button3.BackColor = btn.Enabled ? Color.FromArgb(235, 73, 71) : Color.Gray;
            button3.Cursor = btn.Enabled ? Cursors.Hand : Cursors.Default;
        }

        private void button3_Paint(object sender, PaintEventArgs e)
        {
            dynamic btn2 = (Button)sender;
            dynamic drawBrush2 = new SolidBrush(btn2.ForeColor);
            dynamic sf2 = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            button3.Text = string.Empty;
            e.Graphics.DrawString("Remix Players", btn2.Font, drawBrush2, e.ClipRectangle, sf2);
            drawBrush2.Dispose();
            sf2.Dispose();
        }

        private void button2_Paint(object sender, PaintEventArgs e)
        {
            dynamic btn3 = (Button)sender;
            dynamic drawBrush3 = new SolidBrush(btn3.ForeColor);
            dynamic sf3 = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            button2.Text = string.Empty;
            e.Graphics.DrawString("Mix Players", btn3.Font, drawBrush3, e.ClipRectangle, sf3);
            drawBrush3.Dispose();
            sf3.Dispose();
        }

        private void button2_EnabledChanged(object sender, EventArgs e)
        {
            button2.BackColor = Color.Gray;
            button2.ForeColor = Color.White;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timesRemixed++;
            label19.ForeColor = Color.White;
            label19.Text = "Number of times mixed: " + timesRemixed;
            label20.ForeColor = Color.White;
            label20.Text = "Players successfully remixed ✓";

            Random randomize = new Random();

            int random1, random2, random3, random4, random5, random6, random7, random8;

            random1 = randomize.Next(3, 11);

            do
            {
                random2 = randomize.Next(3, 11);
            } while (random2 == random1);

            do
            {
                random3 = randomize.Next(3, 11);
            } while ((random3 == random2) || (random3 == random1));

            do
            {
                random4 = randomize.Next(3, 11);
            } while ((random4 == random3) || (random4 == random2) || (random4 == random1));

            do
            {
                random5 = randomize.Next(3, 11);
            } while ((random5 == random4) || (random5 == random3) || (random5 == random2) || (random5 == random1));

            do
            {
                random6 = randomize.Next(3, 11);
            } while ((random6 == random5) || (random6 == random4) || (random6 == random3) || (random6 == random2) || (random6 == random1));

            do
            {
                random7 = randomize.Next(3, 11);
            } while ((random7 == random6) || (random7 == random5) || (random7 == random4) || (random7 == random3) || (random7 == random2) || (random7 == random1));

            do
            {
                random8 = randomize.Next(3, 11);
            } while ((random8 == random7) || (random8 == random6) || (random8 == random5) || (random8 == random4) || (random8 == random3) || (random8 == random2) || (random8 == random1));

            // Matching player ids with the numbers generated

            string captainA = textBox1.Text;

            string captainB = textBox2.Text;

            string player1 = textBox3.Text;

            string player2 = textBox4.Text;

            string player3 = textBox5.Text;

            string player4 = textBox6.Text;

            string player5 = textBox7.Text;

            string player6 = textBox8.Text;

            string player7 = textBox9.Text;

            string player8 = textBox10.Text;

            // 1st Spot
            if (random1 == 3)
            {
                label7.Text = "" + player1;
            }
            else if (random1 == 4)
            {
                label7.Text = "" + player2;
            }
            else if (random1 == 5)
            {
                label7.Text = "" + player3;
            }
            else if (random1 == 6)
            {
                label7.Text = "" + player4;
            }
            else if (random1 == 7)
            {
                label7.Text = "" + player5;
            }
            else if (random1 == 8)
            {
                label7.Text = "" + player6;
            }
            else if (random1 == 9)
            {
                label7.Text = "" + player7;
            }
            else if (random1 == 10)
            {
                label7.Text = "" + player8;
            }

            // 2nd Spot
            if (random2 == 3)
            {
                label8.Text = "" + player1;
            }
            else if (random2 == 4)
            {
                label8.Text = "" + player2;
            }
            else if (random2 == 5)
            {
                label8.Text = "" + player3;
            }
            else if (random2 == 6)
            {
                label8.Text = "" + player4;
            }
            else if (random2 == 7)
            {
                label8.Text = "" + player5;
            }
            else if (random2 == 8)
            {
                label8.Text = "" + player6;
            }
            else if (random2 == 9)
            {
                label8.Text = "" + player7;
            }
            else if (random2 == 10)
            {
                label8.Text = "" + player8;
            }

            // 3rd Spot
            if (random3 == 3)
            {
                label9.Text = "" + player1;
            }
            else if (random3 == 4)
            {
                label9.Text = "" + player2;
            }
            else if (random3 == 5)
            {
                label9.Text = "" + player3;
            }
            else if (random3 == 6)
            {
                label9.Text = "" + player4;
            }
            else if (random3 == 7)
            {
                label9.Text = "" + player5;
            }
            else if (random3 == 8)
            {
                label9.Text = "" + player6;
            }
            else if (random3 == 9)
            {
                label9.Text = "" + player7;
            }
            else if (random3 == 10)
            {
                label9.Text = "" + player8;
            }

            // 4th Spot
            if (random4 == 3)
            {
                label10.Text = "" + player1;
            }
            else if (random4 == 4)
            {
                label10.Text = "" + player2;
            }
            else if (random4 == 5)
            {
                label10.Text = "" + player3;
            }
            else if (random4 == 6)
            {
                label10.Text = "" + player4;
            }
            else if (random4 == 7)
            {
                label10.Text = "" + player5;
            }
            else if (random4 == 8)
            {
                label10.Text = "" + player6;
            }
            else if (random4 == 9)
            {
                label10.Text = "" + player7;
            }
            else if (random4 == 10)
            {
                label10.Text = "" + player8;
            }

            // 5th Spot
            if (random5 == 3)
            {
                label13.Text = "" + player1;
            }
            else if (random5 == 4)
            {
                label13.Text = "" + player2;
            }
            else if (random5 == 5)
            {
                label13.Text = "" + player3;
            }
            else if (random5 == 6)
            {
                label13.Text = "" + player4;
            }
            else if (random5 == 7)
            {
                label13.Text = "" + player5;
            }
            else if (random5 == 8)
            {
                label13.Text = "" + player6;
            }
            else if (random5 == 9)
            {
                label13.Text = "" + player7;
            }
            else if (random5 == 10)
            {
                label13.Text = "" + player8;
            }

            // 6th Spot
            if (random6 == 3)
            {
                label12.Text = "" + player1;
            }
            else if (random6 == 4)
            {
                label12.Text = "" + player2;
            }
            else if (random6 == 5)
            {
                label12.Text = "" + player3;
            }
            else if (random6 == 6)
            {
                label12.Text = "" + player4;
            }
            else if (random6 == 7)
            {
                label12.Text = "" + player5;
            }
            else if (random6 == 8)
            {
                label12.Text = "" + player6;
            }
            else if (random6 == 9)
            {
                label12.Text = "" + player7;
            }
            else if (random6 == 10)
            {
                label12.Text = "" + player8;
            }

            // 7th Spot
            if (random7 == 3)
            {
                label11.Text = "" + player1;
            }
            else if (random7 == 4)
            {
                label11.Text = "" + player2;
            }
            else if (random7 == 5)
            {
                label11.Text = "" + player3;
            }
            else if (random7 == 6)
            {
                label11.Text = "" + player4;
            }
            else if (random7 == 7)
            {
                label11.Text = "" + player5;
            }
            else if (random7 == 8)
            {
                label11.Text = "" + player6;
            }
            else if (random7 == 9)
            {
                label11.Text = "" + player7;
            }
            else if (random7 == 10)
            {
                label11.Text = "" + player8;
            }

            // 8th Spot
            if (random8 == 3)
            {
                label5.Text = "" + player1;
            }
            else if (random8 == 4)
            {
                label5.Text = "" + player2;
            }
            else if (random8 == 5)
            {
                label5.Text = "" + player3;
            }
            else if (random8 == 6)
            {
                label5.Text = "" + player4;
            }
            else if (random8 == 7)
            {
                label5.Text = "" + player5;
            }
            else if (random8 == 8)
            {
                label5.Text = "" + player6;
            }
            else if (random8 == 9)
            {
                label5.Text = "" + player7;
            }
            else if (random8 == 10)
            {
                label5.Text = "" + player8;
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Coded by Darwin in 12 / 2018 using Microsoft's Vistual Studio w/ Bunifu UI.\n\n'Team Mixer' is a simple program that helps players mix their teams quickly. Fill both of the captains nicknames / names in and press the 'Insert Captains' button. Fill the remaining fields with the waiting players nicknames / names and then press the 'Mix Players' button, if needed, remix the teams. You can remix them as many times as you want. A 'Times Mixed' counter has been added to track the number of times one has mixed the teams and to prove the results authenticity.\n\nThe numbers generated are completely random and it's results are uncheatable.\n\nVersion: 2.0");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label23.Text = "The program has been reset!";
            button3.Enabled = false;
            button1.Enabled = true;
            button1.BackColor = Color.FromArgb(235, 73, 71);
            button2.Enabled = true;
            button2.BackColor = Color.FromArgb(235, 73, 71);
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox1.Text = "Captain A";
            textBox2.Text = "Captain B";
            textBox1.ForeColor = Color.Black;
            textBox2.ForeColor = Color.Black;
            textBox1.LineFocusedColor = Color.FromArgb(235, 73, 71);
            textBox1.LineIdleColor = Color.FromArgb(235, 73, 71);
            textBox1.LineMouseHoverColor = Color.FromArgb(235, 73, 71);
            textBox2.LineFocusedColor = Color.FromArgb(235, 73, 71);
            textBox2.LineIdleColor = Color.FromArgb(235, 73, 71);
            textBox2.LineMouseHoverColor = Color.FromArgb(235, 73, 71);
            textBox1.Focus();
            label18.ForeColor = Color.DarkGray;
            label18.Text = "Captains successfully inserted X";
            label20.ForeColor = Color.DarkGray;
            label20.Text = "Players successfully mixed X";
            timesRemixed = 0;
            label19.ForeColor = Color.DarkGray;
            label19.Text = "Number of times mixed: 0";
            textBox3.Enabled = true;
            textBox3.Text = "Player 1";
            textBox4.Enabled = true;
            textBox4.Text = "Player 2";
            textBox5.Enabled = true;
            textBox5.Text = "Player 3";
            textBox6.Enabled = true;
            textBox6.Text = "Player 4";
            textBox7.Enabled = true;
            textBox7.Text = "Player 5";
            textBox8.Enabled = true;
            textBox8.Text = "Player 6";
            textBox9.Enabled = true;
            textBox9.Text = "Player 7";
            textBox10.Enabled = true;
            textBox10.Text = "Player 8";
            textBox3.ForeColor = Color.Black;
            textBox3.LineFocusedColor = Color.FromArgb(235, 73, 71);
            textBox3.LineIdleColor = Color.FromArgb(235, 73, 71);
            textBox3.LineMouseHoverColor = Color.FromArgb(235, 73, 71);
            textBox4.ForeColor = Color.Black;
            textBox4.LineFocusedColor = Color.FromArgb(235, 73, 71);
            textBox4.LineIdleColor = Color.FromArgb(235, 73, 71);
            textBox4.LineMouseHoverColor = Color.FromArgb(235, 73, 71);
            textBox5.ForeColor = Color.Black;
            textBox5.LineFocusedColor = Color.FromArgb(235, 73, 71);
            textBox5.LineIdleColor = Color.FromArgb(235, 73, 71);
            textBox5.LineMouseHoverColor = Color.FromArgb(235, 73, 71);
            textBox6.ForeColor = Color.Black;
            textBox6.LineFocusedColor = Color.FromArgb(235, 73, 71);
            textBox6.LineIdleColor = Color.FromArgb(235, 73, 71);
            textBox6.LineMouseHoverColor = Color.FromArgb(235, 73, 71);
            textBox7.ForeColor = Color.Black;
            textBox7.LineFocusedColor = Color.FromArgb(235, 73, 71);
            textBox7.LineIdleColor = Color.FromArgb(235, 73, 71);
            textBox7.LineMouseHoverColor = Color.FromArgb(235, 73, 71);
            textBox8.ForeColor = Color.Black;
            textBox8.LineFocusedColor = Color.FromArgb(235, 73, 71);
            textBox8.LineIdleColor = Color.FromArgb(235, 73, 71);
            textBox8.LineMouseHoverColor = Color.FromArgb(235, 73, 71);
            textBox9.ForeColor = Color.Black;
            textBox9.LineFocusedColor = Color.FromArgb(235, 73, 71);
            textBox9.LineIdleColor = Color.FromArgb(235, 73, 71);
            textBox9.LineMouseHoverColor = Color.FromArgb(235, 73, 71);
            textBox10.ForeColor = Color.Black;
            textBox10.LineFocusedColor = Color.FromArgb(235, 73, 71);
            textBox10.LineIdleColor = Color.FromArgb(235, 73, 71);
            textBox10.LineMouseHoverColor = Color.FromArgb(235, 73, 71);
            label6.Text = "Team A Captain";
            label7.Text = "Team A Player 1";
            label8.Text = "Team A Player 2";
            label9.Text = "Team A Player 3";
            label10.Text = "Team A Player 4";
            label14.Text = "Team B Captain";
            label13.Text = "Team B Player 1";
            label12.Text = "Team B Player 2";
            label11.Text = "Team B Player 3";
            label5.Text = "Team B Player 4";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://steamcommunity.com/id/Darwin_CSGO/");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/diogo_borges12");
        }
        private void label17_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            MouPosX = e.X;
            MouPosY = e.Y;
        }

        private void label17_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.SetDesktopLocation(MousePosition.X - MouPosX, MousePosition.Y - MouPosY);
            }
        }

        private void label17_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        public Form1()
        {
            InitializeComponent();
        }
    }
}
