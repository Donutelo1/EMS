using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace EMS
{
    public partial class AddEmployeeForm : Form
    {



        private int _projectCounter =  1;
        private string _projectPrefix = "1900";
        private string _counterFilePath = "counter.txt"; // File to store the counter
        private const int MaxLength = 11;

        //sql connention string
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-GOK6444\SQLEXPRESS01;Initial Catalog=ConnectionDb;Integrated Security=True;Encrypt=False");
        //ddl import for round form
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
        public AddEmployeeForm()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            //displayEmployeeData();
            LoadCounter();
           
           //text contact key press
           txtcontact.KeyPress += txtcontact_KeyPress;
        }

        private void txtcontact_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow digits, backspace, and the negative sign (if needed at the beginning)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && txtcontact.SelectionStart == 0)
            {

                e.Handled = true; // Prevent the character from being entered
            }
            // Prevent space character
            else if (e.KeyChar == ' ')
            {
                e.Handled = true;
            }
            // Prevent exceeding the maximum length during typing
            else if (txtcontact.Text.Length >= MaxLength && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
            // Prevent negative sign
            else if (e.KeyChar == '-')
            {
                e.Handled = true;
            }
        }
        private void LoadCounter()
        {
            if (File.Exists(_counterFilePath))
            {
                string counterString = File.ReadAllText(_counterFilePath);
                if (int.TryParse(counterString, out int loadedCounter))
                {
                    _projectCounter = loadedCounter;
                }
            }
        }
        private void SaveCounter()
        {
            File.WriteAllText(_counterFilePath, _projectCounter.ToString());
        }

        private void exitBttn_Click(object sender, EventArgs e)// exit button
        {
            this.Close();
        }

        public void clearFields() // clear text box fields
        {
            txtFname.Text = "";
            txtLname.Text = "";
            txtGmail.Text = "";
            txtPass.Text = "";
            txtcontact.Text = "";
            cmbDept.SelectedIndex = -1;
            cmbGender.SelectedIndex = -1;
            cmbStatus.SelectedIndex = -1;
            empPic.Image = null; 
        }

       
        private void addEmpBtn_Click(object sender, EventArgs e)
        {
            string projectId = $"{_projectPrefix}{_projectCounter:D2}";
            textBox1.Text = projectId; // Display in the textbox
            _projectCounter++;

            string email = txtGmail.Text.Trim();
            if (validgmail(email))
            {

            }
            
            else
            {
                MessageBox.Show("Enter valid gmail", "error", MessageBoxButtons.OK);
                return;
            }
            if (txtcontact.Text.Length < MaxLength)
            {
                MessageBox.Show($"Please enter a contact number with at least {MaxLength} digits.", "Incomplete Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtFname.Text == ""
            || txtLname.Text == ""
            || txtcontact.Text ==""
            || txtGmail.Text ==""
            || cmbDept.Text ==""
            || cmbGender.Text ==""
            || cmbStatus.Text ==""
            || txtPass.Text =="")
            {
                MessageBox.Show("Please Fill All Fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                if (conn.State == ConnectionState.Closed)
                {

                   
                    try
                    {

                        MemoryStream ms = new MemoryStream();
                       empPic.Image.Save(ms, empPic.Image.RawFormat);
                        byte[] a = ms.GetBuffer();
                        ms.Close();
                        conn.Open();

                        string checkEmID = "SELECT COUNT (*) FROM Employees WHERE Employee_Id = @id ANd DateDelete is null";
     
                        using (SqlCommand checkEm = new SqlCommand(checkEmID, conn))
                        {
                            checkEm.Parameters.AddWithValue("@id", projectId);

                            int count = (int)checkEm.ExecuteScalar(); 

                            if (count >= 1)
                            {
                                MessageBox.Show(projectId + "is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                //date and time today
                                DateTime today = DateTime.Today; 

                                //query
                                string insertData = "SET IDENTITY_INSERT Employees ON; " + 
                                    "INSERT INTO Employees (Employee_Id, FirstName, LastName, Contact, Gender, Department, Password, Status, Gmail, DateInsert, Image, UnhashPassword)"
                                    + "VALUES (@employeeId , @fName, @lName, @contact, @gender, @department, @pass, @status, @gmail, @dateInsert, @img, @passtilan ); INSERT INTO Attendance (Employee_Id) VALUES(SCOPE_IDENTITY()); INSERT INTO Payroll (Attendance_Id, Employee_Id, Department, SSS, PagIbig, PhilHealth, TotalDeduction, Salary, No_Of_Present) VALUES(SCOPE_IDENTITY(), @employeeId, @department, @sss, @pagibig, @philhealth, @deduc, @salary, @daypresent); " +
                             "SET IDENTITY_INSERT Employees OFF;";

                                //command
                                using (SqlCommand cmd = new SqlCommand(insertData ,conn))
                                {
                                    //command parameters
                                    cmd.Parameters.Add("@img", SqlDbType.VarBinary).Value = a;

                                    cmd.Parameters.AddWithValue("@employeeId", projectId);

                                    cmd.Parameters.AddWithValue("@fName", txtFname.Text.Trim());
                                    cmd.Parameters.AddWithValue("@lName", txtLname.Text.Trim());
                                    cmd.Parameters.AddWithValue("@contact", txtcontact.Text.Trim());
                                    cmd.Parameters.AddWithValue("@gender", cmbGender.Text.Trim());
                                    cmd.Parameters.AddWithValue("@department", cmbDept.Text.Trim());
                                    cmd.Parameters.AddWithValue("@pass", SHA256Hasher.ComputeSha256Hash(txtPass.Text));
                                    cmd.Parameters.AddWithValue("@passtilan", txtPass.Text);
                                    cmd.Parameters.AddWithValue("@status", cmbStatus.Text.Trim());
                                    cmd.Parameters.AddWithValue("@gmail", txtGmail.Text.Trim());
                                    cmd.Parameters.AddWithValue("@sss", 0);
                                    cmd.Parameters.AddWithValue("@pagibig", 0);
                                    cmd.Parameters.AddWithValue("@philhealth", 0);
                                    cmd.Parameters.AddWithValue("@deduc", 0);
                                    cmd.Parameters.AddWithValue("@salary", 0);
                                    cmd.Parameters.AddWithValue("@dayPresent", 0);
                                    cmd.Parameters.AddWithValue("dateInsert", today);


                                    cmd.ExecuteNonQuery();// command exceute
                                    // message box show
                                    MessageBox.Show("Added Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    clearFields();
                                }

                            }
                        }
                    }
                    catch 
                    {
         
                        NotificationError a = new NotificationError();
                        a.ShowDialog();
                    }
                    finally
                    {
                        conn.Close();


                    }
                }
            }
        }

        private void cmbStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbGender_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

      

        private void AddEmployeeForm_Load(object sender, EventArgs e)
        {
            LoadLastRowId(); // Load the last RowId when the form loads

            textBox1.ReadOnly = true;

            exitBttn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, exitBttn.Width, exitBttn.Height, 15, 15));
            addEmpBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, addEmpBtn.Width, addEmpBtn.Height, 15, 15));
            cancelBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, cancelBtn.Width, cancelBtn.Height, 15, 15));
            UpdateBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, UpdateBtn.Width, UpdateBtn.Height, 15, 15));
            BackBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, BackBtn.Width, BackBtn.Height, 15, 15));
            RetrieveDept();
        }


        private void LoadLastRowId()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-GOK6444\SQLEXPRESS01;Initial Catalog=ConnectionDb;Integrated Security=True;Encrypt=False"))
                {
                    connection.Open();

                    string query = "SELECT TOP 1 Employee" +
                        "_Id FROM Employees ORDER BY Employee_Id DESC"; // Get the last RowId  

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        object result = command.ExecuteScalar(); // Execute and get the result

                        if (result != null && result != DBNull.Value)
                        {
                            
                            textBox1.Text = result.ToString(); // Display in the textbox
                        }
                        else
                        {
                          
                            textBox1.Text = "No data found"; // Or handle the case where the table is empty
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading last RowId: " + ex.Message);
               
                textBox1.Text = "Error"; // Indicate an error
            }
        }




        private void cmbDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        
        void RetrieveDept()
        {
            try
            {
                conn.Open();
                String query = "SELECT * FROM Department Where Status = 'Active'";
                SqlCommand cmd = new SqlCommand(query , conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    cmbDept.Items.Add(reader["Department_Name"]).ToString();
                }
                conn.Close();
            }
            catch
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK);
            }
        }

        private void cmbDept_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
       private bool validgmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@gmail\.com$";
            return Regex.IsMatch(email, pattern);
        }


        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            string email = txtGmail.Text.Trim();
            if (validgmail(email))
            {

            }
            else
            {
                MessageBox.Show("Enter valid gmail", "error", MessageBoxButtons.OK);
                return;
            }
            if (txtcontact.Text.Length < MaxLength)
            {
                MessageBox.Show($"Please enter a contact number with at least {MaxLength} digits.", "Incomplete Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtFname.Text == ""
             || txtLname.Text == ""
             || txtcontact.Text == ""
             || txtGmail.Text == ""
             || cmbDept.Text == ""
             || cmbGender.Text == ""
             || cmbStatus.Text == "")

            {
                MessageBox.Show("Please Fiil All Fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            

            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to update " + " " + "?", "Confimation Message"
                    , MessageBoxButtons.YesNo);

                if (check == DialogResult.Yes)
                {
                    try
                    {
                        MemoryStream ms = new MemoryStream();

                        empPic.Image.Save(ms, empPic.Image.RawFormat );
                        byte[] a = ms.GetBuffer();
                        ms.Close();

                        conn.Open();

                        
                        DateTime today = DateTime.Today;

                        string updateData = "UPDATE Employees SET Status = @status, FirstName  = @fName, LastName = @lName, Contact = @contact, Gender = @gender,Department = @dept, Gmail = @gmail, DateUpdate = @date , Image = @img WHERE Employee_Id = @id";

                        using (SqlCommand cmd = new SqlCommand(updateData, conn))
                        {
                            cmd.Parameters.Add("@img", SqlDbType.VarBinary).Value = a;

                            cmd.Parameters.AddWithValue("@status", cmbStatus.Text.Trim());
                            cmd.Parameters.AddWithValue("@fName", txtFname.Text.Trim());
                            cmd.Parameters.AddWithValue("@lName", txtLname.Text.Trim());
                            cmd.Parameters.AddWithValue("@contact", txtcontact.Text.Trim());
                            cmd.Parameters.AddWithValue("@gender", cmbGender.Text.Trim());
                            cmd.Parameters.AddWithValue("@dept", cmbDept.Text.Trim());
                            cmd.Parameters.AddWithValue("@gmail", txtGmail.Text.Trim());  
                            cmd.Parameters.AddWithValue("@id", txtEmpid.Text.Trim());
                            cmd.Parameters.AddWithValue("date", today);

                            cmd.ExecuteNonQuery();
                            
                            MessageBox.Show("Update Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clearFields();
                         
                        }

                    }
                    catch
                    {
                      
                        NotificationError a = new NotificationError();
                        a.ShowDialog();
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Cancelled.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void txtFname_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"\p{Cs}";
           txtFname.Text = Regex.Replace(txtFname.Text, pattern, "");
            txtFname.SelectionStart = txtFname.Text.Length;
        }

        private void txtLname_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"\p{Cs}";
            txtLname.Text = Regex.Replace(txtLname.Text, pattern, "");
           txtLname.SelectionStart = txtLname.Text.Length;
        }

        private void txtcontact_TextChanged(object sender, EventArgs e)
        {
            // Enforce maximum length if text is pasted or set programmatically
            if (txtcontact.Text.Length > MaxLength)
            {
                txtcontact.Text = txtcontact.Text.Substring(0, MaxLength);
                txtcontact.SelectionStart = MaxLength; // Keep cursor at the end
            }
           
            string pattern = @"\p{Cs}";
            txtcontact.Text = Regex.Replace(txtcontact.Text, pattern, "");
            txtcontact.SelectionStart =txtcontact.Text.Length;
        }

        private void txtGmail_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"\p{Cs}";
            txtGmail.Text = Regex.Replace(txtGmail.Text, pattern, "");
            txtGmail.SelectionStart = txtGmail.Text.Length;
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"\p{Cs}";
            txtPass.Text = Regex.Replace(txtPass.Text, pattern, "");
            txtPass.SelectionStart = txtPass.Text.Length;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddEmployeeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveCounter(); // Save on form close, to be extra safe.
        }

        private void browsebtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
              empPic.Image = new Bitmap(open.FileName);
                // image file path  
                String FilePath = open.FileName;
            }
        }

        private void cmbDept_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void cmbDept_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}