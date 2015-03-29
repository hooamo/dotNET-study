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
            SqlDataReader reader = SQLHelper.ExecuteReader("select * from [T_Persons]");
            while (reader.Read())
            {
                string name = reader.GetString(reader.GetOrdinal("Name"));
                MessageBox.Show(name);
            }
        }

        private void btnExeDataTable_Click(object sender, EventArgs e)
        {
            DataTable table = SQLHelper.ExecuteDataTable("select * from [T_Persons]");
            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow row = table.Rows[i];
                string name = Convert.ToString(row["Name"]);
                MessageBox.Show(name);
            }
        }

    }
}
