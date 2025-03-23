using communityBal.ArticlesBal;
using communitymodels;
using communitymodels.Articlesmodel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Curdoperations.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private readonly ArticlesBLogic _context;
        public ArticleController(AppDbContext context)
        {
            _context = new ArticlesBLogic(new communityDal.ArticleDal.ArticleRepository(context));
        }

        [HttpGet]
        public List<Articles> Getallarticles()
        {
            List<Articles> articles = new List<Articles>();
            try
            {
                articles = _context.GetArticle();
                return articles;
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost]
        public string PostArticle(Articles article)
        {
            bool result = false;
            string message = string.Empty;
            try
            {
                result = _context.postarticle(article);
                if (result)
                {
                    message = "record is inserted";
                }
                else
                {
                    message = "records are not inserted..";
                }

            }
            catch (Exception)
            {

                throw;
            }
            return message;
        }

        [HttpPut]
        public string updatearticles(Articles article)
        {
            bool isupdate = false;
            string message = string.Empty;
            try
            {
                isupdate = _context.updatearticle(article);
                if (isupdate)
                {
                    message = "Records are updated successfully...";
                }
                else
                {
                    message = "records are not updated..";
                }

            }
            catch (Exception)
            {

                throw;
            }
            return message;
        }

        [HttpDelete("{id}")]
        public string deleteArticle(int id)
        {
            bool isdelete = false;
            string message = string.Empty;
            try
            {
                isdelete = _context.deletearticle(id);
                if (isdelete)
                {
                    message = "record is deleted successfully..";
                }
                else
                {
                    message = "record not deleted!..";
                }

            }
            catch (Exception)
            {

                throw;
            }
            return message;
        }
    }
}
