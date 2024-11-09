using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;
namespace Tic_Tac_Tao
{
    public partial class Form1 : Form
    {
        bool _player1Turn = true;
        private int _p1;
        private int _p2;
        private int _draw;
        public Form1()
        {
            InitializeComponent();
        }

        private void reset_Click(object sender, EventArgs e)
        {
                  ResetFun();
                 wining.Text = "";
                 whowon.Text = "";
        }
        private void ResetFun()
        {
            t9.Text = string.Empty;
            t8.Text = string.Empty;
            t7.Text = string.Empty;
            t1.Text = string.Empty;
            t2.Text = string.Empty;
            t3.Text = string.Empty;
            t6.Text = string.Empty;
            t5.Text = string.Empty;
            t4.Text = string.Empty;
            t1.Enabled = true;
            t2.Enabled = true;
            t3.Enabled = true;
            t6.Enabled = true;
            t5.Enabled = true;
            t4.Enabled = true;
            t9.Enabled = true;
            t8.Enabled = true;
            t7.Enabled = true;
           
            wining.Text = @"Won";
            wining.ForeColor = Color.DeepSkyBlue;
        }
        private void ButtonsLogic(Guna2Button b)
        {   
            Turns(b);
            Controler();
        IsItDraw();
           
        }
        private void Turns(Guna2Button b)
        {
            if (_player1Turn)
            { 
                b.Text = @"X";
                labelX.Text = @"O";
                b.ForeColor=Color.Crimson;
                labelX.ForeColor=Color.Indigo;
                _player1Turn = false;
                b.DisabledState.ForeColor=Color.Crimson;

            }
            else
            {
                labelX.Text = @"X";
                b.Text = @"O";
                b.ForeColor=Color.Indigo;
                labelX.ForeColor=Color.Crimson;
                _player1Turn = true;
                b.DisabledState.ForeColor=Color.Indigo;

               
            }
            b.DisabledState.FillColor = Color.FromArgb(84,84,84);
            b.Enabled=false;
             
        }

        private void Controler()
        {
            
            if ((t1.Text == t2.Text && t2.Text == t3.Text && t1.Text != "")||
                (t4.Text == t5.Text && t5.Text == t6.Text && t4.Text != "")||
                (t7.Text == t8.Text && t8.Text == t9.Text && t7.Text != "")||
                (t1.Text == t4.Text && t4.Text == t7.Text && t1.Text != "")||
                (t2.Text == t5.Text && t5.Text == t8.Text && t2.Text != "")||
                (t3.Text == t6.Text && t6.Text == t9.Text && t3.Text != "")||
                (t1.Text == t5.Text && t5.Text == t9.Text && t1.Text != "")||
                (t3.Text == t5.Text && t5.Text == t7.Text && t3.Text != ""))
            {
                wining.Text = @"Won";
                wining.ForeColor = Color.DeepSkyBlue;
            
                if (_player1Turn)
                {
                   ResetFun();
                    _p2++;
                    lbp2.Text = _p2.ToString();
                    whowon.Visible = true;
                    whowon.Text = @"O";
                    whowon.ForeColor=Color.Indigo;
                }
                else
                {
                    ResetFun();
                    _p1++;
                    lbp1.Text = _p1.ToString();
                    whowon.Visible = true;
                    whowon.Text = @"X";
                    whowon.ForeColor=Color.Crimson;
                }
                ResetFun();
              
            }
        }

        private void t1_Click(object sender, EventArgs e)
        {
            ButtonsLogic(t1);
        }

        private void t2_Click(object sender, EventArgs e)
        {
            ButtonsLogic(t2);

        }

        private void t3_Click(object sender, EventArgs e)
        {
            ButtonsLogic(t3);

        }

       

        private void t5_Click(object sender, EventArgs e)
        {
            ButtonsLogic(t5);

        }


        private void t6_Click(object sender, EventArgs e)
        {
            ButtonsLogic(t6);

        }

     
        private void t8_Click(object sender, EventArgs e)
        {
            ButtonsLogic(t8);

        }


        private void t4_Click_1(object sender, EventArgs e)
        {
            ButtonsLogic(t4);
        }

        private void t9_Click_1(object sender, EventArgs e)
        {
            ButtonsLogic(t9);
        }

        private void t7_Click_1(object sender, EventArgs e)
        {
            ButtonsLogic(t7);
        }

        private void IsItDraw()
        {
            if (t1.Text != "" && t2.Text != "" && t3.Text != "" &&
                t4.Text != "" && t5.Text != "" && t6.Text != "" &&
                t7.Text != "" && t8.Text != "" && t9.Text != "")
            {
                ResetFun();
                _draw++;
                label3.Text = _draw.ToString();
                whowon.Visible = false;
                wining.Text = @"Draw";
                wining.ForeColor = Color.DarkGray;
            }
        }
        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label7_MouseEnter(object sender, EventArgs e)
        {
            label7.ForeColor=Color.Red;
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            label7.ForeColor=Color.Brown;
        }
    }
}
