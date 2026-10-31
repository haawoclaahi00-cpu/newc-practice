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

namespace file_Handling_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            SaveFileDialog save = new SaveFileDialog();

            save.Filter = "Text Files|*.txt";

            if (save.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllLines(
                    save.FileName,
                    listBox1.Items.Cast<string>()
                );

                MessageBox.Show("Saved Successfully");
            }
        }
        

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();

            open.Filter = "Text Files|*.txt";

            if (open.ShowDialog() == DialogResult.OK)
            {
                listBox1.Items.Clear();

                string[] lines = File.ReadAllLines(open.FileName);

                listBox1.Items.AddRange(lines);
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
          
            if (listBox1.SelectedItem != null)
            {
                txtInput.Text = listBox1.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Please select an item");
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            if (txtInput.Text != "")
            {
                listBox1.Items.Add(txtInput.Text);

                txtInput.Clear();
            }
            else
            {
                MessageBox.Show("Enter some text");
            }
        }

        private void btnDeleteOne_Click(object sender, EventArgs e)
        {
          
            if (listBox1.SelectedIndex != -1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Select an item to delete");
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
          
            listBox1.Items.Clear();
        }
    }
    }
    
    
    
    

