namespace 축산_프로젝트
{
    partial class FanMotor
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
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel24 = new System.Windows.Forms.Panel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.panel21 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel15.Controls.Add(this.panel24);
            this.panel15.Controls.Add(this.panel19);
            this.panel15.Controls.Add(this.panel21);
            this.panel15.Location = new System.Drawing.Point(12, 12);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(124, 246);
            this.panel15.TabIndex = 11;
            // 
            // panel24
            // 
            this.panel24.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel24.Location = new System.Drawing.Point(20, 172);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(79, 54);
            this.panel24.TabIndex = 5;
            // 
            // panel19
            // 
            this.panel19.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel19.Location = new System.Drawing.Point(20, 96);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(79, 54);
            this.panel19.TabIndex = 2;
            // 
            // panel21
            // 
            this.panel21.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel21.Location = new System.Drawing.Point(20, 21);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(79, 54);
            this.panel21.TabIndex = 0;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(158, 149);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(550, 426);
            this.chart1.TabIndex = 12;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(745, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 28);
            this.label1.TabIndex = 13;
            this.label1.Text = "산 날짜";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(745, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 28);
            this.label2.TabIndex = 14;
            this.label2.Text = "고장 이력";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(745, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 28);
            this.label3.TabIndex = 15;
            this.label3.Text = "A/S 기간";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(335, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 28);
            this.label7.TabIndex = 19;
            this.label7.Text = "누적그래프";
            // 
            // FanMotor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 649);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel15);
            this.Name = "FanMotor";
            this.Text = "FanMotor";
            this.Load += new System.EventHandler(this.FanMotor_Load);
            this.panel15.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel24;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
    }
}