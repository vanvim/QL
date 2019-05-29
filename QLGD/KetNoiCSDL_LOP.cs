using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace QLGD
{
    class KetNoiCSDL_LOP
    {
        public static OleDbConnection cnnqlgd;
        public static DataTable bangqlgd;
        private static OleDbCommand cmd;
        private static OleDbDataAdapter ada;

        public static void KetNoi_CSDL()
        {
            string Chuoi_KetNoi = "Provider = Microsoft.Jet.OLEDB.4.0 ;" +
                "Data Source =" + Application.StartupPath + @"\quanlygiangduong.mdb;";
            cnnqlgd = new OleDbConnection(Chuoi_KetNoi);
            cnnqlgd.Open(); //mo ket noi
        }
        public static void HuyKetNoi_CSDL()
        {
            cnnqlgd.Close();
            cnnqlgd.Dispose();
            cnnqlgd = null;
        }
        public static DataTable Laydulieu(string sql, string TableName)
        {
            KetNoi_CSDL();
            DataTable ds = new DataTable();
            cmd= new OleDbCommand(sql, cnnqlgd);
            ada = new OleDbDataAdapter(cmd);
            ada.Fill(ds);
            HuyKetNoi_CSDL();
            return ds;
        }

        public static void chendl(String txtmalop, String txtenlop,String txtmagv)
        {
            // tạo kết nối với file Access
            KetNoi_CSDL();
            bangqlgd = new DataTable("LOP");
            OleDbDataAdapter ada = new OleDbDataAdapter("select * from LOP", cnnqlgd);
            ada.Fill(bangqlgd);

            // Insert dữ liệu vào DataTable
            DataRow R = bangqlgd.NewRow();
            R["MA_LOP"] = txtmalop;
            R["TEN_LOP"] = txtenlop;
            R["MA_GV"] = txtmagv;
            bangqlgd.Rows.Add(R);

            // Tạo đối tượng command
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = cnnqlgd;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Insert into LOP(MA_LOP,TEN_LOP,MA_GV) values(@MA_LOP,@TEN_LOP,@MA_GV)";

            cmd.Parameters.Add("@MA_LOP", OleDbType.VarChar, 10, "MA_LOP");
            cmd.Parameters.Add("@TEN_LOP", OleDbType.VarChar, 50, "TEN_LOP");
            cmd.Parameters.Add("@MA_GV", OleDbType.VarChar, 10, "MA_GV");

            // Insert dữ liệu vào nguồn
            ada.InsertCommand = cmd;
            ada.Update(bangqlgd);

            // Hủy đối tượng
            cmd.Dispose();
            cmd = null;
            HuyKetNoi_CSDL();

        }

        public static void luudl(String txttenlop,String txtmagv, String txtmalop)
        {

            //tao kết nối tới file Access
            KetNoi_CSDL();
            //tao đối tương command
            OleDbCommand objCommand = new OleDbCommand();
            objCommand.Connection = cnnqlgd;
            objCommand.CommandType = CommandType.Text;
            objCommand.CommandText = "Update LOP " +
                "Set TEN_LOP = @TEN_LOP, MA_GV = @MA_GV  " +
                "Where MA_LOP = @MA_LOP";

           
            objCommand.Parameters.Add("@TEN_LOP", OleDbType.VarChar).Value =  txttenlop;
            objCommand.Parameters.Add("@MA_GV", OleDbType.VarChar).Value = txtmagv;
            objCommand.Parameters.Add("@MA_LOP", OleDbType.VarChar).Value = txtmalop;

            objCommand.ExecuteNonQuery();
            // hủy đối tượng
            objCommand.Dispose();
            objCommand = null;
            HuyKetNoi_CSDL();

        }

        public static void xoadl(String MA_LOP)
        {
            //Tạo kết nối
            KetNoi_CSDL();
            //Tạo Adpater
            OleDbDataAdapter objAdapter = new OleDbDataAdapter("select * from LOP", cnnqlgd);
            bangqlgd = new DataTable();
            objAdapter.Fill(bangqlgd);
            //Xây dựng commandBuilder
            new OleDbCommandBuilder(objAdapter);
            //Delete Record cần delete trong datatable
            DataRow[] objRow = bangqlgd.Select("MA_LOP = '" + MA_LOP + "'");
            objRow[0].Delete();

            //Delete dữ liệu nguồn
            objAdapter.Update(bangqlgd);
            //Hủy đối tượng
            objAdapter.Dispose();
            objAdapter = null;
            bangqlgd.Dispose();
            bangqlgd = null;
            HuyKetNoi_CSDL();
        }
        
        public static DataTable LoadDuLieu(String SQL, String TableName)
        {
            KetNoi_CSDL();
            DataTable ds = new DataTable();
            cmd = new OleDbCommand(SQL, cnnqlgd);
            ada = new OleDbDataAdapter(cmd);
            ada.Fill(ds);
            HuyKetNoi_CSDL();
            return ds;

        }
    }
}
