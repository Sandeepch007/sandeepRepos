using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using communityDal.ArticleDal;
using communitymodels.Articlesmodel;

namespace communityBal.ArticlesBal
{
    public class ArticlesBLogic
    {
        private readonly ArticleRepository _articlerepo;
        public ArticlesBLogic(ArticleRepository article)
        {
            _articlerepo = article;
        }
        public List<Articles> GetArticle()
        {
              try
            {
                return _articlerepo.GetallArticles();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool postarticle(Articles art)
        {
            try
            {
                return _articlerepo.postarticle(art);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool updatearticle(Articles art)
        {
            try
            {
                return _articlerepo.updatearticle(art);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool deletearticle(int id)
        {
            try
            {
                return _articlerepo.Deletearticle(id);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
