using System;

using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Tic_Tac_Tao
{
    public partial class fivegrid : Form
    {

       
        private bool player;
        private int[,] grid = new int[5,5];
        public fivegrid()
        {
            InitializeComponent();
            Guna2Button[,] buttons =
            {
                { t00, t01, t02, t03, t04 },
                { t10, t11, t12, t13, t14 },
                { t20, t21, t22, t23, t24 },
                { t30, t31, t32, t33, t34 },
                { t40, t41, t42, t43, t44 },
            
            };
           
        }

private void controlWinner(int x,int y,Guna2Button b){


}



    private void ResetFun()
    {
      
        Guna2Button[,] buttons = new Guna2Button[,]
        {
            { t00, t01, t02, t03, t04 },
            { t10, t11, t12, t13, t14 },
            { t20, t21, t22, t23, t24 },
            { t30, t31, t32, t33, t34 },
            { t40, t41, t42, t43, t44 },
            
        };
        
        foreach (Guna2Button button in buttons)
        {
            button.Text=string.Empty;
            button.Enabled = true;
        }

        for (int i = 0; i < grid.GetLength(0); i++) 
        {
            for (int j = 0; j < grid.GetLength(1); j++) 
            {
                grid[i, j] = 0;
            }
        }

           
        wining.Text = @"Won";
    }

    
   private void t00_Click(object sender, EventArgs e)
        {
            controlWinner(0,0,t00);
        }
   
        private void t01_Click(object sender, EventArgs e)
        {
            controlWinner(0,1,t01);
        }


        private void t02_Click(object sender, EventArgs e)
        {
            controlWinner(0,2,t02);
        }

        private void t03_Click_1(object sender, EventArgs e)
        {
            controlWinner(0,3,t03);
        }

        private void t04_Click(object sender, EventArgs e)
        {
             controlWinner(0,4,t04);
        }

  

        private void reset_Click_1(object sender, EventArgs e)
        {
            ResetFun();
        }

        private void t10_Click(object sender, EventArgs e)
        {
            
        }
    }
}