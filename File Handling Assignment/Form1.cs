using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Handling_Assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {

            string data =
                "Name: " + txtName.Text + Environment.NewLine +
                "Age: " + txtAge.Text + Environment.NewLine +
                "Class: " + txtClass.Text;

            // Save student information
            File.WriteAllText("Student.txt", data);

            // Reading using ReadBlock()
            using (StreamReader reader =
                   File.OpenText("Student.txt"))
            {
                char[] buffer = new char[1024];

                int count = reader.ReadBlock(buffer, 0, buffer.Length);

                string result = new string(buffer, 0, count);

                lstResult.Items.Clear();

                foreach (string line in
                         result.Split(new[] { Environment.NewLine },
                         StringSplitOptions.None))
                {
                    lstResult.Items.Add(line);
                }
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (File.Exists("Student.txt"))
            {
                File.Delete("Student.txt");

                txtName.Clear();
                txtAge.Clear();
                txtClass.Clear();

                lstResult.Items.Clear();

                MessageBox.Show("File Deleted Successfully");
            }
            else
            {
                MessageBox.Show("File Not Found");
            }
        }

    }
}
