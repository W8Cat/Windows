namespace PrintPagesCalculator
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbSheets = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.num2 = new System.Windows.Forms.NumericUpDown();
            this.btCalculate = new System.Windows.Forms.Button();
            this.cbDirect = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.num1 = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbSheets);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tb2);
            this.panel1.Controls.Add(this.tb1);
            this.panel1.Location = new System.Drawing.Point(10, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 89);
            this.panel1.TabIndex = 19;
            // 
            // lbSheets
            // 
            this.lbSheets.AutoSize = true;
            this.lbSheets.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSheets.Location = new System.Drawing.Point(116, 6);
            this.lbSheets.Name = "lbSheets";
            this.lbSheets.Size = new System.Drawing.Size(19, 18);
            this.lbSheets.TabIndex = 17;
            this.lbSheets.Text = "X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Paper Sheets to use:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Second pack";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "First pack";
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(85, 62);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(258, 20);
            this.tb2.TabIndex = 13;
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(85, 35);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(258, 20);
            this.tb1.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Fill with page";
            // 
            // num2
            // 
            this.num2.Location = new System.Drawing.Point(88, 70);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(37, 20);
            this.num2.TabIndex = 17;
            // 
            // btCalculate
            // 
            this.btCalculate.Location = new System.Drawing.Point(174, 12);
            this.btCalculate.Name = "btCalculate";
            this.btCalculate.Size = new System.Drawing.Size(179, 23);
            this.btCalculate.TabIndex = 16;
            this.btCalculate.Text = "Get Pages sequence";
            this.btCalculate.UseVisualStyleBackColor = true;
            this.btCalculate.Click += new System.EventHandler(this.btCalculate_Click);
            // 
            // cbDirect
            // 
            this.cbDirect.AutoSize = true;
            this.cbDirect.Checked = true;
            this.cbDirect.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDirect.Location = new System.Drawing.Point(14, 47);
            this.cbDirect.Name = "cbDirect";
            this.cbDirect.Size = new System.Drawing.Size(95, 17);
            this.cbDirect.TabIndex = 15;
            this.cbDirect.Text = "Direct (Ink Jet)";
            this.cbDirect.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Booklet pages:";
            // 
            // num1
            // 
            this.num1.Location = new System.Drawing.Point(95, 15);
            this.num1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(58, 20);
            this.num1.TabIndex = 13;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 199);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.btCalculate);
            this.Controls.Add(this.cbDirect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.num1);
            this.Name = "MainForm";
            this.Text = "Printing book pages calculator v0.4";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbSheets;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown num2;
        private System.Windows.Forms.Button btCalculate;
        private System.Windows.Forms.CheckBox cbDirect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown num1;
    }
}

