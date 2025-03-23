using DalProCust;
using PropertiesPROCUST;

namespace BalProCust
{
    public class ProCustLogic
    {
        private readonly ProCustRepository _repo;
        public ProCustLogic(ProCustRepository repo)
        {
            _repo = repo;
        }
        public List<ProCust> pro()
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
        public bool update(ProCust pro)
        {
            try
            {
               
                return _repo.UpdateProduct(pro);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool Post(ProCust pro)
        {
            try
            {
                
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

