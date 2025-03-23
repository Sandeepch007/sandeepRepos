using communityDal;
using communitymodels;

namespace communityBal
{
    public class LoginBal
    {
        private readonly LoginRepository _repo;
        public LoginBal(LoginRepository repo)
        {
            _repo = repo;
        }
        public List<SecurityQuestions> GetQuestions()
        {

            try
            {
                List<SecurityQuestions> questions = new List<SecurityQuestions>();
                questions = _repo.GetAllQuestions();
                return questions;

            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool Registration(Login login)
        {
            try
            {
                return _repo.Registration(login);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Login GetUser(string username, string password)
        {
            
            try
            {
                return _repo.GetUserDetails(username, password);
            }
            catch (Exception)
            {
                throw;
            }
            
        }
        public bool isuserexists(string username)
        {
            try
            {
                return _repo.userexists(username);

            }
            catch (Exception) { throw; }
        }


        public string getpwd(string uname, string answer, string question)
        {
            string pwd = string.Empty;
            try
            {
                pwd=_repo.forgotpwd(uname, answer, question);
            }
            catch (Exception)
            {

                throw;
            }
            return pwd;
        }
    }
}
