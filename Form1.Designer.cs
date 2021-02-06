namespace municipios
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
            this.bt = new System.Windows.Forms.Button();
            this.cb = new System.Windows.Forms.ComboBox();
            this.data = new System.Windows.Forms.DataGridView();
            this.pie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pie)).BeginInit();
            this.SuspendLayout();
            // 
            // bt
            // 
            this.bt.Location = new System.Drawing.Point(347, 11);
            this.bt.Margin = new System.Windows.Forms.Padding(2);
            this.bt.Name = "bt";
            this.bt.Size = new System.Drawing.Size(71, 29);
            this.bt.TabIndex = 0;
            this.bt.Text = "File upload";
            this.bt.UseVisualStyleBackColor = true;
            this.bt.Click += new System.EventHandler(this.bt_Click);
            // 
            // cb
            // 
            this.cb.FormattingEnabled = true;
            this.cb.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.cb.Location = new System.Drawing.Point(23, 48);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(121, 21);
            this.cb.TabIndex = 1;
            this.cb.Text = "Letter";
            this.cb.SelectedIndexChanged += new System.EventHandler(this.cb_SelectedIndexChanged);
            // 
            // data
            // 
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Location = new System.Drawing.Point(12, 75);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(517, 276);
            this.data.TabIndex = 2;
            // 
            // pie
            // 
            chartArea1.Name = "ChartArea1";
            this.pie.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.pie.Legends.Add(legend1);
            this.pie.Location = new System.Drawing.Point(553, 75);
            this.pie.Name = "pie";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.pie.Series.Add(series1);
            this.pie.Size = new System.Drawing.Size(246, 258);
            this.pie.TabIndex = 3;
            this.pie.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(811, 375);
            this.Controls.Add(this.pie);
            this.Controls.Add(this.data);
            this.Controls.Add(this.cb);
            this.Controls.Add(this.bt);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt;
        private System.Windows.Forms.ComboBox cb;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.DataVisualization.Charting.Chart pie;
    }
}

