using HotelMangementSystem.Views;
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

namespace HotelMangementSystem
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {



                if (string.IsNullOrEmpty(fname.Text) ||
                    string.IsNullOrEmpty(lname.Text)||
                    string.IsNullOrEmpty(gender.Text) ||
                        string.IsNullOrEmpty(email.Text) ||
                        string.IsNullOrEmpty(country.Text) 
                    )
                {
                    MessageBox.Show("Please Insert all data");
                }
                else
                {
                  
                    Window1 window = new Window1();
                    window.Show();
                }
            }
            catch (Exception exp)
            {

                MessageBox.Show("err: "+exp.Message);
            }

           
        }
    }
}
