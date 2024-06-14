using LB1_tprtbor.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LB1_tprtbor
{
    public class TestFile : ICreateTestFile
    {
        private static TestFile instance;
        private TestFile() { } // Приватный конструктор

        public static TestFile GetInstance()
        {
            if (instance == null)
            {
                instance = new TestFile();
            }
            return instance;
        }

        public void SaveDimensionsToFile(int columns, int rows, int gipCount, int alternativeCount)
        {
            string filePath = "D:\\Tests\\Tests.txt"; // Укажите путь к файлу, куда вы хотите сохранить

            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    // Записываем в первую строку значения columns и rows
                    writer.WriteLine($"{columns} {rows}");
                    // Записываем во вторую строку значения gipCount и alternativeCount
                    writer.WriteLine($"{gipCount} {alternativeCount}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при записі у файл: {ex.Message}");
            }
        }
    }
}
