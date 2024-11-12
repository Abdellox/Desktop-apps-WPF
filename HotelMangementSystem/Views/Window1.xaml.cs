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

namespace HotelMangementSystem.Views
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void CalculateStay_Click(object sender, RoutedEventArgs e)
        {
            // Get selected room type and price
            var selectedRoom = (ComboBoxItem)RoomTypeComboBox.SelectedItem;
            var roomPrice = int.Parse(selectedRoom.Content.ToString().Split('$')[1]);

            // Get check-in and check-out dates
            DateTime checkInDate = CheckInDatePicker.SelectedDate ?? DateTime.Now;
            DateTime checkOutDate = CheckOutDatePicker.SelectedDate ?? DateTime.Now;

            // Calculate total nights
            int totalNights = (checkOutDate - checkInDate).Days;

            if (totalNights > 0)
            {
                // Calculate total cost
                decimal totalCost = totalNights * roomPrice;
                SummaryTextBlock.Text = $"Total Stay: {totalNights} nights\nTotal Cost: ${totalCost}";
            }
            else
            {
                SummaryTextBlock.Text = "Please select a valid date range.";
            }
        }
    }



}
