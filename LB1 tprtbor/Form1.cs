using LB1_tprtbor.Interfaces; 
using System; 
using System.Collections.Generic; 
using System.Windows.Forms; 



namespace LB1_tprtbor

{

    public partial class Form1 : Form

    {

        private Alternative randomAlternative = new Alternative();

        private Combination combination = new Combination();

        private List<int[]> combinations = new List<int[]>();

        private TestFile testFile = TestFile.GetInstance();

        private IFileDimensionsSaver fileDimensionsSaver;



        private int cols;

        private int rows;



        public int alternativeCount;

        public int gipCount;


        int[][] critValues;
        string[] kArray;


        public Form1(int rows, int cols)

        {

            InitializeComponent();

        }

        public Form1()

        {

            InitializeComponent();

            fileDimensionsSaver = new TestFileAdapter(TestFile.GetInstance());

        }



        private void InitializeComponents()

        {

            dataGridView1.Columns.Clear();

            alternativeCount = 0;

            combinations.Clear();

            dataGridView1.ColumnCount = cols;



            for (int i = 0; i < cols; i++) dataGridView1.Columns[i].Name = $"Критерій {i + 1}";



            combination.GenerateCombinations(new int[0], cols, combinations);

            combination.DisplayBestAndWorstCombinations(cols, textBox1, textBox2);

            PopulateDataGridView();

            dataGridView1.AutoResizeColumns();



            fileDimensionsSaver.SaveDimensions(cols, rows - 1, gipCount, alternativeCount);

            randomAlternative.CompareAlternatives(randomAlternative.GenerateRandomAlternative(cols), combinations, cols, textBox3, textBox7, textBox6);

            randomAlternative.DisplayAlternativeCounts(cols, gipCount, alternativeCount, textBox5, textBox4);

        }



        private void PopulateDataGridView()

        {

            IIterator<int[]> iterator = new CombinationIterator(combinations);

            while (iterator.HasNext())

            {

                int[] combination = iterator.Next();

                string[] row = new string[cols];

                for (int j = 0; j < cols; j++)

                {

                    row[j] = $"k{j + 1}{combination[j]}";

                }

                dataGridView1.Rows.Add(row);

                alternativeCount++;



                if (dataGridView1.Rows.Count == rows)

                {

                    break;

                }

            }

            gipCount = (int)Math.Pow(3, cols);

        }



        private void button1_Click(object sender, EventArgs e)

        {

            if (!int.TryParse(textBox8.Text, out cols) || cols <= 0)

            {

                MessageBox.Show("Будь ласка, введіть коректне числове значення для кількості стовпців");

                return;

            }



            if (!int.TryParse(textBox11.Text, out rows) || rows <= 0)

            {

                MessageBox.Show("Будь ласка, введіть коректне числове значення для кількості рядків");

                return;

            }

        


            InitializeComponents();

        }

    }

}