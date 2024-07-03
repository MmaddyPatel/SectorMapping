using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZEE.DAL;
namespace SectorMapping
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BindSector();
            BindStocks();
        }

        private void BindSector()
        {
            DataTable dt;
            string str = "";
            str = "exec sp_get_sector";
            dt = SqlHelper.ExecuteDataset(Properties.Settings.Default.conn_str_main, CommandType.Text, str).Tables[0];

            lstSector.DataSource = dt;
            lstSector.DisplayMember = "only_sector_name";
            lstSector.ValueMember = "sector_id";


        }
   private void BindStocks()
        {
            DataTable dt;
            string str = "";
            int exchange = 1;
            if (radBSE.Checked == true)
            {
                exchange = 2;
            }
            str = "sp_get_companyList " + exchange;
            dt = SqlHelper.ExecuteDataset(Properties.Settings.Default.conn_str_main, CommandType.Text, str).Tables[0];

            checkedListBox1.DataSource = dt;
            checkedListBox1.DisplayMember = "abbrs";
            checkedListBox1.ValueMember = "stock_id";


        }
        private void lstSector_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindSectorList();

        }

        private void BindSectorList()
        {
            string selectedText = lstSector.GetItemText(lstSector.SelectedItem);
            string selectedValue = lstSector.SelectedValue.ToString();
            int exchange = 1;
            if (radBSE.Checked == true)
            {
                exchange = 2;
            }
            string str = "SP_GET_SORTED_INTRADAY  "+exchange +",'TOP TRADES','" + selectedValue + "','50'";
            DataTable dt = SqlHelper.ExecuteDataset(Properties.Settings.Default.conn_str_main, CommandType.Text, str).Tables[0];

            lst_stocks.DataSource = dt;
            lst_stocks.DisplayMember = "name";
            lst_stocks.ValueMember = "stock_id";
        }
        public class ListItem
        {
            public string Name { get; set; }
            public string Value { get; set; }

            public override string ToString()
            {
                return Name;
            }
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            foreach (var item in checkedListBox1.CheckedItems)
            {
                var row = (item as DataRowView).Row;
                richTextBox1.AppendText(row["abbrs"].ToString() + " | " + row["stock_id"].ToString() + "\r\n");
            }
            
          
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
              

            foreach (var item in checkedListBox1.CheckedItems)
            {
                var row = (item as DataRowView).Row;
                string selectedValue = lstSector.SelectedValue.ToString();
                string str = "update stock_items set sector_id =isnull(SECTOR_ID,'') + ',"+ selectedValue + ",' where stock_id ='"+ row["stock_id"].ToString() + "'";
                SqlHelper.ExecuteNonQuery(Properties.Settings.Default.conn_str_main, CommandType.Text, str);
            }
            richTextBox1.Text = "";


            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }
            BindSectorList();
           
        }

        private void radNSE_CheckedChanged(object sender, EventArgs e)
        {
            BindSector();
            BindStocks();
        }

        private void radBSE_CheckedChanged(object sender, EventArgs e)
        {
            BindSector();
            BindStocks();
        }
    }
}
