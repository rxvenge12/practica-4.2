using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica_4._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void tripleButton_Click(object sender, EventArgs e)
        {
            string inputString = inputTextBox.Text;
            string characterInput = charTextBox.Text;

            // Проверяем, что введен символ
            if (!string.IsNullOrEmpty(characterInput) && characterInput.Length == 1)
            {
                char characterToTriple = characterInput[0];

                // Вариант 1: Используя Replace
                string result1 = TripleOccurrences(inputString, characterToTriple);
                resultTextBox1.Text = result1;

                // Вариант 2: Используя StringBuilder
                string result2 = TripleOccurrencesStringBuilder(inputString, characterToTriple);
                resultTextBox2.Text = result2;
            }
            else
            {
                MessageBox.Show("Введите один символ для утроения.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private string TripleOccurrences(string input, char character)
        {
            // Заменяем каждое вхождение символа C на три его копии
            return input.Replace(character.ToString(), new string(character, 3));
        }

        private string TripleOccurrencesStringBuilder(string input, char character)
        {
            // Используем StringBuilder для изменения строки
            StringBuilder result = new StringBuilder(input);
            for (int i = 0; i < result.Length; i++)
            {
                if (result[i] == character)
                {
                    result.Insert(i + 1, new string(character, 2)); // Вставляем две копии символа после текущего вхождения
                    i += 2; // Пропускаем вставленные символы
                }
            }
            return result.ToString();
        }
    }
}