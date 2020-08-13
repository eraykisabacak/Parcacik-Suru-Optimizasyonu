namespace _173311068_pso
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
            this.label1 = new System.Windows.Forms.Label();
            this.nudParcacik = new System.Windows.Forms.NumericUpDown();
            this.nudJenerasyon = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nudC1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudC2 = new System.Windows.Forms.NumericUpDown();
            this.label = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudParcacik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudJenerasyon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudC1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudC2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Parçacık Sayısı :";
            // 
            // nudParcacik
            // 
            this.nudParcacik.Location = new System.Drawing.Point(185, 30);
            this.nudParcacik.Name = "nudParcacik";
            this.nudParcacik.Size = new System.Drawing.Size(161, 26);
            this.nudParcacik.TabIndex = 1;
            this.nudParcacik.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // nudJenerasyon
            // 
            this.nudJenerasyon.Location = new System.Drawing.Point(185, 72);
            this.nudJenerasyon.Name = "nudJenerasyon";
            this.nudJenerasyon.Size = new System.Drawing.Size(161, 26);
            this.nudJenerasyon.TabIndex = 3;
            this.nudJenerasyon.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Jenerasyon Sayısı :";
            // 
            // nudC1
            // 
            this.nudC1.Location = new System.Drawing.Point(185, 116);
            this.nudC1.Name = "nudC1";
            this.nudC1.Size = new System.Drawing.Size(161, 26);
            this.nudC1.TabIndex = 5;
            this.nudC1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "C1 : ";
            // 
            // nudC2
            // 
            this.nudC2.Location = new System.Drawing.Point(185, 159);
            this.nudC2.Name = "nudC2";
            this.nudC2.Size = new System.Drawing.Size(161, 26);
            this.nudC2.TabIndex = 7;
            this.nudC2.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(138, 161);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(41, 20);
            this.label.TabIndex = 6;
            this.label.Text = "C2 : ";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(204, 205);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(117, 41);
            this.btnHesapla.TabIndex = 8;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(389, 30);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Uygunluk";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(598, 427);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(76, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Uygunluk Değeri";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 603);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.nudC2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.nudC1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudJenerasyon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudParcacik);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Parçacık Sürü Optimizasyonu - Ali Eray KISABACAK ";
            ((System.ComponentModel.ISupportInitialize)(this.nudParcacik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudJenerasyon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudC1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudC2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudParcacik;
        private System.Windows.Forms.NumericUpDown nudJenerasyon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudC1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudC2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

