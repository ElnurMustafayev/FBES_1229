using AdoNetInWpfApp.Repositories;
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

namespace AdoNetInWpfApp
{
    public partial class MainWindow : Window
    {
        private readonly ProductSqlRepository productRepo;

        private decimal? Price {
            get {
                if (this.ProductPriceTextBox == null || string.IsNullOrWhiteSpace(this.ProductPriceTextBox.Text))
                    return null;

                if(decimal.TryParse(this.ProductPriceTextBox.Text, out decimal result))
                    return result;

                return null;
            }
        }

        public MainWindow()
        {
            InitializeComponent();

            this.productRepo = new ProductSqlRepository();
        }

        private void SearchProductsOnTextChanged(object sender, TextChangedEventArgs e) {
            var foundItems = this.productRepo.Find(
                name: this.ProductNameTextBox.Text, 
                price: this.Price);

            this.ResultTextBlock.Text = $"Result: {foundItems.Count()}";
        }
    }
}
