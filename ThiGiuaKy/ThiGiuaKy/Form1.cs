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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            comboBox1.Items.Add(new CBBItem { Value = 0, Text = "All" });
            SetCBB(comboBox1);
            //dataGridView1.DataSource = CSDL.Instance.DTKHO;
            //cbbLSH.SelectedIndex = 0;
            //SetCBBSort();
        }
        public void show(int id_kho, string name)
        {
            if (id_kho == 0)
            {
                dataGridView1.DataSource = CSDL_OOP.Instance.GetAllKho();
            }
            else
            {
                //dataGridView1.DataSource = CSDL.Instance.GetListkho(id_kho, "");
            }
        }
        public void SetCBB(ComboBox cb)
        {
            foreach (KV i in CSDL_OOP.Instance.GetAllKV())
            {
                cb.Items.Add(new CBBItem
                {
                    Value = i.ID_KV,
                    Text = i.Dia_chi,
                });
            }
        }

        private void Show_Click(object sender, EventArgs e)
        {
            show(comboBox1.SelectedIndex, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Search(0, textBox1.Text);
        }
        public void Search(int id_KV, string name)
        {
            if (name != null)
            {
                dataGridView1.DataSource = CSDL_OOP.Instance.GetListkho(0, name);
            }
        }
        //public void Delete(List<int> ID_Kho)
        //{
        //    foreach (Kho s in CSDL_OOP.Instance.GetListKho_ByIDKho(ID_Kho))
        //    {
        //        foreach (DataRow i in CSDL.Instance.DTKHO.Select())
        //        {
        //            if (i["ID_Kho"] == s.ID_Kho)
        //                CSDL.Instance.DTKHO.Rows.Remove(i);
        //        }
        //        CSDL.Instance.DTKHO.AcceptChanges();
        //    }
        //}

        private void Add_Click(object sender, EventArgs e)
        {
            //Form2 f2 = new Form2();
            //f2.d += new Form2.Mydel(show);
            //f2.Show();
        }
    }
}
