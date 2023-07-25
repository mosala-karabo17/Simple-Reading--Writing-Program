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

namespace ReadAndWriteGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader sr = new StreamReader("test.txt"))
                {
                    while (!sr.EndOfStream)
                    {
                        richTextBox1.AppendText(sr.ReadLine());
                    }

                    sr.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter sw = new StreamWriter("test.txt",true);
                sw.WriteLine(richTextBox1.Text);


                sw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
               
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
    }
}
