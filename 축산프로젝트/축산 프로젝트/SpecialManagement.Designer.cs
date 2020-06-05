namespace 축산_프로젝트
{
    partial class Special_management
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
            this.panel36 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.panel39 = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.panel40 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.panel31 = new System.Windows.Forms.Panel();
            this.lvData = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel36.SuspendLayout();
            this.panel39.SuspendLayout();
            this.panel40.SuspendLayout();
            this.panel31.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel36
            // 
            this.panel36.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel36.Controls.Add(this.label16);
            this.panel36.Location = new System.Drawing.Point(180, 9);
            this.panel36.Name = "panel36";
            this.panel36.Size = new System.Drawing.Size(79, 54);
            this.panel36.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(14, 18);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 15);
            this.label16.TabIndex = 12;
            this.label16.Text = "송아지";
            // 
            // panel39
            // 
            this.panel39.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel39.Controls.Add(this.label20);
            this.panel39.Location = new System.Drawing.Point(95, 9);
            this.panel39.Name = "panel39";
            this.panel39.Size = new System.Drawing.Size(79, 54);
            this.panel39.TabIndex = 1;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(14, 18);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(52, 15);
            this.label20.TabIndex = 10;
            this.label20.Text = "병든소";
            // 
            // panel40
            // 
            this.panel40.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel40.Controls.Add(this.label21);
            this.panel40.Location = new System.Drawing.Point(10, 9);
            this.panel40.Name = "panel40";
            this.panel40.Size = new System.Drawing.Size(79, 54);
            this.panel40.TabIndex = 0;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(14, 18);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(52, 15);
            this.label21.TabIndex = 11;
            this.label21.Text = "임신소";
            // 
            // panel31
            // 
            this.panel31.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel31.Controls.Add(this.panel36);
            this.panel31.Controls.Add(this.panel39);
            this.panel31.Controls.Add(this.panel40);
            this.panel31.Location = new System.Drawing.Point(12, 3);
            this.panel31.Name = "panel31";
            this.panel31.Size = new System.Drawing.Size(270, 73);
            this.panel31.TabIndex = 12;
            // 
            // lvData
            // 
            this.lvData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lvData.FullRowSelect = true;
            this.lvData.GridLines = true;
            this.lvData.HideSelection = false;
            this.lvData.Location = new System.Drawing.Point(3, 93);
            this.lvData.Name = "lvData";
            this.lvData.Size = new System.Drawing.Size(562, 470);
            this.lvData.TabIndex = 50;
            this.lvData.UseCompatibleStateImageBehavior = false;
            this.lvData.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 106;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Gender";
            this.columnHeader2.Width = 67;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "혈통";
            this.columnHeader3.Width = 88;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "생년월일";
            this.columnHeader4.Width = 147;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "체중";
            this.columnHeader5.Width = 64;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "분류";
            this.columnHeader6.Width = 63;
            // 
            // Special_management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 757);
            this.Controls.Add(this.lvData);
            this.Controls.Add(this.panel31);
            this.Name = "Special_management";
            this.Text = "Special_management";
            this.panel36.ResumeLayout(false);
            this.panel36.PerformLayout();
            this.panel39.ResumeLayout(false);
            this.panel39.PerformLayout();
            this.panel40.ResumeLayout(false);
            this.panel40.PerformLayout();
            this.panel31.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel36;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel39;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Panel panel40;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Panel panel31;
        private System.Windows.Forms.ListView lvData;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}