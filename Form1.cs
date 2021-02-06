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

        private void bt_Click(object sender, EventArgs e)
        {
            var fd = new OpenFileDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                string file = fd.FileName;
                try
                {
                    StreamReader sr = new StreamReader(file);
                    string line;
                    bool f = true;
                    while((line = sr.ReadLine()) != null)
                    {
                        string[] sl = line.Split(',');
                        if (f == true)
                        {
                            data.ColumnCount = sl.Length;
                            f = false;
                        }else data.Rows.Add(sl);
                    }
                }
                catch(IOException)
                {

                }
            }

        }
        private void cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Hola");
        }
    }

}
