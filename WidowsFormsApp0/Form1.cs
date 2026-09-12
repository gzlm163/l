using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WidowsFormsApp0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Font baseFont = richTextBoxResult.Font;

            richTextBoxResult.SelectionCharOffset = 0;
            richTextBoxResult.SelectionFont = baseFont;
            richTextBoxResult.AppendText("t");

            richTextBoxResult.SelectionCharOffset = -5;
            richTextBoxResult.SelectionFont = new Font(baseFont.FontFamily, baseFont.Size * 0.7f);
            richTextBoxResult.AppendText("общ");

            richTextBoxResult.SelectionCharOffset = 0;
            richTextBoxResult.SelectionFont = baseFont;
            richTextBoxResult.AppendText(" = s / v + t      ");

            richTextBoxResult.AppendText("v");

            richTextBoxResult.SelectionCharOffset = -5;
            richTextBoxResult.SelectionFont = new Font(baseFont.FontFamily, baseFont.Size * 0.7f);
            richTextBoxResult.AppendText("ср");

            richTextBoxResult.SelectionCharOffset = 0;
            richTextBoxResult.SelectionFont = baseFont;
            richTextBoxResult.AppendText(" = s / (s / v + t)");

            richTextBoxTime.SelectionCharOffset = 0;
            richTextBoxTime.SelectionFont = baseFont;
            richTextBoxTime.AppendText("t");

            richTextBoxTime.SelectionCharOffset = -5;
            richTextBoxTime.SelectionFont = new Font(baseFont.FontFamily, baseFont.Size * 0.7f);
            richTextBoxTime.AppendText("общ");

            richTextBoxTime.SelectionCharOffset = 0;
            richTextBoxTime.SelectionFont = baseFont;
            richTextBoxTime.AppendText(" = ");

            richTextBoxSpeed.SelectionCharOffset = 0;
            richTextBoxSpeed.SelectionFont = baseFont;
            richTextBoxSpeed.AppendText("v");

            richTextBoxSpeed.SelectionCharOffset = -5;
            richTextBoxSpeed.SelectionFont = new Font(baseFont.FontFamily, baseFont.Size * 0.7f);
            richTextBoxSpeed.AppendText("ср");

            richTextBoxSpeed.SelectionCharOffset = 0;
            richTextBoxSpeed.SelectionFont = baseFont;
            richTextBoxSpeed.AppendText(" = ");
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            if (textBoxDistance.Text == "" || textBoxSpeed.Text == "" || textBoxTime.Text == "" ||
                !double.TryParse(textBoxDistance.Text, out double s) ||
                !double.TryParse(textBoxSpeed.Text, out double v) ||
                !double.TryParse(textBoxTime.Text, out double t))
            {
                MessageBox.Show("Некорректный ввод. Заполните все поля числами.", "Ошибка");
                return;
            }

            if (s < 0 || v <= 0 || t < 0)
            {
                MessageBox.Show("Некорректный ввод. Проверьте значения.", "Ошибка");
                return;
            }

            double tO = s / v + t;
            double vSr = s / tO;

            textBoxAnswerTime.Text = tO.ToString("F2");
            textBoxAnswerSpeed.Text = vSr.ToString("F2");
        }
    }
}
