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
using System.Data.OleDb;
using System.Data;
using System.IO;
using System.Diagnostics;

namespace Chirag_Art
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static int bill=1;
        private Login parentWind = null;
        List<int> mrp = new List<int>();
        List<string> ItName = new List<string>();
        List<int> barcode_no = new List<int>();
        List<int> qty = new List<int>();
        List<int> sum = new List<int>();
        double total=0.0;
        int csum = 0;
       
        static String opConnStr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data"
                          + @" Source=F:\Dropbox\Dropbox\OOSE Project\Jewelery.accdb";
        OleDbConnection opconn = new OleDbConnection(opConnStr);
        OleDbCommand cmd = null;
        public MainWindow(Window childWind)
        {
            parentWind = childWind as Login;
            
            InitializeComponent();
            this.Start_1();
            
            //for logoff functionality
        }
        public MainWindow()
        {
            InitializeComponent();
        }
        static void Increment()
        {
            bill++;
        }
        public void Start_1()
        {
            barcodeNo.Text = "";
            employee.Items.Add("Jheel");
            employee.Items.Add("Rohan");
            timestamp.Text = DateTime.Now.ToString();
            billNo.Text = bill.ToString();
            total=0.0;
        }
        public void Calc_total()
        {
            sum.Add(Convert.ToInt32(qty[csum] * mrp[csum]));
            total = total + (qty[csum] * mrp[csum]);
            total_txt.Text = total.ToString();
            csum++;
        }
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MenuItem select = e.Source as MenuItem;
            //MessageBox.Show(select.Name);
            switch(select.Name)
            {
                case "create_items":
                    {
                        CreateItem ci = new CreateItem(this);
                        ci.Show();
                        break;
                    }
            }
        }

        private void Print_Click(object sender, RoutedEventArgs e)
        {

        }

        private void rpt_Click(object sender, RoutedEventArgs e)
        {
            MenuItem select = e.Source as MenuItem;
            switch (select.Name)
            {
                case "dead_stock":
                    {
                        dead_stock di = new dead_stock();
                        di.Show();
                        break;
                    }
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BillGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void new_click(object sender, RoutedEventArgs e)
        {
            Increment();

            Start_1();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int barcode1 = Convert.ToInt32(barcodeNo.Text);
            int quantity = Convert.ToInt32(quant_amt.Text);
            OleDbDataReader dr = null;
            opconn.Open();
            cmd=new OleDbCommand("update Items set quantity=quantity - "+quantity+" where Barcode="+barcode1+"",opconn);
            cmd.ExecuteNonQuery();
            cmd = new OleDbCommand("update Items set lastSold='" + DateTime.Today + "' where Barcode=" + barcode1 + "", opconn);
            cmd.ExecuteNonQuery();
            cmd = new OleDbCommand("update Items set ItSold=ItSold + " + quantity + " where Barcode=" + barcode1 + "", opconn);
            cmd.ExecuteNonQuery();
            cmd=new OleDbCommand("select ItName,mrp,Barcode from Items where Barcode="+barcode1+"",opconn);
            dr=cmd.ExecuteReader();
            dr.Read();
            ItName.Add(dr[0].ToString());
            mrp.Add(Convert.ToInt32(dr[1]));
            barcode_no.Add(Convert.ToInt32(dr[2]));
            barcodeNo.Text = "";
            quant_amt.Text = "";
            qty.Add(quantity);
            dr.Close();
            Calc_total();
            opconn.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string file_n = "\\Bill.txt";
            file_n = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + file_n;
        }

        private void logoff_click1(object sender, ContextMenuEventArgs e)
        {
            
        }

        private void logoff_but(object sender, RoutedEventArgs e)
        {
                parentWind.Show();
                Close(); 
        }

        private void DataDisplay_Click(object sender, RoutedEventArgs e)
        {
           // MessageBox.Show(barcode_no[0].ToString());
            opconn.Open();
            cmd = new OleDbCommand("delete * from CurrentBill", opconn);
            cmd.ExecuteNonQuery();
            for (int prime = 0; prime < ItName.Count; prime++)
            {
                cmd=new OleDbCommand("insert into CurrentBill([barcode],[Itname],[sellMrp],[Quantity],[sum]) values("+barcode_no[prime]+",'"+ItName[prime]+"',"+mrp[prime]+","+qty[prime]+","+sum[prime]+")",opconn);
                cmd.ExecuteNonQuery();
                
            }
                cmd = new OleDbCommand("select * From CurrentBill", opconn);
            cmd.CommandType = System.Data.CommandType.Text;
            DataTable table = new DataTable();
            OleDbDataAdapter d = new OleDbDataAdapter();
            d.SelectCommand = cmd;
            d.Fill(table);
            if(table != null)
            {
                BillGrid.DataContext = table;
            }
            opconn.Close();
        }

        private void Preview_bill(object sender, RoutedEventArgs e)
        {
            
            File.WriteAllText(@"F:\Dropbox\Dropbox\OOSE Project\Bill.txt", String.Empty);   
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"F:\Dropbox\Dropbox\OOSE Project\Bill.txt", true))
            {
                
                file.WriteLine("@\t\t\t\t\t@");
                file.WriteLine("@\t\tChirag Art\t\t@");
                file.WriteLine("@\t\t\t\t\t@");
                file.WriteLine("@ Salesman: "+employee.Text+"\t\t\t@");
                file.WriteLine("@\tTimestamp: " + DateTime.Now.ToString() + " @");
                file.WriteLine("@_______________________________________@");
                file.WriteLine("@ Bill Number:"+billNo.Text+"\t\t\t\t@");
                file.WriteLine("@_______________________________________@");
                file.WriteLine("@Item\t\tMRP\tQTY\tAMT\t@");
                file.WriteLine("@_______________________________________@");
                for (int i = 0; i < barcode_no.Count;i++ )
                {
                    file.WriteLine("@ " + ItName[i] + "\t" + mrp[i].ToString() + "\t" + qty[i].ToString() + "\t" + sum[i].ToString() + "\t@");
                    file.WriteLine("@\t\t\t\t\t@");
                }
                file.WriteLine("@---------------------------------------@");
                file.WriteLine("@\t\t     Grand total="+total.ToString()+" @");
                file.WriteLine("@---------------------------------------@");
                file.WriteLine("@\tCome again,enjoy shopping!\t@");
            }
            Process.Start("notepad.exe", @"F:\Dropbox\Dropbox\OOSE Project\Bill.txt");
        }
        
    }
}
