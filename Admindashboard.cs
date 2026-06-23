using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace SparePart
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {   
            LoadChart();
            totalinventoryload();
            lowstockload();
            outofstockload();
            loadudhaarstatus();
            totalrevenuetodayload();
            WeeklySalepanel.Height = WeeklySalepanel.Height + 150;
            Inventoryhealthpanel.Height = Inventoryhealthpanel.Height + 150;
            uipanel.Height = uipanel.Height + 150;
            inventoryhealthload();
        }

        private DataTable Loadlastweeksales()
        {
            string query = @"
WITH Last7Days AS (
    SELECT CAST(DATEADD(DAY, -n, CAST(GETDATE() AS DATE)) AS DATE) AS InvoiceDate
    FROM (VALUES (0),(1),(2),(3),(4),(5),(6)) v(n)
),
InvoiceData AS (
    SELECT 
        CONVERT(date, Date, 105) AS InvoiceDate,
        SUM(Grandtotal) AS Total
    FROM Invoices
    GROUP BY CONVERT(date, Date, 105)
)

SELECT 
    CONVERT(varchar(10), d.InvoiceDate, 105) AS Date,
    ISNULL(i.Total, 0) AS GrandTotal
FROM Last7Days d
LEFT JOIN InvoiceData i 
    ON d.InvoiceDate = i.InvoiceDate
ORDER BY d.InvoiceDate;
";
            SqlConnection con = new SqlConnection(DatabaseManagement.getConnectionString());
            DataTable? lastweeksale = DatabaseManagement.retrieve(query, con);

            return lastweeksale!;
        }

        private void outofstockload()
        {
            SqlConnection con = new SqlConnection(DatabaseManagement.getConnectionString());
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Products WHERE Stock < 1;", con);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                object result = cmd.ExecuteScalar();
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                OutofStockTxt.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something Went Wrong\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }

        private void lowstockload()
        {
            SqlConnection con = new SqlConnection(DatabaseManagement.getConnectionString());
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Products WHERE Stock <= lowstock and Stock>0;", con);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                object result = cmd.ExecuteScalar();
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                LowStockTxt.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something Went Wrong\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }
        }

        private void totalinventoryload()
        {
            SqlConnection con = new SqlConnection(DatabaseManagement.getConnectionString());
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT ISNULL(count(ProductID), 0) FROM Products;", con);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                object result = cmd.ExecuteScalar();
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                TotalinventoryTxt.Text = result.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something Went Wrong\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }

        }

        private void totalrevenuetodayload()
        {
            SqlConnection con = new SqlConnection(DatabaseManagement.getConnectionString());
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT ISNULL(SUM(Grandtotal), 0) FROM Invoices WHERE Date = FORMAT(GETDATE(), 'dd-MM-yyyy');", con);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                object result = cmd.ExecuteScalar();
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                TotalRevenuTxt.Text = "RS " + result.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something Went Wrong\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }

        }

        private void loadudhaarstatus()
        {
            SqlConnection con = new SqlConnection(DatabaseManagement.getConnectionString());
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT SUM(GrandTotal) FROM Invoices WHERE InvoiceNumber IN ( SELECT DISTINCT InvoiceNumber FROM Credit );", con);
                SqlCommand cmd2 = new SqlCommand("SELECT count(*) FROM Invoices  WHERE InvoiceNumber IN ( SELECT DISTINCT InvoiceNumber FROM Credit );", con);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                object result = cmd.ExecuteScalar();
                object result2 = cmd2.ExecuteScalar();
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                UdharStatusTxt.Text = result.ToString();
                PendingCustomerTxt.Text = result2.ToString() + " Customer Pending";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something Went Wrong\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.Close();
            }

        }

        private void LoadChart()
        {
            DataTable dt = Loadlastweeksales();

            // =========================
            // CHART SETUP
            // =========================
            weeklysaleschart.Series.Clear();
            weeklysaleschart.ChartAreas.Clear();

            // 🔥 FIX 1: "Series1" ka box (Legend) hatane ke liye
            weeklysaleschart.Legends.Clear();

            ChartArea area = new ChartArea();

            // 🔥 FIX 2: Pura hissa mein graph aaye, white space kam ho jaye (Full Screen Grid)
            area.Position.Auto = false;
            area.Position.X = 3;       // Thoda sa gap left side par numbers ke liye
            area.Position.Y = 10;      // Thoda sa gap upar Title ke liye
            area.Position.Width = 95;  // 95% width tak graph phail jaye
            area.Position.Height = 85; // 85% height tak graph phail jaye

            weeklysaleschart.ChartAreas.Add(area);

            Series series = new Series();
            series.ChartType = SeriesChartType.Column; // BAR GRAPH
            series.IsValueShownAsLabel = true;         // values show on bars
            series.LabelForeColor = System.Drawing.Color.Black;
            series.IsXValueIndexed = true;             // Bars ko space dene ke liye
            series["BarLabelStyle"] = "Outside";
            // INTERACTIVE: Mouse hover tooltip
            series.ToolTip = "Date: #VALX\nSales: #VALY";

            // BOLD TEXT (Bar Values)
            series.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);

            weeklysaleschart.Series.Add(series);

            // =========================
            // LOAD DATA
            // =========================
            foreach (DataRow row in dt.Rows)
            {
                string? date = row["Date"].ToString();
                decimal sales = Convert.ToDecimal(row["GrandTotal"]);

                series.Points.AddXY(date, sales);
            }

            // =========================
            // MODERN & BOLD LOOK
            // =========================
            weeklysaleschart.Titles.Clear();
            //var title = weeklysaleschart.Titles.Add("Last 7 Days Revenue");
            //title.Font = new System.Drawing.Font("Segoe UI", 12f, System.Drawing.FontStyle.Bold);

            weeklysaleschart.ChartAreas[0].AxisX.Interval = 1;

            // DATES SEEDHI RAKHEIN (No Tilt)
            weeklysaleschart.ChartAreas[0].AxisX.LabelStyle.Angle = 0;

            // BOLD TEXT (Axis Labels)
            weeklysaleschart.ChartAreas[0].AxisX.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);
            weeklysaleschart.ChartAreas[0].AxisY.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);

            // BOLD GRID LINES
            weeklysaleschart.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            weeklysaleschart.ChartAreas[0].AxisX.MajorGrid.LineColor = System.Drawing.Color.Black;
            weeklysaleschart.ChartAreas[0].AxisX.MajorGrid.LineWidth = 2;

            weeklysaleschart.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            weeklysaleschart.ChartAreas[0].AxisY.MajorGrid.LineColor = System.Drawing.Color.Black;
            weeklysaleschart.ChartAreas[0].AxisY.MajorGrid.LineWidth = 2;
        }

        void inventoryhealthload()
        {
            // Textboxes se data lena
            int totalproducts = int.Parse(TotalinventoryTxt.Text);
            int outofstock = int.Parse(OutofStockTxt.Text);
            int lowstock = int.Parse(LowStockTxt.Text);

            // 🔥 LOGICAL FIX: Bacha hua stock (Healthy Stock) nikalna
            int healthyStock = totalproducts - (outofstock + lowstock);

            // =========================
            // CHART SETUP
            // =========================
            chart2.Series.Clear();
            chart2.ChartAreas.Clear();
            chart2.Legends.Clear();

            ChartArea area = new ChartArea();
            chart2.ChartAreas.Add(area);

            // Pie chart mein Legend (Neeche colors ki detail) zaroori hoti hai
            Legend legend = new Legend();
            legend.Docking = Docking.Bottom; // Neeche ki taraf show hoga
            legend.Alignment = StringAlignment.Center;
            legend.Font = new System.Drawing.Font("Segoe UI", 9f, System.Drawing.FontStyle.Bold);
            chart2.Legends.Add(legend);

            Series series = new Series("InventoryHealth");
            series.ChartType = SeriesChartType.Pie; // PIE CHART

            // Labels aur tooltips ki setting
            series.IsValueShownAsLabel = true;
            series.Label = "#PERCENT{P0}"; // Pie chart ke upar % mein value aayegi (jaise 75%)
            series.LegendText = "#VALX (#VALY)"; // Legend mein naam aur asili value aayegi (e.g., Low Stock (15))
            series.Font = new System.Drawing.Font("Segoe UI", 10f, System.Drawing.FontStyle.Bold);
            series.LabelForeColor = System.Drawing.Color.White; // Labels ka color white taaki clear padha jaye

            chart2.Series.Add(series);

            // =========================
            // LOAD DATA
            // =========================
            // Yahan hum calculate kiye gaye 3 hisse add kar rahe hain
            series.Points.AddXY("Healthy Stock", healthyStock);
            series.Points.AddXY("Low Stock", lowstock);
            series.Points.AddXY("Out of Stock", outofstock);

            // =========================
            // CUSTOM COLORS (Pie chart ko acha dikhane ke liye)
            // =========================
            series.Points[0].Color = System.Drawing.Color.MediumSeaGreen; // Healthy = Green
            series.Points[1].Color = System.Drawing.Color.Orange;         // Low = Orange
            series.Points[2].Color = System.Drawing.Color.Tomato;         // Out of Stock = Red

            // =========================
            // TITLE SETTING
            // =========================
            chart2.Titles.Clear();

        }

        private void TotalRevenuTxt_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}