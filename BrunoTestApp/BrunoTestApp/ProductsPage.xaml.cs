using BrunoTestApp.Models;
using BrunoTestApp.Rest;
using System.Collections.Generic;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BrunoTestApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProductsPage : ContentPage
    {
        private RestService _service = new RestService();

        List<Product> Products = new List<Product>();

        public ProductsPage()
        {
            InitializeComponent();

            Task.Run(async delegate
            {
                Products = await _service.GetProducts();
            }).Wait();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            ListViewProducts.ItemsSource = Products;
        }
    }
}