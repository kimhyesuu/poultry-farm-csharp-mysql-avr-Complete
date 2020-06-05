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
using System.Drawing.Printing;

namespace 축산_프로젝트
{
    public partial class MainForm : Form
    {
        String connStr;
        MySqlConnection conn;
        MySqlCommand cmd;

        public int _mangAnimalFlag;
        int _FanMotFlag;
        int _SpeciAnimalFlag;



        public MainForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            chart1.Series[0].BorderWidth = 2;
            chart1.Series[1].BorderWidth = 2;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {           
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;

            Rectangle bounds = Screen.FromHandle(this.Handle).WorkingArea;
            int x_offset = SystemInformation.HorizontalResizeBorderThickness + SystemInformation.FixedFrameBorderSize.Width;
            int y_offset = SystemInformation.VerticalResizeBorderThickness + SystemInformation.FixedFrameBorderSize.Height;

            bounds.X -= x_offset;
            bounds.Width += (x_offset * 2);
            bounds.Height += y_offset;

            //this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.MaximizedBounds = bounds;

            // 창 크기 최대화 처리
            this.WindowState = FormWindowState.Maximized;

            Panel p = sender as Panel;


            connStr = "Server=127.0.0.1; Uid=root; Pwd=1234;Database=HYDB;CHARSET=UTF8";
            conn = new MySqlConnection(connStr);
            conn.Open();

            timer.Start();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            timer.Start();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        int cnt = 0;

        private void timer_Tick(object sender, EventArgs e)
        {
            cnt++;

            cmd = new MySqlCommand("", conn);
            String sql = "SELECT all_data,s_temper,s_humi,s_co2,s_Roughness FROM sensor_table ORDER BY all_data DESC LIMIT 1";
            cmd.CommandText = sql; // 트럭에 짐 싣기
                                   // 다시 가져올 짐을 연결할 끈...
            reader = cmd.ExecuteReader(); // 짐을 서버에 부어서 준비하고, 끈만 가져옴....
            reader.Read();

            switch(cnt)
            {
                case 1 : charttemhum(); break;
                case 2: chartcoco(); cnt = 0; break;
            }

        }

        //몇동 
        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
           
            _mangAnimalFlag = 1;
            FarmMagement fm = new FarmMagement(_mangAnimalFlag);
            this.DialogResult = DialogResult.OK;
            fm.ShowDialog();

        }
        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {
            _mangAnimalFlag = 2;
            FarmMagement fm = new FarmMagement(_mangAnimalFlag);
            this.DialogResult = DialogResult.OK;      
            fm.ShowDialog();
        }
        private void panel4_MouseClick(object sender, MouseEventArgs e)
        {
            _mangAnimalFlag = 3;
            FarmMagement fm = new FarmMagement(_mangAnimalFlag);
            fm.ShowDialog();
        }
        private void panel7_MouseClick(object sender, MouseEventArgs e)
        {
            _mangAnimalFlag = 4;
            FarmMagement fm = new FarmMagement(_mangAnimalFlag);
            fm.ShowDialog();
        }
        private void panel6_MouseClick(object sender, MouseEventArgs e)
        {
            _mangAnimalFlag = 5;
            FarmMagement fm = new FarmMagement(_mangAnimalFlag);
            fm.ShowDialog();
        }
        private void panel5_MouseClick(object sender, MouseEventArgs e)
        {
            _mangAnimalFlag = 6;
            FarmMagement fm = new FarmMagement(_mangAnimalFlag);
            fm.ShowDialog();
        }

        //팬모터
        private void panel21_MouseClick(object sender, MouseEventArgs e)
        {
            _FanMotFlag = 1;
            FanMotor ff = new FanMotor();
            ff.ShowDialog();
        }


        //CCTV 
        private void panel14_MouseClick(object sender, MouseEventArgs e)
        {
            CCTV ct = new CCTV();
            ct.ShowDialog();
        }


        //특별관리 대상
        private void panel40_Click(object sender, EventArgs e)
        {
            _SpeciAnimalFlag = 1;
               Special_management ss = new Special_management();
            ss.ShowDialog();
        }
        private void panel39_Click(object sender, EventArgs e)
        {
            _SpeciAnimalFlag = 2;
            Special_management ss = new Special_management();
            ss.ShowDialog();
        }
        private void panel36_Click(object sender, EventArgs e)
        {
            _SpeciAnimalFlag = 3;
            Special_management ss = new Special_management();
            ss.ShowDialog();
        }


        private void panel29_Click(object sender, EventArgs e)
        {
            if (pgbEating.Value > 0)
            {
                pgbEating.Value -= 10;
            }
            else if (pgbEating.Value < 30)
            {
                if (MessageBox.Show("밥이 떨어짐", "경고", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    //거래처 db로 보내기
                    pgbEating.Value = 100;
                }
                else
                {
                    //웹사이트
                    pgbEating.Value = 0;
                }
            }
        }

        private void plWater_Click(object sender, EventArgs e)
        {
            if (pgbWater.Value > 0)
            {
                pgbWater.Value -= 10;
            }
            else if (pgbWater.Value < 30)
            {
                if (MessageBox.Show("물이 떨어짐", "경고", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    //거래처 db로 보내기
                    pgbWater.Value = 100;
                }
                else
                {
                    //웹사이트
                    pgbWater.Value = 0;
                }

            }
        }


        int[] temperAry = new int[30];
        int[] humiAry = new int[30];

        MySqlDataReader reader;

        private void charttemhum()
        {               
            int temper = (int)reader["s_temper"];
            int humi = (int)reader["s_humi"];
            reader.Close();

            // 값을 한칸씩 당기기
            for (int i = 0; i < temperAry.Length - 1; i++)
            {
                temperAry[i] = temperAry[i + 1];
                humiAry[i] = humiAry[i + 1];
            }

            temperAry[temperAry.Length - 1] = temper;
            humiAry[humiAry.Length - 1] = humi;

            // 차트 그리기
            chart1.Series[0].ChartType =
                System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            chart1.Series[1].ChartType =
                System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();

            for (int i = 0; i < temperAry.Length; i++)
            {
                chart1.Series[0].Points.AddXY(i, temperAry[i]);
                chart1.Series[1].Points.AddXY(i, humiAry[i]);
            }

            tbTemHum.Text = temper.ToString();

            if (temper > 28)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                tbFanControl.Text = "강";
                tbFanControl3.Text = "강";
            }
            else if (temper >= 25 && temper <= 28)
            {            
                tbFanControl.Text = "중";
                tbFanControl3.Text = "약";
            }
            else
            {
                tbFanControl.Text = "약";
                tbFanControl3.Text = "중";
            }

        }

        int[] coAry = new int[30];
        int[] rougAry = new int[30];

        private void chartcoco()
        {
            int s_co2 = (int)reader["s_co2"];
            int s_Roughness = (int)reader["s_Roughness"];
            reader.Close();

            // 값을 한칸씩 당기기
            for (int i = 0; i < coAry.Length - 1; i++)
            {
                coAry[i] = coAry[i + 1];
                rougAry[i] = rougAry[i + 1];
            }

            coAry[coAry.Length - 1] = s_co2;
            rougAry[coAry.Length - 1] = s_Roughness;

            // 차트 그리기
            chart2.Series[0].ChartType =
                System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            chart2.Series[1].ChartType =
                System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            chart2.Series[0].Points.Clear();
            chart2.Series[1].Points.Clear();

            for (int i = 0; i < coAry.Length; i++)
            {
                chart2.Series[0].Points.AddXY(i, coAry[i]);
                chart2.Series[1].Points.AddXY(i, rougAry[i]);
            }

        }

        // 공통 함수
        private static DateTime Delay(int MS)
        {
            DateTime ThisMoment = DateTime.Now;
            TimeSpan duration = new TimeSpan(0, 0, 0, 0, MS);
            DateTime AfterWards = ThisMoment.Add(duration);

            while (AfterWards >= ThisMoment)
            {
                System.Windows.Forms.Application.DoEvents();
                ThisMoment = DateTime.Now;
            }

            return DateTime.Now;
        } //딜레이 함수    

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);
            int borderWidth = 1;
            Color borderColor = Color.White;

            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, borderColor,
             borderWidth, ButtonBorderStyle.Outset, borderColor, borderWidth,

            ButtonBorderStyle.Outset, borderColor, borderWidth,
             ButtonBorderStyle.Outset,

            borderColor, borderWidth, ButtonBorderStyle.Outset);
        }
        private void panel15_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);
            int borderWidth = 1;
            Color borderColor = Color.White;

            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, borderColor,
             borderWidth, ButtonBorderStyle.Outset, borderColor, borderWidth,

            ButtonBorderStyle.Outset, borderColor, borderWidth,
             ButtonBorderStyle.Outset,

            borderColor, borderWidth, ButtonBorderStyle.Outset);
        }
        private void panel8_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);
            int borderWidth = 1;
            Color borderColor = Color.White;

            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, borderColor,
             borderWidth, ButtonBorderStyle.Outset, borderColor, borderWidth,

            ButtonBorderStyle.Outset, borderColor, borderWidth,
             ButtonBorderStyle.Outset,

            borderColor, borderWidth, ButtonBorderStyle.Outset);
        }
        private void panel31_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);
            int borderWidth = 1;
            Color borderColor = Color.White;

            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, borderColor,
             borderWidth, ButtonBorderStyle.Outset, borderColor, borderWidth,

            ButtonBorderStyle.Outset, borderColor, borderWidth,
             ButtonBorderStyle.Outset,

            borderColor, borderWidth, ButtonBorderStyle.Outset);
        }
        private void panel25_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);
            int borderWidth = 1;
            Color borderColor = Color.White;

            ControlPaint.DrawBorder(e.Graphics, e.ClipRectangle, borderColor,
             borderWidth, ButtonBorderStyle.Outset, borderColor, borderWidth,

            ButtonBorderStyle.Outset, borderColor, borderWidth,
             ButtonBorderStyle.Outset,

            borderColor, borderWidth, ButtonBorderStyle.Outset);
        }


    }
}
