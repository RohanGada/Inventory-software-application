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
using System.Windows.Shapes;
using System.Data.OleDb;
using System.Data;
namespace Chirag_Art
{
    /// <summary>
    /// Interaction logic for dead_stock.xaml
    /// </summary>
    public partial class dead_stock : Window
    {
        public static String opConnStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data"
                          + @" Source=F:\Dropbox\Dropbox\OOSE Project\Jewelery.accdb";
        OleDbConnection conn = new OleDbConnection(opConnStr);
        OleDbCommand cmd = null;
        OleDbCommand cmd1 = null;
        public dead_stock()
        {
            InitializeComponent();
        }

        private void Display_click(object sender, RoutedEventArgs e)
        {
            List<int> barcode = new List<int>();
            List<string> itName = new List<string>();
            List<int> qty = new List<int>();
            Dictionary<int,DateTime> lastS = new Dictionary<int,DateTime>();
            List<int> no_o_Days = new List<int>();
            conn.Open();
            OleDbDataReader rconn = null;
            List<int> bar = new List<int>();
            Dictionary<int, DateTime> dateAdd = new Dictionary<int, DateTime>();
            Dictionary<int, DateTime> lastSold = new Dictionary<int, DateTime>();
            cmd = new OleDbCommand("Select Barcode,dateAdded,lastSold from Items", conn);
            rconn = cmd.ExecuteReader();
            int i = 0, j = 0;
            while (rconn.Read())
            {
                bar.Add(Convert.ToInt32(rconn[0]));
                dateAdd.Add(i, rconn.GetDateTime(1));
                lastSold.Add(i, rconn.GetDateTime(2));
                i++;
            }
            i--;
         
            List<double> noOfD = new List<double>();
            for (j = 0; j <= i; j++)
                noOfD.Add((lastSold[j] - dateAdd[j]).TotalDays);
            //MessageBox.Show(noOfD[0].ToString());
            j = 0;
            
            for (j = 0; j <= i; j++)
            {
                cmd1 = new OleDbCommand("insert into TempDeadSale([BarC],[dateAdded],[lastSold],[noOfDays]) values(" + bar[j] + ",'" + dateAdd[j] + "','" + lastSold[j] + "'," + noOfD[j] + ")", conn);
                cmd1.ExecuteNonQuery();
            }

            cmd = new OleDbCommand("Select Barcode,ItName,quantity,I.lastSold,noOfDays from Items I,TempDeadSale where I.Barcode=BarC and noOfDays <= "+Convert.ToInt32(days.Text)+"", conn);
            rconn=cmd.ExecuteReader();
            i=0;
            while (rconn.Read())
            {
                barcode.Add(Convert.ToInt32(rconn[0]));
                itName.Add(rconn[1].ToString());
                qty.Add(Convert.ToInt32(rconn[2]));
                lastS.Add(i, rconn.GetDateTime(3));
                no_o_Days.Add(Convert.ToInt32(rconn[4]));
                i++;
            }
            i--;
            j = 0;
            
            for (j = 0; j <= i; j++)
            {
                cmd1 = new OleDbCommand("insert into DeadStock([Barcode],[ItName],[quantity],[lastSold],[noOfDays]) values(" + barcode[j] + ",'" + itName[j] + "'," + qty[j] + ",'" + lastS[j] + "'," + no_o_Days[j] + ")", conn);
                cmd1.ExecuteNonQuery();
            }
            cmd = new OleDbCommand("select * From DeadStock", conn);
            cmd.CommandType = System.Data.CommandType.Text;
            DataTable table = new DataTable();
            OleDbDataAdapter d = new OleDbDataAdapter();
            d.SelectCommand = cmd;
            d.Fill(table);
            if (table != null)
            {
                DeadStock.DataContext = table;
            }
            conn.Close();
            rconn.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            conn.Open();
            cmd = new OleDbCommand("delete * from DeadStock",conn);
            cmd.ExecuteNonQuery();
            cmd = new OleDbCommand("delete * from TempDeadSale", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            Close();
        }
    }
}
