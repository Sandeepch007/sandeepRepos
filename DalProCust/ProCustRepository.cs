using PropertiesPROCUST;

namespace DalProCust
{
    public class ProCustRepository
    {
        private readonly ProCustDbcontext _context;
        public ProCustRepository(ProCustDbcontext context)
        {
            _context = context;
        }
        public List<ProCust> GetProducts()
        {
            List<ProCust> products = new List<ProCust>();
            try
            {
                products = _context.ProCusts.ToList();
                return products;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool UpdateProduct(ProCust pro)
        {
            bool isupdate = false;
            try
            {
                _context.ProCusts.Update(pro);
                _context.SaveChanges();
                isupdate = true;
            }
            catch (Exception)
            {

                throw;
            }
            return isupdate;

        }
        public bool postproducts(ProCust product)
        {
            bool ispost = false;
            try
            {
                _context.ProCusts.Add(product);
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
                var res = _context.ProCusts.Find(id);
                if (res != null)
                {
                    _context.ProCusts.Remove(res);
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

