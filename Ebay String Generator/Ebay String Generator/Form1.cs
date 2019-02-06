using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ebay_String_Generator
{
    public partial class Title_Output : Form
    {
        public Title_Output()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String part1 = "";
            String name = Name.Text;
            if (checkBox1.Checked == true)
                name = name + " GX";
            if (checkBox2.Checked == true)
                name = name + " FA";
            part1 = "Pokemon " + Set.Text + "-" + name + "-" + Number.Text + "-";


            String rarity = radioButton1.Text;
            if (radioButton2.Checked == true)
            { rarity = radioButton2.Text; }
            if (radioButton3.Checked == true)
            { rarity = radioButton3.Text; }
            if (radioButton4.Checked == true)
            { rarity = radioButton4.Text; }
            if (radioButton5.Checked == true)
            { rarity = radioButton5.Text; }

            String foil = "";
            if (radioButton6.Checked == true)
            { foil = radioButton6.Text; }
            if (radioButton7.Checked == true)
            { foil = radioButton7.Text; }

            String end = "";
            if (Amount.Text == "1" || Amount.Text == "")
            { end = "NM"; }
            else
            { end = "NM " + Amount.Text + " Cards"; }
            Title_Output2.Text = part1 + rarity +" " + foil + " " + end;

            Description_Output.Text = Amount.Text + " " + rarity + " " + foil + " "+ name + ", " + Number.Text + ", " + Set.Text + "\n\nNever Been Played, Card Went Straight from the Pack into a Sleeve\nNear Mint Cards, Double Sleeved with Penny Sleeves and Hard Sleeve";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Set.Text = "";
            Name.Text = "";
            Number.Text = "";
            Amount.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
        }
    }
}
