using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace EMS
{
    public partial class Dashboard : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-GOK6444\SQLEXPRESS01;Initial Catalog=ConnectionDb;Integrated Security=True;Encrypt=False");
        public Dashboard()
        {
            InitializeComponent();

         //   displayTE();
          //  displayAE();
          //  displayIE();
        
        }
        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }
          
           displayTE();
            displayAE();
           displayIE();
        }
        public void displayTE()
        {
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT Count (Employee_Id) FROM Employees WHERE DateDelete is Null";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            int count = Convert.ToInt32(reader[0]);
                            dashboardTE.Text = count.ToString();
                        }
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex, "Error Message", MessageBoxButtons.OK);
                }
                finally
                {
                    connect.Close();
                }
            }
        }
        public void displayAE()
        {
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT Count (Employee_Id) FROM Employees WHERE Status = @status " +
                        "And DateDelete is Null";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@status", "Active");
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            int count = Convert.ToInt32(reader[0]);
                            dashboardAE.Text = count.ToString();
                        }
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex, "Error Message", MessageBoxButtons.OK);
                }
                finally
                {
                    connect.Close();
                }
            }
        }
        public void displayIE()
        {
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT Count (Employee_Id) FROM Employees WHERE Status = @status " +
                        "And DateDelete is Null";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@status", "Inactive");
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            int count = Convert.ToInt32(reader[0]);
                            dashboardIE.Text = count.ToString();
                        }
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex, "Error Message", MessageBoxButtons.OK);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
        private void dashboardTE_Click(object sender, EventArgs e)
        {

        }

        private void dashboardIE_Click(object sender, EventArgs e)
        {

        }
    }
}
