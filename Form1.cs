using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace municipios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var fd = new OpenFileDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                string file = fd.FileName;
                try
                {
                    string txt = File.ReadAllText(file);
                    var sr = new StreamReader(file);
                    string line;
                    while((line = sr.ReadLine()) != null)
                    {
                        string[] sl = line.Split(',');
                    }
                }
                catch(IOException)
                {

                }
            }

        }
    }

    

}
