using BalProduct;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductProperties;


namespace Bangalore2task.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductLogic _balobj;
        public ProductController(ProductDbContext context)
        {
            _balobj=new ProductLogic(new DAlproduct.ProductRepository(context));
        }
        [HttpGet]
        public List<Product> GetProducts() 
        {
            List<Product> pro = new List<Product>();
            try
            {

                pro = _balobj.pro();

            }
            catch (Exception)
            {

                throw;
            }
            return pro;
        }

        [HttpPost]
        public string PostProducts(Product pro)
        {
            string msg=string.Empty;
            try
            {
                var res = _balobj.Post(pro);
                if (res)
                {
                    msg = "Record is inserted successfully.....";
                }
                else
                {
                    msg = "Record is not inserted.....";
                }
            }
            catch (Exception)
            {

                throw;
            }
            return msg;
        }

        [HttpPut]
        public string UpdateProducts(Product pro)
        {
            string msg = string.Empty;
            try
            {
                var res = _balobj.update(pro);
                if (res)
                {
                    msg = "Record is updated successfully.....";
                }
                else
                {
                    msg = "Record is not updated.....";
                }
            }
            catch (Exception)
            {

                throw;
            }
            return msg;
        }

        [HttpDelete("{id}")]
        public string DeleteProducts(int id)
        {
            string msg = string.Empty;
            try
            {
                var res=_balobj.delete(id);
                if (res)
                {
                    msg = "Record is Deleted Successfully";
                }
                else
                {
                    msg = "Record is not Deleted";
                }

            }
            catch (Exception)
            {

                throw;
            }
            return msg;
        }

    }
}
