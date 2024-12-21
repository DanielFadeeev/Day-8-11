namespace DAYS_8_11
{
    partial class Form2
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
            this.numLength = new System.Windows.Forms.NumericUpDown();
            this.txtC1 = new System.Windows.Forms.TextBox();
            this.txtC2 = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numLength)).BeginInit();
            this.SuspendLayout();
            // 
            // numLength
            // 
            this.numLength.BackColor = System.Drawing.Color.White;
            this.numLength.ForeColor = System.Drawing.Color.Black;
            this.numLength.Location = new System.Drawing.Point(124, 175);
            this.numLength.Name = "numLength";
            this.numLength.Size = new System.Drawing.Size(120, 22);
            this.numLength.TabIndex = 0;
            // 
            // txtC1
            // 
            this.txtC1.BackColor = System.Drawing.Color.White;
            this.txtC1.ForeColor = System.Drawing.Color.Black;
            this.txtC1.Location = new System.Drawing.Point(124, 223);
            this.txtC1.Name = "txtC1";
            this.txtC1.Size = new System.Drawing.Size(120, 22);
            this.txtC1.TabIndex = 1;
            // 
            // txtC2
            // 
            this.txtC2.BackColor = System.Drawing.Color.White;
            this.txtC2.ForeColor = System.Drawing.Color.Black;
            this.txtC2.Location = new System.Drawing.Point(124, 269);
            this.txtC2.Name = "txtC2";
            this.txtC2.Size = new System.Drawing.Size(120, 22);
            this.txtC2.TabIndex = 2;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(124, 315);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(101, 32);
            this.btnGenerate.TabIndex = 3;
            this.btnGenerate.Text = "Выполнить";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(121, 370);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 16);
            this.lblResult.TabIndex = 4;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(121, 133);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(287, 16);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "Введите длину строки (N), символы C1 и C2";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(496, 424);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtC2);
            this.Controls.Add(this.txtC1);
            this.Controls.Add(this.numLength);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form2";
            this.Text = "Задание 1";
            ((System.ComponentModel.ISupportInitialize)(this.numLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numLength;
        private System.Windows.Forms.TextBox txtC1;
        private System.Windows.Forms.TextBox txtC2;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblDescription;
    }
}