using KLShop.Model.Models;
using System.Collections.Generic;
using KL.Data.Repositories;
using KL.Data.Infrastructure;
using System;

namespace KL.Service
{
    public interface IPostCategoryService
    {
        PostCategory Add(PostCategory postCategory);
        void Update(PostCategory postCategory);
        PostCategory Delete(int id);
        IEnumerable<PostCategory> GetAll();

        IEnumerable<PostCategory> GetAllByParendID(int parentid);

        PostCategory GetByID(int id);
        void Save();
    }
    public class PostCategoryService : IPostCategoryService
    {
        IPostCategoryRepository _postCategoryRepository;
        IUnitOfWork _unitOfWork;
        public PostCategoryService(IPostCategoryRepository postCategoryRepository, IUnitOfWork unitOfWork)
        {
            this._postCategoryRepository = postCategoryRepository;
            this._unitOfWork = unitOfWork;
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }

        public PostCategory Add(PostCategory postCategory)
        {
            return _postCategoryRepository.Add(postCategory);
        }

        PostCategory IPostCategoryService.Delete(int id)
        {
          return  _postCategoryRepository.Delete(id);
        }

        IEnumerable<PostCategory> IPostCategoryService.GetAll()
        {
            return _postCategoryRepository.GetAll();
        }

        IEnumerable<PostCategory> IPostCategoryService.GetAllByParendID(int parentid)
        {
            return _postCategoryRepository.GetMulti(x => x.Status == true && x.ParentID == parentid);
        }

        PostCategory IPostCategoryService.GetByID(int id)
        {
            return _postCategoryRepository.GetSingleById(id);
        }

        public void Update(PostCategory postCategory)
        {
             _postCategoryRepository.Update(postCategory);
        }
    }
}