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

namespace Project12
{
    public partial class Form1 : Form
    {
        const int MAX = 10;
        int count = 0;
        string inputLine = "";
        Employee[] info = new Employee[MAX];
        public Form1()
        {
            InitializeComponent();


        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kyle Gray\nCS 1400\nProject #12");
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog file = new OpenFileDialog();
            file.InitialDirectory = "c:\\";
            file.Filter = "text files (*.txt)|*txt";
            if (file.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = file.OpenFile()) != null)
                {
                    StreamReader data = new StreamReader(myStream);
                }
            }



            for (int i = 0; i < MAX; i++)
            {
                do
                {
                    if (inputLine != null)
                    {
                        temp
                    }

                } while (inputLine != null);





        }
    }
}
