using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Litowczenko_PIAO
{
    public partial class DaneStatystyczne : Form
    {
        public DaneStatystyczne()
        {
            InitializeComponent();
        }

        private void DaneStatystyczne_Load(object sender, EventArgs e)
        {
            
        }


        public void PobierzDaneStatystyczne(string tytuł,double min, double max, double srednia, double mediana, double odchylenie)
        {
            richTextBox1.AppendText("\n");
            richTextBox1.AppendText("\t\tDane dla: " + tytuł + "\n");
            richTextBox1.AppendText("\n\n");
            richTextBox1.AppendText("Minimalna wartość: " + min.ToString() + "\n\n");
            richTextBox1.AppendText("Średnia wartość: " + srednia.ToString() + "\n\n");
            richTextBox1.AppendText("Maksymalna wartość: " + max.ToString() + "\n\n");
            richTextBox1.AppendText("Mediana: " + mediana.ToString() + "\n\n");
            richTextBox1.AppendText("Odchylenie standardowe: " + odchylenie.ToString() + "\n\n");

        }
    }
}
