using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace QLGD
{
    class KETNOICSDL_ROOM
    {
        public static OleDbConnection connection;
        public static OleDbCommand command;
        public static OleDbDataAdapter adapter;
        public static DataTable table;

        public static void taoketnoi()
        {
            string connectpath = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + Application.StartupPath + @"\quanlygiangduong.mdb;";
            connection = new OleDbConnection(connectpath);
            connection.Open();
        }

        public static void huyketnot()
        {
            connection.Close();
            connection.Dispose();
            connection = null;

        }

        public static DataTable laydulieu(string sql1, string table_name)
        {
            taoketnoi();
            DataTable table_data = new DataTable();
            command = new OleDbCommand(sql1, connection);
            adapter = new OleDbDataAdapter(command);
            adapter.Fill(table_data);
            huyketnot();
            return table_data;
        }

        public static void chendulieu(string txt_maphong, string txt_tenphong, string txt_maloai, string txt_succhua, string txt_gd)
        {
            taoketnoi();
            table = new DataTable("ROOM");

            OleDbDataAdapter objAdapter = new OleDbDataAdapter("select * from ROOM", connection);
            objAdapter.Fill(table);
            DataRow R = table.NewRow();
            R["MA_PHONG"] = txt_maphong;
            R["TEN_PHONG"] = txt_tenphong;
            R["MA_LOAI"] = txt_maloai;
            R["SUC_CHUA"] = txt_succhua;
            R["GĐ"] = txt_gd;
            table.Rows.Add(R);
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = connection;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Insert into ROOM(MA_PHONG,TEN_PHONG,MA_LOAI,SUC_CHUA,GĐ) values(@MAPHONG, @TENPHONG, @MALOAI, @SUCCHUA, @GĐ)";
            cmd.Parameters.Add("@MAPHONG", OleDbType.VarChar, 20, "MA_PHONG");
            cmd.Parameters.Add("@TENPHONG", OleDbType.VarChar, 40, "TEN_PHONG");
            cmd.Parameters.Add("@MALOAI", OleDbType.VarChar, 30, "MA_LOAI");
            cmd.Parameters.Add("@SUCCHUA", OleDbType.VarChar, 20, "SUC_CHUA");
            cmd.Parameters.Add("@GĐ", OleDbType.VarChar, 30, "GĐ");
            objAdapter.InsertCommand = cmd;
            objAdapter.Update(table);
            cmd.Dispose();
            cmd = null;
            huyketnot();
        } 

        // phương thức lưu dữ liệu
        public static DataTable loaddulieu(string SQL, string TableName)
        {
            taoketnoi();
            DataTable ds = new DataTable();
            command = new OleDbCommand(SQL, connection);
            adapter = new OleDbDataAdapter(command);
            adapter.Fill(ds);
            huyketnot();
            return ds;
        }

        //phương thức xóa dữ liệu
        public static void xoadulieu(string txt_maphong)
        {
            taoketnoi();
            OleDbDataAdapter objAdapter = new OleDbDataAdapter("select * from ROOM", connection);
            table = new DataTable();
            objAdapter.Fill(table);
            new OleDbCommandBuilder(objAdapter);
            DataRow[] objRow = table.Select("MA_PHONG = '" + txt_maphong + "'");
            objRow[0].Delete();
            objAdapter.Update(table);
            objAdapter.Dispose();
            objAdapter = null;
            table.Dispose();
            table = null;
            huyketnot();
        }

        // phương thức load dư liệu
        public static void luudulieu(string txt_maphong, string txt_tenphong, string txt_maloai, string txt_succhua, string txt_gd)
        {
            taoketnoi();
            OleDbCommand objCommand = new OleDbCommand();
            objCommand.Connection = connection;
            objCommand.CommandType = CommandType.Text;
            objCommand.CommandText = "Update ROOM " +
                                     "Set TEN_PHONG=@TENPHONG, MA_LOAI=@MALOAI, SUC_CHUA=@SUCCHUA, GĐ=@GĐ " +
                                     "Where MA_PHONG=@MAPHONG";

            objCommand.Parameters.Add("@TENPHONG", OleDbType.VarChar).Value = txt_tenphong;
            objCommand.Parameters.Add("@MALOAI", OleDbType.VarChar).Value = txt_maloai;
            objCommand.Parameters.Add("@SUCCHUA", OleDbType.VarChar).Value = txt_succhua;
            objCommand.Parameters.Add("@GĐ", OleDbType.VarChar).Value = txt_gd;
            objCommand.Parameters.Add("@MAPHONG", OleDbType.VarChar).Value = txt_maphong;

            objCommand.ExecuteNonQuery();
            objCommand.Dispose();
            objCommand = null;
            huyketnot();
        }
    }
}
