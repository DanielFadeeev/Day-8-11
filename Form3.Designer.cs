namespace DAYS_8_11
{
    partial class Form3
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
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnReverse = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(66, 61);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(211, 16);
            this.lblDescription.TabIndex = 11;
            this.lblDescription.Text = "Введите строку для разворота";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(66, 215);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 16);
            this.lblResult.TabIndex = 10;
            // 
            // btnReverse
            // 
            this.btnReverse.Location = new System.Drawing.Point(69, 160);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(101, 32);
            this.btnReverse.TabIndex = 9;
            this.btnReverse.Text = "Выполнить";
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtInput
            // 
            this.txtInput.BackColor = System.Drawing.Color.White;
            this.txtInput.ForeColor = System.Drawing.Color.Black;
            this.txtInput.Location = new System.Drawing.Point(69, 116);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(208, 22);
            this.txtInput.TabIndex = 7;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(368, 308);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnReverse);
            this.Controls.Add(this.txtInput);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form3";
            this.Text = "Задание 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.TextBox txtInput;
    }
}