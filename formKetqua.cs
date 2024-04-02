using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace xoso_PhanVanTho
{
    public partial class formKetqua : Form
    {
        int dem = 0;
        string daiSql = "";
        string ngaySql = "";
        string giaveSql = "";
        string ketquaSql = "";
        string[] ketquaProcess = new string[18];
        public formKetqua()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            formTho f1 = new formTho();
            f1.ShowDialog();
        }
        void checkGiai()
        {
            if (txtKetqua.Text.Length <6 || txtKetqua.Text.Length >6)
            {
                txtKetqua.Enabled = true;
                MessageBox.Show("Vé số phải từ 6 chữ số");
            }
            else
            {
                string strConnection = string.Format("Server=localhost; database=dbxoso; UID=root; password=; SslMode = none");
                MySqlConnection connection = new MySqlConnection(strConnection);
                try
                {
                    connection.Open();
                    string Query = "SELECT * FROM savexoso";
                    MySqlCommand MyCommand2 = new MySqlCommand(Query, connection);
                    MySqlDataReader rdr = MyCommand2.ExecuteReader();
                    while (rdr.Read())
                    {
                        daiSql = rdr.GetString(1);
                        ngaySql = rdr.GetString(2);
                        giaveSql = rdr.GetString(3);
                        if(cbb1.Text == daiSql && dateTimePicker1.Text == ngaySql)
                        {
                            ketquaSql = rdr.GetString(4);
                            lbGiave.Text = giaveSql;
                            lbDai.Text = "Kết quả xổ số tỉnh "+daiSql+" "+ ngaySql;
                        }
                    }
                    checkKetqua();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Ket noi that bai: " + e.Message);
                }
                finally
                {
                    connection.Close();
                    connection.Dispose();
                }
            }
        }
        void checkKetqua()
        {
            ketquaProcess = ketquaSql.Split(',');
            if (txtKetqua.Text.Substring(txtKetqua.Text.Length - 2) == ketquaProcess[0].Substring(ketquaProcess[0].Length - 2))
            {
                lbThongbao.Text += "Chúc mừng bạn đã trúng giải 8" + "\r\n";
                dem++;
            }
            if (txtKetqua.Text.Substring(txtKetqua.Text.Length - 3) == ketquaProcess[1].Substring(ketquaProcess[1].Length - 3))
            {
                lbThongbao.Text += "Chúc mừng bạn đã trúng giải 7" + "\r\n";
                dem++;
            }
            if (txtKetqua.Text.Substring(txtKetqua.Text.Length - 4) == ketquaProcess[ 2].Substring(ketquaProcess[ 2].Length - 4))
            {
                lbThongbao.Text += "Chúc mừng bạn đã trúng giải 6" + "\r\n";
                dem++;
            }
            if (txtKetqua.Text.Substring(txtKetqua.Text.Length - 4) == ketquaProcess[ 3].Substring(ketquaProcess[ 3].Length - 4))
            {
                lbThongbao.Text += "Chúc mừng bạn đã trúng giải 6" + "\r\n";
                dem++;
            }
            if (txtKetqua.Text.Substring(txtKetqua.Text.Length - 4) == ketquaProcess[ 4].Substring(ketquaProcess[ 4].Length - 4))
            {
                lbThongbao.Text += "Chúc mừng bạn đã trúng giải 6" + "\r\n";
                dem++;
            }
            if (txtKetqua.Text.Substring(txtKetqua.Text.Length - 4) == ketquaProcess[ 5].Substring(ketquaProcess[ 5].Length - 4))
            {
                lbThongbao.Text += "Chúc mừng bạn đã trúng giải 5" + "\r\n";
                dem++;
            }
            if (txtKetqua.Text.Substring(txtKetqua.Text.Length - 5) == ketquaProcess[ 6].Substring(ketquaProcess[ 6].Length - 5))
            {
                lbThongbao.Text += "Chúc mừng bạn đã trúng giải 4" + "\r\n";
                dem++;
            }
            if (txtKetqua.Text.Substring(txtKetqua.Text.Length - 5) == ketquaProcess[ 7].Substring(ketquaProcess[ 7].Length - 5))
            {
                lbThongbao.Text += "Chúc mừng bạn đã trúng giải 4" + "\r\n";
                dem++;
            }
            if (txtKetqua.Text.Substring(txtKetqua.Text.Length - 5) == ketquaProcess[ 8].Substring(ketquaProcess[ 8].Length - 5))
            {
                lbThongbao.Text += "Chúc mừng bạn đã trúng giải 4" + "\r\n";
                dem++;
            }
            if (txtKetqua.Text.Substring(txtKetqua.Text.Length - 5) == ketquaProcess[9].Substring(ketquaProcess[9].Length - 5))
            {
                lbThongbao.Text += "Chúc mừng bạn đã trúng giải 4" + "\r\n";
                dem++;
            }
            if (txtKetqua.Text.Substring(txtKetqua.Text.Length - 5) == ketquaProcess[10].Substring(ketquaProcess[10].Length - 5))
            {
                lbThongbao.Text += "Chúc mừng bạn đã trúng giải 4" + "\r\n";
                dem++;
            }
            if (txtKetqua.Text.Substring(txtKetqua.Text.Length - 5) == ketquaProcess[11].Substring(ketquaProcess[11].Length - 5))
            {
                lbThongbao.Text += "Chúc mừng bạn đã trúng giải 4" + "\r\n";
                dem++;
            }
            if (txtKetqua.Text.Substring(txtKetqua.Text.Length - 5) == ketquaProcess[12].Substring(ketquaProcess[12].Length - 5))
            {
                lbThongbao.Text += "Chúc mừng bạn đã trúng giải 4" + "\r\n";
                dem++;
            }
            if (txtKetqua.Text.Substring(txtKetqua.Text.Length - 5) == ketquaProcess[13].Substring(ketquaProcess[13].Length - 5))
            {
                lbThongbao.Text += "Chúc mừng bạn đã trúng giải 3" + "\r\n";
                dem++;
            }
            if (txtKetqua.Text.Substring(txtKetqua.Text.Length - 5) == ketquaProcess[14].Substring(ketquaProcess[14].Length - 5))
            {
                lbThongbao.Text += "Chúc mừng bạn đã trúng giải 3" + "\r\n";
                dem++;
            }
            if (txtKetqua.Text.Substring(txtKetqua.Text.Length - 5) == ketquaProcess[ 15].Substring(ketquaProcess[ 15].Length - 5))
            {
                lbThongbao.Text += "Chúc mừng bạn đã trúng giải 2" + "\r\n";
                dem++;
            }
            if (txtKetqua.Text.Substring(txtKetqua.Text.Length - 5) == ketquaProcess[ 16].Substring(ketquaProcess[ 16].Length - 5))
            {
                lbThongbao.Text += "Chúc mừng bạn đã trúng giải nhất" + "\r\n";
                dem++;
            }
            if (txtKetqua.Text.Substring(txtKetqua.Text.Length - 6) == ketquaProcess[ 17].Substring(ketquaProcess[ 17].Length - 6))
            {
                lbThongbao.Text += "Chúc mừng bạn đã trúng giải đặc biệt" + "\r\n";
                dem++;
            }
            if(dem == 0)
            {
                lbThongbao.Text = "Chúc bạn may mắn lần sau!!!";
            }
            txtKetqua.Enabled = false;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            checkGiai();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtKetqua.Enabled = true;
            lbThongbao.Text = "";
            dem = 0;
        }

        private void cbb1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
