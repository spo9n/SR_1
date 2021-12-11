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

namespace SR1_Surgai_P81
{
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>();

        public Form1()
        {
            InitializeComponent();
        }

        private void закритиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void AddButton_Click(object sender, EventArgs e)
        {
            bool flag = true;

            foreach (int mark in Array.ConvertAll(marksTextBox.Text.Split(','), int.Parse))
            {
                if (mark < 2 || mark > 12)
                {
                    flag = false;
                    MessageBox.Show("Помилка! Діапазон оцінок 2 - 12 балів.");
                }
            }
            if (flag)
            {
                Student student = new Student(fullNameTextBox.Text, Int32.Parse(yearOfBirthTextBox.Text), Int32.Parse(groupNumberTextBox.Text), Array.ConvertAll(marksTextBox.Text.Split(','), int.Parse));

                students.Add(student);

                MessageBox.Show("Запис успішно додано!");

                dataGridView.Rows.Add(fullNameTextBox.Text, yearOfBirthTextBox.Text, groupNumberTextBox.Text, student.getMarks()[0], student.getMarks()[1], student.getMarks()[2], student.getMarks()[3], student.getAverageMark().ToString());

                fullNameTextBox.Clear();
                yearOfBirthTextBox.Clear();
                groupNumberTextBox.Clear();
                marksTextBox.Clear();
            }
        }

        private void taskSolutionButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                if (Convert.ToInt32(dataGridView.Rows[i].Cells[3].Value) == 8 & Convert.ToInt32(dataGridView.Rows[i].Cells[4].Value) == 9)
                {
                    dataGridView.Rows[i].Visible = true;
                }
                else
                {
                    dataGridView.Rows[i].Visible = false;
                }
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView.Rows.Count; i++)
            {
                dataGridView.Rows[i].Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ToolTip t = new ToolTip();
            t.SetToolTip(taskSolutionButton, "Студенти з оцінкою 8 по фізиці та оцінкою 9 з математики.");
        }
    }
}