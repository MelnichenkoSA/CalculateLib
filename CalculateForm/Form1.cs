using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void EpsLabel_Click(object sender, EventArgs e)
        {

        }

        private void FunctionLabel_Click(object sender, EventArgs e)
        {

        }

        private void XLabel_Click(object sender, EventArgs e)
        {

        }

        private void ResultBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void XBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EpsBox_TextChanged(object sender, EventArgs e)
        {

        }

        private List<double> ResultButton_Click(object sender, EventArgs e)
        {
            return CalculateLib.Calculations.CalculateSumSeries(double.Parse(XBox.Text), double.Parse(EpsBox.Text));
        }
    }
}
