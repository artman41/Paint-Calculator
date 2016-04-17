using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint_Calculator {
    public partial class Form1 : Form {

        public Form1() {

            FileHandling.LoadColours();

            ColourValues.ChosenColour = ColourValues.Colours.ElementAt(0);

            InitializeComponent();
        }

        private void setToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBoxSetPrice.Show();
        }

        private void addColourToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBoxAddColour.Show();
        }

        private void colourToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBoxChooseColour.Show();
        }

        private void textBox1_Click(object sender, EventArgs e) {
            this.textBox1.Clear();
        }

        private void buttonCalculate_Click(object sender, EventArgs e) {
            if (!(this.textBox1.Text == "Input the Area!")) {
                try {

                    String[] s = this.textBox1.Text.Split("£".ToCharArray());

                    if(s.Length == 2) {
                        this.textBox1.Text = "£" + (int.Parse(s[1]) * ColourValues.ChosenColour.Price).ToString();
                    } else {
                        this.textBox1.Text = "£" + (int.Parse(s[0]) * ColourValues.ChosenColour.Price).ToString();
                    }
                } catch(Exception ex) {

                }
            }
        }

        private void Form1_FormClosed(object sender, EventArgs e) {
            FileHandling.WriteColours(ColourValues.Colours.ToArray());
        }
    }
}
