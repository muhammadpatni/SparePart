namespace SparePart
{
    partial class AdminDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            mainpanel = new Panel();
            uipanel = new Panel();
            label2 = new Label();
            Inventoryhealthpanel = new Panel();
            chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel2 = new Panel();
            label15 = new Label();
            label14 = new Label();
            WeeklySalepanel = new Panel();
            weeklysalepanelgraph = new Panel();
            weeklysaleschart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel1 = new Panel();
            label13 = new Label();
            label12 = new Label();
            UdharPnl = new Panel();
            PendingCustomerTxt = new Label();
            label9 = new Label();
            pictureBox5 = new PictureBox();
            UdharStatusTxt = new Label();
            LowStcokPnl = new Panel();
            label7 = new Label();
            pictureBox4 = new PictureBox();
            LowStockTxt = new Label();
            OutOfStockPnl = new Panel();
            label5 = new Label();
            pictureBox3 = new PictureBox();
            OutofStockTxt = new Label();
            InventoryPnl = new Panel();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            TotalinventoryTxt = new Label();
            RevenuPnl = new Panel();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            TotalRevenuTxt = new Label();
            mainpanel.SuspendLayout();
            uipanel.SuspendLayout();
            Inventoryhealthpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart2).BeginInit();
            panel2.SuspendLayout();
            WeeklySalepanel.SuspendLayout();
            weeklysalepanelgraph.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)weeklysaleschart).BeginInit();
            panel1.SuspendLayout();
            UdharPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            LowStcokPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            OutOfStockPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            InventoryPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            RevenuPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // mainpanel
            // 
            mainpanel.Controls.Add(uipanel);
            mainpanel.Dock = DockStyle.Fill;
            mainpanel.Location = new Point(0, 0);
            mainpanel.Name = "mainpanel";
            mainpanel.Size = new Size(1166, 553);
            mainpanel.TabIndex = 6;
            // 
            // uipanel
            // 
            uipanel.Controls.Add(label2);
            uipanel.Controls.Add(Inventoryhealthpanel);
            uipanel.Controls.Add(WeeklySalepanel);
            uipanel.Controls.Add(UdharPnl);
            uipanel.Controls.Add(LowStcokPnl);
            uipanel.Controls.Add(OutOfStockPnl);
            uipanel.Controls.Add(InventoryPnl);
            uipanel.Controls.Add(RevenuPnl);
            uipanel.Location = new Point(27, 12);
            uipanel.Name = "uipanel";
            uipanel.Size = new Size(1105, 529);
            uipanel.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(34, 14);
            label2.Name = "label2";
            label2.Size = new Size(212, 25);
            label2.TabIndex = 21;
            label2.Text = "Business Overview";
            // 
            // Inventoryhealthpanel
            // 
            Inventoryhealthpanel.BackColor = Color.White;
            Inventoryhealthpanel.Controls.Add(chart2);
            Inventoryhealthpanel.Controls.Add(panel2);
            Inventoryhealthpanel.Location = new Point(638, 170);
            Inventoryhealthpanel.Name = "Inventoryhealthpanel";
            Inventoryhealthpanel.Size = new Size(417, 316);
            Inventoryhealthpanel.TabIndex = 14;
            // 
            // chart2
            // 
            chartArea1.Name = "ChartArea1";
            chart2.ChartAreas.Add(chartArea1);
            chart2.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chart2.Legends.Add(legend1);
            chart2.Location = new Point(0, 100);
            chart2.Name = "chart2";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart2.Series.Add(series1);
            chart2.Size = new Size(417, 216);
            chart2.TabIndex = 6;
            chart2.Text = "chart1";
            // 
            // panel2
            // 
            panel2.Controls.Add(label15);
            panel2.Controls.Add(label14);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(417, 100);
            panel2.TabIndex = 5;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Black;
            label15.Location = new Point(13, 28);
            label15.Name = "label15";
            label15.Size = new Size(184, 25);
            label15.TabIndex = 2;
            label15.Text = "Inventory Health";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.FromArgb(128, 132, 140);
            label14.Location = new Point(13, 62);
            label14.Name = "label14";
            label14.Size = new Size(166, 17);
            label14.TabIndex = 4;
            label14.Text = "Current Stock Distribution";
            // 
            // WeeklySalepanel
            // 
            WeeklySalepanel.BackColor = Color.White;
            WeeklySalepanel.Controls.Add(weeklysalepanelgraph);
            WeeklySalepanel.Controls.Add(panel1);
            WeeklySalepanel.Location = new Point(31, 170);
            WeeklySalepanel.Name = "WeeklySalepanel";
            WeeklySalepanel.Size = new Size(601, 316);
            WeeklySalepanel.TabIndex = 15;
            // 
            // weeklysalepanelgraph
            // 
            weeklysalepanelgraph.Controls.Add(weeklysaleschart);
            weeklysalepanelgraph.Dock = DockStyle.Fill;
            weeklysalepanelgraph.Location = new Point(0, 94);
            weeklysalepanelgraph.Name = "weeklysalepanelgraph";
            weeklysalepanelgraph.Size = new Size(601, 222);
            weeklysalepanelgraph.TabIndex = 6;
            // 
            // weeklysaleschart
            // 
            chartArea2.Name = "ChartArea1";
            weeklysaleschart.ChartAreas.Add(chartArea2);
            weeklysaleschart.Dock = DockStyle.Fill;
            legend2.Name = "Legend1";
            weeklysaleschart.Legends.Add(legend2);
            weeklysaleschart.Location = new Point(0, 0);
            weeklysaleschart.Name = "weeklysaleschart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            weeklysaleschart.Series.Add(series2);
            weeklysaleschart.Size = new Size(601, 222);
            weeklysaleschart.TabIndex = 0;
            weeklysaleschart.Text = "chart1";
            // 
            // panel1
            // 
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label12);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(601, 94);
            panel1.TabIndex = 5;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.FromArgb(128, 132, 140);
            label13.Location = new Point(13, 62);
            label13.Name = "label13";
            label13.Size = new Size(266, 17);
            label13.TabIndex = 6;
            label13.Text = "Sale's Performance for the last sevent days";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(13, 28);
            label12.Name = "label12";
            label12.Size = new Size(257, 25);
            label12.TabIndex = 5;
            label12.Text = "Weekly Revenue Trend";
            // 
            // UdharPnl
            // 
            UdharPnl.BackColor = Color.White;
            UdharPnl.Controls.Add(PendingCustomerTxt);
            UdharPnl.Controls.Add(label9);
            UdharPnl.Controls.Add(pictureBox5);
            UdharPnl.Controls.Add(UdharStatusTxt);
            UdharPnl.Location = new Point(864, 51);
            UdharPnl.Name = "UdharPnl";
            UdharPnl.Size = new Size(191, 104);
            UdharPnl.TabIndex = 16;
            // 
            // PendingCustomerTxt
            // 
            PendingCustomerTxt.AutoSize = true;
            PendingCustomerTxt.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PendingCustomerTxt.ForeColor = Color.FromArgb(128, 132, 140);
            PendingCustomerTxt.Location = new Point(13, 80);
            PendingCustomerTxt.Name = "PendingCustomerTxt";
            PendingCustomerTxt.Size = new Size(132, 17);
            PendingCustomerTxt.TabIndex = 4;
            PendingCustomerTxt.Text = "4 Customer Pending";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(128, 132, 140);
            label9.Location = new Point(43, 19);
            label9.Name = "label9";
            label9.Size = new Size(87, 17);
            label9.TabIndex = 4;
            label9.Text = "Udhar Status";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(13, 12);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(24, 24);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 1;
            pictureBox5.TabStop = false;
            // 
            // UdharStatusTxt
            // 
            UdharStatusTxt.AutoSize = true;
            UdharStatusTxt.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UdharStatusTxt.ForeColor = Color.Black;
            UdharStatusTxt.Location = new Point(13, 55);
            UdharStatusTxt.Name = "UdharStatusTxt";
            UdharStatusTxt.Size = new Size(99, 25);
            UdharStatusTxt.TabIndex = 2;
            UdharStatusTxt.Text = "Rs 4443";
            // 
            // LowStcokPnl
            // 
            LowStcokPnl.BackColor = Color.White;
            LowStcokPnl.Controls.Add(label7);
            LowStcokPnl.Controls.Add(pictureBox4);
            LowStcokPnl.Controls.Add(LowStockTxt);
            LowStcokPnl.Location = new Point(656, 51);
            LowStcokPnl.Name = "LowStcokPnl";
            LowStcokPnl.Size = new Size(191, 104);
            LowStcokPnl.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(128, 132, 140);
            label7.Location = new Point(54, 19);
            label7.Name = "label7";
            label7.Size = new Size(69, 17);
            label7.TabIndex = 4;
            label7.Text = "Low Stock";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(13, 12);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(24, 24);
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // LowStockTxt
            // 
            LowStockTxt.AutoSize = true;
            LowStockTxt.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LowStockTxt.ForeColor = Color.Black;
            LowStockTxt.Location = new Point(54, 72);
            LowStockTxt.Name = "LowStockTxt";
            LowStockTxt.Size = new Size(38, 25);
            LowStockTxt.TabIndex = 2;
            LowStockTxt.Text = "43";
            // 
            // OutOfStockPnl
            // 
            OutOfStockPnl.BackColor = Color.White;
            OutOfStockPnl.Controls.Add(label5);
            OutOfStockPnl.Controls.Add(pictureBox3);
            OutOfStockPnl.Controls.Add(OutofStockTxt);
            OutOfStockPnl.Location = new Point(453, 51);
            OutOfStockPnl.Name = "OutOfStockPnl";
            OutOfStockPnl.Size = new Size(191, 104);
            OutOfStockPnl.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(128, 132, 140);
            label5.Location = new Point(62, 12);
            label5.Name = "label5";
            label5.Size = new Size(84, 17);
            label5.TabIndex = 4;
            label5.Text = "Out of Stock";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(13, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(43, 40);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // OutofStockTxt
            // 
            OutofStockTxt.AutoSize = true;
            OutofStockTxt.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OutofStockTxt.ForeColor = Color.Black;
            OutofStockTxt.Location = new Point(51, 72);
            OutofStockTxt.Name = "OutofStockTxt";
            OutofStockTxt.Size = new Size(38, 25);
            OutofStockTxt.TabIndex = 2;
            OutofStockTxt.Text = "44";
            // 
            // InventoryPnl
            // 
            InventoryPnl.BackColor = Color.White;
            InventoryPnl.Controls.Add(label1);
            InventoryPnl.Controls.Add(pictureBox2);
            InventoryPnl.Controls.Add(TotalinventoryTxt);
            InventoryPnl.Location = new Point(241, 51);
            InventoryPnl.Name = "InventoryPnl";
            InventoryPnl.Size = new Size(191, 104);
            InventoryPnl.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(128, 132, 140);
            label1.Location = new Point(43, 12);
            label1.Name = "label1";
            label1.Size = new Size(101, 17);
            label1.TabIndex = 4;
            label1.Text = "Total Inventory";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(13, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 24);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // TotalinventoryTxt
            // 
            TotalinventoryTxt.AutoSize = true;
            TotalinventoryTxt.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TotalinventoryTxt.ForeColor = Color.Black;
            TotalinventoryTxt.Location = new Point(43, 72);
            TotalinventoryTxt.Name = "TotalinventoryTxt";
            TotalinventoryTxt.Size = new Size(38, 25);
            TotalinventoryTxt.TabIndex = 2;
            TotalinventoryTxt.Text = "15";
            // 
            // RevenuPnl
            // 
            RevenuPnl.BackColor = Color.White;
            RevenuPnl.Controls.Add(label3);
            RevenuPnl.Controls.Add(pictureBox1);
            RevenuPnl.Controls.Add(TotalRevenuTxt);
            RevenuPnl.Location = new Point(31, 51);
            RevenuPnl.Name = "RevenuPnl";
            RevenuPnl.Size = new Size(191, 104);
            RevenuPnl.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(128, 132, 140);
            label3.Location = new Point(43, 12);
            label3.Name = "label3";
            label3.Size = new Size(101, 17);
            label3.TabIndex = 4;
            label3.Text = "Today's Revenu";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(13, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 24);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // TotalRevenuTxt
            // 
            TotalRevenuTxt.AutoSize = true;
            TotalRevenuTxt.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TotalRevenuTxt.ForeColor = Color.Black;
            TotalRevenuTxt.Location = new Point(26, 72);
            TotalRevenuTxt.Name = "TotalRevenuTxt";
            TotalRevenuTxt.Size = new Size(99, 25);
            TotalRevenuTxt.TabIndex = 2;
            TotalRevenuTxt.Text = "Rs 4443";
            TotalRevenuTxt.Click += TotalRevenuTxt_Click;
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 250, 252);
            ClientSize = new Size(1166, 553);
            Controls.Add(mainpanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminDashboard";
            Text = "Dashboard";
            Load += AdminDashboard_Load;
            mainpanel.ResumeLayout(false);
            uipanel.ResumeLayout(false);
            uipanel.PerformLayout();
            Inventoryhealthpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            WeeklySalepanel.ResumeLayout(false);
            weeklysalepanelgraph.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)weeklysaleschart).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            UdharPnl.ResumeLayout(false);
            UdharPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            LowStcokPnl.ResumeLayout(false);
            LowStcokPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            OutOfStockPnl.ResumeLayout(false);
            OutOfStockPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            InventoryPnl.ResumeLayout(false);
            InventoryPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            RevenuPnl.ResumeLayout(false);
            RevenuPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainpanel;
        private Panel uipanel;
        private Label label2;
        private Panel Inventoryhealthpanel;
        private Label label14;
        private Label label15;
        private Panel WeeklySalepanel;
        private Panel UdharPnl;
        private Label PendingCustomerTxt;
        private Label label9;
        private PictureBox pictureBox5;
        private Label UdharStatusTxt;
        private Panel LowStcokPnl;
        private Label label7;
        private PictureBox pictureBox4;
        private Label LowStockTxt;
        private Panel OutOfStockPnl;
        private Label label5;
        private PictureBox pictureBox3;
        private Label OutofStockTxt;
        private Panel InventoryPnl;
        private Label label1;
        private PictureBox pictureBox2;
        private Label TotalinventoryTxt;
        private Panel RevenuPnl;
        private Label label3;
        private PictureBox pictureBox1;
        private Label TotalRevenuTxt;
        private Panel weeklysalepanelgraph;
        private Panel panel1;
        private Label label13;
        private Label label12;
        private System.Windows.Forms.DataVisualization.Charting.Chart weeklysaleschart;
        private Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    }
}