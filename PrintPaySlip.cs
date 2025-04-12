using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Drawing.Drawing2D;
using Microsoft.Data.SqlClient;
using System.Runtime.InteropServices;

namespace EMS
{
    public partial class PrintPaySlip: UserControl
    {
       
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-GOK6444\SQLEXPRESS01;Initial Catalog=ConnectionDb;Integrated Security=True;Encrypt=False");

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
         (
         int nLeft,
         int nRight,
         int ntop,
         int nBottom,
         int nWidthEllipse,
         int nHeightEllipse
         );

        public PrintPaySlip()
        {
            InitializeComponent();
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            string empId = txtEmpID.Text;

            if(string.IsNullOrEmpty(empId))
            {
                MessageBox.Show("please enter employee id");
                return;
            }

            string con = @"Data Source=DESKTOP-GOK6444\SQLEXPRESS01;Initial Catalog=ConnectionDb;Integrated Security=True;Encrypt=False";
            string query = @"SELECT P.Payroll_Id, P.Employee_Id, P.No_Of_Present, P.Salary, P.Department, P.SSS, P.PagIbig, P.PhilHealth, P.TotalDeduction, P.DateUpdate, E.FirstName, E.LastName FROM Payroll P INNER JOIN Employees E ON P.Employee_Id = E.Employee_Id WHERE P.Employee_Id = @id";

            using (SqlConnection conn = new SqlConnection(con))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", txtEmpID.Text);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    SaveFileDialog saveDialog = new SaveFileDialog();
                    saveDialog.Filter = "PDF Files (*.Pdf) |*.pdf";
                    saveDialog.FileName = " Employee_" + empId + ".pdf";
                    if(saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        using(FileStream fs = new FileStream(saveDialog.FileName, FileMode.Create))
                        {
                            Document doc = new Document();
                            PdfWriter.GetInstance(doc, fs);
                            doc.Open();

              
                            //title 
                            doc.Add(new Paragraph("                                                   COMPANY NAME"));
                            doc.Add(new Paragraph("                                                      [Street Addres]"));
                            doc.Add(new Paragraph("\n                                                       SALARY SLIP"));

                            doc.Add(new Paragraph("\nEmployee ID: " + empId));
                            doc.Add(new Paragraph("First Name        _____________________________________________   " + reader["FirstName"].ToString()));
                            doc.Add(new Paragraph("Last Name        _____________________________________________   " + reader["LastName"].ToString()));
                            doc.Add(new Paragraph("dd/MM/yyyy & Time    ________________________________________   " + reader["DateUpdate"].ToString()));

                            doc.Add(new Paragraph("\nPayroll ID: " + reader["Payroll_Id"].ToString()));
                            doc.Add(new Paragraph("Day Present    ______________________________________________   " + reader["No_Of_Present"].ToString()));
                            doc.Add(new Paragraph("Salary Amount  _____________________________________________   " + reader["Salary"].ToString()));
                            doc.Add(new Paragraph("Role         __________________________________________________   " + reader["Department"].ToString()));

                            doc.Add(new Paragraph("\nDeduction"));
                            doc.Add(new Paragraph("SSS              ________________________________________________   " + reader["SSS"].ToString()));
                            doc.Add(new Paragraph("PagIbig         ________________________________________________   " + reader["PagIbig"].ToString()));
                            doc.Add(new Paragraph("PhilHealth     ________________________________________________   " + reader["PhilHealth"].ToString()));

                            doc.Add(new Paragraph("\nTotal Deduction"));
                            doc.Add(new Paragraph("Amount             ______________________________________________   " + reader["TotalDeduction"].ToString()));

                            doc.Add(new Paragraph("\n Date Generated:  " + DateTime.Now.ToString()));

                            doc.Add(new Paragraph("\n"));
                            doc.Add(new Paragraph("\n"));
                            doc.Add(new Paragraph("\n         ______________________                                ______________________"));
                            doc.Add(new Paragraph("\n                     Signed By                                                           Approve By"));



                            doc.Close();
                            MessageBox.Show("PDF Exported Successfully");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Employee not Found");
                }
            }

        }
 
        private void PrintPaySlip_Load(object sender, EventArgs e)
        {
            txtEmpID.Text = EmployeeLogIn.LoggedInUSername;

            printBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, printBtn.Width, printBtn.Height, 7, 7));
        }
    }
}
