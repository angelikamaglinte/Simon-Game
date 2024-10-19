using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1_SimonGame
{
    public partial class InstructionsForm : Form
    {
        public InstructionsForm()
        {

            InitializeComponent();

            lblInstructions.Text = "Welcome to Simon Game!\n\n" +
                               "Instructions:\n" +
                               "1. Observe the sequence of colors shown.\n" +
                               "2. Click on the colors in the same order.\n" +
                               "3. If you make a mistake, the game will end.\n" +
                               "4. Try to achieve the highest score possible!\n" +
                               "5. Top 3 High Scores will be displayed in the Score board\n\n" +
                               "Good luck!";
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
