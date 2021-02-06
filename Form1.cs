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
using System.Windows.Forms.DataVisualization.Charting;

namespace municipios
{
    public partial class Form1 : Form
    {
        string[,] municipios;

        public Form1()
        {
            InitializeComponent();
            municipios = new string[3, 2] { { "", "0"}, { "", "0" }, { "", "0" } };
            
        }

        //
        private DataTable dt = new DataTable();
        //

        private void contarTipoMunicipio(string tipoMunicipio)
        {
            bool encontrado = false;
            for(int i = 0; i< municipios.GetLength(0); i++)
            {
                if((municipios[i,0]).Equals(tipoMunicipio))
                {
                    municipios[i, 1] = Convert.ToString(Convert.ToInt32(municipios[i, 1]) + 1);
                    break;
                }
                else if ((municipios[i, 0]).Equals("") && !encontrado)
                {
                    municipios[i, 0] = tipoMunicipio;
                    municipios[i, 1] = "1";
                    break;
                }
            }
        }


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
                            for (int k = 0; k < sl.Length; k++)
                            {
                                dt.Columns.Add(sl[k]);
                            }
                            f = false;
                        }
                        else
                        {
                            dt.Rows.Add(sl);
                            contarTipoMunicipio(sl[(sl.Length - 1)]);
                        }
                    }
                    data.DataSource = dt;

                    //PIE CHART
                    /* string[] list = (from p in dt.AsEnumerable()
                                   orderby p.Field<string>("Tipo: Municipio / Isla / Ãrea no municipalizada") ascending
                                   select p.Field<string>("Tipo: Municipio / Isla / Ãrea no municipalizada")).ToArray();
                     string[] type = {  "Municipio",  "Isla",  "Ãrea no municipalizada"  };
                     int m=0, i=0, a=0;
                     for (int l=0;l<list.Length;l++)
                     {
                         if (list[l] == type[0]) m++;
                         else if (list[l] == type[1]) i++;
                         else a++;
                     }
                     pie.Series["s1"].Points.AddXY(type[0],  m);
                     pie.Series["s1"].Points.AddXY(type[1], i);
                     pie.Series["s1"].Points.AddXY(type[2], a);*/
                    //
                    
                    pie.Series.Clear();
                    pie.Legends.Clear();

                    //Add a new Legend(if needed) and do some formating
                    pie.Legends.Add("Tipo Municipio");
                    pie.Legends[0].LegendStyle = LegendStyle.Table;
                    pie.Legends[0].Docking = Docking.Bottom;
                    pie.Legends[0].Alignment = StringAlignment.Center;
                    pie.Legends[0].Title = "Tipos Municipios";
                    pie.Legends[0].BorderColor = Color.Black;

                    //Add a new chart-series
                    string seriesname = "Tipos Municipio";
                    pie.Series.Add(seriesname);
                    //set the chart-type to "Pie"
                    pie.Series[seriesname].ChartType = SeriesChartType.Pie;
                    pie.Series[seriesname]["PieLabelStyle"] = "Disabled";

                    //Add some datapoints so the series. in this case you can pass the values to this method
                    pie.Series[seriesname].Points.AddXY(municipios[0, 0], municipios[0, 1]);
                    pie.Series[seriesname].Points.AddXY(municipios[1, 0], municipios[1, 1]);
                    pie.Series[seriesname].Points.AddXY(municipios[2, 0], municipios[2, 1]);
                }
                catch(IOException)
                {

                }
            }
        }
        private void cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt.DefaultView.RowFilter = string.Format("Convert([{0}], 'System.String') LIKE '{1}*'", "Nombre Departamento", cb.Text);
        }
    }

}
