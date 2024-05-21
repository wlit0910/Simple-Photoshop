namespace Litowczenko_PIAO
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            plikToolStripMenuItem = new ToolStripMenuItem();
            zapiszToolStripMenuItem = new ToolStripMenuItem();
            wyjdźToolStripMenuItem = new ToolStripMenuItem();
            opcjeToolStripMenuItem = new ToolStripMenuItem();
            pomocToolStripMenuItem = new ToolStripMenuItem();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            button4 = new Button();
            label3 = new Label();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            pictureBox2 = new PictureBox();
            button3 = new Button();
            label2 = new Label();
            tabPage3 = new TabPage();
            button13 = new Button();
            button12 = new Button();
            button11 = new Button();
            button10 = new Button();
            button9 = new Button();
            label4 = new Label();
            pictureBox3 = new PictureBox();
            tabPage4 = new TabPage();
            button18 = new Button();
            textBox2 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            button17 = new Button();
            button16 = new Button();
            button15 = new Button();
            button14 = new Button();
            label5 = new Label();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(321, 461);
            button2.Name = "button2";
            button2.Size = new Size(165, 53);
            button2.TabIndex = 5;
            button2.Text = "Przekształć obraz do skali szarości i wyświetl go";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(32, 68);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(454, 333);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(32, 461);
            button1.Name = "button1";
            button1.Size = new Size(107, 53);
            button1.TabIndex = 3;
            button1.Text = "Wczytaj i wyświetl obraz";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(425, 50);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 6;
            label1.Text = "30.04.2024";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { plikToolStripMenuItem, opcjeToolStripMenuItem, pomocToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(531, 24);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            plikToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { zapiszToolStripMenuItem, wyjdźToolStripMenuItem });
            plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            plikToolStripMenuItem.Size = new Size(38, 20);
            plikToolStripMenuItem.Text = "&Plik";
            // 
            // zapiszToolStripMenuItem
            // 
            zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
            zapiszToolStripMenuItem.Size = new Size(107, 22);
            zapiszToolStripMenuItem.Text = "&Zapisz";
            // 
            // wyjdźToolStripMenuItem
            // 
            wyjdźToolStripMenuItem.Name = "wyjdźToolStripMenuItem";
            wyjdźToolStripMenuItem.Size = new Size(107, 22);
            wyjdźToolStripMenuItem.Text = "&Wyjdź";
            // 
            // opcjeToolStripMenuItem
            // 
            opcjeToolStripMenuItem.Name = "opcjeToolStripMenuItem";
            opcjeToolStripMenuItem.Size = new Size(50, 20);
            opcjeToolStripMenuItem.Text = "&Opcje";
            // 
            // pomocToolStripMenuItem
            // 
            pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            pomocToolStripMenuItem.Size = new Size(57, 20);
            pomocToolStripMenuItem.Text = "&Pomoc";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 24);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(531, 598);
            tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Honeydew;
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(button2);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(523, 570);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "ĆW1";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Beige;
            tabPage2.Controls.Add(button4);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(chart1);
            tabPage2.Controls.Add(button8);
            tabPage2.Controls.Add(button7);
            tabPage2.Controls.Add(button6);
            tabPage2.Controls.Add(button5);
            tabPage2.Controls.Add(pictureBox2);
            tabPage2.Controls.Add(button3);
            tabPage2.Controls.Add(label2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(523, 570);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "ĆW2";
            // 
            // button4
            // 
            button4.Location = new Point(39, 412);
            button4.Name = "button4";
            button4.Size = new Size(114, 42);
            button4.TabIndex = 17;
            button4.Text = "Odśwież";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(432, 18);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 16;
            label3.Text = "07.05.2024";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(39, 460);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(454, 104);
            chart1.TabIndex = 15;
            chart1.Text = "chart1";
            // 
            // button8
            // 
            button8.Location = new Point(379, 408);
            button8.Name = "button8";
            button8.Size = new Size(114, 46);
            button8.TabIndex = 14;
            button8.Text = "Wyświetl histogram B";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.Location = new Point(379, 357);
            button7.Name = "button7";
            button7.Size = new Size(114, 50);
            button7.TabIndex = 13;
            button7.Text = "Wyświetl histogram G";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Location = new Point(259, 408);
            button6.Name = "button6";
            button6.Size = new Size(114, 46);
            button6.TabIndex = 12;
            button6.Text = "Wyświetl histogram R";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(259, 357);
            button5.Name = "button5";
            button5.Size = new Size(114, 50);
            button5.TabIndex = 11;
            button5.Text = "Wyświetl histogram szarości";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(39, 18);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(454, 333);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(39, 357);
            button3.Name = "button3";
            button3.Size = new Size(114, 53);
            button3.TabIndex = 8;
            button3.Text = "Wczytaj i wyświetl obraz";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(406, 34);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 7;
            label2.Text = "07.05.2024";
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.LightCyan;
            tabPage3.Controls.Add(button13);
            tabPage3.Controls.Add(button12);
            tabPage3.Controls.Add(button11);
            tabPage3.Controls.Add(button10);
            tabPage3.Controls.Add(button9);
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(pictureBox3);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(523, 570);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "ĆW3";
            // 
            // button13
            // 
            button13.Location = new Point(244, 439);
            button13.Name = "button13";
            button13.Size = new Size(114, 50);
            button13.TabIndex = 22;
            button13.Text = "Pierwiastkowanie";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // button12
            // 
            button12.Location = new Point(363, 380);
            button12.Name = "button12";
            button12.Size = new Size(114, 50);
            button12.TabIndex = 21;
            button12.Text = "Logarytmowanie";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // button11
            // 
            button11.Location = new Point(244, 380);
            button11.Name = "button11";
            button11.Size = new Size(114, 50);
            button11.TabIndex = 20;
            button11.Text = "Potęgowanie";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button10
            // 
            button10.Location = new Point(23, 439);
            button10.Name = "button10";
            button10.Size = new Size(114, 42);
            button10.TabIndex = 19;
            button10.Text = "Odśwież";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button9.Location = new Point(23, 380);
            button9.Name = "button9";
            button9.Size = new Size(114, 53);
            button9.TabIndex = 18;
            button9.Text = "Wczytaj i wyświetl obraz";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(398, 23);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 17;
            label4.Text = "14.05.2024";
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(23, 41);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(454, 333);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(button18);
            tabPage4.Controls.Add(textBox2);
            tabPage4.Controls.Add(label7);
            tabPage4.Controls.Add(label6);
            tabPage4.Controls.Add(textBox1);
            tabPage4.Controls.Add(button17);
            tabPage4.Controls.Add(button16);
            tabPage4.Controls.Add(button15);
            tabPage4.Controls.Add(button14);
            tabPage4.Controls.Add(label5);
            tabPage4.Controls.Add(pictureBox4);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(523, 570);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "ĆW4";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            button18.Location = new Point(160, 520);
            button18.Name = "button18";
            button18.Size = new Size(114, 42);
            button18.TabIndex = 28;
            button18.Text = "Podwójne ograniczeine";
            button18.UseVisualStyleBackColor = true;
            button18.Click += button18_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(381, 468);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 27;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(296, 417);
            label7.Name = "label7";
            label7.Size = new Size(68, 15);
            label7.TabIndex = 26;
            label7.Text = "Próg dolny:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(296, 476);
            label6.Name = "label6";
            label6.Size = new Size(69, 15);
            label6.TabIndex = 25;
            label6.Text = "Próg górny:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(381, 409);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 24;
            // 
            // button17
            // 
            button17.Location = new Point(160, 457);
            button17.Name = "button17";
            button17.Size = new Size(114, 42);
            button17.TabIndex = 23;
            button17.Text = "Próg dolny";
            button17.UseVisualStyleBackColor = true;
            button17.Click += button17_Click;
            // 
            // button16
            // 
            button16.Location = new Point(160, 397);
            button16.Name = "button16";
            button16.Size = new Size(114, 42);
            button16.TabIndex = 22;
            button16.Text = "Próg górny";
            button16.UseVisualStyleBackColor = true;
            button16.Click += button16_Click;
            // 
            // button15
            // 
            button15.Location = new Point(27, 457);
            button15.Name = "button15";
            button15.Size = new Size(114, 42);
            button15.TabIndex = 21;
            button15.Text = "Skala szarości";
            button15.UseVisualStyleBackColor = true;
            button15.Click += button15_Click;
            // 
            // button14
            // 
            button14.Location = new Point(27, 397);
            button14.Name = "button14";
            button14.Size = new Size(114, 42);
            button14.TabIndex = 20;
            button14.Text = "Wczytaj";
            button14.UseVisualStyleBackColor = true;
            button14.Click += button14_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(420, 28);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 18;
            label5.Text = "21.05.2024";
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(27, 46);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(454, 333);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 622);
            Controls.Add(tabControl1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Photoshop";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button2;
        private PictureBox pictureBox1;
        private Button button1;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem plikToolStripMenuItem;
        private ToolStripMenuItem opcjeToolStripMenuItem;
        private ToolStripMenuItem pomocToolStripMenuItem;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label label2;
        private TabPage tabPage4;
        private ToolStripMenuItem zapiszToolStripMenuItem;
        private ToolStripMenuItem wyjdźToolStripMenuItem;
        private PictureBox pictureBox2;
        private Button button3;
        private Button button6;
        private Button button5;
        private Button button8;
        private Button button7;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Label label3;
        private Button button4;
        private Label label4;
        private PictureBox pictureBox3;
        private Button button9;
        private Button button13;
        private Button button12;
        private Button button11;
        private Button button10;
        private Label label5;
        private PictureBox pictureBox4;
        private TextBox textBox2;
        private Label label7;
        private Label label6;
        private TextBox textBox1;
        private Button button17;
        private Button button16;
        private Button button15;
        private Button button14;
        private Button button18;
    }
}