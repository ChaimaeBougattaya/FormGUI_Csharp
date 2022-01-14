using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            String gender="",ville,langage="";

            if (radioBtnMale.Checked == true)
                gender = "Monsieur";
            else if(radioBtnFemale.Checked == true)
                gender = "Madame";

            if (checkBox1.Checked == true)
                langage += "C++   |";
            if (checkBox2.Checked == true)
                langage += "C#   |";
            if (checkBox3.Checked == true)
                langage += "VS   |";
            if (checkBox4.Checked == true)
                langage += "R   |";

            ville = CBcountry.Text.ToString();
           
            MessageBox.Show(gender + " " +textBox1.Text + " " + textBox2.Text +" "+textBox3.Text +" ans"
                
                +"\nVous etes de "+textBox4.Text + "  à "+ville
                +"\n Vous avez choisi :  "+langage);
        }
    }
}
