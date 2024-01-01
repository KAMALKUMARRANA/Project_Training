using BlazorAspNetCoreHostedDemo.Shared;

namespace BlazorAspNetCoreHostedDemo.Server
{
    public class ProductService
    {
        private List<Product> _products;
        public ProductService()
        {
            _products = new List<Product>();
        }
        public List<Product> GetProduct()
        {
            return _products;
        }

        public void AddProduct(Product product)
        {
            _products.Add(product);
        }
        public void RemoveProduct(string productCode)
        {
            _products.RemoveAll(x=>x.ProductCode==productCode);
        }


    }
}
