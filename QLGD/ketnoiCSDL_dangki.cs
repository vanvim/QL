using System;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace QLGD
{
    class ketnoiCSDL_dangki
    {
        public static OleDbConnection cnn;
        public static DataTable tb;
        private static OleDbCommand cmd;
        public static OleDbDataAdapter ada;

        public static void ketnoi()
        {
            string chuoi = "Provider = Microsoft.Jet.OLEDB.4.0 ;" +
                "Data Source =" + Application.StartupPath + @"\quanlygiangduong.mdb;";
            cnn = new OleDbConnection(chuoi);
            cnn.Open();
        }
        public static void huy_ketnoi()
        {
            cnn.Close();
            cnn.Dispose();
        }
        public static DataTable laydl(string sql, string tablename)
        {
            ketnoi();
            DataTable ds = new DataTable();
            cmd = new OleDbCommand(sql, cnn);
            ada = new OleDbDataAdapter(cmd);
            ada.Fill(ds);
            huy_ketnoi();
            return ds;

        }

        public static void chendl(string txtmaphong, string txt_ma_account, string txtthu, string txtbuoi)
        {
            ketnoi();
            tb = new DataTable("DANG_KI");
            OleDbDataAdapter data = new OleDbDataAdapter("select * from DANG_KI", cnn);
            data.Fill(tb);
            //insert dữ liệu
            DataRow r = tb.NewRow();
            r["MA_PHONG"] = txtmaphong;
            r["MA_ACCOUNT"] = txt_ma_account;
            r["THU"] = txtthu;
            r["BUOI"] = txtbuoi;
            tb.Rows.Add(r);

            // tạo đối tượng
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = cnn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into DANG_KI(MA_PHONG,MA_ACCOUNT,THU,BUOI) values(maphong,ma_account,thu,buoi)";
            cmd.Parameters.Add("maphong", OleDbType.VarChar, 20, "MA_PHONG");
            cmd.Parameters.Add("ma_account", OleDbType.VarChar, 20, "MA_ACCOUNT");
            cmd.Parameters.Add("thu", OleDbType.VarChar, 20, "THU");
            cmd.Parameters.Add("buoi", OleDbType.VarChar, 20, "BUOI");
            
            //Insert dữ liệu vào nguồn
            ada.InsertCommand = cmd;
            ada.Update(tb);

            //Hủy đối tượng
            cmd.Dispose();
            cmd = null;
            huy_ketnoi();
        }
        public static void XoaDL(string txt_maphong, string txt_ma_account, string txt_thu, string txt_buoi)
        {
            //Tạo kết nối
            ketnoi();
            //Tạo Adpater
            OleDbDataAdapter ada = new OleDbDataAdapter("select * from DANG_KI", cnn);
            tb = new DataTable();
            ada.Fill(tb);
            //Xây dựng commandBuilder
            new OleDbCommandBuilder(ada);
            //Delete Record cần delete trong datatable

            DataRow[] objRow = tb.Select("MA_ACCOUNT = '" + txt_ma_account + " ' and MA_PHONG = '" + txt_maphong +"' and THU = '" + txt_thu + "' and BUOI = '" +txt_buoi+  "'");
            objRow[0].Delete();
            //Delete dữ liệu nguồn
            ada.Update(tb);
            //Hủy đối tượng
            ada.Dispose();
            ada = null;
            tb.Dispose();
            tb = null;
            huy_ketnoi();
        }
        public static void LuuDL(string txtmaphong,string txtthu, string txtbuoi, string txt_ma_account)
        {
            //Tạo kết nối tới file Access
            ketnoi();
            //Tạo đối tượng command
            OleDbCommand objCommand = new OleDbCommand();
            objCommand.Connection = cnn;
            objCommand.CommandType = CommandType.Text;
            objCommand.CommandText = "Update DANG_KI " +
                                     "Set MA_PHONG=@maphong,THU=@thu, BUOI=@buoi " +
                                     "Where MA_ACCOUNT=@ma_account";

            objCommand.Parameters.Add("@maphong", OleDbType.VarChar).Value = txtmaphong;
            objCommand.Parameters.Add("@thu", OleDbType.VarChar).Value = txtthu;
            objCommand.Parameters.Add("@buoi", OleDbType.VarChar).Value = txtbuoi;            
            objCommand.Parameters.Add("@ma_account", OleDbType.VarChar).Value = txt_ma_account;
            objCommand.ExecuteNonQuery();
            //Hủy đối tượng
            objCommand.Dispose();
            objCommand = null;
            huy_ketnoi();
        }
    }
}
