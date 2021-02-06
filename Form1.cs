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
        private DataTable dt = new DataTable();

        private void bt_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
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
                            for(int i = 0; i < sl.Length; i++)
                            {
                                dt.Columns.Add(sl[i]);
                            }
                            f = false;
                        }else dt.Rows.Add(sl);
                    }
                    data.DataSource = dt;
                }
                catch(IOException)
                {

                }
            }

        }
        private void cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt.DefaultView.RowFilter = string.Format("Convert([{0}], 'System.String') LIKE '{1}*'", "Nombre Municipio", cb.Text);
        }
    }

}
