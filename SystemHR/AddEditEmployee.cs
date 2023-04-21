using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemHR
{
    public partial class AddEditEmployee : Form
    {
        private FileHelper<List<Employees>> _fileHelper = new FileHelper<List<Employees>>(Program.FilePath); 
        public EventHandler ReloadProducts;
        private int _employeeId;
        private Employees _employees;
        public AddEditEmployee(int id = 0)
        {
            InitializeComponent();
            _employeeId = id;
            tbStatusEmployeed.Text = "Zatrudniony";
            tbFirstName.Select();

            GetEmployeeData();

        }

        private void GetEmployeeData()
        {
            if (_employeeId != 0)
            {
                Text = "Edytowanie danych pracownika";

                var employess = _fileHelper.DeserializeFromFile();
                _employees = employess.FirstOrDefault(x => x.Id == _employeeId);

                if (_employees == null)
                    throw new Exception("Brak ucznia o podanym Id");

                FillTextBoxes();
            }
        }

        private void FillTextBoxes()
        {
            tbId.Text = _employees.Id.ToString();
            tbFirstName.Text = _employees.FirstName.ToString();
            tbLastName.Text = _employees.LastName.ToString();
            tbStatusEmployeed.Text = _employees.Employeed.ToString();
            tbDismissedDate.Text = _employees.DismissedDate.ToString();
            nudWage.Value = _employees.Wage;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var employees = _fileHelper.DeserializeFromFile();

            if (_employeeId != 0)
                employees.RemoveAll(x => x.Id == _employeeId);
            else
                AssignIdToNewEmployee(employees);

            AddNewEmployeeToList(employees);

            _fileHelper.SerializeToFile(employees);
        }

        private void AssignIdToNewEmployee(List<Employees> employees)
        {
            var employeeWithHighestId = employees.OrderByDescending(x => x.Id).FirstOrDefault();
            _employeeId = employeeWithHighestId == null ? 1 : employeeWithHighestId.Id + 1;
        }

        private void AddNewEmployeeToList(List<Employees> employees)
        {
            var employee = new Employees
            {
                Id = _employeeId,
                FirstName = tbFirstName.Text,
                LastName = tbLastName.Text,
                EmployedDate = DateTime.Now,
                DismissedDate = null,
                Employeed = tbStatusEmployeed.Text,
                Wage = nudWage.Value,
                GroupId = 1
            };
            employees.Add(employee);

            AssignIdToNewEmployee(employees);

            ReloadProducts?.Invoke(btnConfirm, new EmployeeAddEventArgs(employees));

            NewEmployee();
        }

        private void NewEmployee()
        {
            tbId.Text = string.Empty;
            tbFirstName.Text = string.Empty;
            tbLastName.Text = string.Empty;
            nudWage.Text = "0,00";
            tbDismissedDate = default;
            tbStatusEmployeed.Text = "Zatrudniony";
            dtpEmployeed.Text = string.Empty;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
