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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;  // Читаем строку
            string result = "";            // Переменная для результата

            for (int i = input.Length - 1; i >= 0; i--) // Проходим строку с конца
            {
                result += input[i];        // Добавляем символы в обратном порядке
            }

            lblResult.Text = "Результат: " + result;
        }
    }
}
