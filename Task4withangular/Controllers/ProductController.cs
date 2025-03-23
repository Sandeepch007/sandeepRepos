using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ballayer;
using propertylayer;
namespace Task4withangular.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly Ballogiclayer _balobj;
        public ProductController(AppdbContext context)
        {
            _balobj =new Ballogiclayer(new Dallayer.DalRepository(context));
        }
        [HttpGet]
        public List<Products> products()
        {
            List<Products> products = new List<Products>();
            try
            {
                products = _balobj.GetProduct();
            }
            catch (Exception)
            {

                throw;
            }
            return products;
        }
        [HttpGet("category")]
        public List<category> categories() 
        {
            List<category> categories = new List<category>();
            try
            {
             categories=_balobj.Getcategory();
            }
            catch (Exception)
            {

                throw;
            }
            return categories;

        }
        [HttpPost]
        public string postproducts(Products products) 
        {
            string msg = string.Empty;
            bool ispost=false;
            try
            {
                ispost=_balobj.postpro(products);
                if(ispost)
                {
                    msg = "record is inserted...";
                }
                else
                {
                    msg = "record is not inserted..";
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
