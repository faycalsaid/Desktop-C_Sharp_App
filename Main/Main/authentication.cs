using Main.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class Authentication : Form
    {
        static Authentication _obj;
        public Authentication()
        {
            InitializeComponent();

        }

        private void login()
        {
            if(DAOAuth.exist(loginTxtBox.Text, pwdTxtBox.Text))
            {
                mainForm m = new mainForm();
                m.Show();
                this.Hide();
            }
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            login();
        }

        public static Authentication Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Authentication();
                }

                return _obj;
            }
        }

        private void ExitAuthBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
