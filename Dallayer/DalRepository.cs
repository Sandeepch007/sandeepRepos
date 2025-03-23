using propertylayer;

namespace Dallayer
{
    public class DalRepository
    {
        private readonly AppdbContext _context;
        public DalRepository(AppdbContext context) 
        { 
        _context = context;
        }
        public List<Products> GetProducts() 
        {
            List<Products> products = new List<Products>();
            try
            {
                products=(from pro in _context.Products join cat in _context.Category on pro.CategoryId equals cat.CategoryId select(new Products
                {
                    ProductId=pro.ProductId,
                    ProductName=pro.ProductName,
                    ProductPrice=pro.ProductPrice,
                    ProductCode=pro.ProductCode,
                    TotalPrice=pro.TotalPrice,
                    quantity=pro.quantity,
                    category=new category
                    {
                        CategoryName=cat.CategoryName
                    }
                })).ToList();
                return products;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<category> GetCategories()
        {
            try
            {
                List<category > categories = new List<category>();
                categories=_context.Category.ToList();
                return categories;
            }
            catch (Exception)
            {

                throw;
            }
            
        }
        public bool postproducts(Products product)
        {
            bool ispost=false;
            try
            {
                _context.Products.Add(product);
                _context.SaveChanges();
                ispost=true;

            }
            catch (Exception)
            {

                throw;
            }
            return ispost;
        }
    }
}
