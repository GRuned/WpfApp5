using System;
using System.Collections;
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

namespace WpfApp5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SortedList sortedList;
        public MainWindow()
        {
            InitializeComponent();
            sortedList = new SortedList();
        }

        private void Value_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Key_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            sortedList.Add(key.Text, value.Text);
            key.Text = "";
            value.Text = "";
            ICollection collection = sortedList.Keys;
            string Data = "";
            foreach (string key in collection)
            {

                Data = Data + sortedList[key].ToString() + ", ";

            }
            MessageBox.Show(Data);
        }



    }
}
