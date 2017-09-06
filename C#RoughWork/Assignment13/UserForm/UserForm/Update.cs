using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserInfo;

namespace UserForm
{
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string oldName = txtOldName.Text;
            int newName = int.Parse(txtNewName.Text);

            ContextUser cu = new ContextUser();
            var users = cu.Users.Where(i=>i.Name.Equals(oldName));
            foreach (var item in users)
            {
                item.Age = newName;
            }

            cu.SaveChanges();
        }
    }
}
