using HDal;
using HModels;

namespace HBal
{
    public class HospitalLogic
    {
        private readonly HospitalRepository _repo;
        public HospitalLogic(HospitalRepository repo)
        {
            _repo = repo;
        }
        public List<SecurityQuestion> getques()
        {
            try
            {
                return _repo.GetQuestions();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public Register login(string identity, string userrole, string password)
        {
            try
            {
                return _repo.Loginget(identity, userrole, password);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public string register(Register reg)
        {
            
            try
            {
                return _repo.Registerpost(reg);

            }
            catch (Exception)
            {

                throw;
            }
        }
        public string getpwd(string username, string securityquestion, string securityanswer)
        {
            string msg = string.Empty;
            try
            {
                msg= _repo.Forgotpwd(username, securityquestion, securityanswer);
            }
            catch (Exception)
            {

                throw;
            }
            return msg;
        }

    }
}
