using C969_ncarrel.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C969_ncarrel
{
    public partial class Homepage : Form
    {
        public BindingList<Appointment> appointments = new BindingList<Appointment>();
        public QueryDB Params = new QueryDB();
        public Homepage()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Homepage_Load(object sender, EventArgs e)
        {
            
        }
    }
}
