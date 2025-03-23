using System.Security.AccessControl;
using HModels;

namespace HDal
{
    public class HospitalRepository
    {
        private readonly HospitalDbContext _context;
        public HospitalRepository(HospitalDbContext context)
        {
            _context = context;
        }
        public List<SecurityQuestion> GetQuestions()
        {
            List<SecurityQuestion> list = new List<SecurityQuestion>();
            try
            {
                list=_context.SecurityQuestions.ToList();
            }
            catch (Exception)
            {

                throw;
            }
            return list;
        }

        public string Registerpost(Register reg)
        {

            try
            {
                _context.Registers.Add(reg);
                _context.SaveChanges();
                return reg.RegId;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public Register Loginget(string identity,string userrole,string password)
        {

            try
            {

                Register reg = new Register();
                reg = _context.Registers.Where(u => u.Username == identity || u.Email==identity ||u.RegId==identity &&
u.Password == password && u.UserRole==userrole).FirstOrDefault();
                return reg;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public string Forgotpwd(string username,string securityquestion,string securityanswer)
        {
            
            try
            {
                var pwd = (from Register in _context.Registers
                           join question in _context.SecurityQuestions
                           on Register.SecId equals question.securityQuestion
                           where Register.Username == username
                                 && Register.SecurityAnswer == securityanswer
                                 && Register.SecId == securityquestion
                           select Register.Password).FirstOrDefault();

                
                return pwd ?? "Password not found";
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
