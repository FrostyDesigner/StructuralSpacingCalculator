namespace SpacingCalculator
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtNumPanels = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGapWidth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTotalWidth = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPanelWidth = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalGapWidth = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(197, 152);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Do Stuff";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // txtNumPanels
            // 
            this.txtNumPanels.Location = new System.Drawing.Point(12, 153);
            this.txtNumPanels.Name = "txtNumPanels";
            this.txtNumPanels.Size = new System.Drawing.Size(160, 20);
            this.txtNumPanels.TabIndex = 1;
            this.txtNumPanels.Text = "20";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number of Panels";
            // 
            // txtGapWidth
            // 
            this.txtGapWidth.Location = new System.Drawing.Point(12, 89);
            this.txtGapWidth.Name = "txtGapWidth";
            this.txtGapWidth.Size = new System.Drawing.Size(160, 20);
            this.txtGapWidth.TabIndex = 1;
            this.txtGapWidth.Text = ".5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gap Width";
            // 
            // txtTotalWidth
            // 
            this.txtTotalWidth.Location = new System.Drawing.Point(12, 32);
            this.txtTotalWidth.Name = "txtTotalWidth";
            this.txtTotalWidth.Size = new System.Drawing.Size(160, 20);
            this.txtTotalWidth.TabIndex = 1;
            this.txtTotalWidth.Text = "100";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Length";
            // 
            // txtPanelWidth
            // 
            this.txtPanelWidth.Location = new System.Drawing.Point(12, 292);
            this.txtPanelWidth.Name = "txtPanelWidth";
            this.txtPanelWidth.Size = new System.Drawing.Size(160, 20);
            this.txtPanelWidth.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Total Gap Width";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Panel Width";
            // 
            // txtTotalGapWidth
            // 
            this.txtTotalGapWidth.Location = new System.Drawing.Point(12, 227);
            this.txtTotalGapWidth.Name = "txtTotalGapWidth";
            this.txtTotalGapWidth.Size = new System.Drawing.Size(160, 20);
            this.txtTotalGapWidth.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 353);
            this.Controls.Add(this.txtTotalGapWidth);
            this.Controls.Add(this.txtPanelWidth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTotalWidth);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGapWidth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumPanels);
            this.Controls.Add(this.btnCalculate);
            this.Name = "Form1";
            this.Text = "Spacing Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtNumPanels;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGapWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTotalWidth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPanelWidth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotalGapWidth;
    }
}

