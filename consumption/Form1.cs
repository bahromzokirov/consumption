using System;
using System.IO;
using System.Text;

namespace consumption
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            

        }
        private void button1_Click(object ? sender, EventArgs e)
        {
            try
            {
                string filePath = @"C:/consumption.txt";
                StreamWriter writer = new StreamWriter(filePath);
                using (writer)
                {
                    
                    writer.Write($"{comboBox1},{textBox1},{textBox2}");
                }

            }
            catch(Exception)
            {
                MessageBox.Show("Error");

            }


            //SaveFileDialog savefile = new SaveFileDialog();
            //savefile.DefaultExt = "consumption.txt"; 
            //savefile.Filter = "Test files|.txt";

            //if (savefile.ShowDialog() ==  DialogResult.OK )
            //{
            //    using (StreamWriter sw = new (savefile.FileName))
            //    {
            //        sw.WriteLine($"{dateTimePicker1.Value.ToShortDateString()}");
            //        sw.WriteLine($"Еда: { textBox1.Text} смн.");
            //        sw.WriteLine($"Проезд: {textBox2.Text} смн.");
            //        sw.WriteLine($"Интернет: {textBox3.Text}  смн.");
            //        sw.WriteLine($"Мобильная связь: {textBox4.Text}  смн.");
            //        sw.WriteLine($"Таблетки: {textBox5.Text} смн.");
            //        sw.Close();
            //    }
            //   }
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            //StreamReader sr = new StreamReader(@".\09.06.2022.txt");
            //string x = sr.ReadToEnd();
            //string[] y = x.Split('\n');
            //foreach(string s  in y)
            //{
            //    comboBox2.Items.Add(s); 
            //}

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
      
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}