

using Griddallayer;
using property;

namespace GridBallayer
{
    public class FinancialLogic
    {
        private readonly FinancialRepository _repo;
        public FinancialLogic(FinancialRepository repo)
        {
            _repo = repo;
        }
        public List<FinancialData> getall()
        {
            List<FinancialData> fdata=new List<FinancialData>();
            try
            {
                fdata = _repo.GetFinancialdata();
            }
            catch (Exception)
            {

                throw;
            }
            return fdata;
        }

    }
}
