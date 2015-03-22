using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO.Net
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExeNoQuery_Click(object sender, EventArgs e)
        {
            SQLHelper.ExecuteNonQuery("insert into [T_Persons](Name,Age) values(@name,@age)", new SqlParameter("name", "Tom"), new SqlParameter("age", 18));
        }

        private void btnExeScalar_Click(object sender, EventArgs e)
        {
            object i = SQLHelper.ExecuteScalar("select count(*) from [T_Persons]");
            MessageBox.Show(Convert.ToString(i));
        }

        private void btnExeReader_Click(object sender, EventArgs e)
        {

        }

    }
}
