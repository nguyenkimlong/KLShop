using KL.Data.Infrastructure;
using KL.Data.Repositories;
using KLShop.Model.Models;
using System;
using System.Collections.Generic;

namespace KL.Service
{
    /// <summary>
    /// Tạo interface cho ProductCatagory
    /// Tạo các phương thức
    /// </summary>
    internal interface IProductCatagoryService
    {
        ProductCategory Add(ProductCategory postCategory);

        void Update(ProductCategory postCategory);

        ProductCategory Delete(int id);

        IEnumerable<ProductCategory> GetAll();

        ProductCategory GetByID(int id);

        void Save();
    }

    public class ProductCatagoryService : IProductCatagoryService
    {
        private IProductCategoryRepository _productCategoryRepository;
        private IUnitOfWork _unitOfWork;

        public ProductCatagoryService(IProductCategoryRepository productCategoryRepository, IUnitOfWork unitOfWork)
        {
            _productCategoryRepository = productCategoryRepository;
            _unitOfWork = unitOfWork;
        }

        public ProductCategory Add(ProductCategory postCategory)
        {
            return  _productCategoryRepository.Add(postCategory);
        }

        public ProductCategory Delete(int id)
        {
            return _productCategoryRepository.Delete(id);
        }

        public IEnumerable<ProductCategory> GetAll()
        {
            return _productCategoryRepository.GetAll();
        }       

        public ProductCategory GetByID(int id)
        {
            return _productCategoryRepository.GetSingleById(id);
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }

        public void Update(ProductCategory postCategory)
        {
            _productCategoryRepository.Update(postCategory);
        }
    }
}