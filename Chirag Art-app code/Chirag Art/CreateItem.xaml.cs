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

namespace Chirag_Art
{
    /// <summary>
    /// Interaction logic for CreateItem.xaml
    /// </summary>
    public partial class CreateItem : Window
    {
        private MainWindow parentWind = null;
        public CreateItem(Window callingWind)
        {
            //for communication between two windows forms
            parentWind = callingWind as MainWindow; 
            InitializeComponent();
            
        }
        public CreateItem()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
        
    

        private void Add_click(object sender, RoutedEventArgs e)
        {
            String it_n = item_name.Text;
            String it_grp = item_grp.Text;
            String it_ctg= item_category.Text;
            String br = barcode.Text;
            int prct= int.Parse(percent.Text);
            int cst = int.Parse(cost.Text);
            int mgn=int.Parse(margin.Text);
            int mrpr=int.Parse(mrp.Text);
            int qty =int.Parse(quantity.Text);
            String opConnStr=@"Provider=Microsoft.ACE.OLEDB.12.0;Data"
                          + @" Source=F:\Dropbox\Dropbox\OOSE Project\Jewelery.accdb";
            OleDbConnection conn = new OleDbConnection(opConnStr);
            OleDbCommand cmd = null;
            if (qty <= 0 || cst <= 0 || mrpr <=0)
                MessageBox.Show("invalid");
            conn.Open();
            cmd = new OleDbCommand("insert into Items([Barcode],[ItName],[ItGroup],[ItCategory],[cost],[percent],[margin],[mrp],[quantity],[ItSold],[dateAdded],[lastSold]) values(" + br + ",'" + it_n + "','" + it_grp + "','" + it_ctg + "'," + cst + "," + prct + "," + mgn + "," + mrpr + "," + qty + ",0,'" + DateTime.Today + "','" + DateTime.Today + "')", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Added");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //ItemDisplay iDis = new ItemDisplay();
           // iDis.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void cancel_onCLick(object sender, RoutedEventArgs e)
        {
        }

        private void barcode_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
