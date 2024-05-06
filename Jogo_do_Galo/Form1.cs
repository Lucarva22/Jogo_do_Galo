using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Jogo_do_Galo
{
    public partial class Form1 : Form
    {
        bool vez = true; // Para inicializar o programa a true 
        
        public Form1()
        {
            InitializeComponent();
            textBox4.Text = "USER 1 a jogar";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int vNum = Convert.ToInt16(textBox2.Text);

            string Player1 = textBox1.Text;
            Player1 = "X";

            string Player2 = textBox3.Text;
            Player2 = "O";


            if(button1.Text !="")
            {
                textBox4.Text = "Escolha outro";
            }

            else if (vez == true) // sempre que for true adiciona um X.
            {
                button1.Text = Player1;
                vez=false; // Converter o bool para falso para o O jogar.
                textBox2.Text = (vNum + 1).ToString();
                textBox4.Text = "USER 2 a jogar";
             
            }

            else if (vez== false) // sempre que for false adiciona um O.
            {
                button1.Text = Player2;
                vez=true; // Converter o bool para true para o X jogar.
                textBox2.Text = (vNum + 1).ToString();
                textBox4.Text = "USER 1 a jogar";

            }

            if (button1.Text == Player1 && button2.Text == Player1 && button3.Text == Player1)
            {
                textBox4.Text = "USER 1 Vencedor";
            }
            else if (button4.Text == Player1 && button5.Text == Player1 && button6.Text == Player1)
            {
                textBox4.Text = "USER 1 Vencedor";
            }
            else if (button7.Text == Player1 && button8.Text == Player1 && button9.Text == Player1)
            {
                textBox4.Text = "USER 1 Vencedor";
            }

            if (button1.Text == Player2 && button2.Text == Player2 && button3.Text == Player2)
            {
                textBox4.Text = "USER 2 Vencedor";
            }
            else if (button4.Text == Player2 && button5.Text == Player2 && button6.Text == Player2)
            {
                textBox4.Text = "USER 2 Vencedor";
            }
            else if (button7.Text == Player2 && button8.Text == Player2 && button9.Text == Player2)
            {
                textBox4.Text = "USER 2 Vencedor";
            }

            if (button1.Text == Player1 && button6.Text == Player1 && button9.Text == Player1)
            {
                textBox4.Text = "USER 1 Vencedor";
            }
            else if (button2.Text == Player1 && button5.Text == Player1 && button8.Text == Player1)
            {
                textBox4.Text = "USER 1 Vencedor";
            }
            else if (button7.Text == Player1 && button3.Text == Player1 && button4.Text == Player1)
            {
                textBox4.Text = "USER 1 Vencedor";
            }

            if (button1.Text == Player2 && button6.Text == Player2 && button9.Text == Player2)
            {
                textBox4.Text = "USER 2 Vencedor";
            }
            else if (button2.Text == Player2 && button5.Text == Player2 && button8.Text == Player2)
            {
                textBox4.Text = "USER 2 Vencedor";
            }
            else if (button7.Text == Player2 && button3.Text == Player2 && button4.Text == Player2)
            {
                textBox4.Text = "USER 2 Vencedor";
            }

            if (button1.Text == Player1 && button5.Text == Player1 && button7.Text == Player1)
            {
                textBox4.Text = "USER 1 Vencedor";
            }
            else if (button3.Text == Player1 && button5.Text == Player1 && button9.Text == Player1)
            {
                textBox4.Text = "USER 1 Vencedor";
            }

            if (button1.Text == Player2 && button5.Text == Player2 && button7.Text == Player2)
            {
                textBox4.Text = "USER 2 Vencedor";
            }
            else if (button3.Text == Player1 && button5.Text == Player2 && button9.Text == Player2)
            {
                textBox4.Text = "USER 2 Vencedor";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int vNum = Convert.ToInt16(textBox2.Text);

            string Player1 = textBox1.Text;
            Player1 = "X";

            string Player2 = textBox3.Text;
            Player2 = "O";

            if (button2.Text != "")
            {
                textBox4.Text = "Escolha outro";
            }
            else if (vez == true)
            {
                button2.Text = Player1;
                vez = false;
                textBox2.Text = (vNum + 1).ToString();
                textBox4.Text = "USER 2 a jogar";
            }

            else if(vez == false)
            {
                button2.Text = Player2;
                vez = true;
                textBox2.Text = (vNum + 1).ToString();
                textBox4.Text = "USER 1 a jogar";
            }
        

            if (button1.Text == Player1 && button2.Text == Player1 && button3.Text == Player1)
            {
                textBox4.Text = "USER 1 Vencedor";
            }
            else if (button4.Text == Player1 && button5.Text == Player1 && button6.Text == Player1)
            {
                textBox4.Text = "USER 1 Vencedor";
            }
            else if (button7.Text == Player1 && button8.Text == Player1 && button9.Text == Player1)
            {
                textBox4.Text = "USER 1 Vencedor";
            }

            if (button1.Text == Player2 && button2.Text == Player2 && button3.Text == Player2)
            {
                textBox4.Text = "USER 2 Vencedor";
            }
            else if (button4.Text == Player2 && button5.Text == Player2 && button6.Text == Player2)
            {
                textBox4.Text = "USER 2 Vencedor";
            }
            else if (button7.Text == Player2 && button8.Text == Player2 && button9.Text == Player2)
            {
                textBox4.Text = "USER 2 Vencedor";
            }

            if (button1.Text == Player1 && button6.Text == Player1 && button9.Text == Player1)
            {
                textBox4.Text = "USER 1 Vencedor";
            }
            else if (button2.Text == Player1 && button5.Text == Player1 && button8.Text == Player1)
            {
                textBox4.Text = "USER 1 Vencedor";
            }
            else if (button7.Text == Player1 && button3.Text == Player1 && button4.Text == Player1)
            {
                textBox4.Text = "USER 1 Vencedor";
            }

            if (button1.Text == Player2 && button6.Text == Player2 && button9.Text == Player2)
            {
                textBox4.Text = "USER 2 Vencedor";
            }
            else if (button2.Text == Player2 && button5.Text == Player2 && button8.Text == Player2)
            {
                textBox4.Text = "USER 2 Vencedor";
            }
            else if (button7.Text == Player2 && button3.Text == Player2 && button4.Text == Player2)
            {
                textBox4.Text = "USER 2 Vencedor";
            }

            if (button1.Text == Player1 && button5.Text == Player1 && button7.Text == Player1)
            {
                textBox4.Text = "USER 1 Vencedor";
            }
            else if (button3.Text == Player1 && button5.Text == Player1 && button9.Text == Player1)
            {
                textBox4.Text = "USER 1 Vencedor";
            }

            if (button1.Text == Player2 && button5.Text == Player2 && button7.Text == Player2)
            {
                textBox4.Text = "USER 2 Vencedor";
            }
            else if (button3.Text == Player1 && button5.Text == Player2 && button9.Text == Player2)
            {
                textBox4.Text = "USER 2 Vencedor";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int vNum = Convert.ToInt16(textBox2.Text);

            string Player1 = textBox1.Text;
            Player1 = "X";

            string Player2 = textBox3.Text;
            Player2 = "O";

            if (button3.Text != "")
            {
                textBox4.Text = "Escolha outro";
            }
            else if (vez == true)
            {
                button3.Text = Player1;
                vez = false;
                textBox2.Text = (vNum + 1).ToString();
                textBox4.Text = "USER 2 a jogar";
            }

            else if (vez == false)
            {
                button3.Text = Player2;
                vez = true;
                textBox2.Text = (vNum + 1).ToString();
                textBox4.Text = "USER 1 a jogar";
            }

            if (button1.Text == Player1 && button2.Text == Player1 && button3.Text == Player1)
            {
                textBox4.Text = "USER 1 Vencedor";
            }
            else if (button4.Text == Player1 && button5.Text == Player1 && button6.Text == Player1)
            {
                textBox4.Text = "USER 1 Vencedor";
            }
            else if (button7.Text == Player1 && button8.Text == Player1 && button9.Text == Player1)
            {
                textBox4.Text = "USER 1 Vencedor";
            }

            if (button1.Text == Player2 && button2.Text == Player2 && button3.Text == Player2)
            {
                textBox4.Text = "USER 2 Vencedor";
            }
            else if (button4.Text == Player2 && button5.Text == Player2 && button6.Text == Player2)
            {
                textBox4.Text = "USER 2 Vencedor";
            }
            else if (button7.Text == Player2 && button8.Text == Player2 && button9.Text == Player2)
            {
                textBox4.Text = "USER 2 Vencedor";
            }

            if (button1.Text == Player1 && button6.Text == Player1 && button9.Text == Player1)
            {
                textBox4.Text = "USER 1 Vencedor";
            }
            else if (button2.Text == Player1 && button5.Text == Player1 && button8.Text == Player1)
            {
                textBox4.Text = "USER 1 Vencedor";
            }
            else if (button7.Text == Player1 && button3.Text == Player1 && button4.Text == Player1)
            {
                textBox4.Text = "USER 1 Vencedor";
            }

            if (button1.Text == Player2 && button6.Text == Player2 && button9.Text == Player2)
            {
                textBox4.Text = "USER 2 Vencedor";
            }
            else if (button2.Text == Player2 && button5.Text == Player2 && button8.Text == Player2)
            {
                textBox4.Text = "USER 2 Vencedor";
            }
            else if (button7.Text == Player2 && button3.Text == Player2 && button4.Text == Player2)
            {
                textBox4.Text = "USER 2 Vencedor";
            }

            if (button1.Text == Player1 && button5.Text == Player1 && button7.Text == Player1)
            {
                textBox4.Text = "USER 1 Vencedor";
            }
            else if (button3.Text == Player1 && button5.Text == Player1 && button9.Text == Player1)
            {
                textBox4.Text = "USER 1 Vencedor";
            }

            if (button1.Text == Player2 && button5.Text == Player2 && button7.Text == Player2)
            {
                textBox4.Text = "USER 2 Vencedor";
            }
            else if (button3.Text == Player1 && button5.Text == Player2 && button9.Text == Player2)
            {
                textBox4.Text = "USER 2 Vencedor";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int vNum = Convert.ToInt16(textBox2.Text);

            string Player1 = textBox1.Text;
            Player1 = "X";

            string Player2 = textBox3.Text;
            Player2 = "O";

            if (button6.Text != "")
            {
                textBox4.Text = "Escolha outro";
            }
            else if (vez == true)
            {
                button6.Text = Player1;
                vez = false;
                textBox2.Text = (vNum + 1).ToString();
                textBox4.Text = "USER 2 a jogar";
            }
             
            else if (vez == false)
            {
                button6.Text = Player2;
                vez = true;
                textBox2.Text = (vNum + 1).ToString();
                textBox4.Text = "USER 1 a jogar";
            }

            if (button1.Text == Player1 && button2.Text == Player1 && button3.Text == Player1)
            {
                textBox4.Text = "USER 1 Vencedor";
            }
            else if (button4.Text == Player1 && button5.Text == Player1 && button6.Text == Player1)
            {
                textBox4.Text = "USER 1 Vencedor";
            }
            else if (button7.Text == Player1 && button8.Text == Player1 && button9.Text == Player1)
            {
                textBox4.Text = "USER 1 Vencedor";
            }

            if (button1.Text == Player2 && button2.Text == Player2 && button3.Text == Player2)
            {
                textBox4.Text = "USER 2 Vencedor";
            }
            else if (button4.Text == Player2 && button5.Text == Player2 && button6.Text == Player2)
            {
                textBox4.Text = "USER 2 Vencedor";
            }
            else if (button7.Text == Player2 && button8.Text == Player2 && button9.Text == Player2)
            {
                textBox4.Text = "USER 2 Vencedor";
            }

            if (button1.Text == Player1 && button6.Text == Player1 && button9.Text == Player1)
            {
                textBox4.Text = "USER 1 Vencedor";
            }
            else if (button2.Text == Player1 && button5.Text == Player1 && button8.Text == Player1)
            {
                textBox4.Text = "USER 1 Vencedor";
            }
            else if (button7.Text == Player1 && button3.Text == Player1 && button4.Text == Player1)
            {
                textBox4.Text = "USER 1 Vencedor";
            }

            if (button1.Text == Player2 && button6.Text == Player2 && button9.Text == Player2)
            {
                textBox4.Text = "USER 2 Vencedor";
            }
            else if (button2.Text == Player2 && button5.Text == Player2 && button8.Text == Player2)
            {
                textBox4.Text = "USER 2 Vencedor";
            }
            else if (button7.Text == Player2 && button3.Text == Player2 && button4.Text == Player2)
            {
                textBox4.Text = "USER 2 Vencedor";
            }

            if (button1.Text == Player1 && button5.Text == Player1 && button7.Text == Player1)
            {
                textBox4.Text = "USER 1 Vencedor";
            }
            else if (button3.Text == Player1 && button5.Text == Player1 && button9.Text == Player1)
            {
                textBox4.Text = "USER 1 Vencedor";
            }

            if (button1.Text == Player2 && button5.Text == Player2 && button7.Text == Player2)
            {
                textBox4.Text = "USER 2 Vencedor";
            }
            else if (button3.Text == Player1 && button5.Text == Player2 && button9.Text == Player2)
            {
                textBox4.Text = "USER 2 Vencedor";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int vNum = Convert.ToInt16(textBox2.Text);

            string Player1 = textBox1.Text;
            Player1 = "X";

            string Player2 = textBox3.Text;
            Player2 = "O";
            
            if (button5.Text != "")
            {
                textBox4.Text = "Escolha outro";
            }
            else if (vez == true)
            {
                button5.Text = Player1;
                vez = false;
                textBox2.Text = (vNum + 1).ToString();
                textBox4.Text = "USER 2 a jogar";
            }

            else if (vez == false)
            {
                button5.Text = Player2;
                vez = true;
                textBox2.Text = (vNum + 1).ToString();
                textBox4.Text = "USER 1 a jogar";
            }

            if (button1.Text == Player1 && button2.Text == Player1 && button3.Text == Player1)
            {
                textBox4.Text = "USER 1 Vencedor";
            }
            else if (button4.Text == Player1 && button5.Text == Player1 && button6.Text == Player1)
            {
                textBox4.Text = "USER 1 Vencedor";
            }
            else if (button7.Text == Player1 && button8.Text == Player1 && button9.Text == Player1)
            {
                textBox4.Text = "USER 1 Vencedor";
            }

            if (button1.Text == Player2 && button2.Text == Player2 && button3.Text == Player2)
            {
                textBox4.Text = "USER 2 Vencedor";
            }
            else if (button4.Text == Player2 && button5.Text == Player2 && button6.Text == Player2)
            {
                textBox4.Text = "USER 2 Vencedor";
            }
            else if (button7.Text == Player2 && button8.Text == Player2 && button9.Text == Player2)
            {
                textBox4.Text = "USER 2 Vencedor";
            }

            if (button1.Text == Player1 && button6.Text == Player1 && button9.Text == Player1)
            {
                textBox4.Text = "USER 1 Vencedor";
            }
            else if (button2.Text == Player1 && button5.Text == Player1 && button8.Text == Player1)
            {
                textBox4.Text = "USER 1 Vencedor";
            }
            else if (button7.Text == Player1 && button3.Text == Player1 && button4.Text == Player1)
            {
                textBox4.Text = "USER 1 Vencedor";
            }

            if (button1.Text == Player2 && button6.Text == Player2 && button9.Text == Player2)
            {
                textBox4.Text = "USER 2 Vencedor";
            }
            else if (button2.Text == Player2 && button5.Text == Player2 && button8.Text == Player2)
            {
                textBox4.Text = "USER 2 Vencedor";
            }
            else if (button7.Text == Player2 && button3.Text == Player2 && button4.Text == Player2)
            {
                textBox4.Text = "USER 2 Vencedor";
            }

            if (button1.Text == Player1 && button5.Text == Player1 && button7.Text == Player1)
            {
                textBox4.Text = "USER 1 Vencedor";
            }
            else if (button3.Text == Player1 && button5.Text == Player1 && button9.Text == Player1)
            {
                textBox4.Text = "USER 1 Vencedor";
            }

            if (button1.Text == Player2 && button5.Text == Player2 && button7.Text == Player2)
            {
                textBox4.Text = "USER 2 Vencedor";
            }
            else if (button3.Text == Player1 && button5.Text == Player2 && button9.Text == Player2)
            {
                textBox4.Text = "USER 2 Vencedor";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int vNum = Convert.ToInt16(textBox2.Text);

            string Player1 = textBox1.Text;
            Player1 = "X";

            string Player2 = textBox3.Text;
            Player2 = "O";

            if (button4.Text != "")
            {
                textBox4.Text = "Escolha outro";
            }
            else if (vez == true)
            {
                button4.Text = Player1;
                vez = false;
                textBox2.Text = (vNum + 1).ToString();
                textBox4.Text = "USER 2 a jogar";
            }

            else if (vez == false)
            {
                button4.Text = Player2;
                vez = true;
                textBox2.Text = (vNum + 1).ToString();
                textBox4.Text = "USER 1 a jogar";
            }

            if (button1.Text == Player1 && button2.Text == Player1 && button3.Text == Player1)
            {
                textBox4.Text = "USER 1 Vencedor";
            }
            else if (button4.Text == Player1 && button5.Text == Player1 && button6.Text == Player1)
            {
                textBox4.Text = "USER 1 Vencedor";
            }
            else if (button7.Text == Player1 && button8.Text == Player1 && button9.Text == Player1)
            {
                textBox4.Text = "USER 1 Vencedor";
            }

            if (button1.Text == Player2 && button2.Text == Player2 && button3.Text == Player2)
            {
                textBox4.Text = "USER 2 Vencedor";
            }
            else if (button4.Text == Player2 && button5.Text == Player2 && button6.Text == Player2)
            {
                textBox4.Text = "USER 2 Vencedor";
            }
            else if (button7.Text == Player2 && button8.Text == Player2 && button9.Text == Player2)
            {
                textBox4.Text = "USER 2 Vencedor";
            }

            if (button1.Text == Player1 && button6.Text == Player1 && button9.Text == Player1)
            {
                textBox4.Text = "USER 1 Vencedor";
            }
            else if (button2.Text == Player1 && button5.Text == Player1 && button8.Text == Player1)
            {
                textBox4.Text = "USER 1 Vencedor";
            }
            else if (button7.Text == Player1 && button3.Text == Player1 && button4.Text == Player1)
            {
                textBox4.Text = "USER 1 Vencedor";
            }

            if (button1.Text == Player2 && button6.Text == Player2 && button9.Text == Player2)
            {
                textBox4.Text = "USER 2 Vencedor";
            }
            else if (button2.Text == Player2 && button5.Text == Player2 && button8.Text == Player2)
            {
                textBox4.Text = "USER 2 Vencedor";
            }
            else if (button7.Text == Player2 && button3.Text == Player2 && button4.Text == Player2)
            {
                textBox4.Text = "USER 2 Vencedor";
            }

            if (button1.Text == Player1 && button5.Text == Player1 && button7.Text == Player1)
            {
                textBox4.Text = "USER 1 Vencedor";
            }
            else if (button3.Text == Player1 && button5.Text == Player1 && button9.Text == Player1)
            {
                textBox4.Text = "USER 1 Vencedor";
            }

            if (button1.Text == Player2 && button5.Text == Player2 && button7.Text == Player2)
            {
                textBox4.Text = "USER 2 Vencedor";
            }
            else if (button3.Text == Player1 && button5.Text == Player2 && button9.Text == Player2)
            {
                textBox4.Text = "USER 2 Vencedor";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int vNum = Convert.ToInt16(textBox2.Text);

            string Player1 = textBox1.Text;
            Player1 = "X";

            string Player2 = textBox3.Text;
            Player2 = "O";

            if (button9.Text != "")
            {
                textBox4.Text = "Escolha outro";
            }
            else if (vez == true)
            {
                button9.Text = Player1;
                vez = false;
                textBox2.Text = (vNum + 1).ToString();
                textBox4.Text = "USER 2 a jogar";
            }

            else if (vez == false)
            {
                button9.Text = Player2;
                vez = true;
                textBox2.Text = (vNum + 1).ToString();
                textBox4.Text = "USER 1 a jogar";
            }

            if (button1.Text == Player1 && button2.Text == Player1 && button3.Text == Player1)
            {
                textBox4.Text = "USER 1 Vencedor";
            }
            else if (button4.Text == Player1 && button5.Text == Player1 && button6.Text == Player1)
            {
                textBox4.Text = "USER 1 Vencedor";
            }
            else if (button7.Text == Player1 && button8.Text == Player1 && button9.Text == Player1)
            {
                textBox4.Text = "USER 1 Vencedor";
            }

            if (button1.Text == Player2 && button2.Text == Player2 && button3.Text == Player2)
            {
                textBox4.Text = "USER 2 Vencedor";
            }
            else if (button4.Text == Player2 && button5.Text == Player2 && button6.Text == Player2)
            {
                textBox4.Text = "USER 2 Vencedor";
            }
            else if (button7.Text == Player2 && button8.Text == Player2 && button9.Text == Player2)
            {
                textBox4.Text = "USER 2 Vencedor";
            }

            if (button1.Text == Player1 && button6.Text == Player1 && button9.Text == Player1)
            {
                textBox4.Text = "USER 1 Vencedor";
            }
            else if (button2.Text == Player1 && button5.Text == Player1 && button8.Text == Player1)
            {
                textBox4.Text = "USER 1 Vencedor";
            }
            else if (button7.Text == Player1 && button3.Text == Player1 && button4.Text == Player1)
            {
                textBox4.Text = "USER 1 Vencedor";
            }

            if (button1.Text == Player2 && button6.Text == Player2 && button9.Text == Player2)
            {
                textBox4.Text = "USER 2 Vencedor";
            }
            else if (button2.Text == Player2 && button5.Text == Player2 && button8.Text == Player2)
            {
                textBox4.Text = "USER 2 Vencedor";
            }
            else if (button7.Text == Player2 && button3.Text == Player2 && button4.Text == Player2)
            {
                textBox4.Text = "USER 2 Vencedor";
            }

            if (button1.Text == Player1 && button5.Text == Player1 && button7.Text == Player1)
            {
                textBox4.Text = "USER 1 Vencedor";
            }
            else if (button3.Text == Player1 && button5.Text == Player1 && button9.Text == Player1)
            {
                textBox4.Text = "USER 1 Vencedor";
            }

            if (button1.Text == Player2 && button5.Text == Player2 && button7.Text == Player2)
            {
                textBox4.Text = "USER 2 Vencedor";
            }
            else if (button3.Text == Player1 && button5.Text == Player2 && button9.Text == Player2)
            {
                textBox4.Text = "USER 2 Vencedor";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int vNum = Convert.ToInt16(textBox2.Text);

            string Player1 = textBox1.Text;
            Player1 = "X";

            string Player2 = textBox3.Text;
            Player2 = "O";

            if (button8.Text != "")
            {
                textBox4.Text = "Escolha outro";
            }
           else if (vez == true)
            {
                button8.Text = Player1;
                vez = false;
                textBox2.Text = (vNum + 1).ToString();
                textBox4.Text = "USER 2 a jogar";
            }

            else if (vez == false)
            {
                button8.Text = Player2;
                vez = true;
                textBox2.Text = (vNum + 1).ToString();
                textBox4.Text = "USER 1 a jogar";
            }

            if (button1.Text == Player1 && button2.Text == Player1 && button3.Text == Player1)
            {
                textBox4.Text = "USER 1 Vencedor";
            }
            else if (button4.Text == Player1 && button5.Text == Player1 && button6.Text == Player1)
            {
                textBox4.Text = "USER 1 Vencedor";
            }
            else if (button7.Text == Player1 && button8.Text == Player1 && button9.Text == Player1)
            {
                textBox4.Text = "USER 1 Vencedor";
            }

            if (button1.Text == Player2 && button2.Text == Player2 && button3.Text == Player2)
            {
                textBox4.Text = "USER 2 Vencedor";
            }
            else if (button4.Text == Player2 && button5.Text == Player2 && button6.Text == Player2)
            {
                textBox4.Text = "USER 2 Vencedor";
            }
            else if (button7.Text == Player2 && button8.Text == Player2 && button9.Text == Player2)
            {
                textBox4.Text = "USER 2 Vencedor";
            }

            if (button1.Text == Player1 && button6.Text == Player1 && button9.Text == Player1)
            {
                textBox4.Text = "USER 1 Vencedor";
            }
            else if (button2.Text == Player1 && button5.Text == Player1 && button8.Text == Player1)
            {
                textBox4.Text = "USER 1 Vencedor";
            }
            else if (button7.Text == Player1 && button3.Text == Player1 && button4.Text == Player1)
            {
                textBox4.Text = "USER 1 Vencedor";
            }

            if (button1.Text == Player2 && button6.Text == Player2 && button9.Text == Player2)
            {
                textBox4.Text = "USER 2 Vencedor";
            }
            else if (button2.Text == Player2 && button5.Text == Player2 && button8.Text == Player2)
            {
                textBox4.Text = "USER 2 Vencedor";
            }
            else if (button7.Text == Player2 && button3.Text == Player2 && button4.Text == Player2)
            {
                textBox4.Text = "USER 2 Vencedor";
            }

            if (button1.Text == Player1 && button5.Text == Player1 && button7.Text == Player1)
            {
                textBox4.Text = "USER 1 Vencedor";
            }
            else if (button3.Text == Player1 && button5.Text == Player1 && button9.Text == Player1)
            {
                textBox4.Text = "USER 1 Vencedor";
            }

            if (button1.Text == Player2 && button5.Text == Player2 && button7.Text == Player2)
            {
                textBox4.Text = "USER 2 Vencedor";
            }
            else if (button3.Text == Player1 && button5.Text == Player2 && button9.Text == Player2)
            {
                textBox4.Text = "USER 2 Vencedor";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int vNum = Convert.ToInt16(textBox2.Text);

            string Player1 = textBox1.Text;
            Player1 = "X";

            string Player2 = textBox3.Text;
            Player2 = "O";

            if (button7.Text != "")
            {
                textBox4.Text = "Escolha outro";
            }
           else if (vez == true)
            {
                button7.Text = Player1;
                vez = false;
                textBox2.Text = (vNum + 1).ToString();
                textBox4.Text = "USER 2 a jogar";
            }

            else if (vez == false)
            {
                button7.Text = Player2;
                vez = true;
                textBox2.Text = (vNum + 1).ToString();
                textBox4.Text = "USER 1 a jogar";
            }

            if (button1.Text == Player1 && button2.Text == Player1 && button3.Text == Player1)
            {
                textBox4.Text = "USER 1 Vencedor";
            }
            else if (button4.Text == Player1 && button5.Text == Player1 && button6.Text == Player1)
            {
                textBox4.Text = "USER 1 Vencedor";
            }
            else if (button7.Text == Player1 && button8.Text == Player1 && button9.Text == Player1)
            {
                textBox4.Text = "USER 1 Vencedor";
            }

            if (button1.Text == Player2 && button2.Text == Player2 && button3.Text == Player2)
            {
                textBox4.Text = "USER 2 Vencedor";
            }
            else if (button4.Text == Player2 && button5.Text == Player2 && button6.Text == Player2)
            {
                textBox4.Text = "USER 2 Vencedor";
            }
            else if (button7.Text == Player2 && button8.Text == Player2 && button9.Text == Player2)
            {
                textBox4.Text = "USER 2 Vencedor";
            }

            if (button1.Text == Player1 && button6.Text == Player1 && button9.Text == Player1)
            {
                textBox4.Text = "USER 1 Vencedor";
            }
            else if (button2.Text == Player1 && button5.Text == Player1 && button8.Text == Player1)
            {
                textBox4.Text = "USER 1 Vencedor";
            }
            else if (button7.Text == Player1 && button3.Text == Player1 && button4.Text == Player1)
            {
                textBox4.Text = "USER 1 Vencedor";
            }

            if (button1.Text == Player2 && button6.Text == Player2 && button9.Text == Player2)
            {
                textBox4.Text = "USER 2 Vencedor";
            }
            else if (button2.Text == Player2 && button5.Text == Player2 && button8.Text == Player2)
            {
                textBox4.Text = "USER 2 Vencedor";
            }
            else if (button7.Text == Player2 && button3.Text == Player2 && button4.Text == Player2)
            {
                textBox4.Text = "USER 2 Vencedor";
            }

            if (button1.Text == Player1 && button5.Text == Player1 && button7.Text == Player1)
            {
                textBox4.Text = "USER 1 Vencedor";
            }
            else if (button3.Text == Player1 && button5.Text == Player1 && button9.Text == Player1)
            {
                textBox4.Text = "USER 1 Vencedor";
            }

            if (button1.Text == Player2 && button5.Text == Player2 && button7.Text == Player2)
            {
                textBox4.Text = "USER 2 Vencedor";
            }
            else if (button3.Text == Player2 && button5.Text == Player2 && button9.Text == Player2)
            {
                textBox4.Text = "USER 2 Vencedor";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox2.Text = "0";
            textBox4.Text = "";
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            vez = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
