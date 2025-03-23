using DAlproduct;
using ProductProperties;

namespace BalProduct
{
    public class ProductLogic
    {
        private readonly ProductRepository _repo;
        public ProductLogic(ProductRepository repo)
        {
            _repo = repo;
        }
        public List<Product> pro()
        {
            try
            {
                return _repo.GetProducts();

            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool update(Product pro)
        {
            try
            {   pro.Updated=DateTime.Now;
                return _repo.UpdateProduct(pro);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool Post(Product pro)
        {
            try
            {
                pro.CreatedAt = DateTime.Now;// Stores time as 00:00:00
                return _repo.postproducts(pro);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool delete(int id)
        {
            try
            {
                return _repo.deletepro(id);
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
