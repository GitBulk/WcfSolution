using Business.Entities;
using System.ServiceModel;

namespace Business.Services.Contracts
{
    [ServiceContract]
    public interface IArticleService
    {
        [OperationContract]
        void Add(Article article);

        [OperationContract]
        void Update(Article article);

        [OperationContract]
        void Delete(Article article);

        [OperationContract]
        Article GetById(int id);

        [OperationContract]
        Article[] GetAll();
    }
}
