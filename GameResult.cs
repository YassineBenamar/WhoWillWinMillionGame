using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProject4
{
    public partial class GameResult : Form
    {
        public GameResult(string strGameOver,string strMoney)
        {
            InitializeComponent();
            lblResult.Text = strGameOver;
            lblMoney.Text = strMoney;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        public void lblResultColor()
        {

            if (lblResult.Text == "You Lose")
            {
                lblResult.ForeColor = Color.Red;
            }

            if (lblResult.Text== "You Win")
            {
                lblResult.ForeColor = Color.Green;
                
            }

        }

        private void GameResult_Load(object sender, EventArgs e)
        {
            lblResultColor();
        }
    }
}
