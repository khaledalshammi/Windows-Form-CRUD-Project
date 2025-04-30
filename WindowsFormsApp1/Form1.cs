using System;
using System.Linq;
using System.Data.Entity;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private UserProfileDBContext db;
        public Form1()
        {
            InitializeComponent();
            db = new UserProfileDBContext();
            this.dataGridView2.CellClick += dataGridView2_CellClick;
            this.dataGridView2.Click += dataGridView2_Click;
            //this.dataGridView2.AutoGenerateColumns = false;
            this.Click += Form1_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Department> departments = db.Departments.ToList();

            LoadUserProfiles();
            department.DataSource = departments;
            department.DisplayMember = "DeptName";
            department.ValueMember = "DeptID";
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            //dataGridView2.Height = dataGridView2.ColumnHeadersHeight + dataGridView2.Rows.GetRowsHeight(DataGridViewElementStates.Visible);
            update.Enabled = false;
            delete.Enabled = false;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 0)
            {
                dataGridView2.ClearSelection();
                ClearFormFields();
            }
        }

        private void Add(object sender, EventArgs e)
        {
            if (department.SelectedValue == null)
            {
                MessageBox.Show("Please select a valid department.");
                return;
            }

            string fullnameText = fullname.Text.Trim();
            string emailText = email.Text.Trim();
            DateTime birthdateText = birthdate.Value;

            int deptId = (int)department.SelectedValue;

            Department departmentTable = db.Departments.Find(deptId);
            if (departmentTable != null)
            {
                UserProfile new_user_rofile = new UserProfile()
                {
                    FullName = fullnameText,
                    Email = emailText,
                    BirthDate = birthdateText,
                    Department = departmentTable
                };
                if (ValidateModelData(new_user_rofile, db))
                {
                    db.UserProfiles.Add(new_user_rofile);
                    db.SaveChanges();
                    MessageBox.Show("Data is added successfully");
                    LoadUserProfiles();
                    ClearFormFields();
                    dataGridView2.ClearSelection();
                }
            }
            else
            {
                MessageBox.Show("Department is not exists");
            }
        }

        private void Delete(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow == null)
            {
                MessageBox.Show("Please select a record to delete.");
                return;
            }
            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this record?",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );
            if (result == DialogResult.Yes)
            {
                int userId = (int)dataGridView2.CurrentRow.Cells["UserID"].Value;
                UserProfile user = db.UserProfiles.Find(userId);
                if (user != null)
                {
                    db.UserProfiles.Remove(user);
                    db.SaveChanges();
                    //MessageBox.Show("Data is deleted successfully");
                    LoadUserProfiles();
                    ClearFormFields();
                    dataGridView2.ClearSelection();
                }
                else
                {
                    MessageBox.Show("User not found.");
                }
            }
        }

        private void Update(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow == null)
            {
                MessageBox.Show("Please select a record to delete.");
                return;
            }
            int userId = (int)dataGridView2.CurrentRow.Cells["UserID"].Value;
            UserProfile user = db.UserProfiles.Find(userId);
            if (user != null)
            {
                string fullnameText = fullname.Text.Trim();
                string emailText = email.Text.Trim();
                DateTime birthdateText = birthdate.Value;

                int deptId = (int)department.SelectedValue;

                Department departmentTable = db.Departments.Find(deptId);
                if (departmentTable != null)
                {
                    user.FullName = fullnameText;
                    user.Email = emailText;
                    user.BirthDate = birthdateText;
                    user.Department = departmentTable;
                    if (ValidateModelData(user, db))
                    {
                        db.SaveChanges();
                        MessageBox.Show("Data is updated successfully");
                        LoadUserProfiles();
                        ClearFormFields();
                        dataGridView2.ClearSelection();
                    }
                }
                else
                {
                    MessageBox.Show("Department is not exists");
                }
            }
            else
            {
                MessageBox.Show("User not found.");
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView2.Rows[e.RowIndex].Cells["UserID"].Value != null)
            {
                update.Enabled = true;
                delete.Enabled = true;
                int userId = (int)dataGridView2.Rows[e.RowIndex].Cells["UserID"].Value;

                var selectedUser = db.UserProfiles
                    .Include(u => u.Department)
                    .FirstOrDefault(u => u.UserID == userId);

                if (selectedUser != null)
                {
                    fullname.Text = selectedUser.FullName;
                    email.Text = selectedUser.Email;
                    birthdate.Value = selectedUser.BirthDate;
                    department.SelectedValue = selectedUser.Department.DeptID;
                }
            }
            else
            {
                ClearFormFields();
            }
        }
        private void dataGridView2_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count == 0)
            {
                ClearFormFields();
            }
        }

        private void ClearFormFields()
        {
            fullname.Clear();
            email.Clear();
            birthdate.Value = DateTime.Now;
            department.SelectedIndex = 0;
            update.Enabled = false;
            delete.Enabled = false;
        }

        // Custom Methods

        /*
        public bool CheckMailAddress(string email)
        {
            return new EmailAddressAttribute().IsValid(email);
        }
        */
        public bool ValidateModelData(UserProfile newUser, UserProfileDBContext db)
        {
            var context = new ValidationContext(newUser, null, null);
            var results = new List<ValidationResult>();

            bool isValid = Validator.TryValidateObject(newUser, context, results, true);

            if (!isValid)
            {
                string errorMessages = string.Join("\n", results.Select(r => r.ErrorMessage));
                MessageBox.Show("Validation failed:\n" + errorMessages);
                return false;
            }
            return true;
        }
        public void LoadUserProfiles()
        {
            using (UserProfileDBContext db = new UserProfileDBContext())
            {
                var userProfiles = db.UserProfiles
                    .Include(u => u.Department)
                    .ToList()
                    .Select(u => new
                    {
                        u.UserID,
                        u.FullName,
                        u.Email,
                        BirthDate = u.BirthDate.ToString("yyyy-MM-dd"),
                        Department = u.Department.DeptName
                    })
                    .ToList();

                dataGridView2.DataSource = userProfiles;
                dataGridView2.Columns["UserID"].Visible = false;
                dataGridView2.Columns["FullName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
    }
}
