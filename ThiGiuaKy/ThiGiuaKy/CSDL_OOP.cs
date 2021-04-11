using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThiGiuaKy
{
    class CSDL_OOP
    {
        private static CSDL_OOP _Instance;

        public static CSDL_OOP Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new CSDL_OOP();
                return _Instance;
            }
            private set
            {

            }
        }
        private CSDL_OOP() { }
        public Kho GetKho(DataRow i)
        {
            Kho s = new Kho();
            s.ID_Kho = Convert.ToInt32(i["ID_Kho"]);
            s.Ten = i["Ten"].ToString();
            s.Dien_tich = Convert.ToDouble(i["Dien tich"]);
            s.Trang_Thai = i["Trang thai"].ToString();
            s.ID_KV = Convert.ToInt32(i["ID_KV"]);
            return s;
        }
        public List<Kho> GetAllKho()
        {
            List<Kho> kho = new List<Kho>();
            foreach (DataRow i in CSDL.Instance.DTKHO.Rows)
            {
                kho.Add(GetKho(i));
            }
            return kho;
        }

        public List<Kho> GetListkho(int id_kv,string name)
        {
            List<Kho> kho = new List<Kho>();
            foreach (Kho s in GetAllKho())
            {
                if (s.ID_KV == id_kv && s.Ten.Contains(name))
                {
                    kho.Add(s);
                }
            }
            return kho;
        }

        public List<KV> GetAllKV()
        {
            List<KV> kv = new List<KV>();
           
            foreach (DataRow i in CSDL.Instance.DTKV.Rows)
            {
                KV l = new KV();
                l.ID_KV = Convert.ToInt32(i["ID_KV"].ToString());
                l.Dia_chi = i["Dia_chi"].ToString();
                kv.Add(l);
            }
            return kv;

        }
        //public List<Kho> GetListKho_ByIDKho(List<int> data)
        //{
        //    List<Kho> kho = new List<Kho>();
     
        //    foreach (int i in data)
        //    {
        //        foreach (DataRow j in CSDL.Instance.DTKHO.Rows)
        //        {
        //            if (i == j["ID_Kho"])
        //            {
        //                Kho s = new Kho();
        //                s.ID_Kho = Convert.ToInt32(j["ID_Kho"]);
        //                s.Ten = j["Ten"].ToString();
        //                s.Dien_tich = Convert.ToDouble(j["Dien Tich"]);
        //                s.Trang_Thai = j["Trang Thai"].ToString();
        //                s.ID_KV = Convert.ToInt32(j["ID_kv"].ToString());
        //                kho.Add(s);
        //            }
        //        }
        //    }
        //    return kho;
        //}
    }
}
