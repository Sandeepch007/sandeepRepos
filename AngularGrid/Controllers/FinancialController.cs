using GridBallayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using property;

namespace AngularGrid.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FinancialController : ControllerBase
    {
        private readonly FinancialLogic _ballog;
        public FinancialController(GridDbContext context)
        {
            _ballog=new FinancialLogic(new Griddallayer.FinancialRepository(context));
        }
        [HttpGet]
        public List<FinancialData> GetFData()
        {
            List<FinancialData> data=new List<FinancialData>();
            try
            {
                data = _ballog.getall();

            }
            catch (Exception)
            {

                throw;
            }
            return data;
        }
    }
}
