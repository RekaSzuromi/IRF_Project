using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        BindingList<data> Rates = new BindingList<data>();

        public Form1()
        {
            InitializeComponent();
        }

        private void ReadData()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader sr = new StreamReader(ofd.FileName, Encoding.Default))
                {
                    sr.ReadLine(); // Remove headers
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(',');

                        data d = new data();
                        d.Date = Convert.ToDateTime(line[0]);
                        d.Open = Convert.ToDouble(line[1]);
                        d.High = Convert.ToDouble(line[2]);
                        d.Low = Convert.ToDouble(line[3]);
                        d.Close = Convert.ToDouble(line[4]);
                        d.Volume = Convert.ToInt32(line[6]);
                        Rates.Add(d);
                    }
                }

            }

        }




        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
