using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SQLite;
using System.Data;

namespace JTDic
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();
        private enum langs { unknown, en, jp, th };
        public MainWindow()
        {
            InitializeComponent();
            SetConnection();
            //MessageBox.Show((int)new Languages("あ").Check()+"");
            //ก = 3585 ฮ = 3630

            //LoadData();
            //textbox_1.Text = "";
        }
        private void SetConnection()
        {
            sql_con = new SQLiteConnection("Data Source=database.db;Version=3;New=False;Compress=True;");
        }
        private void ExecuteQuery(string txtQuery)
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = txtQuery;
            sql_cmd.ExecuteNonQuery();
            sql_con.Close();
        }
        private void LoadData()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = "select jp from table_words where word_id=1";
            CommandText = "select jp,th from table_words where kana='あい'";
            string sql = "select jp,th from table_words limit 1000";

            DB = new SQLiteDataAdapter(sql, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            //this.dataGrid1.DataContext = DT;
            //dataGrid1.SetValue(DT,0);

            dataGrid1.ItemsSource = new DataView(DS.Tables[0]);
            
            //GriDd.DataSource = DT;
            sql_con.Close();
        }

       

        private void search(string condition)
        {

            
            string s = "";
            switch (((int)new Languages(condition).Check()))
            {
                case 0:
                    s = "jp";
                    break;
                case 1:
                    s = "romanji";
                    break;
                case 2:
                    s = "kana";
                    break;
                case 3:
                    s = "kata";
                    break;
                case 4:
                    s = "th";
                    break;

            }

            //MessageBox.Show(s);
            string sql = "select jp,th from table_words where "+s+" like '" + condition + "%'";
            //sql = "select jp,th from table_words where en like 'a%'";

            try
            {
                SetConnection();
                sql_con.Open();
                sql_cmd = sql_con.CreateCommand();
                DB = new SQLiteDataAdapter(sql, sql_con);
                DS.Reset();
                DB.Fill(DS);

                dataGrid1.ItemsSource = new DataView(DS.Tables[0]);
                sql_con.Close();
            }
            catch (Exception e) { }
            
        }

        private void Add()
        {
            //string txtSQLQuery = "insert into  mains (desc) values ('" + txtDesc.Text + "')";
            //ExecuteQuery(txtSQLQuery);
        }

        private void textbox_1_TextChanged(object sender, TextChangedEventArgs e)
        {
            search(textbox_1.Text);
        }
    }
}
