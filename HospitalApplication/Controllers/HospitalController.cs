using HBal;
using HModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HospitalApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HospitalController : ControllerBase
    {
        private readonly HospitalLogic _logic;
        public HospitalController(HospitalDbContext context)
        {
            _logic=new HospitalLogic(new HDal.HospitalRepository(context));
        }
        [HttpGet]
        public List<SecurityQuestion> GetQues()
        {
            List<SecurityQuestion> list=new List<SecurityQuestion>();
            try
            {
                list=_logic.getques();
            }
            catch (Exception)
            {

                throw;
            }
            return list;
        }
        [HttpPost]
        public string Postregister(Register reg)
        {
            string msg=string.Empty;
            try
            {
                var res=_logic.register(reg);
                return res;
            }
            catch (Exception)
            {

                throw;
            }
           
        }
        [HttpGet("identity/userrole/password")]
        public Register Loginget(string identity, string userrole, string password)
        {
            
            try
            {
                return _logic.login(identity, userrole, password);
            }
            catch (Exception)
            {

                throw;
            }
            
        }
        [HttpGet("username/securityquestion/securityanswer")]
        public string GetPassword(string username, string securityquestion, string securityanswer)
        {
            try
            {
                return _logic.getpwd(username,securityquestion,securityanswer);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
