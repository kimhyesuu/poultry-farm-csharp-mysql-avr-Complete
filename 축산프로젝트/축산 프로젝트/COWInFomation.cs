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

namespace 축산_프로젝트
{
    public partial class COWInFomation : Form
    {
        String connStr;
        MySqlConnection conn;
        MySqlCommand cmd;



        public COWInFomation()
        {
            InitializeComponent();
        }

        private void COWInFomation_Load(object sender, EventArgs e)
        {
            connStr = "server=127.0.0.1; Uid=root; pwd=1234; Database=HYDB;CHARSET=UTF8";

            try
            {
                conn = new MySqlConnection(connStr);
                conn.Open();
                MessageBox.Show("GOOD 프로젝트 다하면 지우기");
            }
            catch
            {
                MessageBox.Show("연결실패 - 아이디 비번 확인 요망");
            }
        }

        private void tbNewResit_Click(object sender, EventArgs e)
        {
            //cmd = new MySqlCommand("", conn);

            //if (tbuserID.Text != null && tbname.Text != null && tbBirthyear.Text != null && tbAddr != null)
            //{
            //    N_userID = tbuserID.Text.ToString(); //ID
            //    N_name = tbname.Text.ToString(); //이름
            //    N_birth = int.Parse(tbBirthyear.Text); //이름
            //    N_addr = tbAddr.Text.ToString(); //주소
            //    N_mobile1 = tbmobile1.Text.ToString(); //국번
            //    N_mobile2 = tbmobile2.Text.ToString(); //핸드폰번호   
            //    N_height = Convert.ToInt16(tbHeight.Text); //핸드폰번호   
            //}
            //else
            //{
            //    MessageBox.Show("텍스트 입력이 안되었습니다 입력해주세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            ////INSERT INTO userTbl VALUES('LSG', '이승기', 1987, '서울', '011', '1111111', 182, '2008-8-8');
            //String sql = "INSERT INTO userTbl(userID,name,birthYear,addr,mobile1,mobile2,height) VALUES('";
            //sql += N_userID + "','" + N_name + "'," + N_birth + ",'" + N_addr +
            //    "','" + N_mobile1 + "','" + N_mobile2 + "'," + N_height + ")";

            //N_cmd.CommandText = sql;

            //try
            //{
            //    N_cmd.ExecuteNonQuery();
            //}
            //catch
            //{
            //    MessageBox.Show("연결실패 sql 잘 되었는 지 확인 하세요");
            //}

            //tbuserID.Text = "";
            //tbname.Text = "";
            //tbname.Text = "";
            //tbAddr.Text = "";
            //tbmobile1.Text = "";
            //tbmobile2.Text = "";
            //tbHeight.Text = "";
        }
    }
}
