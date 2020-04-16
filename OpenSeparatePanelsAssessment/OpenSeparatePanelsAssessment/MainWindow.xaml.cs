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
using OpenSeparatePanelsAssessment.ViewModels;


namespace OpenSeparatePanelsAssessment
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

 
        private void PurpleTalk_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new PurPleTalkViewModel();
        }

        private void XcubeLabs_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new XcubeLabsViewModel();
        }

        private void YesGnome_Click(object sender, RoutedEventArgs e)
        {
            DataContext = new YesGnomeViewModel();
        }
    }
}
