using Business.Entities;
using Business.Services.Contracts;
using Data.Core.Infrastructures;
using System.Linq;

namespace Business.Services
{
    public class ArticleService : IArticleService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IArticleRepository _articleRepository;

        public ArticleService(IUnitOfWork unitOfWork, IArticleRepository articleRepository)
        {
            _unitOfWork = unitOfWork;
            _articleRepository = articleRepository;
        }
        public void Add(Article article)
        {
            _articleRepository.Add(article);
            _unitOfWork.Commit();
        }

        public void Update(Article article)
        {
            _articleRepository.Update(article);
            _unitOfWork.Commit();
        }

        public void Delete(Article article)
        {
            _articleRepository.Delete(article);
            _unitOfWork.Commit();
        }

        public Article GetById(int id)
        {
            return _articleRepository.GetById(id);
        }

        public Article[] GetAll()
        {
            return _articleRepository.GetAll().ToArray();
        }
    }
}
