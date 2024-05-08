using System;
using System.Net.NetworkInformation;
using System.Windows.Forms.DataVisualization.Charting;


namespace Litowczenko_PIAO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        System.Drawing.Color kolorRGB = new System.Drawing.Color();
        public int[] tablica = new int[256];

        bool sprawdzCzySzarosc = false;
        bool sprawdzCzyKolor = false;

        public Bitmap skalaSzarosci;


        private void button1_Click(object sender, EventArgs e) // zak³adka ÆW1
        {
            OpenFileDialog
            openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png) | *.jpg; *.jpeg: *.gif; *.bmp; *.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void button2_Click(object sender, EventArgs e) // zak³adka ÆW1
        {
            if (pictureBox1.Image != null)
            {
                Bitmap oryginalne = new Bitmap(pictureBox1.Image);
                Bitmap skalaSzarosci = DoSkaliSzarosci(oryginalne);
                pictureBox1.Image = skalaSzarosci;
            }
        }

        private Bitmap DoSkaliSzarosci(Bitmap original) // metoda przekszta³caj¹ca obraz do skali szaroœci
        {
            Bitmap skalaSzarosci = new Bitmap(original.Width, original.Height);
            for (int x = 0; x < original.Width; x++)
            {
                for (int y = 0; y < original.Height; y++)
                {
                    Color pixel = original.GetPixel(x, y);


                    double wynik = 0.299 * pixel.R + 0.587 * pixel.G + 0.114 * pixel.B;

                    skalaSzarosci.SetPixel(x, y, Color.FromArgb((int)wynik, (int)wynik, (int)wynik));
                }
            }
            return skalaSzarosci;
        }

        private void button3_Click(object sender, EventArgs e)// zak³adka ÆW2 - wczytaj i wyœwietl obraz
        {

            OpenFileDialog
            openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png) | *.jpg; *.jpeg: *.gif; *.bmp; *.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = new Bitmap(openFileDialog1.FileName);
                pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            }
            sprawdzCzySzarosc = false;
            sprawdzCzyKolor = false;
        }



        private void button5_Click(object sender, EventArgs e) // HISTOGRAM SZAROŒCI
        {
            Bitmap oryginalne = new Bitmap(pictureBox2.Image);

            double minGray = 255, maxGray = 0, sumGray = 0;
            double[] grayValues = new double[oryginalne.Width * oryginalne.Height];
            int index = 0;
            int wynik = 0;


            for (int i = 0; i < oryginalne.Width; i++)
            {
                for (int j = 0; j < oryginalne.Height; j++)
                {
                    kolorRGB = oryginalne.GetPixel(i, j);

                    wynik = (int)(Math.Round(0.299 * kolorRGB.R) + Math.Round(0.587 * kolorRGB.G) + Math.Round(0.114 * kolorRGB.B));

                    Color kolorSzary = Color.FromArgb(wynik, wynik, wynik);

                    oryginalne.SetPixel(i, j, kolorSzary);

                    grayValues[index++] = wynik;

                    if (wynik < minGray) minGray = wynik;
                    if (wynik > maxGray) maxGray = wynik;
                    sumGray += wynik;

                }
            }

            skalaSzarosci = oryginalne;
            pictureBox2.Image = skalaSzarosci;

            for (int i = 0; i < skalaSzarosci.Width; i++)
            {
                for (int j = 0; j < skalaSzarosci.Height; j++)
                {
                    kolorRGB = skalaSzarosci.GetPixel(i, j);

                    tablica[kolorRGB.R] += 1;

                }
            }
            // Bitmap skalaSzarosci = DoSkaliSzarosci(oryginalne);


            /*
                        for (int i = 0; i < oryginalne.Width; i++)
                        {
                            for (int j = 0; j < oryginalne.Height; j++)
                            {
                                kolorRGB = oryginalne.GetPixel(i, j);
                                tablica[kolorRGB.R] += 1;

                                Color pixel = oryginalne.GetPixel(i, j);


                                double wynik = 0.299 * pixel.R + 0.587 * pixel.G + 0.114 * pixel.B;
                                skalaSzarosci.SetPixel(i, j, Color.FromArgb((int)wynik, (int)wynik, (int)wynik));

                                grayValues[index++] = wynik;

                                if (wynik < minGray) minGray = wynik;
                                if (wynik > maxGray) maxGray = wynik;
                                sumGray += wynik;
                            }
                        }

                        pictureBox2.Image = skalaSzarosci;

                        */

            double[] wartosciSzare = new double[skalaSzarosci.Width * skalaSzarosci.Height];

            int i2 = 0;
            for (int x = 0; x < skalaSzarosci.Width; x++)
            {
                for (int y = 0; y < skalaSzarosci.Height; y++)
                {
                    Color pixel = skalaSzarosci.GetPixel(x, y);
                    wartosciSzare[i2] = pixel.R;
                    i2++;
                }
            }
            double mediana = ObliczMediane(wartosciSzare);
            mediana = Math.Round(mediana, 2);


            chart1.Series.Clear();

            //chart1.ChartAreas[0].AxisX.Title = "Jasnoœæ pikseli (stopnie szaroœci)";
            //chart1.ChartAreas[0].AxisY.Title = "Liczba pikseli";
            chart1.ChartAreas[0].AxisY.IsMarginVisible = false;
            chart1.ChartAreas[0].AxisX.IsMarginVisible = false;
            chart1.ChartAreas[0].AxisX.Maximum = 255;
            chart1.ChartAreas[0].AxisX.Minimum = 0;

            chart1.ChartAreas[0].AxisX.LabelAutoFitMaxFontSize = 5;
            chart1.ChartAreas[0].AxisY.LabelAutoFitMaxFontSize = 5;



            string[] linie = new string[256];

            for (int i = 0; i < 256; i++)
            {

                linie[i] = i.ToString();
                chart1.Series.Add(linie[i]);
                chart1.Series[linie[i]].ChartType = SeriesChartType.Line;
                chart1.Series[linie[i]].Color = Color.Gray;
                chart1.Series[linie[i]].Points.AddXY(i, tablica[i]);
                chart1.Series[linie[i]].Points.AddXY(i, 0);
                chart1.Series[linie[i]].IsVisibleInLegend = false;

            }

            minGray = Math.Round(minGray, 2);

            double srednia = sumGray / (oryginalne.Width * oryginalne.Height);
            srednia = Math.Round(srednia, 2);

            double odchylenieST = ObliczOdchylenieST(wartosciSzare, srednia);
            odchylenieST = Math.Round(odchylenieST, 2);




            Color col = Color.Violet;

            Histogram histogram = new Histogram();
            histogram.Show();
            histogram.RysujHistogram("Histogram szaroœci", "Jasnoœæ pikseli (stopnie szaroœci)", col, "", tablica);


            DaneStatystyczne dane = new DaneStatystyczne();
            dane.Show();
            dane.PobierzDaneStatystyczne("Histogram szaroœci",minGray,maxGray,srednia,mediana,odchylenieST);


    //        MessageBox.Show("Minimalna wartoœæ: " + minGray.ToString() + "\n\n" + "Œrednia wartoœæ: " + srednia.ToString() + "\n\nMaksymalna wartoœæ: "
    //+ maxGray.ToString() + "\n\nMediana: " + mediana.ToString() + "\n\nOdchylenie standardowe: " + odchylenieST.ToString());

        }



        private void button6_Click(object sender, EventArgs e) // HISTOGRAM RED
        {
            if (sprawdzCzySzarosc == true)
            {
                MessageBox.Show("Nie mo¿na wygenerowaæ histogramu RED dla obrazu przekszta³conego do skali szaroœci.\nWczytaj ponownie obraz.");
                button3.PerformClick(); // wykona siê ca³y kod z przycisku 3, czyli "Wczytaj obraz"
            }
            else
            {

                Bitmap obrazRGB = new Bitmap(pictureBox2.Image);
                int[] tablicaR = new int[256];
                System.Drawing.Color kolorRGB2 = new System.Drawing.Color();

                double minR = 255, maxR = 0, sumR = 0;


                for (int i = 0; i < obrazRGB.Width; i++)
                {

                    for (int j = 0; j < obrazRGB.Height; j++)
                    {
                        kolorRGB2 = obrazRGB.GetPixel(i, j);
                        tablicaR[kolorRGB2.R] += 1;


                        if (kolorRGB2.R < minR) minR = kolorRGB2.R;
                        if (kolorRGB2.R > maxR) maxR = kolorRGB2.R;
                        sumR += kolorRGB2.R;
                    }
                }

                double[] wartosciR = new double[obrazRGB.Width * obrazRGB.Height];

                int i2 = 0;
                for (int x = 0; x < obrazRGB.Width; x++)
                {
                    for (int y = 0; y < obrazRGB.Height; y++)
                    {
                        Color pixel = obrazRGB.GetPixel(x, y);
                        wartosciR[i2] = pixel.R;
                        i2++;
                    }
                }
                double mediana = ObliczMediane(wartosciR);
                mediana = Math.Round(mediana, 2);


                chart1.Series.Clear();
                //chart1.ChartAreas[0].AxisX.Title = "Jasnoœæ pikseli (stopnie szaroœci)";
                //chart1.ChartAreas[0].AxisY.Title = "Liczba pikseli";
                chart1.ChartAreas[0].AxisY.IsMarginVisible = false;
                chart1.ChartAreas[0].AxisX.IsMarginVisible = false;
                chart1.ChartAreas[0].AxisX.Maximum = 255;
                chart1.ChartAreas[0].AxisX.Minimum = 0;

                chart1.ChartAreas[0].AxisX.LabelAutoFitMaxFontSize = 5;
                chart1.ChartAreas[0].AxisY.LabelAutoFitMaxFontSize = 5;

                string[] linieR = new string[256];

                for (int i = 0; i < 256; i++)
                {

                    linieR[i] = i.ToString();
                    chart1.Series.Add("R" + linieR[i]);
                    chart1.Series["R" + linieR[i]].ChartType = SeriesChartType.Line;
                    chart1.Series["R" + linieR[i]].Color = Color.Red;
                    chart1.Series["R" + linieR[i]].Points.AddXY(i, tablicaR[i]);
                    chart1.Series["R" + linieR[i]].Points.AddXY(i, 0);
                    chart1.Series["R" + linieR[i]].IsVisibleInLegend = false;
                }

                double srednia = sumR / (obrazRGB.Width * obrazRGB.Height);
                srednia = Math.Round(srednia, 2);

                double odchylenieST = ObliczOdchylenieST(wartosciR, srednia);
                odchylenieST = Math.Round(odchylenieST, 2);


                Color col = Color.Red;
                Histogram histogram = new Histogram();
                histogram.Show();
                histogram.RysujHistogram("Histogram RED", "Jasnoœæ pikseli", col, "", tablicaR);

                DaneStatystyczne dane = new DaneStatystyczne();
                dane.Show();
                dane.PobierzDaneStatystyczne("Histogram RED", minR, maxR, srednia, mediana, odchylenieST);

                //MessageBox.Show("Minimalna wartoœæ: " + minR.ToString() + "\n\n" + "Œrednia wartoœæ: " + srednia.ToString() + "\n\nMaksymalna wartoœæ: " + maxR.ToString()
                //    + "\n\nMediana: " + mediana.ToString() + "\n\nOdchylenie standardowe: " + odchylenieST.ToString());
            }
        }

        private void button7_Click(object sender, EventArgs e) // GREEN
        {
            int[] tablicaG = new int[256];
            System.Drawing.Color kolorRGB2 = new System.Drawing.Color();
            Bitmap obrazRGB = new Bitmap(pictureBox2.Image);

            double minG = 255, maxG = 0, sumG = 0;


            for (int i = 0; i < obrazRGB.Width; i++)
            {

                for (int j = 0; j < obrazRGB.Height; j++)
                {
                    kolorRGB2 = obrazRGB.GetPixel(i, j);
                    tablicaG[kolorRGB2.G] += 1;

                    if (kolorRGB2.G < minG) minG = kolorRGB2.G;
                    if (kolorRGB2.G > maxG) maxG = kolorRGB2.G;
                    sumG += kolorRGB2.G;
                }
            }

            double[] wartosciG = new double[obrazRGB.Width * obrazRGB.Height];

            int i2 = 0;
            for (int x = 0; x < obrazRGB.Width; x++)
            {
                for (int y = 0; y < obrazRGB.Height; y++)
                {
                    Color pixel = obrazRGB.GetPixel(x, y);
                    wartosciG[i2] = pixel.G;
                    i2++;
                }
            }


            double mediana = ObliczMediane(wartosciG);
            mediana = Math.Round(mediana, 2);

            chart1.Series.Clear();
           // chart1.ChartAreas[0].AxisX.Title = "Jasnoœæ pikseli";
            //chart1.ChartAreas[0].AxisY.Title = "Liczba pikseli";
            chart1.ChartAreas[0].AxisY.IsMarginVisible = false;
            chart1.ChartAreas[0].AxisX.IsMarginVisible = false;
            chart1.ChartAreas[0].AxisX.Maximum = 255;
            chart1.ChartAreas[0].AxisX.Minimum = 0;

            chart1.ChartAreas[0].AxisX.LabelAutoFitMaxFontSize = 5;
            chart1.ChartAreas[0].AxisY.LabelAutoFitMaxFontSize = 5;

            string[] linieG = new string[256];

            for (int i = 0; i < 256; i++)
            {
                linieG[i] = i.ToString();
                chart1.Series.Add("G" + linieG[i]);
                chart1.Series["G" + linieG[i]].ChartType = SeriesChartType.Line;
                chart1.Series["G" + linieG[i]].Color = Color.Green;
                chart1.Series["G" + linieG[i]].Points.AddXY(i, tablicaG[i]);
                chart1.Series["G" + linieG[i]].Points.AddXY(i, 0);
                chart1.Series["G" + linieG[i]].IsVisibleInLegend = false;
            }

            double srednia = sumG / (obrazRGB.Width * obrazRGB.Height);
            srednia = Math.Round(srednia, 2);

            double odchylenieST = ObliczOdchylenieST(wartosciG, srednia);
            odchylenieST = Math.Round(odchylenieST, 2);


            Color col = Color.Green;
            Histogram histogram = new Histogram();
            histogram.Show();
            histogram.RysujHistogram("Histogram GREEN", "Jasnoœæ pikseli", col, "", tablicaG);

            DaneStatystyczne dane = new DaneStatystyczne();
            dane.Show();
            dane.PobierzDaneStatystyczne("Histogram GREEN", minG, maxG, srednia, mediana, odchylenieST);

            //MessageBox.Show("Minimalna wartoœæ: " + minG.ToString() + "\n\n" + "Œrednia wartoœæ: " + srednia.ToString() + "\n\nMaksymalna wartoœæ: " + maxG.ToString() +
            //    "\n\nMediana: " + mediana.ToString() + "\n\nOdchylenie standardowe: " + odchylenieST.ToString());


        }

        private void button8_Click(object sender, EventArgs e) // HISTOGRAM BLUE
        {
            int[] tablicaB = new int[256];
            Bitmap obrazRGB = new Bitmap(pictureBox2.Image);
            System.Drawing.Color kolorRGB2 = new System.Drawing.Color();

            double minB = 255, maxB = 0, sumB = 0;


            for (int i = 0; i < obrazRGB.Width; i++)
            {

                for (int j = 0; j < obrazRGB.Height; j++)
                {
                    kolorRGB2 = obrazRGB.GetPixel(i, j);
                    tablicaB[kolorRGB2.B] += 1;


                    if (kolorRGB2.B < minB) minB = kolorRGB2.B;
                    if (kolorRGB2.B > maxB) maxB = kolorRGB2.B;

                    sumB += kolorRGB2.B;

                }
            }

            double[] wartosciB = new double[obrazRGB.Width * obrazRGB.Height];

            int i2 = 0;
            for (int x = 0; x < obrazRGB.Width; x++)
            {
                for (int y = 0; y < obrazRGB.Height; y++)
                {
                    Color pixel = obrazRGB.GetPixel(x, y);
                    wartosciB[i2] = pixel.B;
                    i2++;
                }
            }


            double mediana = ObliczMediane(wartosciB);
            mediana = Math.Round(mediana, 2);

            chart1.Series.Clear();

            //chart1.ChartAreas[0].AxisX.Title = "Jasnoœæ pikseli";
            //chart1.ChartAreas[0].AxisY.Title = "Liczba pikseli";

            chart1.ChartAreas[0].AxisY.IsMarginVisible = false;
            chart1.ChartAreas[0].AxisX.IsMarginVisible = false;
            chart1.ChartAreas[0].AxisX.Maximum = 255;
            chart1.ChartAreas[0].AxisX.Minimum = 0;

            chart1.ChartAreas[0].AxisX.LabelAutoFitMaxFontSize = 5;
            chart1.ChartAreas[0].AxisY.LabelAutoFitMaxFontSize = 5;

            string[] linieB = new string[256];

            for (int i = 0; i < 256; i++)
            {
                linieB[i] = i.ToString();
                chart1.Series.Add("B" + linieB[i]);
                chart1.Series["B" + linieB[i]].ChartType = SeriesChartType.Line;
                chart1.Series["B" + linieB[i]].Color = Color.Blue;
                chart1.Series["B" + linieB[i]].Points.AddXY(i, tablicaB[i]);
                chart1.Series["B" + linieB[i]].Points.AddXY(i, 0);
                chart1.Series["B" + linieB[i]].IsVisibleInLegend = false;
            }

            double srednia = sumB / (obrazRGB.Width * obrazRGB.Height);
            srednia = Math.Round(srednia, 2);


            double odchylenieST = ObliczOdchylenieST(wartosciB, srednia);
            odchylenieST = Math.Round(odchylenieST, 2);


            Color col = Color.Blue;
            Histogram histogram = new Histogram();
            histogram.Show();
            histogram.RysujHistogram("Histogram BLUE", "Jasnoœæ pikseli", col, "", tablicaB);


            DaneStatystyczne dane = new DaneStatystyczne();
            dane.Show();
            dane.PobierzDaneStatystyczne("Histogram BLUE", minB, maxB, srednia, mediana, odchylenieST);


            //MessageBox.Show("Minimalna wartoœæ: " + minB.ToString() + "\n\n" + "Œrednia wartoœæ: " + srednia.ToString() + "\n\nMaksymalna wartoœæ: " + maxB.ToString() +
            //    "\n\nMediana: " + mediana.ToString() + "\n\nOdchylenie standardowe: " + odchylenieST.ToString());

        }


        private double ObliczMediane(double[] wartosci)
        {
            Array.Sort(wartosci);
            int wartoscSrodkowa = wartosci.Length / 2;

            if (wartosci.Length % 2 == 0)
            {
                double mediana = (wartosci[wartoscSrodkowa] + wartosci[wartoscSrodkowa - 1]) / 2.0;
                return mediana;
            }
            else
            {
                double median = wartosci[wartoscSrodkowa];
                return median;
            }
        }

        private double ObliczOdchylenieST(double[] wartosci, double srednia)
        {
            double sumaKwadratow = 0;
            foreach (double value in wartosci)
            {
                sumaKwadratow += Math.Pow(value - srednia, 2);
            }
            double wariancja = sumaKwadratow / wartosci.Length;
            double odchylenieST = Math.Sqrt(wariancja);
            return odchylenieST;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button3.PerformClick();
            chart1.Series.Clear();
        }
    }
}