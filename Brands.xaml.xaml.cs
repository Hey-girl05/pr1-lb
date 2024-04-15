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
    /// Логика взаимодействия для Brands.xaml
    /// </summary>
    public partial class Brands : UserControl
    {
        BrandsTableAdapter people = new BrandsTableAdapter();

        public Brands()
        {
        }

        public Brands(object colourDataGrid)
        {
            InitializeComponent();
            ColourDataGrid.ItemsSource = people.GetData();
            ColourDataGrid = colourDataGrid;
        }

        public object ColourDataGrid { get; private set; }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }
    }
}
