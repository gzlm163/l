using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            string[] lastNames = { "Иванов", "Петров", "Сидоров", "Кузнецов", "Смирнов",
                       "Попов", "Лебедев", "Козлов", "Новиков", "Морозов",
                       "Соколов", "Михайлов", "Фёдоров", "Андреев", "Алексеев",
                       "Макаров", "Никитин", "Захаров", "Егоров", "Павлов" };

            string[] firstNames = { "Иван", "Пётр", "Сидор", "Кузьма", "Семён",
                        "Алексей", "Дмитрий", "Максим", "Егор", "Артём",
                        "Николай", "Сергей", "Андрей", "Владимир", "Олег",
                        "Павел", "Роман", "Денис", "Кирилл", "Тимур" };

            Random random = new Random();
            List<string> lines = new List<string>();
            lines.Add("Фамилия,Имя,Школа,Оценка1,Оценка2");

            for (int studentIndex = 0; studentIndex < 50; studentIndex++)
            {
                string lastName = lastNames[random.Next(lastNames.Length)];
                string firstName = firstNames[random.Next(firstNames.Length)];
                int schoolNumber = random.Next(1, 6);
                int gradeFirst = random.Next(2, 6);
                int gradeSecond = random.Next(2, 6);

                lines.Add($"{lastName},{firstName},{schoolNumber},{gradeFirst},{gradeSecond}");
            }

            File.WriteAllLines("schoolchildren.csv", lines);
            MessageBox.Show("Данные сохранены в schoolchildren.csv");
        }

        private void buttonShowBest_Click(object sender, EventArgs e)
        {
            listBoxResult.Items.Clear();

            if (!File.Exists("schoolchildren.csv"))
            {
                MessageBox.Show("Файл не найден. Сначала сгенерируйте данные.");
                return;
            }

            string[] lines = File.ReadAllLines("schoolchildren.csv");
            lines = lines.Skip(1).ToArray();

            for (int schoolNumber = 1; schoolNumber <= 5; schoolNumber++)
            {
                string bestStudentName = "";
                int bestSum = -1;

                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length < 5) continue;

                    string lastName = parts[0];
                    string firstName = parts[1];
                    int school = int.Parse(parts[2]);
                    int gradeFirst = int.Parse(parts[3]);
                    int gradeSecond = int.Parse(parts[4]);

                    if (school == schoolNumber)
                    {
                        int sum = gradeFirst + gradeSecond;
                        if (sum > bestSum)
                        {
                            bestSum = sum;
                            bestStudentName = $"{lastName} {firstName}";
                        }
                    }
                }

                if (bestStudentName != "")
                    listBoxResult.Items.Add($"Школа {schoolNumber}: {bestStudentName} (сумма {bestSum})");
                else
                    listBoxResult.Items.Add($"Школа {schoolNumber}: нет данных");
            }
        }
    }
}
