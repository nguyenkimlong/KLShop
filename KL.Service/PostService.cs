using KL.Data.Infrastructure;
using KL.Data.Repositories;
using KLShop.Model.Models;
using System.Collections.Generic;

namespace KL.Service
{
    #region

    public interface IPostService
    {
        void Add(Post post);

        void Update(Post post);

        void Delete(int id);

        IEnumerable<Post> GetAll();

        IEnumerable<Post> GetAllPaging(int page, int pageSize, out int totalRow);

        IEnumerable<Post> GetAllByCategoryPaging(int CategoryId, int page, int pageSize, out int totalRow);

        Post GetByID(int id);

        IEnumerable<Post> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow);

        void SaveChanges();
    }

    public class PosService : IPostService
    {
        private IPostRepository _postRepository;
        private IUnitOfWork _unitOfWork;

        /// <summary>
        /// Cách khởi tạo Repository và UoW là cơ chế "DI" =>SOLID
        /// Tim 2 đối tượng để khởi tạo
        /// Cơ chế DI
        /// </summary>
        /// <param name="postRepository"></param>
        /// <param name="unitOfWork"></param>
        public PosService(IPostRepository postRepository, IUnitOfWork unitOfWork)
        {
            this._postRepository = postRepository;
            this._unitOfWork = unitOfWork;
        }

        void IPostService.Add(Post post)
        {
            _postRepository.Add(post);
        }

        void IPostService.Delete(int id)
        {
            _postRepository.Delete(id);
        }

        IEnumerable<Post> IPostService.GetAll()
        {
            return _postRepository.GetAll(new string[] { "PostCategory" });
        }

        IEnumerable<Post> IPostService.GetAllByCategoryPaging(int CategoryId, int page, int pageSize, out int totalRow)
        {
            return _postRepository.GetMultiPaging(x => x.Status == true && x.CategoryID == CategoryId, out totalRow, page, pageSize, new string[] { "PostCategory" });
        }

        IEnumerable<Post> IPostService.GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow)
        {
            return _postRepository.GetAllByTag(tag, page, pageSize, out totalRow);
        }

        IEnumerable<Post> IPostService.GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _postRepository.GetMultiPaging(x => x.Status == true, out totalRow, page, pageSize);
        }

        Post IPostService.GetByID(int id)
        {
            return _postRepository.GetSingleById(id);
        }

        void IPostService.SaveChanges()
        {
            _unitOfWork.Commit();
        }

        void IPostService.Update(Post post)
        {
            _postRepository.Update(post);
        }
    }

    #endregion
}