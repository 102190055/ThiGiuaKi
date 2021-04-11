using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThiGiuaKy
{
    public partial class Form2 : Form
    {
        public delegate void Mydel(string id_kho, int ClassID);
        public Mydel d { get; set; }
        public int ID_Kho { get; set; }
        public Form2(int ID_Kho)
        {
            InitializeComponent();
            //this.ID_Kho = ID_Kho;
            //ShowForm(ID_Kho);
        }
        //void ShowKVcbb()
        //{
        //    foreach(CBBItem i in CSDL_OOP.Instance.GetcbbKV())
        //    {
        //        kv_cbb.Items.Add(i);
        //    }
        //}
        //void ShowTTcbb()
        //{
        //    List<Kho> kho = CSDL_OOP.Instance.GetAllKho();
        //    int id = 0;
        //    foreach(Kho i in kho)
        //    {
        //        kv_cbb.Items.Add(new CBBItem);
        //    }
        //}
        //public void ShowForm(int ID_Kho)
        //{
        //    ShowKVcbb();
        //    ShowTTcbb();
        //    Kho s = CSDL_OOP.Instance.GetKho()
        //}

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
