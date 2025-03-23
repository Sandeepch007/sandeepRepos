using BalProCust;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PropertiesPROCUST;

namespace Bang2Withcustomertask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProCustController : ControllerBase
    {
        private readonly ProCustLogic _balobj;
        public ProCustController(ProCustDbcontext context)
        {
            _balobj = new ProCustLogic(new DalProCust.ProCustRepository(context));
        }
        [HttpGet]
        public List<ProCust> GetProducts()
        {
            List<ProCust> pro = new List<ProCust>();
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
        public string PostProducts(ProCust pro)
        {
            string msg = string.Empty;
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
        public string UpdateProducts(ProCust pro)
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
                var res = _balobj.delete(id);
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

