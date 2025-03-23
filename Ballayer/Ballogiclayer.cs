using Dallayer;
using propertylayer;

namespace Ballayer
{
    public class Ballogiclayer
    {
        private readonly DalRepository _repository;
        public Ballogiclayer(DalRepository repository)
        {
            _repository = repository;
        }

        public List<Products> GetProduct() 
        {
            try
            {
                return _repository.GetProducts();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<category> Getcategory() 
        {
            try
            {
                return _repository.GetCategories();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool postpro(Products products) 
        {
            try
            {
                return _repository.postproducts(products);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
