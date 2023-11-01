using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AI_Translator
{
    public partial class OnScreenKeyboard : Form
    {
        DataHandler dataSet;
        private mainForm parent;
        bool caps = false;
        bool alt = false;

        public OnScreenKeyboard(mainForm mainForm)
        {
            InitializeComponent();
            keyAssigment();
            parent = mainForm;
        }
        private void keyAssigment()
        {
            if ( comboBox1.SelectedIndex==0)        //Buttons mapping
            {
                if (caps == false && alt == false) { button27.Text = "й"; }else if(caps==true && alt==false) { button27.Text = "Й"; } else if (caps==false&&alt==true) { button27.Text = "й"; } else { button27.Text = "Й"; }
                if (caps == false && alt == false) { button26.Text = "ц"; } else if (caps == true && alt == false) { button26.Text = "Ц"; } else if (caps == false && alt == true) { button26.Text = "ц"; } else { button26.Text = "Ц"; }














            }
            else if ( comboBox1.SelectedIndex==1)
            {
                button27.Text = "q";

            }
        }
        private void OnScreenKeyboard_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }





        // ================================= KEYS ASSIGMENTS ================================= //
        private void button40_Click(object sender, EventArgs e)
        {
            parent.inputBox.Text += button40.Text;
        }
        private void button27_Click(object sender, EventArgs e)
        {
            parent.inputBox.Text += button27.Text;
        }
        private void button26_Click(object sender, EventArgs e)
        {
            parent.inputBox.Text += button26.Text;
        }




        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            keyAssigment();
        }






        // ============================================= MODIFIER KEYS ===================================================================== //
        private void button2_Click(object sender, EventArgs e)
        {
            switch(caps)
            {
                case true:
                    caps = false;
                    button2.BackColor = default;
                break;
                case false:
                    caps = true;
                    button2.BackColor = Color.White;
                break;
            }
            keyAssigment();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            switch (alt)
            {
                case true:
                    alt = false;
                    button1.BackColor = default;
                break;
                case false:
                    alt = true;
                    button1.BackColor = Color.White;
                break;
            }
            keyAssigment();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            parent.translateButton_Click(sender, e);
        }

        // ============================================= END OF MODIFIER KEYS ============================================================== //

    }
}
