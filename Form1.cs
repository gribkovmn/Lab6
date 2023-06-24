using System.Linq;

namespace Lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int[] initialArr = new int[20];
        private int[] sortedArr = new int[20];

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Одномерные массивы";
        }

        private void fill(int[] arr, TextBox obj)
        {
            // Заполнение текстбокса содержимым массива
            obj.Text = "";
            for(int i = 0; i < arr.Length; i++)
            {
                obj.AppendText($"arr[{i}] = {arr[i]}{Environment.NewLine}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            textBox1.Text = ""; // Очистка
            for(int i = 0; i < initialArr.Length; i++)
            {
                initialArr[i] = random.Next(-50, 50);
            }
            this.fill(initialArr, textBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int maxValue = initialArr.Max();
            int maxValueIndex = initialArr.ToList().IndexOf(maxValue);
            this.sortedArr = (int[])initialArr.Clone();
            int firstValue = initialArr[0];
            this.sortedArr[maxValueIndex] = firstValue;
            this.sortedArr[0] = maxValue;
            this.label1.Text = $"Описание: Поменяли местами {maxValueIndex + 1} элемент c 1м";
            this.fill(this.sortedArr, textBox2);

        }
    }
}