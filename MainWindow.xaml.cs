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

namespace pr1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public Brands Brands { get; private set; }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            People people = new  People();
            this.Content = people;
            
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            Brands = new Brands();
            this.Content = Brands;

        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            PeopleBrands people = new PeopleBrands();
            this.Content = people;

        }

    }

}
