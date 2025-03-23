using communityBal;
using communitymodels;
using communityDal;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;

namespace Curdoperations.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly LoginBal _loginBalobj;
        public LoginController(AppDbContext context)
        {
            _loginBalobj = new LoginBal(new communityDal.LoginRepository(context));
        }
        [HttpGet("GetAllQuestions")]
        public List<SecurityQuestions> GetQuestion()
        {
            try
            {
                List<SecurityQuestions> finalquestion=_loginBalobj.GetQuestions();

                return finalquestion;
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpPost("registration")]
        public string Post(Login login)
        {
            bool isregister=false;
            string strmsg = string.Empty;
            try
            {
                isregister = _loginBalobj.Registration(login);
                if (isregister)
                {
                    strmsg = "registration successfully";
                }
                else
                {
                    strmsg = "registration is failed please try again!";
                }
            }
            catch (Exception)
            {
                throw;
            }
            return strmsg;
        }
        [HttpGet("GetUserDetails/username/pwd")]
        public Login Getuser(string username, string password)
        {
            try
            {
                return _loginBalobj.GetUser(username, password);
            }
            catch (Exception
            )
            {
                throw;
            }
        }

        [HttpGet("isuserexist/username")]
        public bool isuserexisted(string username)
        {
            try
            {
                return _loginBalobj.isuserexists(username);

            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpGet("Getpassword/username/answer/question")]
        public string Getpassword(string username,string answer,string question) 
        {
            
            
            try
            {
               return _loginBalobj.getpwd(username, answer, question);
                
            }
            catch (Exception)
            {

                throw;
            }
           
        }
        
        
    }
}
