using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prumer
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
        }
        double meziVypocet = 0;
        int pocetCisel = 0;
        private void vysledekBtn_Click(object sender, EventArgs e)
        {
            meziVypocet = meziVypocet + Convert.ToDouble(textBoxCislo.Text);
            pocetCisel++;
            textBoxCislo.Text = Convert.ToString(meziVypocet / pocetCisel);
            meziVypocet = 0;
            pocetCisel = 0;
        }

        private void addNumberBtn_Click(object sender, EventArgs e)
        {
            meziVypocet = meziVypocet + Convert.ToDouble(textBoxCislo.Text);
            pocetCisel++;
            textBoxCislo.Text = null;
        }
    }
}
