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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(367, 615);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(189, 71);
            button2.TabIndex = 5;
            button2.Text = "Przekształć obraz do skali szarości i wyświetl go";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(37, 91);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(519, 444);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(37, 615);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(122, 71);
            button1.TabIndex = 3;
            button1.Text = "Wczytaj i wyświetl obraz";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(486, 67);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 6;
            label1.Text = "30.04.2024";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { plikToolStripMenuItem, opcjeToolStripMenuItem, pomocToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(607, 30);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            plikToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { zapiszToolStripMenuItem, wyjdźToolStripMenuItem });
            plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            plikToolStripMenuItem.Size = new Size(46, 24);
            plikToolStripMenuItem.Text = "&Plik";
            // 
            // zapiszToolStripMenuItem
            // 
            zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
            zapiszToolStripMenuItem.Size = new Size(135, 26);
            zapiszToolStripMenuItem.Text = "&Zapisz";
            // 
            // wyjdźToolStripMenuItem
            // 
            wyjdźToolStripMenuItem.Name = "wyjdźToolStripMenuItem";
            wyjdźToolStripMenuItem.Size = new Size(135, 26);
            wyjdźToolStripMenuItem.Text = "&Wyjdź";
            // 
            // opcjeToolStripMenuItem
            // 
            opcjeToolStripMenuItem.Name = "opcjeToolStripMenuItem";
            opcjeToolStripMenuItem.Size = new Size(62, 24);
            opcjeToolStripMenuItem.Text = "&Opcje";
            // 
            // pomocToolStripMenuItem
            // 
            pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            pomocToolStripMenuItem.Size = new Size(68, 24);
            pomocToolStripMenuItem.Text = "&Pomoc";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 30);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(607, 799);
            tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Honeydew;
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(button2);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(599, 766);
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
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 4, 3, 4);
            tabPage2.Size = new Size(599, 766);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "ĆW2";
            // 
            // button4
            // 
            button4.Location = new Point(45, 549);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(130, 56);
            button4.TabIndex = 17;
            button4.Text = "Odśwież";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(494, 24);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 16;
            label3.Text = "07.05.2024";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(45, 613);
            chart1.Margin = new Padding(3, 4, 3, 4);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(519, 139);
            chart1.TabIndex = 15;
            chart1.Text = "chart1";
            // 
            // button8
            // 
            button8.Location = new Point(433, 544);
            button8.Margin = new Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Size = new Size(130, 61);
            button8.TabIndex = 14;
            button8.Text = "Wyświetl histogram B";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.Location = new Point(433, 476);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(130, 67);
            button7.TabIndex = 13;
            button7.Text = "Wyświetl histogram G";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.Location = new Point(296, 544);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(130, 61);
            button6.TabIndex = 12;
            button6.Text = "Wyświetl histogram R";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(296, 476);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(130, 67);
            button5.TabIndex = 11;
            button5.Text = "Wyświetl histogram szarości";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(45, 24);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(519, 444);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(45, 476);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(130, 71);
            button3.TabIndex = 8;
            button3.Text = "Wczytaj i wyświetl obraz";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(464, 45);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
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
            tabPage3.Location = new Point(4, 29);
            tabPage3.Margin = new Padding(3, 4, 3, 4);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(599, 766);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "ĆW3";
            // 
            // button13
            // 
            button13.Location = new Point(279, 585);
            button13.Margin = new Padding(3, 4, 3, 4);
            button13.Name = "button13";
            button13.Size = new Size(130, 67);
            button13.TabIndex = 22;
            button13.Text = "Pierwiastkowanie";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button13_Click;
            // 
            // button12
            // 
            button12.Location = new Point(415, 507);
            button12.Margin = new Padding(3, 4, 3, 4);
            button12.Name = "button12";
            button12.Size = new Size(130, 67);
            button12.TabIndex = 21;
            button12.Text = "Logarytmowanie";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button12_Click;
            // 
            // button11
            // 
            button11.Location = new Point(279, 507);
            button11.Margin = new Padding(3, 4, 3, 4);
            button11.Name = "button11";
            button11.Size = new Size(130, 67);
            button11.TabIndex = 20;
            button11.Text = "Potęgowanie";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button10
            // 
            button10.Location = new Point(26, 585);
            button10.Margin = new Padding(3, 4, 3, 4);
            button10.Name = "button10";
            button10.Size = new Size(130, 56);
            button10.TabIndex = 19;
            button10.Text = "Odśwież";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button9.Location = new Point(26, 507);
            button9.Margin = new Padding(3, 4, 3, 4);
            button9.Name = "button9";
            button9.Size = new Size(130, 71);
            button9.TabIndex = 18;
            button9.Text = "Wczytaj i wyświetl obraz";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(455, 31);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 17;
            label4.Text = "14.05.2024";
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(26, 55);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(519, 444);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 29);
            tabPage4.Margin = new Padding(3, 4, 3, 4);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(599, 766);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "ĆW4";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(607, 829);
            Controls.Add(tabControl1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
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
    }
}