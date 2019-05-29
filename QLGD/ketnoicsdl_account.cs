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
    class ketnoicsdl_account
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
        public static void LuuDL(string txtpwd, string txtmatk)
        {
            //Tạo kết nối tới file Access
            ketnoi();
            //Tạo đối tượng command
            OleDbCommand objCommand = new OleDbCommand();
            objCommand.Connection = cnn;
            objCommand.CommandType = CommandType.Text;
            objCommand.CommandText = "Update ACCOUNT " +
                                     "Set PWD = @PWD " +
                                     "Where MATK=@MATK";

            objCommand.Parameters.Add("@PWD", OleDbType.VarChar).Value = txtpwd;
            objCommand.Parameters.Add("@MATK", OleDbType.VarChar).Value = txtmatk;
            
            objCommand.ExecuteNonQuery();
            //Hủy đối tượng
            objCommand.Dispose();
            objCommand = null;
            huy_ketnoi();
        }
    }
}
