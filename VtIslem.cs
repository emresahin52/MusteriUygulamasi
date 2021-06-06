using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace MUSTERIAPPS
{
    public class VtIslem
    {
        #region Tanımlamalar

        static SqlConnection musConn = new SqlConnection(VtAdres.baglanti);
        static SqlDataAdapter musAdp;
        public static SqlCommand musCmd = new SqlCommand();

        #endregion

        #region Kullanıcı Tanımlı Olaylar

        public static DataTable VeriGetir(string sorgu)
        {
            DataTable MusTablo = new DataTable();
            MusTablo.Clear();
            musAdp = new SqlDataAdapter(sorgu, musConn);
            musAdp.Fill(MusTablo);
            return MusTablo;
        }

        #endregion
    }
}
