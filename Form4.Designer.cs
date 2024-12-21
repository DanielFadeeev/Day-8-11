namespace DAYS_8_11
{
    partial class Form4
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
            this.btnCodes = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(53, 39);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(456, 16);
            this.lblDescription.TabIndex = 15;
            this.lblDescription.Text = "Введите строку, чтобы узнать коды первого и последнего символов";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(53, 193);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 16);
            this.lblResult.TabIndex = 14;
            // 
            // btnCodes
            // 
            this.btnCodes.Location = new System.Drawing.Point(56, 138);
            this.btnCodes.Name = "btnCodes";
            this.btnCodes.Size = new System.Drawing.Size(101, 32);
            this.btnCodes.TabIndex = 13;
            this.btnCodes.Text = "Выполнить";
            this.btnCodes.UseVisualStyleBackColor = true;
            this.btnCodes.Click += new System.EventHandler(this.btnCodes_Click);
            // 
            // txtInput
            // 
            this.txtInput.BackColor = System.Drawing.Color.White;
            this.txtInput.ForeColor = System.Drawing.Color.Black;
            this.txtInput.Location = new System.Drawing.Point(56, 94);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(208, 22);
            this.txtInput.TabIndex = 12;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(547, 249);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCodes);
            this.Controls.Add(this.txtInput);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form4";
            this.Text = "Задание 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnCodes;
        private System.Windows.Forms.TextBox txtInput;
    }
}