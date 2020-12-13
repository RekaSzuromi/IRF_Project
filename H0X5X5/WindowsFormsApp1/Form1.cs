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
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        BindingList<data> Rates = new BindingList<data>();

        public Form1()
        {
            InitializeComponent();

            dataGridView1.DataSource = Rates;

            //chartRateData.DataSource = Rates;

            IList<int> honapList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            listBox1.DataSource = honapList;

            DataOnChart();

            ReadData();

            szures();

            
        }
        public void szures()
        {
            var szurtadatok = (from x in Rates
                               where x.Date.Year > 2019
                                  && x.Date.Month > Convert.ToInt32(listBox1.SelectedItem)
                               select x)
                            .ToList();
            chartRateData.DataSource = szurtadatok;

            data elsoadat = szurtadatok[0];
            data utolsoadat = szurtadatok[szurtadatok.Count - 1];
            labelKulonbseg.Text = (Math.Round((utolsoadat.Close - elsoadat.Open), 2, MidpointRounding.AwayFromZero)).ToString();
            labelHanyados.Text = (Math.Round(((utolsoadat.Close * 100) / elsoadat.Open), 2, MidpointRounding.AwayFromZero)).ToString();

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

        private void DataOnChart()
        {


            var series = chartRateData.Series[0];
            series.ChartType = SeriesChartType.Line;
            series.XValueMember = "Date";
            series.YValueMembers = "Close";
            series.BorderWidth = 2;

            var legend = chartRateData.Legends[0];
            legend.Enabled = false;

            var chartArea = chartRateData.ChartAreas[0];
            chartArea.AxisX.MajorGrid.Enabled = false;
            chartArea.AxisY.MajorGrid.Enabled = false;
            chartArea.AxisY.IsStartedFromZero = false;

        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            szures();
            chartRateData.DataBind();
        }

       

        private void Form1_Paint_1(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Entities.Division div = new Entities.Division();
            div.DrawImage(g);
            Entities.Substraction ext = new Entities.Substraction();
            ext.DrawImage(g);
        }

        

    }
}
