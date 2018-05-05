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

namespace TrackingApp_Events_Interface
{
    /// <summary>
    /// Interaction logic for LocatieWindow.xaml
    /// </summary>
    public partial class LocatieWindow : Window
    {
        public event EventHandler<LocationEventArgs> LocationSubmitted;
        ILocalisable l;
        public LocatieWindow(ILocalisable localisable)
        {
            InitializeComponent();
            if (localisable is Employee)
            {
                this.Title = "Employee: " + localisable.TrackId;
            }
            else if (localisable is Car)
            {
                this.Title = "Car: " + localisable.TrackId;
            }
            else if (localisable is Van)
            {
                this.Title = "Van: " + localisable.TrackId;
            }
            lb_TrackId.Content = localisable.TrackId;
            l = localisable;
        }

        private void OnLocationSubmitted(LocationEventArgs args)
        {
            LocationSubmitted?.Invoke(this, args);
        }

        private void bt_Submit_Location_Click(object sender, RoutedEventArgs e)
        {
            string id = lb_TrackId.Content.ToString();
            string location = tb_Location.Text;
            OnLocationSubmitted(new LocationEventArgs(id, location));
            tb_Location.Clear();
        }
    }
}
