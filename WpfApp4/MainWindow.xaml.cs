using System;
using System.Collections.Generic;
using System.Data;
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
using System.Data;
using System.IO.Packaging;

namespace WpfApp4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window 
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        void fillingDataGridUsingDataTable()
        {
            DataTable dt = new DataTable();
            DataColumn id = new DataColumn("Id",typeof(int));
            DataColumn Name = new DataColumn("Name",typeof(string));
            DataColumn Phone = new DataColumn("Phone",typeof(int));
            DataColumn Gmail = new DataColumn("Gmail", typeof(string));
            DataColumn Address = new DataColumn("Address", typeof(string));


            dt.Columns.Add(id);
            dt.Columns.Add(Name);                
            dt.Columns.Add(Phone);
            dt.Columns.Add(Gmail);
            dt.Columns.Add(Address);

            DataRow firstRow = dt.NewRow();
            firstRow[0] = 1;
            firstRow[1] = "Divye";
            firstRow[2] = "25";
            firstRow[3] = "divyepankaj23@gmail.com";
            firstRow[4] = "3327/139C/45 Anand Nager, Rewari";

            DataRow secondRow = dt.NewRow();
            secondRow[0] = 2;
            secondRow[1] = "pankaj";
            secondRow[2] = "34";
            secondRow[3] = "divyepankaj0023@gmail.com";
            secondRow[4] = "3327/139C/46 Anand Nager, Rewari";
            
            DataRow thirdRow = dt.NewRow();
            thirdRow[0] = 3;
            thirdRow[1] = "Navdeep";
            thirdRow[2] = "14";
            thirdRow[3] = "divyepankaj118103@gmail.com";
            thirdRow[4] = "3327/139C/47 Anand Nager, Rewari";

            dt.Rows.Add(firstRow);
            dt.Rows.Add(secondRow);
            dt.Rows.Add(thirdRow);

            myDataGrid.ItemsSource = dt.DefaultView;

        }

        private void myDataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            this.fillingDataGridUsingDataTable();
        }
    }
    }

