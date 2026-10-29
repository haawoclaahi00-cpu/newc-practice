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

namespace File_Handling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
           
            try
            {
                using (StreamWriter outputfile =
                    File.CreateText(txtFileName.Text))
                {
                    outputfile.WriteLine("Welcome to CA244");
                    outputfile.WriteLine("Jamhuriya University");
                    outputfile.WriteLine("File Handling");
                }

                MessageBox.Show("File created successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReadToEnd_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader Input_file =
                    File.OpenText(txtFileName.Text))
                {
                    txtOutput.Text = Input_file.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            
            try
            {
                using (StreamWriter outputfile =
                    File.CreateText(txtFileName.Text))
                {
                    outputfile.WriteLine("Welcome to My First File");
                    outputfile.WriteLine("My Name is Haawa");
                    outputfile.WriteLine("I am an IT Student");
                }

                MessageBox.Show("File written successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
          
            try
            {
                if (File.Exists(txtFileName.Text))
                {
                    File.Delete(txtFileName.Text);

                    txtOutput.Clear();

                    MessageBox.Show("File deleted successfully!");
                }
                else
                {
                    MessageBox.Show("File does not exist!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    }
    
