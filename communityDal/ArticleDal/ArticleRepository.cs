using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using communitymodels;
using communitymodels.Articlesmodel;

namespace communityDal.ArticleDal
{
    public class ArticleRepository
    {
        private readonly AppDbContext _context;
        public ArticleRepository(AppDbContext context)
        {
            _context = context;
        }
        public List<Articles> GetallArticles() 
        {
            List<Articles> articles = new List<Articles>();
            try
            {
                articles=(from art in _context.PostArticle join log in _context.Logins on art.LoginId equals
                     log.Loginid select(new Articles
                     {
                         ArticleId=art.ArticleId,
                         ArticleDescripstion=art.ArticleDescripstion,
                         ArticleType=art.ArticleType,
                         CurrentDate = art.CurrentDate,
                         LoginId =art.LoginId,
                         login = new Login
                         {
                             Username = log.Username,

                         }
                     })).ToList();
                return articles;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool postarticle(Articles article)
        {
            bool issave = false;
            try
            {
                article.CurrentDate = DateTime.Now.Date;
                _context.PostArticle.Add(article);
                _context.SaveChanges();
                issave=true;

            }
            catch (Exception)
            {

                throw;
            }
            return issave;
        }


        public bool updatearticle(Articles article)
        {
            bool isupdate = false;
            try
            {
                _context.PostArticle.Update(article);
                _context.SaveChanges();
                isupdate = true;

            }
            catch (Exception)
            {

                throw;
            }
            return isupdate;
        }

        public bool Deletearticle(int id)
        {
            bool isupdate = false;
            
            try
            {
                var articleid = _context.PostArticle.Find(id);
                if (articleid != null) 
                { 

                _context.PostArticle.Remove(articleid);
                _context.SaveChanges();
                isupdate = true;

                }
            }
            catch (Exception)
            {

                throw;
            }
            return isupdate;
        }
    }
}
