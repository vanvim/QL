using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace QLGD
{
    class KetNoiCSDL_TB
    {
        public static OleDbConnection StrKetNoi;
        public static DataTable StrBang_DuLieu;
        private static OleDbCommand cmd;
        private static OleDbDataAdapter ada;
        public static void TaoKetNoi_CSDL()
        {
            String sKetNoi = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source =" + Application.StartupPath + @"\quanlygiangduong.mdb;";
            StrKetNoi = new OleDbConnection(sKetNoi);
            StrKetNoi.Open();
        }
        public static void Huy_KetNoi()
        {
            StrKetNoi.Close(); //Đóng kết nối
            StrKetNoi.Dispose();//Giải phóng tài nguyên
            StrKetNoi = null; //Hủy đối tượng
        }
        public static DataTable LoadDuLieu(string SQL, string TableName)
        {
            TaoKetNoi_CSDL();
            DataTable ds = new DataTable();
            cmd = new OleDbCommand(SQL, StrKetNoi);
            ada = new OleDbDataAdapter(cmd);
            ada.Fill(ds);
            Huy_KetNoi();
            return ds;
        }
        public static void Chen_DuLieu(string txt_MAPHONG, string txtMLTB, string txtTTB, string txtSL)
        {
            //Tao ket noi den file Access
            TaoKetNoi_CSDL();
            //
            StrBang_DuLieu = new DataTable("QLTTB");
            OleDbDataAdapter ada_chen = new OleDbDataAdapter("Select * from QLTTB", StrKetNoi);
            ada_chen.Fill(StrBang_DuLieu);
            //Chen du lieu
            DataRow R = StrBang_DuLieu.NewRow();
            R["MA_PHONG"] = txt_MAPHONG;
            R["MA_LOAITB"] = txtMLTB;
            R["TEN_TB"] = txtTTB;
            R["SO_LUONG"] = txtSL;
            StrBang_DuLieu.Rows.Add(R);
            //Tao doi tuong Command
            OleDbCommand cmd_chen = new OleDbCommand();
            cmd_chen.Connection = StrKetNoi;
            cmd_chen.CommandType = CommandType.Text;
            cmd_chen.CommandText = "Insert into QLTTB(MA_PHONG,MA_LOAITB,TEN_TB,SO_LUONG) values(@MA_PHONG,@MA_LOAI_TB,@TEN_TB,@SO_LUONG)";
            cmd_chen.Parameters.Add("@MA_PHONG", OleDbType.VarChar, 20, "@MA_PHONG");
            cmd_chen.Parameters.Add("@MA_LOAI_TB", OleDbType.VarChar, 20, "MA_LOAITB");
            cmd_chen.Parameters.Add("@TEN_TB", OleDbType.VarChar, 20, "TEN_TB");
            cmd_chen.Parameters.Add("@SO_LUONG", OleDbType.VarChar, 20, "SO_LUONG");
            //Chen du lieu vao nguon
            ada_chen.InsertCommand = cmd_chen;
            ada_chen.Update(StrBang_DuLieu);
            //Huy doi tuong
            cmd_chen.Dispose();
            cmd_chen = null;
            Huy_KetNoi();
        }
        public static void Luu_Dulieu( string txt_MAPHONG, string txtMLTB,string txtTTB, string txtSL)
        {
            TaoKetNoi_CSDL();
            //Tạo đối tượng command
            OleDbCommand cmd_luu = new OleDbCommand();
            cmd_luu.Connection = StrKetNoi;
            cmd_luu.CommandType = CommandType.Text;
            

            cmd_luu.CommandText = "Update QLTTB " +
                                     "Set MA_LOAI_TB=@MA_LOAI_TB,TEN_TB= @TEN_TB, SO_LUONG=@SO_LUONG " +
                                     "Where MA_PHONG=@MA_PHONG";

            cmd_luu.Parameters.Add("@MA_PHONG", OleDbType.VarChar).Value = txt_MAPHONG;
            cmd_luu.Parameters.Add("@MA_LOAI_TB", OleDbType.VarChar).Value = txtMLTB;
            cmd_luu.Parameters.Add("@TEN_TB", OleDbType.VarChar).Value  = txtTTB;
            cmd_luu.Parameters.Add("@SO_LUONG", OleDbType.Integer).Value = txtSL;
            

            cmd_luu.ExecuteNonQuery();
            cmd_luu.Dispose();
            cmd_luu = null;
            Huy_KetNoi();
        }
        public static void Xoa_Dulieu(string txt_MAPHONG)
        {
            //Tao ket noi CSDL
            TaoKetNoi_CSDL();
            OleDbDataAdapter ada_xoa = new OleDbDataAdapter("Select * from TB", StrKetNoi);
            StrBang_DuLieu = new DataTable();
            ada_xoa.Fill(StrBang_DuLieu);
            new OleDbCommandBuilder(ada_xoa);
            DataRow[] objRow = StrBang_DuLieu.Select("MA_PHONG = '" + txt_MAPHONG + "'");
            objRow[0].Delete();
            ada_xoa.Update(StrBang_DuLieu);
            ada_xoa.Dispose();
            ada_xoa = null;
            StrBang_DuLieu.Dispose();
            StrBang_DuLieu = null;
            Huy_KetNoi();
        }
    }
}