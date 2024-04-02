using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace xoso_PhanVanTho
{
    public partial class formTho : Form
    {
        public formTho()
        {
            InitializeComponent();
        }
        public string[] strKq1 = new string[18];
        public string[] strKq2 = new string[18];
        public string[] strGiai = new string[18];

        string daiSql = "";
        string ngaySql = "";

        int mlgiay = 0;
        int mlgiay1 = 0;
        int mlgiay2 = 0;
        int numer = 0;
        int giay = 0;
        int giay1 = 0;
        string RunNumber(int number)
        {
            string res = "";
            Random rd = new Random();
            while (res.Length < number)
                res = res + rd.Next(10);
            return res;
        }
        string RunNumber2(int a,int b)
        {
            string res = "";
            Random rd = new Random();
            res = res + rd.Next(a , b);
            return res;
        }
        void Start1(int id)
        {
            switch (id)
            {
                case 0:
                    {
                        txt8.Text = RunNumber(2);
                        strKq1[0] = txt8.Text;
                        strGiai[0] = "8";
                        break;
                    }
                case 1:
                    {
                        txt7.Text = RunNumber(3);
                        strKq1[1] = txt7.Text;
                        strGiai[1] = "7";
                        break;
                    }
                case 2:
                    {
                        txt61.Text = RunNumber(4);
                        strKq1[2] = txt61.Text;
                        strGiai[2] = "6.1";
                        break;
                    }
                case 3:
                    {
                        txt62.Text = RunNumber(4);
                        strKq1[3] = txt62.Text;
                        strGiai[3] = "6.2";
                        break;
                    }
                case 4:
                    {
                        txt63.Text = RunNumber(4);
                        strKq1[4] = txt63.Text;
                        strGiai[4] = "6.3";
                        break;
                    }
                case 5:
                    {
                        txt5.Text = RunNumber(4);
                        strKq1[5] = txt5.Text;
                        strGiai[5] = "5";
                        break;
                    }
                case 6:
                    {
                        txt41.Text = RunNumber(5);
                        strKq1[6] = txt41.Text;
                        strGiai[6] = "4.1";
                        break;
                    }
                case 7:
                    {
                        txt42.Text = RunNumber(5);
                        strKq1[7] = txt42.Text;
                        strGiai[7] = "4.2";
                        break;
                    }
                case 8:
                    {
                        txt43.Text = RunNumber(5);
                        strKq1[8] = txt43.Text;
                        strGiai[8] = "4.3";
                        break;
                    }
                case 9:
                    {
                        txt44.Text = RunNumber(5);
                        strKq1[9] = txt44.Text;
                        strGiai[9] = "4.4";
                        break;
                    }
                case 10:
                    {
                        txt45.Text = RunNumber(5);
                        strKq1[10] = txt45.Text;
                        strGiai[10] = "4.5";
                        break;
                    }
                case 11:
                    {
                        txt46.Text = RunNumber(5);
                        strKq1[11] = txt46.Text;
                        strGiai[11] = "4.6";
                        break;
                    }
                case 12:
                    {
                        txt47.Text = RunNumber(5);
                        strKq1[12] = txt47.Text;
                        strGiai[12] = "4.7";
                        break;
                    }
                case 13:
                    {
                        txt31.Text = RunNumber(5);
                        strKq1[13] = txt31.Text;
                        strGiai[13] = "3.1";
                        break;
                    }
                case 14:
                    {
                        txt32.Text = RunNumber(5);
                        strKq1[14] = txt32.Text;
                        strGiai[14] = "3.2";
                        break;
                    }
                case 15:
                    {
                        txt2.Text = RunNumber(5);
                        strKq1[15] = txt2.Text;
                        strGiai[15] = "2";
                        break;
                    }
                case 16:
                    {
                        txt1.Text = RunNumber(5);
                        strKq1[16] = txt1.Text;
                        strGiai[16] = "nhất";
                        break;
                    }
                case 17:
                    {
                        txtDB.Text = RunNumber(6);
                        strKq1[17] = txtDB.Text;
                        strGiai[17] = "đặc biệt";
                        break;
                    }
            }
        }
        void Start2(int id)
        {
            switch (id)
            {
                case 0:
                    {
                        txt28.Text = RunNumber2(10, 99);
                        strKq2[0] = txt28.Text;
                        strGiai[0] = "8";
                        break;
                    }
                case 1:
                    {
                        txt27.Text = RunNumber2(100, 999);
                        strKq2[1] = txt27.Text;
                        strGiai[1] = "7";
                        break;
                    }
                case 2:
                    {
                        txt261.Text = RunNumber2(1000, 9999);
                        strKq2[2] = txt261.Text;
                        strGiai[2] = "6.1";
                        break;
                    }
                case 3:
                    {
                        txt262.Text = RunNumber2(1000, 9999);
                        strKq2[3] = txt262.Text;
                        strGiai[3] = "6.2";
                        break;
                    }
                case 4:
                    {
                        txt263.Text = RunNumber2(1000, 9999);
                        strKq2[4] = txt263.Text;
                        strGiai[4] = "6.3";
                        break;
                    }
                case 5:
                    {
                        txt25.Text = RunNumber2(1000, 9999);
                        strKq2[5] = txt25.Text;
                        strGiai[5] = "5";
                        break;
                    }
                case 6:
                    {
                        txt241.Text = RunNumber2(10000, 99999);
                        strKq2[6] = txt241.Text;
                        strGiai[6] = "4.1";
                        break;
                    }
                case 7:
                    {
                        txt242.Text = RunNumber2(10000, 99999);
                        strKq2[7] = txt242.Text;
                        strGiai[7] = "4.2";
                        break;
                    }
                case 8:
                    {
                        txt243.Text = RunNumber2(10000, 99999);
                        strKq2[8] = txt243.Text;
                        strGiai[8] = "4.3";
                        break;
                    }
                case 9:
                    {
                        txt244.Text = RunNumber2(10000, 99999);
                        strKq2[9] = txt244.Text;
                        strGiai[9] = "4.4";
                        break;
                    }
                case 10:
                    {
                        txt245.Text = RunNumber2(10000, 99999);
                        strKq2[10] = txt245.Text;
                        strGiai[10] = "4.5";
                        break;
                    }
                case 11:
                    {
                        txt246.Text = RunNumber2(10000, 99999);
                        strKq2[11] = txt246.Text;
                        strGiai[11] = "4.6";
                        break;
                    }
                case 12:
                    {
                        txt247.Text = RunNumber2(10000, 99999);
                        strKq2[12] = txt247.Text;
                        strGiai[12] = "4.7";
                        break;
                    }
                case 13:
                    {
                        txt231.Text = RunNumber2(10000, 99999);
                        strKq2[13] = txt231.Text;
                        strGiai[13] = "3.1";
                        break;
                    }
                case 14:
                    {
                        txt232.Text = RunNumber2(10000, 99999);
                        strKq2[14] = txt232.Text;
                        strGiai[14] = "3.2";
                        break;
                    }
                case 15:
                    {
                        txt22.Text = RunNumber2(10000, 99999);
                        strKq2[15] = txt22.Text;
                        strGiai[15] = "2";
                        break;
                    }
                case 16:
                    {
                        txt21.Text = RunNumber2(10000, 99999);
                        strKq2[16] = txt21.Text;
                        strGiai[16] = "nhất";
                        break;
                    }
                case 17:
                    {
                        txt2DB.Text = RunNumber2(100000, 999999);
                        strKq2[17] = txt2DB.Text;
                        strGiai[17] = "đặc biệt";
                        break;
                    }
            }
        }
        int checkStart = 0;

        string returnStr1()
        {
            string strRes = "";
            for(int i = 0; i<strKq1.Length; i++)
            {
                strRes +=   strKq1[i]+ ",";
            }
            return strRes;
        }
        string returnStr2()
        {
            string strRes = "";
            for (int i = 0; i < strKq2.Length; i++)
            {
                strRes += strKq2[i] + ",";
            }
            return strRes;
        }
        void InsertDB1()
        {
            string strConnection = string.Format("Server=localhost; database=dbxoso; UID=root; password=; SslMode = none");
            MySqlConnection connection = new MySqlConnection(strConnection);
            try
            {
                string Query1 = "insert into dbxoso.savexoso(daiXoso,ngayXoso,giaveXoso,ketquaXoso) values('" + cbbDai1.Text + "','" + dateTimePicker1.Text + "','"+cbbGiave1.Text+"','" + returnStr1() + "')";
                MySqlCommand MyCommand1 = new MySqlCommand(Query1, connection);
                connection.Open();
                MySqlDataReader MyReader1 = MyCommand1.ExecuteReader();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ket noi that bai: " + e.Message) ;
            }
            finally
            {
                connection.Close();
                connection.Dispose();
            }
        }
        void InsertDB2()
        {
            string strConnection = string.Format("Server=localhost; database=dbxoso; UID=root; password=; SslMode = none");
            MySqlConnection connection = new MySqlConnection(strConnection);
            try
            {
                string Query2 = "insert into dbxoso.savexoso(daiXoso,ngayXoso,giaveXoso,ketquaXoso) values('" + cbbDai2.Text + "','" + dateTimePicker2.Text + "','"+cbbGiave2.Text+"','" + returnStr2() + "')";
                MySqlCommand MyCommand2 = new MySqlCommand(Query2, connection);
                connection.Open();
                MySqlDataReader MyReader2 = MyCommand2.ExecuteReader();
                
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
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                if (checkedRun())
                {
                    return;
                }
                else
                {
                    btnStart.Text = "Dừng";
                    timer1.Start();
                    btnClear.Enabled = false;
                    numeric.Enabled = false;
                    checkStart = 0;
                }
                
            }
            else
            {
                btnStart.Text = "Quay số";
                timer1.Stop();
                btnClear.Enabled = true;
            }
        }
        void clearTimer()
        {
            timer1.Stop();
            timer2.Stop();
            MessageBox.Show("Đã quay xong!!");
            btnClear.Enabled = true;
            numeric.Enabled = true;
            btnStart.Text = "Quay cả 2 đài";
            btnStart.Enabled = false;
        }

        bool checkedRun()
        {
            bool check = false;
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
                    if (cbbDai1.Text == daiSql && dateTimePicker1.Text == ngaySql)
                    {
                        MessageBox.Show("Đài này đã quay rồi!!");
                        timer1.Stop();
                        check = true;
                    }
                    else
                    {
                        if (cbbDai2.Text == daiSql && dateTimePicker2.Text == ngaySql)
                        {
                            MessageBox.Show("Đài này đã quay rồi!!");
                            timer1.Stop();
                            check = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ket noi that bai: " + ex.Message);
            }
            finally
            {
                connection.Close();
                connection.Dispose();
            }
            return check;
        }
        bool checkedRun1()
        {
            bool check = false;
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
                    if (cbbDai1.Text == daiSql && dateTimePicker1.Text == ngaySql)
                    {
                        MessageBox.Show("Đài này đã quay rồi!!");
                        timer1.Stop();
                        check = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ket noi that bai: " + ex.Message);
            }
            finally
            {
                connection.Close();
                connection.Dispose();
            }
            return check;
        }
        bool checkedRun2()
        {
            bool check = false;
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
                    if (cbbDai2.Text == daiSql && dateTimePicker2.Text == ngaySql)
                    {
                        MessageBox.Show("Đài này đã quay rồi!!");
                        timer1.Stop();
                        check = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ket noi that bai: " + ex.Message);
            }
            finally
            {
                connection.Close();
                connection.Dispose();
            }
            return check;
        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (18*numeric.Value*1000 <= mlgiay && 18 * numeric.Value * 1000 <= mlgiay1)
            {
                clearTimer();
                InsertDB1();
                InsertDB2();
            }
            else
            {
                if(18 * numeric.Value * 1000 == mlgiay)
                {
                    clearTimer();
                    InsertDB1();
                }
                if(18 * numeric.Value * 1000 == mlgiay1)
                {
                    clearTimer();
                    InsertDB2();
                }
                if (numer == numeric.Value)
                {
                    numer = 0;
                    mlgiay2 = 0;
                }
                if (checkStart == 0)
                {
                    mlgiay += timer1.Interval;
                    mlgiay1 += timer1.Interval;
                    Start1(giay);
                    Start2(giay1);
                    setGiai(giay, numer);
                }
                else
                {
                    if (checkStart == 1)
                    {
                        Start1(giay);
                        mlgiay += timer1.Interval;
                        setGiai(giay, numer);
                    }
                    else
                    {
                        Start2(giay1);
                        mlgiay1 += timer1.Interval;
                        setGiai(giay1, numer);
                    }
                }
                mlgiay2 += timer1.Interval;
                numer = mlgiay2 / 1000;
                giay = mlgiay / ((int)numeric.Value * 1000);
                giay1 = mlgiay1 / ((int)numeric.Value * 1000);
            }
        }
        void setGiai(int target,int giay)
        {
            switch (target)
            {
                case 0:
                    lbTime.Text = "Đang mở giải " + strGiai[0] + " (" + giay + "s)";
                    break;
                case 1:
                    lbTime.Text = "Đang mở giải " + strGiai[1] + " (" + giay + "s)";
                    break;
                case 2:
                    lbTime.Text = "Đang mở giải " + strGiai[2] + " (" + giay + "s)";
                    break;
                case 3:
                    lbTime.Text = "Đang mở giải " + strGiai[3] + " (" + giay + "s)";
                    break;
                case 4:
                    lbTime.Text = "Đang mở giải " + strGiai[4] + " (" + giay + "s)";
                    break;
                case 5:
                    lbTime.Text = "Đang mở giải " + strGiai[5] + " (" + giay + "s)";
                    break;
                case 6:
                    lbTime.Text = "Đang mở giải " + strGiai[6] + " (" + giay + "s)";
                    break;
                case 7:
                    lbTime.Text = "Đang mở giải " + strGiai[7] + " (" + giay + "s)";
                    break;
                case 8:
                    lbTime.Text = "Đang mở giải " + strGiai[8] + " (" + giay + "s)";
                    break;
                case 9:
                    lbTime.Text = "Đang mở giải " + strGiai[9] + " (" + giay + "s)";
                    break;
                case 10:
                    lbTime.Text = "Đang mở giải " + strGiai[10] + " (" + giay + "s)";
                    break;
                case 11:
                    lbTime.Text = "Đang mở giải " + strGiai[11] + " (" + giay + "s)";
                    break;
                case 12:
                    lbTime.Text = "Đang mở giải " + strGiai[12] + " (" + giay + "s)";
                    break;
                case 13:
                    lbTime.Text = "Đang mở giải " + strGiai[13] + " (" + giay + "s)";
                    break;
                case 14:
                    lbTime.Text = "Đang mở giải " + strGiai[14] + " (" + giay + "s)";
                    break;
                case 15:
                    lbTime.Text = "Đang mở giải " + strGiai[15] + " (" + giay + "s)";
                    break;
                case 16:
                    lbTime.Text = "Đang mở giải " + strGiai[16] + " (" + giay + "s)";
                    break;
                case 17:
                    lbTime.Text = "Đang mở giải " + strGiai[17] + " (" + giay + "s)";
                    break;
            }
        }
        void setClear()
        {
            timer1.Stop();
            mlgiay = 0;
            mlgiay1 = 0;
            numer = 0;
            giay = 0;
            giay1 = 0;
            lbTime.Text = "................................";
            numer = 0;
            mlgiay2 = 0;
            numeric.Enabled = true;
            btnStart.Enabled = true;
        }
        void clear1()
        {
            btnStart1.Text = "Quay số " + cbbDai1.Items[cbbDai1.SelectedIndex];
            foreach (Control c in panel4.Controls)
            {
                if (c is TextBox)
                    c.Text = "00";
            }
            foreach (Control c in panel5.Controls)
            {
                if (c is TextBox)
                    c.Text = "000";
            }
            foreach (Control c in panel6.Controls)
            {
                if (c is TextBox)
                    c.Text = "0000";
            }
            foreach (Control c in panel7.Controls)
            {
                if (c is TextBox)
                    c.Text = "0000";
            }
            foreach (Control c in panel11.Controls)
            {
                if (c is TextBox)
                    c.Text = "00000";
            }
            foreach (Control c in panel9.Controls)
            {
                if (c is TextBox)
                    c.Text = "00000";
            }
            foreach (Control c in panel10.Controls)
            {
                if (c is TextBox)
                    c.Text = "00000";
            }
            foreach (Control c in panel12.Controls)
            {
                if (c is TextBox)
                    c.Text = "00000";
            }
            foreach (Control c in panel13.Controls)
            {
                if (c is TextBox)
                    c.Text = "000000";
            }
        }
        void clear2()
        {
            btnStart2.Text = "Quay số " + cbbDai2.Items[cbbDai2.SelectedIndex];
            foreach (Control c in panel23.Controls)
            {
                if (c is TextBox)
                    c.Text = "00";
            }
            foreach (Control c in panel18.Controls)
            {
                if (c is TextBox)
                    c.Text = "000";
            }
            foreach (Control c in panel16.Controls)
            {
                if (c is TextBox)
                    c.Text = "0000";
            }
            foreach (Control c in panel15.Controls)
            {
                if (c is TextBox)
                    c.Text = "0000";
            }
            foreach (Control c in panel22.Controls)
            {
                if (c is TextBox)
                    c.Text = "00000";
            }
            foreach (Control c in panel19.Controls)
            {
                if (c is TextBox)
                    c.Text = "00000";
            }
            foreach (Control c in panel20.Controls)
            {
                if (c is TextBox)
                    c.Text = "00000";
            }
            foreach (Control c in panel21.Controls)
            {
                if (c is TextBox)
                    c.Text = "00000";
            }
            foreach (Control c in panel14.Controls)
            {
                if (c is TextBox)
                    c.Text = "000000";
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            setClear();
            clear1();
            clear2();
        }
        private void btnCkeck_Click(object sender, EventArgs e)
        {
            formKetqua f2 = new formKetqua();
            f2.ShowDialog();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                if (checkedRun1())
                {
                    return;
                }
                else
                {
                    btnStart1.Text = "Dừng";
                    timer1.Start();
                    btnClear.Enabled = false;
                    numeric.Enabled = false;
                    checkStart = 1;
                }
            }
            else
            {
                btnStart1.Text = "Quay số" + cbbDai1.Items[cbbDai1.SelectedIndex];
                timer1.Stop();
                btnClear.Enabled = true;
            }
        }
        private void btnStart2_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled)
            {
                if (checkedRun2())
                {
                    return;
                }
                else
                {
                    btnStart2.Text = "Dừng";
                    timer1.Start();
                    btnClear.Enabled = false;
                    numeric.Enabled = false;
                    checkStart = 2;
                }
            }
            else
            {
                btnStart2.Text = "Quay số " + cbbDai2.Items[cbbDai2.SelectedIndex];
                timer1.Stop();
                btnClear.Enabled = true;
            }
        }
        private void cbbDai1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnStart1.Text = "Quay số " + cbbDai1.Items[cbbDai1.SelectedIndex];
        }

        private void cbbDai2_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnStart2.Text = "Quay số " + cbbDai2.Items[cbbDai2.SelectedIndex];
        }
        string gio = "";
        string phut = "";

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (gio.Length == 0)
            {
                if (checkedRun())
                {
                    return;
                }
                else
                {
                    btnSettime.Text = "Hủy";
                    gio = numericUpDown1.Value.ToString();
                    phut = numericUpDown2.Value.ToString();
                    timer2.Start();
                    MessageBox.Show("Đã đặt giờ quay tự động");
                }
            }
            else
            {
                btnSettime.Text = "Đặt giờ";
                gio = "";
                phut = "";
                timer2.Stop();
                timer1.Stop();
            }   
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (gio == DateTime.Now.ToString("HH") && phut == DateTime.Now.ToString("mm"))
            {
                timer1.Start();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            lbThoigian.Text = DateTime.Now.ToString("H:m:ss");
        }
    }
}
