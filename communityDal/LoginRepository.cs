using communitymodels;
using Microsoft.EntityFrameworkCore;

namespace communityDal
{
    public class LoginRepository
    {
        private AppDbContext _context;
        public LoginRepository(AppDbContext context)
        {
            _context = context;
        }
        public List<SecurityQuestions> GetAllQuestions()
        {
            List<SecurityQuestions> _questions = new List<SecurityQuestions>();
            try
            {
                _questions = _context.SecurityQuestions.ToList();
                return _questions;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool Registration(Login login)
        {
            bool res = false;
            try
            {
                _context.Logins.Add(login);
                _context.SaveChanges();
                res = true;
            }
            catch (Exception) 
            {
                res=false;
                throw;
            }
            return res;
        }

        public Login GetUserDetails(string username, string password)
        {
            try
            {
                Login login = new Login();
                login = _context.Logins.Where(u => u.Username == username && u.Password == password).FirstOrDefault();
                return login;
            }
            catch(Exception ex)
            {
                throw;
            }

        }

        public bool userexists(string username)
        {
            try
            {
                bool isexists = false;
                var objuser = _context.Logins.Where(u => u.Username == username).Select(u => u.Username);
                if (objuser != null) 
                {
                    isexists = true;
                }
                return isexists;

            }
            catch (Exception)
            {

                throw;
            }
        }

       
        public string forgotpwd(string username,string secanswer,string secquestion)
        {
            
            
            try
            {
                var pwd = (from login in _context.Logins
                           join question in _context.SecurityQuestions
                           on login.Questionid equals question.Questionid
                           where login.Username == username
                                 && login.Secanswer == secanswer
                                 && question.Secquestion == secquestion
                           select login.Password).FirstOrDefault();

                // Return the password if found, else return a message
                return pwd ?? "Password not found";
            }
            catch (Exception ex)
            {
                // Log and handle the exception as needed
                throw new Exception("An error occurred while retrieving the password.", ex);
            }
           
        }


    }
}
