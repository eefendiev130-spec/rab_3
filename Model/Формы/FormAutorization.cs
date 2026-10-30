using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Model.Формы;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1
{
    public partial class FormAutorization : Form
    {
        public FormAutorization()
        {
            InitializeComponent();
        }
        public static Users Enter_User;

        private void button1_Click(object sender, EventArgs e)
        {
            Enter_User = null;
            Model1 model1 = new Model1();
            Enter_User = model1.Users.FirstOrDefault(x => x.Login == textBoxLogin.Text && x.Password == textBoxPassword.Text);
            if (Enter_User != null) 
            {
                switch (Enter_User.RoleID)
                {
                    case 1:

                        FormManager formManager = new FormManager();
                        formManager.ShowDialog();
                        break;
                     case 2:
                        FormSeller formSeller = new FormSeller();
                        formSeller.ShowDialog();
                        break;
                    case 3:
                        Form1 formDirector = new Form1();
                        formDirector.ShowDialog();
                        break;
                        default: throw new Exception("Роль не найдена!");

                }
            }
        }
    }
}
