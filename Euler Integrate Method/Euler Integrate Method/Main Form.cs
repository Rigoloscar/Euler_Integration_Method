using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Classes;

namespace Euler_Integrate_Method
{
    public partial class Form1 : Form
    {
        Equation equation = new Equation();
        double precision = 0.003;
        double h;
        int NPoints;
        double Xo;
        double Yo;
        Color curveCol = Color.Red;
        Color pointCol= Color.Blue;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxH.Text = Convert.ToString(50*precision);
            textBoxP.Text = Convert.ToString(500);
            textBoxX.Text = Convert.ToString(0);
            textBoxY.Text = Convert.ToString(0);
            chart1.Series.Clear();
            chart1.Visible = true;
            checkBoxC.Checked = false;
            checkBoxE.Checked = true;
            panelP.BackColor = pointCol;
            panelC.BackColor = curveCol;
        }

        private void ComputeBtn_Click(object sender, EventArgs e)
        { 
            Series EqSerie = new Series("Aproximated integral");
            Series CurSerie = new Series("Aproximated curve");

            try 
            {
                this.h = Convert.ToDouble(textBoxH.Text);
                this.NPoints = Convert.ToInt32(textBoxP.Text);
                this.Xo = Convert.ToDouble(textBoxX.Text);
                this.Yo = Convert.ToDouble(textBoxY.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Format error");
                return;
            }
                
            equation.GetData(this.h, this.NPoints, this.Xo, this.Yo);
            equation.Compute();
            Pointt[] points = equation.ReturnData();

            for (int i = 0; i < this.NPoints; i++)
            {
                EqSerie.Points.AddXY(points[i].X, points[i].Y);
                CurSerie.Points.AddXY(points[i].X, points[i].Y);
            }

            EqSerie.ChartType = SeriesChartType.Point;
            CurSerie.ChartType = SeriesChartType.FastLine;
            chart1.Series.Clear();

            if (checkBoxC.Checked == true)
            {
                chart1.Series.Add(CurSerie);
                chart1.Series["Aproximated curve"].IsVisibleInLegend = false;
                chart1.Series["Aproximated curve"].Color = curveCol;
            }
            if (checkBoxE.Checked == true)
            {
                chart1.Series.Add(EqSerie);
                chart1.Series["Aproximated integral"].IsVisibleInLegend = false;
                chart1.Series["Aproximated integral"].Color = pointCol;
            }
            
            chart1.ChartAreas[0].AxisX.Title = "X axis";
            chart1.ChartAreas[0].AxisY.Title = "Y axis";
            chart1.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.LightGray;
        }

        private void trackBarH_Scroll(object sender, EventArgs e)
        {
            this.h = Convert.ToDouble(trackBarH.Value) * this.precision;
            textBoxH.Text = Convert.ToString(h);
        }

        private void trackBarP_Scroll(object sender, EventArgs e)
        {
            this.NPoints = Convert.ToInt32(trackBarP.Value);
            textBoxP.Text = Convert.ToString(this.NPoints);
        }

        private void panelP_Click(object sender, EventArgs e)
        {
            colorDialog2.ShowDialog();
            
            if (colorDialog2.Color != null)
            {
                this.pointCol = colorDialog2.Color;
                panelP.BackColor = colorDialog2.Color;
            }
        }

        private void panelC_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();

            if (colorDialog1.Color != null)
            {
                this.curveCol = colorDialog1.Color;
                panelC.BackColor = colorDialog1.Color;
            }
        }
    }
}
