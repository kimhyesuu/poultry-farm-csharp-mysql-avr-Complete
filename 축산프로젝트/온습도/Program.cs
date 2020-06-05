using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace 온습도
{
    class Program
    {
        static void Main(string[] args)
        {
            String connStr;
            MySqlConnection conn;
            MySqlCommand cmd;
            connStr = "Server=127.0.0.1; Uid=root; Pwd=1234;Database=HYDB;CHARSET=UTF8";
            conn = new MySqlConnection(connStr);
            conn.Open();
            cmd = new MySqlCommand("", conn);
            Random r = new Random();
            while (true)
            {
                //INSERT INTO sensor_table(s_temper,s_humi,s_co2,s_Activity,s_Roughness,s_Fan) VALUES('s_date','s_temper','s_humi','s_co2','s_Roughness','s_Fan');
                String all_data = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");
                String s_temper = (r.Next(20, 40)).ToString(); // 온도 센서
                String s_humi = (r.Next(0, 100)).ToString(); // 습도 센서
                String s_co2 = (r.Next(-100, 100)).ToString(); //co2 센서
                String s_Roughness = (r.Next(0, 300)).ToString(); // 조도 센서
                String s_Fan = (r.Next(0, 300)).ToString(); // 조도 센서
                String s_Activity = (r.Next(0, 300)).ToString();
                String sql = "INSERT INTO sensor_table(all_data,s_temper,s_humi,s_co2,s_Activity,s_Roughness,s_Fan) VALUES('";

                sql += all_data + "', " + s_temper + "," + s_humi + "," + s_co2 +"," + s_Activity + "," + s_Roughness + "," + s_Fan + ")";
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                Console.WriteLine(all_data + " , " + s_temper + " , " + s_humi + " , " + s_co2 + " , " + s_Activity +  " , " + s_Roughness + " , " + s_Fan);
                System.Threading.Thread.Sleep(500);
            }

            conn.Close();

        }
    }
}
