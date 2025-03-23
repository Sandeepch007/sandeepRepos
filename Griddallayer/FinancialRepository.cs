
using property;

namespace Griddallayer
{
    public class FinancialRepository
    {
       private readonly GridDbContext _context;
        public FinancialRepository(GridDbContext context)
        {
            _context = context;
        }
        public List<FinancialData> GetFinancialdata()
        {
            List<FinancialData> financialDatas = new List<FinancialData>();
            try
            {
                financialDatas=_context.financialdata.ToList();


            }
            catch (Exception)
            {

                throw;
            }
            return financialDatas;
        }

    }
}
