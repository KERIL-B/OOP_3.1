using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingPieChart
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Random rand = new Random();
            List<double> list = new List<double>();

            for (int i = 0; i < 10; i++)
            {
                list.Add(rand.Next(20));
            }

            pieChartUC1.Create(list);
        }
    }
}
