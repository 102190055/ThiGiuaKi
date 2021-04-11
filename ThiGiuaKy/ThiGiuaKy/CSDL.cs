using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiGiuaKy
{
    class CSDL
    {
        public DataTable DTKHO { get; set; }
        public DataTable DTKV { get; set; }
        public static CSDL Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new CSDL();
                }
                return _Instance;
            }
            private set
            {
            }
        }

        private static CSDL _Instance;
        private CSDL()
        {
            DTKHO = new DataTable();
            DTKHO.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("ID_Kho",typeof(int)),
                new DataColumn("Ten",typeof(string)),
                new DataColumn("Dien tich",typeof(double)),
                new DataColumn("Trang thai",typeof(string)),
                new DataColumn("ID_KV",typeof(int)),
            });
            DataRow dr = DTKHO.NewRow();
            dr["ID_Kho"] = 1;
            dr["Ten"] = "A1";
            dr["Dien tich"] = 10000;
            dr["Trang thai"] = "Full";
            dr["ID_KV"] = 1;
            DTKHO.Rows.Add(dr);
            DataRow dr1 = DTKHO.NewRow();
            dr1["ID_Kho"] = 2;
            dr1["Ten"] = "A2";
            dr1["Dien tich"] = 20000;
            dr1["Trang thai"] = "Not Full";
            dr1["ID_KV"] = 2;
            DTKHO.Rows.Add(dr1);
            DataRow dr2 = DTKHO.NewRow();
            dr2["ID_Kho"] = 3;
            dr2["Ten"] = "A3";
            dr2["Dien tich"] = 30000;
            dr2["Trang thai"] = "KHD";
            dr2["ID_KV"] = 1;
            DTKHO.Rows.Add(dr2);

            DTKV = new DataTable();
            DTKV.Columns.AddRange(new DataColumn[]
                {
                    new DataColumn ("ID_KV",typeof(int)),
                    new DataColumn ("Dia_chi",typeof(string))
                });
            DataRow dr3 = DTKV.NewRow();
            dr3["ID_KV"] = 1; dr3["Dia_Chi"] = "Da_Nang";
            DTKV.Rows.Add(dr3);

            DataRow dr4 = DTKV.NewRow();
            dr4["ID_KV"] = 2; dr4["Dia_Chi"] = "Quang_Nam";
            DTKV.Rows.Add(dr4);
        }

        //internal object GetListkho(int id_kho, string v)
        //{
        //    throw new NotImplementedException();
        //}

        //internal IEnumerable<Kho> GetAllKho()
        //{
        //    throw new NotImplementedException();
        //}

        public void setDTKho(List<Kho> kho)
        {
            DTKHO.Rows.Clear();
            foreach (var i in kho)
            {
                DataRow dr = DTKHO.NewRow();
                dr["ID_Kho"] = i.ID_Kho;
                dr["Ten"] = i.Ten;
                dr["Dien tich"] = i.Dien_tich;
                dr["Trang thai"] = i.Trang_Thai;
                dr["ID_KV"] = i.ID_KV;
                DTKHO.Rows.Add(dr);

            }
        }
    }
}
