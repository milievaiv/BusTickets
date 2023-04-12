using BusTickets.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;

namespace BusTickets
{

    internal class SQLConnection
    {
        private string connectionString = @"Data Source=(local)\SQLEXPRESS;Initial Catalog=BusTickets;Integrated Security=True";
        private SqlConnection cnn;
        private SqlCommand command;
        private SqlDataReader dataReader;
        private ComboBox comboBox;

        public SQLConnection()
        {

        }

        public SQLConnection(FlatComboBox cb)
        {
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            String sql, Output = "";
            sql = "SELECT S_Point FROM Route";
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                Output = dataReader.GetValue(0).ToString();
                cb.Items.Add(Output);
            }
            cnn.Close();
        }

        public SQLConnection(MyComboBox cb)
        {
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            String sql, Output = "";
            sql = "SELECT S_Point FROM Route";
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                Output = dataReader.GetValue(0).ToString();
                cb.Items.Add(Output);
            }
            cnn.Close();
        }

        public void SearchRPC(List<Label[]> arr, string sp, string ep, bool ow, string bd)
        {
            int _ow = 0;
            if (ow == true)
            {
                _ow = 1;
            }
            else
            {
                _ow = 0;
            }
            int i = 0;
            cnn = new SqlConnection(connectionString);
            String sql, Output = "";
            sql = "SELECT Company.Company_N, T_Type.Price, Route.S_Point, Route.E_Point, T_Type.One_way, T_Type.S_Hour, T_Type.E_Hour, Bus.ID " +
                  "FROM ((Bus " +
                  "INNER JOIN T_Type " +
                  "ON T_Type.ID = Bus.T_Type) " +
                  "INNER JOIN Company " +
                  "ON T_Type.Company = Company.ID) " +
                  "INNER JOIN Route " +
                  $"ON T_Type.Route=Route.ID WHERE Route.S_Point = '{sp}' AND Route.E_Point = '{ep}' AND T_Type.One_way = {_ow} AND Bus.Date = '{bd}';";
            cnn.Open();
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();
            if (dataReader.HasRows != false)
            {
                while (dataReader.Read())
                {
                    string cn = dataReader.GetValue(0).ToString();
                    string pr = dataReader.GetValue(1).ToString();
                    string sh = dataReader.GetValue(5).ToString();
                    string eh = dataReader.GetValue(6).ToString();
                    string bus_id = dataReader.GetValue(7).ToString();
                    if (ow == false)
                    {
                        List<string> shtmp = new List<string>();
                        shtmp = sh.Split(',').ToList();
                        List<string> ehtmp = new List<string>();
                        ehtmp = eh.Split(',').ToList();
                        arr.Add(new Label[5]);
                        for (int s = 0; s < arr[i].Count(); s++)
                        {
                            arr[i][s] = new Label();
                        }
                        arr[i][0].Text = cn;
                        arr[i][1].Text = pr;
                        arr[i][2].Text = shtmp[0].Trim() + " - " + ehtmp[0].Trim();
                        arr[i][3].Text = shtmp[1].Trim() + " - " + ehtmp[1].Trim();
                        arr[i][4].Text = bus_id;
                        i++;
                    }
                    else
                    {
                        arr.Add(new Label[4]);
                        for (int s = 0; s < arr[i].Count(); s++)
                        {
                            arr[i][s] = new Label();
                        }
                        arr[i][0].Text = cn;
                        arr[i][1].Text = pr;
                        arr[i][2].Text = sh + " - " + eh;
                        arr[i][3].Text = bus_id;
                        i++;
                    }
                }
                dataReader.Close();
            }
            else MessageBox.Show("Данните не са намерени!");
            dataReader.Close();

        }
        public void Search_SP(List<string> S_Point)
        {
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            String sql, Output = "";
            sql = "SELECT DISTINCT S_Point FROM Route";
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                Output = dataReader.GetValue(0).ToString();
                S_Point.Add(Output);
            }
            cnn.Close();
        }

        public void Search_EP(List<string> E_Point)
        {
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            String sql, Output = "";
            sql = "SELECT DISTINCT E_Point FROM Route";
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                Output = dataReader.GetValue(0).ToString();
                E_Point.Add(Output);
            }
            cnn.Close();
        }

        public void SearchSE(List<string> SE_Result, string input)
        {
            cnn = new SqlConnection(connectionString);
            cnn.Open();
            String sql, Output = "";
            sql = $"SELECT E_Point FROM Route WHERE S_Point = '{input}'";
            command = new SqlCommand(sql, cnn);
            dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                Output = dataReader.GetValue(0).ToString();
                SE_Result.Add(Output);
            }
            cnn.Close();
        }

        public void InsertTO(string f_name, string l_name, string phone, int bus_id)
        {
            cnn.ConnectionString = connectionString;
            cnn.Open();
            string sql  = $"INSERT INTO T_Order VALUES('{f_name}', '{l_name}', '{phone}');";
            command = new SqlCommand(sql, cnn);
            cnn.Close();
        }

        public void InsertTS(string date_sold, int t_order)
        {
            cnn.ConnectionString = connectionString;
            cnn.Open();
            OleDbCommand insert = new OleDbCommand();
            string sql = $"INSERT INTO T_Sells VALUES('{date_sold}', '{t_order}');";
            command = new SqlCommand(sql, cnn);
            cnn.Close();
        }
    }
}
