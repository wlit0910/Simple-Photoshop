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

namespace Litowczenko_PIAO
{
    public partial class Histogram : Form
    {
        public Histogram()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        public void RysujHistogram(string tytul, string ox, Color color, string kod, int[] wartosci) // dane z Formularza 1
        {
            try
            {
                chart1.Series.Clear();


                chart1.ChartAreas[0].AxisX.ScaleView.Zoomable = true;
                chart1.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
                chart1.MouseWheel += Chart1_MouseWheel;


                Title tyt = chart1.Titles.Add(tytul);
                tyt.Font = new Font("Arial", 15, FontStyle.Bold); 

                chart1.ChartAreas[0].AxisX.Title = ox;
                chart1.ChartAreas[0].AxisX.TitleFont = new Font("Arial", 13, FontStyle.Bold);
                chart1.ChartAreas[0].AxisY.Title = "Liczba pikseli";
                chart1.ChartAreas[0].AxisY.TitleFont = new Font("Arial", 13, FontStyle.Bold);
                chart1.ChartAreas[0].AxisX.Maximum = 255;
                chart1.ChartAreas[0].AxisX.Minimum = 0;

                string[] linieR = new string[256];

                for (int i = 0; i < 256; i++)
                {

                    linieR[i] = i.ToString();
                    chart1.Series.Add(kod + linieR[i]);
                    chart1.Series[kod + linieR[i]].ChartType = SeriesChartType.Line;
                    chart1.Series[kod + linieR[i]].Color = color;
                    chart1.Series[kod + linieR[i]].Points.AddXY(i, wartosci[i]);
                    chart1.Series[kod + linieR[i]].Points.AddXY(i, 0);
                    chart1.Series[kod + linieR[i]].IsVisibleInLegend = false;
                }

            }
            catch
            {
                
            }
        }

        // skalowanie wykresu:		 
        // https://stackoverflow.com/questions/13584061/how-to-enable-zooming-in-microsoft-chart-control-by-using-mouse-wheel


        private void Chart1_MouseWheel(object sender, MouseEventArgs e)
        {
            try
            {
                var chart = (Chart)sender;
                var xAxis = chart.ChartAreas[0].AxisX;
                var yAxis = chart.ChartAreas[0].AxisY;

                if (e.Delta < 0) // Na dół
                {
                    try
                    {
                        xAxis.ScaleView.ZoomReset();
                        yAxis.ScaleView.ZoomReset();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Błąd. Treść błędu: \n" + ex.Message);
                    }

                }
                else if (e.Delta > 0) // Do góry
                {
                    var xMin = xAxis.ScaleView.ViewMinimum;
                    var xMax = xAxis.ScaleView.ViewMaximum;
                    var yMin = yAxis.ScaleView.ViewMinimum;
                    var yMax = yAxis.ScaleView.ViewMaximum;

                    var posXStart = xAxis.PixelPositionToValue(e.Location.X) - (xMax - xMin) / 4;
                    var posXFinish = xAxis.PixelPositionToValue(e.Location.X) + (xMax - xMin) / 4;
                    var posYStart = yAxis.PixelPositionToValue(e.Location.Y) - (yMax - yMin) / 4;
                    var posYFinish = yAxis.PixelPositionToValue(e.Location.Y) + (yMax - yMin) / 4;

                    xAxis.ScaleView.Zoom(posXStart, posXFinish);
                    yAxis.ScaleView.Zoom(posYStart, posYFinish);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd. Treść błędu: \n" + ex.Message);
            }
        }

    }
}
