using Task1_asp.Net.Database.Models;

namespace Task1_asp.Net.Database
{
    public class DbContextCustom
    {
        public static int _productId;
        public static int _sliderproductId;


        public static List<Product> _product = new List<Product>()
        {
            
            new Product("Lavender Marigold","100% Organic, Fresh","pink","small",550,DateTime.Now),
            new Product("Orchid Heart","100% Organic, Fresh","purple","medium",250,DateTime.Now),
        };

        public static List<sliderProduct> _sliderProduct = new List<sliderProduct>()
        {
            new sliderProduct("Jasmine","100% Natural, Organic",1,25,"https://www.google.com/"),
            new sliderProduct("Orchid","100% Natural, Organic",2,45, "https://www.linkedin.com")

        };
    }
}
