namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartRateData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelHanyados = new System.Windows.Forms.Label();
            this.labelKulonbseg = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.buttonAlkalmaz = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartRateData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // chartRateData
            // 
            chartArea1.Name = "ChartArea1";
            this.chartRateData.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartRateData.Legends.Add(legend1);
            this.chartRateData.Location = new System.Drawing.Point(12, 97);
            this.chartRateData.Name = "chartRateData";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartRateData.Series.Add(series1);
            this.chartRateData.Size = new System.Drawing.Size(352, 263);
            this.chartRateData.TabIndex = 0;
            this.chartRateData.Text = "chart1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(370, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(418, 263);
            this.dataGridView1.TabIndex = 1;
            // 
            // labelHanyados
            // 
            this.labelHanyados.AutoSize = true;
            this.labelHanyados.BackColor = System.Drawing.SystemColors.Info;
            this.labelHanyados.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHanyados.ForeColor = System.Drawing.Color.Green;
            this.labelHanyados.Location = new System.Drawing.Point(116, 48);
            this.labelHanyados.Name = "labelHanyados";
            this.labelHanyados.Size = new System.Drawing.Size(101, 25);
            this.labelHanyados.TabIndex = 2;
            this.labelHanyados.Text = "Hanyados";
            // 
            // labelKulonbseg
            // 
            this.labelKulonbseg.AutoSize = true;
            this.labelKulonbseg.BackColor = System.Drawing.SystemColors.Info;
            this.labelKulonbseg.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKulonbseg.ForeColor = System.Drawing.Color.Green;
            this.labelKulonbseg.Location = new System.Drawing.Point(476, 48);
            this.labelKulonbseg.Name = "labelKulonbseg";
            this.labelKulonbseg.Size = new System.Drawing.Size(107, 25);
            this.labelKulonbseg.TabIndex = 3;
            this.labelKulonbseg.Text = "Kulonbseg";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "2020 hanyadik hónapjától?";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Honeydew;
            this.listBox1.Font = new System.Drawing.Font("Myanmar Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Location = new System.Drawing.Point(283, 382);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 46);
            this.listBox1.TabIndex = 5;
            // 
            // buttonAlkalmaz
            // 
            this.buttonAlkalmaz.BackColor = System.Drawing.Color.Green;
            this.buttonAlkalmaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlkalmaz.ForeColor = System.Drawing.Color.White;
            this.buttonAlkalmaz.Location = new System.Drawing.Point(438, 393);
            this.buttonAlkalmaz.Name = "buttonAlkalmaz";
            this.buttonAlkalmaz.Size = new System.Drawing.Size(102, 33);
            this.buttonAlkalmaz.TabIndex = 6;
            this.buttonAlkalmaz.Text = "Alkalmaz";
            this.buttonAlkalmaz.UseVisualStyleBackColor = false;
            this.buttonAlkalmaz.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(116, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Százalékos változás a kijelől időszakban:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(478, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Záróárfolyam változásának mértéke:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(212, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(549, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "$";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAlkalmaz);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelKulonbseg);
            this.Controls.Add(this.labelHanyados);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chartRateData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint_1);
            ((System.ComponentModel.ISupportInitialize)(this.chartRateData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartRateData;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelHanyados;
        private System.Windows.Forms.Label labelKulonbseg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button buttonAlkalmaz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

