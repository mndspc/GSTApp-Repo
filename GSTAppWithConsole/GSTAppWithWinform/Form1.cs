using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GST;
namespace GSTAppWithWinform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double proAmt =Convert.ToDouble( textBox1.Text);
            double gstPer = Convert.ToDouble(textBox2.Text);
            GSTCalc gSTCalc = new GSTCalc(proAmt, gstPer);
            double result = gSTCalc.AmtIncludingGst();
            MessageBox.Show(string.Format("Product Amount is:{0}",result));
        }
    }
}
