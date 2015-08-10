using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;


namespace HisClient
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();          
 
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.TableName = "gggg";
            dt.Columns.Clear();
            dt.Columns.Add("aa");
            dt.Columns.Add("bb");
            dt.Columns.Add("cc");
            dt.Columns.Add("dd");
            dt.Columns.Add("ee");
            dt.Columns.Add("ff");
            dt.Columns.Add("gg");
            dt.Columns.Add("hh");

            dt.Rows.Add();
            dt.Rows.Add();


            dt.Rows[0]["aa"] = "1";
            dt.Rows[0]["bb"] = "2";
            dt.Rows[0]["cc"] = "3";
            dt.Rows[0]["dd"] = "4";
            dt.Rows[0]["ee"] = "5";
            dt.Rows[0]["ff"] = "6";
            dt.Rows[0]["gg"] = "7";
            dt.Rows[0]["hh"] = "8";


            dt.Rows[1]["aa"] = 11;
            dt.Rows[1]["bb"] = 22;
            dt.Rows[1]["cc"] = 33;
            dt.Rows[1]["dd"] = 44444444444444.00;
            dt.Rows[1]["ee"] = 55;
            dt.Rows[1]["ff"] = 66;
            dt.Rows[1]["gg"] = 77;
            dt.Rows[1]["hh"] = 88;
            gridControl1.Dock = DockStyle.Fill;
            gridControl1.DataSource = dt;
            gridView1.Columns.Clear();
            ComFunc comfun = new ComFunc();
            comfun.dgvstyle(gridView1, 0, "aa", "第一", 10, true, true, DevExpress.Utils.HorzAlignment.Center, DevExpress.XtraGrid.Columns.FixedStyle.Left, true);
            comfun.dgvstyle(gridView1, 1, "bb", "第2", 100, true, true, DevExpress.Utils.HorzAlignment.Center, DevExpress.XtraGrid.Columns.FixedStyle.None, true);
            comfun.dgvstyle(gridView1, 2, "cc", "第3", 100, true, true, DevExpress.Utils.HorzAlignment.Center, DevExpress.XtraGrid.Columns.FixedStyle.None, true);
            comfun.dgvstyle(gridView1, 3, "dd", "第4", 100, true, true, DevExpress.Utils.HorzAlignment.Center, DevExpress.XtraGrid.Columns.FixedStyle.None, true);
            comfun.dgvstyle(gridView1, 4, "ee", "第5", 10, true, true, DevExpress.Utils.HorzAlignment.Center, DevExpress.XtraGrid.Columns.FixedStyle.None, true);
            comfun.dgvstyle(gridView1, 5, "ff", "第6", 20, true, true, DevExpress.Utils.HorzAlignment.Center, DevExpress.XtraGrid.Columns.FixedStyle.None, true);
            comfun.dgvstyle(gridView1, 6, "hh", "第8", 30, true, true, DevExpress.Utils.HorzAlignment.Center, DevExpress.XtraGrid.Columns.FixedStyle.None, true);
            comfun.dgvstyle(gridView1, 7, "gg", "第7", 50, true, true, DevExpress.Utils.HorzAlignment.Far, DevExpress.XtraGrid.Columns.FixedStyle.None, true);
            gridView1.GroupPanelText = "这是绑定结果";

            zqctext1.ID = "aaaaaa";
            zqctext1.Text = "bbbbbb";
        }
    }
}
