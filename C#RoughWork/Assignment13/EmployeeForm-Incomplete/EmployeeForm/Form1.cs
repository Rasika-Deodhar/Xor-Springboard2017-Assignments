using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeForm;
using EmployeeFormLibrary;

namespace EmployeeForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(txtEmpId.Text);
            string Name = txtEmpName.Text;
            int Salary = int.Parse(txtEmpSalary.Text);

            using (var empDB = new EmployeeDataEntities())
            {
                empDB.Employees
            }
        }
    }
}
