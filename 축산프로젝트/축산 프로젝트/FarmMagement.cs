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
    public partial class FarmMagement : Form
    {

        String connStr;
        MySqlConnection conn;
        MySqlCommand cmd;
        int value = 0;
        MySqlDataReader reader; //콤보박스 읽기

        public FarmMagement(int a)
        {
            InitializeComponent();
            value = a;
        }

        private void FarmMagement_Load(object sender, EventArgs e)
        {
            timer.Start();
            string housedon = "";

            switch(value)
            {
                case 1: housedon = "< 10";  break;
                case 2: housedon = "> 9 "; break;
                case 3: break;
                case 4: break;
                case 5: break;
                case 6: break;
                case 0: break;
            }

            connStr = "Server=127.0.0.1; Uid=root; Pwd=1234;Database=HYDB;CHARSET=UTF8";
            conn = new MySqlConnection(connStr);
            conn.Open();

            cmd = new MySqlCommand("", conn);
            //콤보 박스 초기화 
            string sql = "SELECT * FROM Cow_DB WHERE CowId " + housedon;
            cmd.CommandText = sql;
          
            reader = cmd.ExecuteReader();//읽어서 가져오기 

          //  CowId INT NOT NULL primary key, --소 아이디
          //  gender CHAR(3), --성별
          //  PedInFO CHAR(10) , --혈통
          //  birthDay CHAR(15) , --생년월일
          //  Weights INT,       --체중
          //  Classif INT,

            while (reader.Read())
            {
                string CowId = reader["CowId"].ToString();
                string gender = reader["gender"].ToString();
                string PedInFO = reader["PedInFO"].ToString();
                string birthDay = reader["birthDay"].ToString();
                string Weights = reader["Weights"].ToString();
                string Classif = reader["Classif"].ToString();

                ListViewItem lvi = new ListViewItem(new string[] { CowId, gender, PedInFO, birthDay , Weights , Classif });
                this.lvData.Items.Add(lvi);
            }

            //리더를 여기서 끝내준다.
            reader.Close();
            //콤보박스에 넣기
            conn.Close();
        }

        int[] ActivityS = new int[30];

        private void timer_Tick(object sender, EventArgs e)
        {     
            conn = new MySqlConnection(connStr);
            conn.Open();

            cmd = new MySqlCommand("", conn);
            String sql = "SELECT s_Activity FROM sensor_table ORDER BY all_data DESC LIMIT 1";
            cmd.CommandText = sql; // 트럭에 짐 싣기
                                   // 다시 가져올 짐을 연결할 끈...

            reader = cmd.ExecuteReader(); // 짐을 서버에 부어서 준비하고, 끈만 가져옴....
            reader.Read();

            int s_Activity = (int)reader["s_Activity"];
            reader.Close();

            // 값을 한칸씩 당기기
            for (int i = 0; i < ActivityS.Length - 1; i++)
            {
                ActivityS[i] = ActivityS[i + 1];              
            }

            ActivityS[ActivityS.Length - 1] = s_Activity;        

            // 차트 그리기
            chartAct.Series[0].ChartType =
                System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            
            chartAct.Series[0].Points.Clear();

            for (int i = 0; i < ActivityS.Length; i++)
            {
                chartAct.Series[0].Points.AddXY(i, ActivityS[i]);
           
            }
            conn.Close();
        }
    }
}
