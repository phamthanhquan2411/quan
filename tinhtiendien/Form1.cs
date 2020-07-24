using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace tinhtiendien
{
    public partial class bt_ : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=LAPTOP-3DGSACIE\SQLEXPRESS;Initial Catalog=btlsl;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from hihi ";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dgv.DataSource = table;
        }
        public bt_()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { 

            int i;
            i = dgv.CurrentRow.Index;
            tb_makh.Text = dgv.Rows[i].Cells["MAKH"].Value.ToString();
            tb_ten.Text = dgv.Rows[i].Cells["TENKH"].Value.ToString();
            tb_sdt.Text = dgv.Rows[i].Cells["SDT"].Value.ToString();
            tb_sd.Text = dgv.Rows[i].Cells["CHISODAU"].Value.ToString();
            tb_sc.Text = dgv.Rows[i].Cells["CHISOCUOI"].Value.ToString();
            dtime.Text = dgv.Rows[i].Cells["NGAYTINHTIEN"].Value.ToString();

        }
        

        private void bt_them_Click(object sender, EventArgs e)
        {
            if (tb_makh.Text == "")
            {
                MessageBox.Show("bạn chưa nhập mã Khách Hàng");
            }
            
            command = connection.CreateCommand();

            command.CommandText = "insert into hihi values('" + tb_makh.Text + "','" + tb_ten.Text + "','" + tb_sdt.Text + "','" + tb_sd.Text + "','"+tb_sc.Text+"','" + dtime.Text + "')";
            try
            {
                command.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Trùng Mã Khách Hàng","Thông Báo");
            }
            loaddata();
            tb_makh.Text = "";
            tb_sdt.Text = "";
            tb_sd.Text = "";
            tb_sc.Text = "";
            tb_ten.Text = "";
        }

        private void bt_sua_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = " update hihi set TENKH = '"+tb_ten.Text+"', SDT= '"+tb_sdt.Text+"', CHISODAU="+tb_sd.Text+",CHISOCUOI= "+tb_sc.Text+", NGAYTINHTIEN= '"+dtime.Text+"' where MAKH= '"+tb_makh.Text+"'";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "delete from hihi where MAKH = '" + tb_makh.Text + "'";
            command.ExecuteNonQuery();
            loaddata();
        }

        private void bt_tk_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from hihi where MAKH = '" + tb_tk.Text + "'";
            if (tb_tk.Text == "")
            {
                loaddata();
            }
            else
            {
                command.ExecuteNonQuery();
                adapter.SelectCommand = command;
                table.Clear();
                adapter.Fill(table);
                dgv.DataSource = table;
            }
            
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 fr = new Form2();
            fr.a = tb_makh.Text;
            fr.b = tb_ten.Text;
            fr.c = tb_sdt.Text;
            fr.d = tb_sd.Text;
            fr.g = dtime.Text;
            fr.h = tb_sc.Text;
            int sodien;
            int chisodau, chisocuoi;
            int duoi50;
            int tu51den100;
            int tu101den200;
            int tu201den300;
            int tren300;

            chisodau= Convert.ToInt32(tb_sd.Text);
            chisocuoi = Convert.ToInt32(tb_sc.Text);
            sodien = chisocuoi - chisodau;
            duoi50 = Convert.ToInt32(textBox2.Text);
            tu51den100 = Convert.ToInt32(textBox3.Text);
            tu101den200 = Convert.ToInt32(textBox4.Text);
            tu201den300 = Convert.ToInt32(textBox5.Text);
            tren300 = Convert.ToInt32(textBox6.Text);
            int tien;
            if (sodien <= 50)
            {
                tien = sodien * duoi50;
                fr.f = tien.ToString();
                fr.ShowDialog();
            }
            if (50 < sodien && sodien < 101)
            {
                tien = tu51den100 * (sodien - 50) + duoi50 * 50;
                fr.f = tien.ToString();
                fr.ShowDialog();
            }
            if (100 < sodien && sodien < 201)
            {
                tien = tu101den200 * (sodien - 100) + duoi50 * 50 + tu51den100 * 50;
                fr.f = tien.ToString();
                fr.ShowDialog();
            }
            if (200 < sodien && sodien < 301)
            {
                tien = tu201den300 * (sodien - 200) + duoi50 * 50 + tu51den100 * 50 + tu101den200 * 100;
                fr.f = tien.ToString();
                fr.ShowDialog();
            }
            if (sodien>300)
            {
                tien = tu101den200 * 100 + duoi50 * 50 + tu201den300 * 100 + tu51den100 * 50+ tren300*(sodien-300);
                fr.f = tien.ToString();
                fr.ShowDialog();
            }
        }
            private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult f = MessageBox.Show("Bạn muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (f == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loaddata();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
