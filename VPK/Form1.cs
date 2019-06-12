using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Cities
{
    public partial class Form_main : Form
    {
        public Form_main()
        {
            InitializeComponent();
            loadTable();
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void loadTable()
        {
            string myConnection = "server=web113.default-host.net;Port=3306;uid=daleth_max;pwd=huE96m5VHbC3;database=daleth_warehouse";
            MySqlConnection myConnect = new MySqlConnection(myConnection);

            string selectQuery = "";

            try
            {
                myConnect.Open();
                selectQuery =
                "SELECT VPK_name, VPK_adress, VPK_products FROM daleth_warehouse.table_VPK;";

                MySqlCommand command = new MySqlCommand(selectQuery, myConnect);

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter();

                dataAdapter.SelectCommand = command;
                DataTable dTable = new DataTable();

                dataAdapter.Fill(dTable);

                BindingSource bSource = new BindingSource();

                bSource.DataSource = dTable;
                dataGridViewCities.DataSource = bSource;
                dataAdapter.Update(dTable);

                dataGridViewCities.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

                dataGridViewCities.Columns[0].HeaderText = "Назва виробництва";
                dataGridViewCities.Columns[1].HeaderText = "Адреса";
                dataGridViewCities.Columns[2].HeaderText = "Продукція";

                myConnect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void searchVpk(string SearchParam, string SearchType)
        {
            string myConnection = "server=web113.default-host.net;Port=3306;uid=daleth_max;pwd=huE96m5VHbC3;database=daleth_warehouse";
            MySqlConnection myConnect = new MySqlConnection(myConnection);

            string selectQuery = "";

            //Назва
            //Продукт

            if (SearchType == "Назва")
            {
                selectQuery = "SELECT VPK_name, VPK_adress, VPK_products FROM daleth_warehouse.table_VPK WHERE VPK_name LIKE '%" + SearchParam + "%';";
            }
            if (SearchType == "Продукт")
            {
                selectQuery = "SELECT  VPK_name, VPK_adress, VPK_products FROM daleth_warehouse.table_VPK WHERE VPK_products LIKE '%" + SearchParam + "%';";
            }


            try
            {
                myConnect.Open();

                MySqlCommand command = new MySqlCommand(selectQuery, myConnect);

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter();

                dataAdapter.SelectCommand = command;
                DataTable dTable = new DataTable();

                dataAdapter.Fill(dTable);

                BindingSource bSource = new BindingSource();

                bSource.DataSource = dTable;
                dataGridViewCities.DataSource = bSource;
                dataAdapter.Update(dTable);

                dataGridViewCities.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;

                dataGridViewCities.Columns[0].HeaderText = "Назва виробництва";
                dataGridViewCities.Columns[1].HeaderText = "Адреса";
                dataGridViewCities.Columns[2].HeaderText = "Продукція";

                myConnect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form_main_Load(object sender, EventArgs e)
        {

        }



        private void скасуватиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadTable();
        }

        private void шукатиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.toolStriptextBoxSearchData.Text != "" && this.toolStripComboBoxSearcType.Text != "")
            {
                searchVpk(this.toolStriptextBoxSearchData.Text, this.toolStripComboBoxSearcType.Text);
            }
        }
    }
}
