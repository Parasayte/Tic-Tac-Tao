using System;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Tic_Tac_Tao
{
    public partial class sevengrid : Form
    {
        private bool _player1Turn;


        public sevengrid()
        {   
            InitializeComponent();
           
           Guna2Button[,] grid = 
                                {
                                    { n00, n01, n02, n03, n04, n05, n06 },
                                    { n10, n11, n12, n13, n14, n15, n16 },
                                    { n20, n21, n22, n23, n24, n25, n26 },
                                    { n30, n31, n32, n33, n34, n35, n36 },
                                    { n40, n41, n42, n43, n44, n45, n46 },
                                    { n50, n51, n52, n53, n54, n55, n56 },
                                    { n60, n61, n62, n63, n64, n65, n66 }
                                };

        
        }
        private void ResetFun()
        {
              
            Guna2Button[,] grid = 
            {
                { n00, n01, n02, n03, n04, n05, n06 },
                { n10, n11, n12, n13, n14, n15, n16 },
                { n20, n21, n22, n23, n24, n25, n26 },
                { n30, n31, n32, n33, n34, n35, n36 },
                { n40, n41, n42, n43, n44, n45, n46 },
                { n50, n51, n52, n53, n54, n55, n56 },
                { n60, n61, n62, n63, n64, n65, n66 }
            };
            foreach (Guna2Button button in grid)
            {
                button.Text=string.Empty;
                button.Enabled = true;
            }
           
            wining.Text = @"Won";
            wining.ForeColor = Color.DeepSkyBlue;
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

       
        private void n00_Click_1(object sender, EventArgs e)
        {
            Turns(n00);
        }

        private void guna2Button29_Click(object sender, EventArgs e)
        {
            ResetFun();
        }

        private void n01_Click(object sender, EventArgs e)
        {
              Turns(n01);
        }
    }
}