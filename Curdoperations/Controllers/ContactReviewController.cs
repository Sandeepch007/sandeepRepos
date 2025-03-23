using communityBal;
using communitymodels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Curdoperations.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactReviewController : ControllerBase
    {
        private readonly ContactreviewBlogic _creviewlog;
        public ContactReviewController(AppDbContext context)
        {
            _creviewlog = new ContactreviewBlogic(new communityDal.ContactreviewRepository(context));
        }
        [HttpGet("GetAllContacts")]
        public List<Contact> Getallcontactrev()
        {
            try
            {
                List<Contact> conts = _creviewlog.getreviews();

                return conts;
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpPost("postcontact")]
        public string Post(Contact cont)
        {
            bool isregister = false;
            string strmsg = string.Empty;
            try
            {
                isregister = _creviewlog.contactss(cont);
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

    }
}
