using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacTo
{
    public partial class TicTacToeForm : Form
    {
        private bool isPlayerOneTurn;
        private int buttonClicksCount = 0;
        string s;
        int [,]arr=new int[100,100];
        int width = 250;
        int height = 360;
        int n=0;
        public TicTacToeForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            EnableButtons(false);
            startNewGameToolStripMenuItem.Enabled = true;
            resetGameToolStripMenuItem.Enabled = false;


        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("All right reserved to the developer", "About Tic Tac Toe", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Button99_Click(object sender, EventArgs e)
        {

        }

        private void Button88_Click(object sender, EventArgs e)
        {

        }

        private void Button77_Click(object sender, EventArgs e)
        {

        }

        private void Button66_Click(object sender, EventArgs e)
        {

        }

        private void Button55_Click(object sender, EventArgs e)
        {
            int x = 7, y = 7;
            Button b = (Button)sender;
            Button_click(b, x, y);
        }

        private void Button109_Click(object sender, EventArgs e)
        {

        }

        private void Button98_Click(object sender, EventArgs e)
        {

        }

        private void Button87_Click(object sender, EventArgs e)
        {

        }

        private void Button76_Click(object sender, EventArgs e)
        {

        }

        private void Button65_Click(object sender, EventArgs e)
        {

        }

        private void Button54_Click(object sender, EventArgs e)
        {
            int x = 7, y = 6;
            Button b = (Button)sender;
            Button_click(b, x, y);
        }

        private void Button108_Click(object sender, EventArgs e)
        {

        }

        private void Button97_Click(object sender, EventArgs e)
        {

        }

        private void Button86_Click(object sender, EventArgs e)
        {

        }

        private void Button75_Click(object sender, EventArgs e)
        {

        }

        private void Button64_Click(object sender, EventArgs e)
        {
            int x = 8, y = 8;
            Button b = (Button)sender;
            Button_click(b, x, y);
        }

        private void Button53_Click(object sender, EventArgs e)
        {
            int x = 7, y = 5;
            Button b = (Button)sender;
            Button_click(b, x, y);
        }

        private void Button107_Click(object sender, EventArgs e)
        {

        }

        private void Button96_Click(object sender, EventArgs e)
        {

        }

        private void Button85_Click(object sender, EventArgs e)
        {

        }

        private void Button74_Click(object sender, EventArgs e)
        {

        }

        private void Button63_Click(object sender, EventArgs e)
        {
            int x = 8, y = 7;
            Button b = (Button)sender;
            Button_click(b, x, y);
        }

        private void Button52_Click(object sender, EventArgs e)
        {
            int x = 7, y = 4;
            Button b = (Button)sender;
            Button_click(b, x, y);
        }

        private void Button106_Click(object sender, EventArgs e)
        {

        }

        private void Button95_Click(object sender, EventArgs e)
        {

        }

        private void Button84_Click(object sender, EventArgs e)
        {

        }

        private void Button73_Click(object sender, EventArgs e)
        {

        }

        private void Button62_Click(object sender, EventArgs e)
        {
            int x = 8, y = 6;
            Button b = (Button)sender;
            Button_click(b, x, y);
        }

        private void Button51_Click(object sender, EventArgs e)
        {
            int x = 7, y = 3;
            Button b = (Button)sender;
            Button_click(b, x, y);
        }

        private void Button105_Click(object sender, EventArgs e)
        {

        }

        private void Button94_Click(object sender, EventArgs e)
        {

        }

        private void Button83_Click(object sender, EventArgs e)
        {

        }

        private void Button72_Click(object sender, EventArgs e)
        {

        }

        private void Button61_Click(object sender, EventArgs e)
        {
            int x = 8, y = 5;
            Button b = (Button)sender;
            Button_click(b, x, y);
        }

        private void Button50_Click(object sender, EventArgs e)
        {
            int x = 7, y = 2;
            Button b = (Button)sender;
            Button_click(b, x, y);
        }

        private void Button104_Click(object sender, EventArgs e)
        {

        }

        private void Button93_Click(object sender, EventArgs e)
        {

        }

        private void Button82_Click(object sender, EventArgs e)
        {

        }

        private void Button71_Click(object sender, EventArgs e)
        {

        }

        private void Button60_Click(object sender, EventArgs e)
        {
            int x = 8, y = 4;
            Button b = (Button)sender;
            Button_click(b, x, y);
        }

        private void Button49_Click(object sender, EventArgs e)
        {
            int x = 7, y = 1;
            Button b = (Button)sender;
            Button_click(b, x, y);
        }

        private void Button103_Click(object sender, EventArgs e)
        {

        }

        private void Button92_Click(object sender, EventArgs e)
        {

        }

        private void Button81_Click(object sender, EventArgs e)
        {

        }

        private void Button70_Click(object sender, EventArgs e)
        {

        }

        private void Button59_Click(object sender, EventArgs e)
        {
            int x = 8, y = 3;
            Button b = (Button)sender;
            Button_click(b, x, y);
        }

        private void Button48_Click(object sender, EventArgs e)
        {
            int x = 6, y = 8;
            Button b = (Button)sender;
            Button_click(b, x, y);
        }

        private void Button102_Click(object sender, EventArgs e)
        {

        }

        private void Button101_Click(object sender, EventArgs e)
        {

        }

        private void Button91_Click(object sender, EventArgs e)
        {

        }

        private void Button90_Click(object sender, EventArgs e)
        {

        }

        private void Button80_Click(object sender, EventArgs e)
        {

        }

        private void Button79_Click(object sender, EventArgs e)
        {

        }

        private void Button69_Click(object sender, EventArgs e)
        {

        }

        private void Button68_Click(object sender, EventArgs e)
        {

        }

        private void Button58_Click(object sender, EventArgs e)
        {
            int x = 8, y = 2;
            Button b = (Button)sender;
            Button_click(b, x, y);
        }

        private void Button57_Click(object sender, EventArgs e)
        {
            int x = 8, y = 1;
            Button b = (Button)sender;
            Button_click(b, x, y);
        }

        private void Button47_Click(object sender, EventArgs e)
        {
            int x = 6, y = 7;
            Button b = (Button)sender;
            Button_click(b, x, y);
        }

        private void Button100_Click(object sender, EventArgs e)
        {

        }

        private void Button46_Click(object sender, EventArgs e)
        {
            int x = 6, y = 6;
            Button b = (Button)sender;
            Button_click(b, x, y);
        }

        private void Button89_Click(object sender, EventArgs e)
        {

        }

        private void Button78_Click(object sender, EventArgs e)
        {

        }

        private void Button67_Click(object sender, EventArgs e)
        {

        }

        private void Button56_Click(object sender, EventArgs e)
        {
            int x = 7, y = 8;
            Button b = (Button)sender;
            Button_click(b, x, y);
        }

        private void Button45_Click(object sender, EventArgs e)
        {
            int x = 6, y = 5;
            Button b = (Button)sender;
            Button_click(b, x, y);
        }

        private void Button110_Click(object sender, EventArgs e)
        {

        }

        private void Button33_Click(object sender, EventArgs e)
        {
            int x = 5, y = 1;
            Button b = (Button)sender;
            Button_click(b, x, y);
        }

        private void Button22_Click(object sender, EventArgs e)
        {
            int x = 3, y = 6;
            Button b = (Button)sender;
            Button_click(b, x, y);
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            int x = 2, y = 1;
            Button b = (Button)sender;
            Button_click(b, x, y);
        }

        private void Button32_Click(object sender, EventArgs e)
        {
            int x = 4, y = 8;
            Button b = (Button)sender;
            Button_click(b, x, y);
        }

        private void Button21_Click(object sender, EventArgs e)
        {
            int x = 3, y = 5;
            Button b = (Button)sender;
            Button_click(b, x, y);
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            int x = 1, y = 8;
            Button b = (Button)sender;
            Button_click(b, x, y);
        }

        private void Button31_Click(object sender, EventArgs e)
        {
            int x = 4, y = 7;
            Button b = (Button)sender;
            Button_click(b, x, y);
        }

        private void Button20_Click(object sender, EventArgs e)
        {
            int x = 3, y = 4;
            Button b = (Button)sender;
            Button_click(b, x, y);
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            int x = 1, y = 7;
            Button b = (Button)sender;
            Button_click(b, x, y);
        }

        private void Button30_Click(object sender, EventArgs e)
        {
            int x = 4, y = 6;
            Button b = (Button)sender;
            Button_click(b, x, y);
        }

        private void Button19_Click(object sender, EventArgs e)
        {
            int x = 3, y = 3;
            Button b = (Button)sender;
            Button_click(b, x, y);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            int x = 1, y = 6;
            Button b = (Button)sender;
            Button_click(b, x, y);
        }

        private void Button29_Click(object sender, EventArgs e)
        {
            int x = 4, y = 5;
            Button b = (Button)sender;
            Button_click(b, x, y);
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            int x = 3, y = 2;
            Button b = (Button)sender;
            Button_click(b, x, y);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            int x = 1, y = 5;
            Button b = (Button)sender;
            Button_click(b, x, y);
        }

        private void Button28_Click(object sender, EventArgs e)
        {
            int x = 4, y = 4;
            Button b = (Button)sender;
            Button_click(b, x, y);
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            int x = 3, y = 1;
            Button b = (Button)sender;
            Button_click(b, x, y);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            int x = 1, y = 4;
            Button b = (Button)sender;
            Button_click(b, x, y);
        }

        private void Button27_Click(object sender, EventArgs e)
        {
            int x = 4, y = 3;
            Button b = (Button)sender;
            Button_click(b, x, y);
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            int x = 2, y = 8;
            Button b = (Button)sender;
            Button_click(b, x, y);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            int x = 1, y = 3;
            Button b = (Button)sender;
            Button_click(b, x, y);
        }
        private void Button_click(object sender,int x,int y)
        {
            Button b = (Button)sender;
            if (isPlayerOneTurn == true)
            {
                if (PlayerOneXradioButton.Checked)
                    b.Text = "X";
                else
                    b.Text = "O";
                isPlayerOneTurn = false; ;
                b.Enabled = false;
                arr[x, y] = 1;
            }
            else
            {
                if (PlayerTwoXradioButton.Checked)
                    b.Text = "X";
                else
                    b.Text = "O";
                isPlayerOneTurn = true;
                b.Enabled = false;
                arr[x, y] = 2;
            }
            buttonClicksCount++;
            CheckTheWinner(x,y);
        }
        private void Button26_Click(object sender, EventArgs e)
        {
            int x = 4, y = 2;
            Button b = (Button)sender;
            Button_click(b, x, y);
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            int x = 2, y = 7;
            Button b = (Button)sender;
            Button_click(b, x, y);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int x = 1, y = 2;
            Button b = (Button)sender;
            Button_click(b, x, y);
        }

        private void Button25_Click(object sender, EventArgs e)
        {
            int x = 4, y = 1;
            Button b = (Button)sender;
            Button_click(b, x, y);
        }

        private void Button24_Click(object sender, EventArgs e)
        {
            int x = 3, y = 8;
            Button b = (Button)sender;
            Button_click(b, x, y);
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            int x = 2, y = 6;
            Button b = (Button)sender;
            Button_click(b, x, y);
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            int x = 2, y = 5;
            Button b = (Button)sender;
            Button_click(b, x, y);
        }

        private void Button23_Click(object sender, EventArgs e)
        {
            int x = 3, y = 7;
            Button b = (Button)sender;
            Button_click(b, x, y);
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            int x = 2, y = 3;
            Button b = (Button)sender;
            Button_click(b, x, y);
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            int x = 2, y = 4;
            Button b = (Button)sender;
            Button_click(b, x, y);
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            int x = 2, y = 2;
            Button b = (Button)sender;
            Button_click(b, x, y);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int x = 1,y=1;
            Button b = (Button)sender;
            Button_click(b,x,y);
            
        }

        private void Button36_Click(object sender, EventArgs e)
        {
            int x = 5, y = 4;
            Button b = (Button)sender;
            Button_click(b, x, y);
        }

        private void Button35_Click(object sender, EventArgs e)
        {
            int x = 5, y = 3;
            Button b = (Button)sender;
            Button_click(b, x, y);
        }

        private void Button34_Click(object sender, EventArgs e)
        {
            int x = 5, y = 2;
            Button b = (Button)sender;
            Button_click(b, x, y);
        }

        private void Button37_Click(object sender, EventArgs e)
        {
            int x = 5, y = 5;
            Button b = (Button)sender;
            Button_click(b, x, y);
        }

        private void Button38_Click(object sender, EventArgs e)
        {
            int x = 5, y = 6;
            Button b = (Button)sender;
            Button_click(b, x, y);
        }

        private void Button39_Click(object sender, EventArgs e)
        {
            int x = 5, y = 7;
            Button b = (Button)sender;
            Button_click(b, x, y);
        }

        private void Button40_Click(object sender, EventArgs e)
        {
            int x = 5, y = 8;
            Button b = (Button)sender;
            Button_click(b, x, y);
        }

        private void Button41_Click(object sender, EventArgs e)
        {

        }

        private void Button42_Click(object sender, EventArgs e)
        {
            int x = 6, y = 2;
            Button b = (Button)sender;
            Button_click(b, x, y);
        }

        private void Button43_Click(object sender, EventArgs e)
        {
            int x = 6, y = 3;
            Button b = (Button)sender;
            Button_click(b, x, y);
        }

        private void Button44_Click(object sender, EventArgs e)
        {
            int x = 6, y = 4;
            Button b = (Button)sender;
            Button_click(b, x, y);
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void PlayerOneNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void StartNewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(DimensionNumberTextBox.Text=="0")
            {
                MessageBox.Show("Enter the dimension number you want to play");
            }
            else
            {
                n = Convert.ToInt32(DimensionNumberTextBox.Text);
                if (n <= 2 || n > 9)
                {
                    MessageBox.Show("Sorry you can't play");
                }
                else
                {
                    width = 241;
                    height = 354;
                    width += 210;
                    height -= 89;
                    width += ((n - 3) * 75);
                    width -= (n - 3);
                    height -= (n - 2) * 9;
                    height += (n - 2) * 86;
                    this.Height = height;
                    this.Width = width;
                    EnableButtons(true);
                    startNewGameToolStripMenuItem.Enabled = false;
                    resetGameToolStripMenuItem.Enabled = true;
                    EnablePlayerOptions(false);
                    isPlayerOneTurn = PlayerOneStartRadioButton.Checked;
                    buttonClicksCount = 0;
                    for (int i = 1; i <= n; i++)
                    {
                        for (int j = 1; j <= n; j++)
                        {
                            arr[i, j] = 0;
                        }
                    }
                }
            }
        }
        private void EnableButtons(bool enable)
        {
            B1Button.Enabled = enable;
            B2Button.Enabled = enable;
            B3Button.Enabled = enable;
            B4Button.Enabled = enable;
            B5Button.Enabled = enable;
            B6Button.Enabled = enable;
            B7Button.Enabled = enable;
            B8Button.Enabled = enable;
            B9Button.Enabled = enable;
            B10Button.Enabled = enable;
            B11Button.Enabled = enable;
            B12Button.Enabled = enable;
            B13Button.Enabled = enable;
            B14Button.Enabled = enable;
            B15Button.Enabled = enable;
            B16Button.Enabled = enable;
            B17Button.Enabled = enable;
            B18Button.Enabled = enable;
            B19Button.Enabled = enable;
            B20Button.Enabled = enable;
            B21Button.Enabled = enable;
            B22Button.Enabled = enable;
            B23Button.Enabled = enable;
            B24Button.Enabled = enable;
            B25Button.Enabled = enable;
            B26Button.Enabled = enable;
            B27Button.Enabled = enable;
            B28Button.Enabled = enable;
            B29Button.Enabled = enable;
            B30Button.Enabled = enable;
            B31Button.Enabled = enable;
            B32Button.Enabled = enable;
            B33Button.Enabled = enable;
            B34Button.Enabled = enable;
            B35Button.Enabled = enable;
            B36Button.Enabled = enable;
            B37Button.Enabled = enable;
            B38Button.Enabled = enable;
            B39Button.Enabled = enable;
            B40Button.Enabled = enable;
            B41Button.Enabled = enable;
            B42Button.Enabled = enable;
            B43Button.Enabled = enable;
            B44Button.Enabled = enable;
            B45Button.Enabled = enable;
            B46Button.Enabled = enable;
            B47Button.Enabled = enable;
            B48Button.Enabled = enable;
            B49Button.Enabled = enable;
            B50Button.Enabled = enable;
            B51Button.Enabled = enable;
            B52Button.Enabled = enable;
            B53Button.Enabled = enable;
            B54Button.Enabled = enable;
            B55Button.Enabled = enable;
            B56Button.Enabled = enable;
            B57Button.Enabled = enable;
            B58Button.Enabled = enable;
            B59Button.Enabled = enable;
            B60Button.Enabled = enable;
            B61Button.Enabled = enable;
            B62Button.Enabled = enable;
            B63Button.Enabled = enable;
            B64Button.Enabled = enable;
        }

        private void ResetGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetGame();
        }
        private void ResetGame()
        {
            EnableButtons(false);
            startNewGameToolStripMenuItem.Enabled = true;
            resetGameToolStripMenuItem.Enabled = false;
            EnablePlayerOptions(true);
            DimensionNumberTextBox.Text = "0";
            width = 245;
            height = 360;
            this.Height = height;
            this.Width = width;
            ClearButton();
        }

        private void ClearButton()
        {
            B1Button.Text = "";
            B2Button.Text = "";
            B3Button.Text = "";
            B4Button.Text = "";
            B5Button.Text = "";
            B6Button.Text = "";
            B7Button.Text = "";
            B8Button.Text = "";
            B9Button.Text = "";
            B10Button.Text = "";
            B11Button.Text = "";
            B12Button.Text = "";
            B13Button.Text = "";
            B14Button.Text = "";
            B15Button.Text = "";
            B16Button.Text = "";
            B17Button.Text = "";
            B18Button.Text = "";
            B19Button.Text = "";
            B20Button.Text = "";
            B21Button.Text = "";
            B22Button.Text = "";
            B23Button.Text = "";
            B24Button.Text = "";
            B25Button.Text = "";
            B26Button.Text = "";
            B27Button.Text = "";
            B28Button.Text = "";
            B29Button.Text = "";
            B30Button.Text = "";
            B31Button.Text = "";
            B32Button.Text = "";
            B33Button.Text = "";
            B34Button.Text = "";
            B35Button.Text = "";
            B36Button.Text = "";
            B37Button.Text = "";
            B38Button.Text = "";
            B39Button.Text = "";
            B40Button.Text = "";
            B41Button.Text = "";
            B42Button.Text = "";
            B43Button.Text = "";
            B44Button.Text = "";
            B45Button.Text = "";
            B46Button.Text = "";
            B47Button.Text = "";
            B48Button.Text = "";
            B49Button.Text = "";
            B50Button.Text = "";
            B51Button.Text = "";
            B52Button.Text = "";
            B53Button.Text = "";
            B54Button.Text = "";
            B55Button.Text = "";
            B56Button.Text = "";
            B57Button.Text = "";
            B58Button.Text = "";
            B59Button.Text = "";
            B60Button.Text = "";
            B61Button.Text = "";
            B62Button.Text = "";
            B63Button.Text = "";
            B64Button.Text = "";
        }

        private void EnablePlayerOptions(bool enable)
        {
            PlayersNameGroupBox.Enabled = enable;
            SelectXGroupBox.Enabled = enable;
            StartPlayerGroupBox.Enabled = enable;
            DimensionBox.Enabled = enable;
        }

        private void FileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void CheckTheWinner(int x,int y)
        {
            int value = arr[x, y];
            bool win = false;
            int counter = 0;
            for(int i=1;i<=n;i++)
            {
                if (arr[x, i] == value)
                {
                    counter++;
                }
            }
            if(counter==n)
            {
                win = true;
            }
            counter = 0;
            for(int i=1;i<=n;i++)
            {
                if(arr[i,y]==value)
                {
                    counter++;
                }
            }
            if (counter == n) { win = true; }
            counter = 0;
            if(x==y)
            {
                for(int i=1;i<=n;i++)
                {
                    if(arr[i,i]==value)
                    { counter++; }
                }
            }
            if (counter == n) { win = true; }
            int j = n;
            counter = 0;
            for(int i=1;i<=n;i++)
            {
                if (arr[i, j] == value) { counter++; }
                j--;
            }
            if (counter == n) { win = true; }
            if (win == true)
            {
                if (value == 1) { MessageBox.Show(PlayerOneNameTextBox.Text + " is the winner!!!","Game Over",MessageBoxButtons.OK,MessageBoxIcon.Information); }
                else if(value==2)
                {
                    MessageBox.Show(PlayerTwoNameTextBox.Text +" is the winner!!!","Game Over",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                ResetGame();
            }
            int fe = n * n;
            if(buttonClicksCount==fe && win==false)
            {
                 MessageBox.Show("The Game is drawn", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetGame();
            }
            /*else
            {
                s = Convert.ToString(counter);
                MessageBox.Show(s);
            }*/
        }
        
        private void DimensionNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
