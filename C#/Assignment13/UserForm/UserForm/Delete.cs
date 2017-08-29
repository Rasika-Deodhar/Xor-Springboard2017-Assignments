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
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string name = txtDeleteName.Text;

            ContextUser cs = new ContextUser();
            var u = cs.Users.Where(i=>i.Name.Equals(name));
            cs.Users.RemoveRange(u);

            cs.SaveChanges();
        }
    }
}
