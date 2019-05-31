using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class confirmStandsModal : UserControl
    {
        private string location;
        private string area;
        private int dbId; //Data base Card ID;
        public confirmStandsModal(string location, string area, int dbId)
        {
            this.location = location;
            this.area = area;
            this.dbId = dbId;
            InitializeComponent();

            this.initValues();

            this.Focus();
        }

        public void testLog()
        {
            Console.WriteLine(location +" "+area+" "+dbId);
        }

        private void initValues ()
        {
            localisationTxtBox.Text = this.location;
            areaTxtBox.Text = this.area;

        }

    }
}
