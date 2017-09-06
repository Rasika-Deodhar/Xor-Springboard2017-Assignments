using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserForm;
using UserInfo;

namespace UserInfo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            //string Name = txtName.Text;
        }

        private void txtAge_TextChanged(object sender, EventArgs e)
        {
            //int Age = int.Parse(txtAge.Text);
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            //string name = txtName.Text;
            //lblName.Text = name;
            string NameText = txtName.Text;
            int AgeText = int.Parse(txtAge.Text);

            using (var user = new ContextUser())
            {
                var userObj = new User { Name = NameText, Age = AgeText};
                user.Users.Add(userObj);
                user.SaveChanges();
                //Console.WriteLine("Record added to Department!");
                lblName.Text = "Record added to Department!";
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            Update update = new Update();
            update.ShowDialog();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            Delete delete = new Delete();
            delete.ShowDialog();
        }
    }
}
