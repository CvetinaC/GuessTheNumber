using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessTheNumber
{
    public partial class MainForm : Form
    {
        int counter = 0;
        public MainForm()
        {
            InitializeComponent();
        }


        private void btnPlay_Click(object sender, EventArgs e)
        {
            lblRandom.ResetText();
            comboBoxLevels.SelectedItem = null;
            tbChoose.ResetText();
            pbResult.Image = null;
            pbUpOrDown.Image = null;
            lblTries.ResetText();
            counter = 0;
        }

        private void comboBoxLevels_SelectedIndexChanged(object sender, EventArgs e)
        {
            Random rand = new Random();

            if (comboBoxLevels.SelectedIndex == 0)
            {
                lblRandom.Text = rand.Next(1, 10).ToString();
            }
            else if (comboBoxLevels.SelectedIndex == 1)
            {
                lblRandom.Text = rand.Next(1, 50).ToString();
            }
            else if (comboBoxLevels.SelectedIndex == 2)
            {
                lblRandom.Text = rand.Next(1, 100).ToString();
            }
            else if (comboBoxLevels.SelectedIndex == 3)
            {
                lblRandom.Text = rand.Next(1, 1000).ToString();
            }


        }

        

       
        private void btnCompare_Click(object sender, EventArgs e)
        {   
            if (comboBoxLevels.SelectedItem == null)
            {
                MessageBox.Show("Въведи ниво!");
                return;
            }
            else if (tbChoose.Text == string.Empty)
            {
                MessageBox.Show("Въведи число!!");
                return;
            }
            else
            {
                try
                {
                    if (double.Parse(lblRandom.Text) < double.Parse(tbChoose.Text))
                    {
                        pbUpOrDown.Image = Properties.Resources.arrow_39658_640;
                    }
                    else if (double.Parse(lblRandom.Text) > double.Parse(tbChoose.Text))
                    {
                        pbUpOrDown.Image = Properties.Resources.up_39637__340;
                    }
                    else
                    {
                        pbUpOrDown.Image = null;
                        if (counter < 10)
                            pbResult.Image = Properties.Resources.thumb_up_terminator_pablo_M_R;
                        else
                            pbResult.Image = Properties.Resources.ArnoldThumbsDown;
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Въведете число!");
                    return;
                }
                counter++;
                lblTries.Text = counter.ToString();
            }
            
        }

        private void lblTries_Click(object sender, EventArgs e)
        {
            
        }
    }
}
