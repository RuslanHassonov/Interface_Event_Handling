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
        public LocatieWindow(ILocalisable localisable)
        {
            InitializeComponent();
            this.Title = localisable.TrackId;
            lb_TrackId.Content = localisable.TrackId;
        }
    }
}
