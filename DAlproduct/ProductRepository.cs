using ProductProperties;
using System;

namespace DAlproduct
{
    public class ProductRepository
    {
        private readonly ProductDbContext _context;
        public ProductRepository(ProductDbContext context)
        {
            _context = context;
        }
        public List<Product> GetProducts()
        {
            List<Product> products = new List<Product>();
            try
            {
                products = _context.Products.ToList();         
                return products;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool UpdateProduct(Product pro)
        {
            bool isupdate = false;
            try
            {
                _context.Products.Update(pro);
                _context.SaveChanges();
                isupdate = true;
            }
            catch (Exception)
            {

                throw;
            }
            return isupdate;

        }
        public bool postproducts(Product product)
        {
            bool ispost = false;
            try
            {
                _context.Products.Add(product);
                _context.SaveChanges();
                ispost = true;

            }
            catch (Exception)
            {

                throw;
            }
            return ispost;
        }

        public bool deletepro(int id)
        {
            bool isdelete = false;
            try
            {
                var res = _context.Products.Find(id);
                if (res != null)
                {
                    _context.Products.Remove(res);
                    _context.SaveChanges();
                    isdelete = true;
                }
            }
            catch (Exception)
            {

                throw;
            }
            return isdelete;
        }
    }

}

