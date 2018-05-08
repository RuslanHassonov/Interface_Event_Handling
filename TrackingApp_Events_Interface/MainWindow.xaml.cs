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

namespace TrackingApp_Events_Interface
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Vehicle> listVehicles;
        public MainWindow()
        {
            InitializeComponent();
            listVehicles = new List<Vehicle>();
        }

        #region Employee
        private void bt_Add_Employee_Click(object sender, RoutedEventArgs e)
        {
            if (tb_Employee_Name.Text != null)
            {
                var employee = new Employee(tb_Employee_Name.Text);
                lb_Company_Overview.Items.Add(employee.ToString());
                LocatieWindow w = new LocatieWindow(employee);
                w.Show();
                employee.LocationSubmitted += (s, args) =>
                {
                    lb_Movement_Overview.Items.Add("Employee: " + args.TrackId + " - New Location: " + args.Location);
                };
                tb_Employee_Name.Clear();
            }
        }
        #endregion
        #region Car
        private void bt_Add_Car_Click(object sender, RoutedEventArgs e)
        {
            if (tb_License_Plate_Car.Text != null)
            {
                var car = new Car(tb_License_Plate_Car.Text, null);
                if (!car.VehicleExists(listVehicles, tb_License_Plate_Car.Text))
                {
                    listVehicles.Add(car);
                    lb_Company_Overview.Items.Add(car.ToString());
                    LocatieWindow w = new LocatieWindow(car);
                    w.Show();

                    car.LocationSubmitted += (s, args) =>
                    {
                        lb_Movement_Overview.Items.Add("Car: " + args.TrackId + " - New Location: " + args.Location);
                    };
                    tb_License_Plate_Car.Clear();
                }
                else
                {
                    MessageBox.Show("This license plate already exists.");
                }
            }
        }
        #endregion
        #region Van
        private void bt_Add_Van_Click(object sender, RoutedEventArgs e)
        {
            if (tb_License_Plate_Van.Text != null)
            {
                var van = new Van(tb_License_Plate_Van.Text, null);
                if (!van.VehicleExists(listVehicles, tb_License_Plate_Van.Text))
                {
                    listVehicles.Add(van);
                    lb_Company_Overview.Items.Add(van.ToString());
                    LocatieWindow w = new LocatieWindow(van);
                    w.Show();

                    van.LocationSubmitted += (s, args) =>
                    {
                        lb_Movement_Overview.Items.Add("Van: " + args.TrackId + " - New Location: " + args.Location);
                    };
                    tb_License_Plate_Van.Clear();
                }
                else
                {
                    MessageBox.Show("This license plate already exists.");
                }
            }
        }
        #endregion
    }
}
