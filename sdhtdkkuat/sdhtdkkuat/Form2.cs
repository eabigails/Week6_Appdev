
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace sdhtdkkuat
{
    public partial class Form2 : Form
    {
        public static Form2 instance;
        public int b;
        string[] listjawaban = File.ReadAllText("Wordle Word List.txt").Split(',');
        string dijawab = "";
        string tebakanalam = "";
        int barisan;
        int dipindahkebarisbwh = 0;
        List<string> greeny = new List<string>();
        int wincondition = 0;
       
        public Form2(int random)
        {
            InitializeComponent();
            dipindahkebarisbwh = random;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            for (int i = 0; i <= 4; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Button button = new Button();
                    button.Size = new Size(50, 50);
                    button.Tag = j.ToString() + "," + i.ToString();
                    button.Location = new Point(i * button.Width, j * button.Height);
                    Controls.Add(button);

                }
            }
            jwbnnyauser();
        }
        private void hitungpanel(int keylength)
        {
            for (int i = 0; i < 5; i++)
            {
                foreach (Button button in this.Controls.OfType<Button>())
                {
                    string tag = button.Tag.ToString();
                    if (tag == barisan.ToString() + "," + i.ToString() && i < keylength)
                    {
                        button.Text = tebakanalam[i].ToString();
                    }
                    else if (tag == barisan.ToString() + "," + i.ToString())
                    {
                        button.Text = "";
                    }
                }
            }
        }
        private void jwbnnyauser()
        {
            for (int i = 0; i < listjawaban.Length; i++)
            {
                listjawaban[i] = listjawaban[i];
            }
            Random rdm = new Random();
            dijawab = listjawaban[rdm.Next(0, listjawaban.Length - 1)];
        }

        private void diuptodate(string key)
        {

            if (key == "ENTER")
            {
                greensolution();


                if (listjawaban.Contains(tebakanalam))
                {
                    greenflag();
                    yellowflag();
                    kondisimenangkalah();
                }
                else
                {
                    MessageBox.Show("Word does not contain in word list");
                }

            }
            else if (key == "DELETE")
            {
                dihilangkandrdunia(tebakanalam.Length);
            }
            else
            {

                tebakanalam = tebakanalam + key.ToUpper(); ;

                hitungpanel(tebakanalam.Length);
            }
        }

        

        private void button_Q_Click(object sender, EventArgs e)
        {
            diuptodate("Q");
        }

        private void button_W_Click(object sender, EventArgs e)
        {
            diuptodate("W");
        }

        private void button_E_Click(object sender, EventArgs e)
        {
            diuptodate("E");
        }

        private void button_R_Click(object sender, EventArgs e)
        {
            diuptodate("R");
        }

        private void button_T_Click(object sender, EventArgs e)
        {
            diuptodate("T");
        }

        private void button_Y_Click(object sender, EventArgs e)
        {
            diuptodate("Y");
        }

        private void button_U_Click(object sender, EventArgs e)
        {
            diuptodate("U");
        }

        private void button_I_Click(object sender, EventArgs e)
        {
            diuptodate("I");
        }

        private void button_O_Click(object sender, EventArgs e)
        {
            diuptodate("O");
        }

        private void button_P_Click(object sender, EventArgs e)
        {
            diuptodate("P");
        }

        private void button_A_Click(object sender, EventArgs e)
        {
            diuptodate("A");
        }

        private void button_S_Click(object sender, EventArgs e)
        {
            diuptodate("S");
        }

        private void button_D_Click(object sender, EventArgs e)
        {
            diuptodate("D");
        }

        private void button_F_Click(object sender, EventArgs e)
        {
            diuptodate("F");
        }

        private void button_G_Click(object sender, EventArgs e)
        {
            diuptodate("G");
        }

        private void button_H_Click(object sender, EventArgs e)
        {
            diuptodate("H");
        }

        private void button_J_Click(object sender, EventArgs e)
        {
            diuptodate("J");
        }

        private void button_K_Click(object sender, EventArgs e)
        {
            diuptodate("K");
        }

        private void button_L_Click(object sender, EventArgs e)
        {
            diuptodate("L");
        }

        private void button_Z_Click(object sender, EventArgs e)
        {
            diuptodate("Z");
        }

        private void button_X_Click(object sender, EventArgs e)
        {
            diuptodate("X");
        }

        private void button_C_Click(object sender, EventArgs e)
        {
            diuptodate("C");
        }

        private void button_V_Click(object sender, EventArgs e)
        {
            diuptodate("V");
        }

        private void button_B_Click(object sender, EventArgs e)
        {
            diuptodate("B");
        }

        private void button_N_Click(object sender, EventArgs e)
        {
            diuptodate("N");
        }

        private void button_M_Click(object sender, EventArgs e)
        {
            diuptodate("M");
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            diuptodate("DELETE");
        }

        private void button_Enter_Click(object sender, EventArgs e)
        {
            diuptodate("ENTER");
        }

        private void dihilangkandrdunia(int keylength)
        {
            tebakanalam = tebakanalam.Substring(0, tebakanalam.Length - 1);
            hitungpanel(tebakanalam.Length);
        }
        

        private void greenflag()
        {
            wincondition = 0;
            for (int i = 0; i < 5; i++)
            {
                foreach (Button button in this.Controls.OfType<Button>())
                {
                    string tag = button.Tag.ToString();
                    if (tag == barisan.ToString() + "," + i.ToString())
                    {
                        if (tebakanalam[i] == dijawab[i])
                        {
                            button.BackColor = Color.Green;
                            button.ForeColor = Color.White;
                            greeny[i] = "";
                            wincondition++;
                        }
                    }
                }
            }
        }

        private void yellowflag()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    foreach (Button button in this.Controls.OfType<Button>())
                    {
                        string tag = button.Tag.ToString();
                        if (tag == barisan.ToString() + "," + i.ToString())
                        {
                            if (tebakanalam[i].ToString() == greeny[j].ToString() && button.BackColor != Color.LightGreen && greeny[j] != "")
                            {
                                button.BackColor = Color.Yellow;
                                greeny[i] = "";
                            }
                        }
                    }
                }
            }
        }

        private void greensolution()
        {
            for (int i = 0; i < 5; i++)
            {
                greeny.Add(dijawab[i].ToString());
            }
        }

        private void kondisimenangkalah()
        {
            barisan++;
            tebakanalam = "";
            if (wincondition == 5)
            {
                MessageBox.Show("Wawww menang!!!");
                this.Close();
            }
            else if (barisan == dipindahkebarisbwh && wincondition != 5)
            {
                MessageBox.Show("Salah bwahahaha jawabannya " + dijawab);

            }

        }

        

    }
}
