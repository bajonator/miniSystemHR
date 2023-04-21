using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SystemHR
{
    public partial class Main : Form
    {
        private FileHelper<List<Employees>> _fileHelper = new FileHelper<List<Employees>>(Program.FilePath);
        private List<Group> _groups;
        public Main()
        {
            InitializeComponent();
            _groups = GroupHelper.GetGroups("Wszyscy");
            InitGroupCombobox();
            SetColumnsHeader();
            HideColumns();
            RefreshEmployee();
        }

        private void InitGroupCombobox()
        {
            cbFiltering.DataSource = _groups;
            cbFiltering.DisplayMember = "Name";
            cbFiltering.ValueMember = "Id";
        }

        private void SetColumnsHeader()
        {
            dgvEmployees.Columns[nameof(Employees.Id)].HeaderText = "Numer";
            dgvEmployees.Columns[nameof(Employees.FirstName)].HeaderText = "Imię";
            dgvEmployees.Columns[nameof(Employees.LastName)].HeaderText = "Nazwisko";
            dgvEmployees.Columns[nameof(Employees.DismissedDate)].HeaderText = "Zwolnony dnia";
            dgvEmployees.Columns[nameof(Employees.EmployedDate)].HeaderText = "Zatrudniony dnia";
            dgvEmployees.Columns[nameof(Employees.Wage)].HeaderText = "Zarobki";
            dgvEmployees.Columns[nameof(Employees.Employeed)].HeaderText = "Status zatrudnienia";
        }
        private void HideColumns()
        {
            dgvEmployees.Columns[nameof(Employees.GroupId)].Visible = false;
        }
        private void RefreshEmployee()
        {
            var employees = _fileHelper.DeserializeFromFile();

            var selectedGroupId = (cbFiltering.SelectedItem as Group).Id;

            if (selectedGroupId != 0)
                employees = employees.Where(x => x.GroupId == selectedGroupId).ToList();

            dgvEmployees.DataSource = employees;
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            AddEditEmployee addEditEmployee = new AddEditEmployee();
            addEditEmployee.ReloadProducts += (s, ea) =>
            {
                EmployeeAddEventArgs eventArgs = ea as EmployeeAddEventArgs;
                if (eventArgs != null)
                {
                    List<Employees> employees = eventArgs.Employees;
                    dgvEmployees.DataSource = employees;
                }
            };
            addEditEmployee.ShowDialog();
        }

        private void btnEditEmployee_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count == 0)
            {
                MessageBox.Show("Proszę zaznacz pracownika, którego dane chcesz edytować.");
                return;
            }

            var addEditEmployee = new AddEditEmployee(Convert.ToInt32(dgvEmployees.SelectedRows[0].Cells[0].Value));
            addEditEmployee.ReloadProducts += (s, ea) =>
            {
                EmployeeAddEventArgs eventArgs = ea as EmployeeAddEventArgs;
                if (eventArgs != null)
                {
                    List<Employees> employees = eventArgs.Employees;
                    dgvEmployees.DataSource = employees;
                }
            };
            addEditEmployee.ShowDialog();
        }

        private void cbFiltering_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshEmployee();
        }

        private void btnDissmiss_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count != 0)
            {
                ChangeStatusEmployee();
                RefreshEmployee();
            }
            else
                MessageBox.Show("Prosze wybierz pracownika, który ma być zwolniony.");
        }

        private void ChangeStatusEmployee()
        {
            var employees = _fileHelper.DeserializeFromFile();
            var employee = employees.FirstOrDefault(x => x.Id == Convert.ToInt32(dgvEmployees.SelectedRows[0].Cells[0].Value));
            if (employee != null)
            {
                employee.DismissedDate = DateTime.Now;
                employee.Employeed = "Zwolniony";
                employee.GroupId = 2;
            }
            _fileHelper.SerializeToFile(employees);
        }

        private void dgvEmployees_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int value = (int)dgvEmployees.Rows[e.RowIndex].Cells[7].Value;

            if (value == 2)
            {
                e.CellStyle.BackColor = Color.Red;
            }
            else if (value == 1)
            {
                e.CellStyle.BackColor = Color.MediumSeaGreen;
            }
            else
                e.CellStyle.BackColor = Color.White;


            dgvEmployees.ColumnHeadersDefaultCellStyle.BackColor = Color.Yellow;
            dgvEmployees.ColumnHeadersDefaultCellStyle.Font = new Font("SegoeUI", 8, FontStyle.Bold);
            dgvEmployees.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvEmployees.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvEmployees.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
    }
}
