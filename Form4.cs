using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAYS_8_11
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnCodes_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text; // Читаем строку

            if (input.Length > 0)          // Проверяем, что строка не пустая
            {
                int firstCode = input[0];  // Код первого символа
                int lastCode = input[input.Length - 1]; // Код последнего символа

                lblResult.Text = "Код первого: " + firstCode + ", последнего: " + lastCode;
            }
            else
            {
                lblResult.Text = "Строка пустая!"; // Если строка пустая
            }
        }
    }
}
