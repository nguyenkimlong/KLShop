using KL.Data.Infrastructure;
using KL.Data.Repositories;
using KLShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KL.Service
{
    interface IProductService
    {
        void Add(Product post);

        void Update(Product post);

        void Delete(int id);

        IEnumerable<Product> GetAll();

        IEnumerable<Product> GetAllPaging(int page, int pageSize, out int totalRow);

        IEnumerable<Product> GetAllByCategoryPaging(int CategoryId, int page, int pageSize, out int totalRow);

        Product GetByID(int id);

        IEnumerable<Product> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow);

        void SaveChanges();
    }
    public class ProductService : IProductService
    {
        private IProductRepository _productRepository;
        private IUnitOfWork _unitOfWork;

        public ProductService(IProductRepository productRepository, IUnitOfWork unitOfWork)
        {
            _productRepository = productRepository;
            _unitOfWork = unitOfWork;
        }

        public void Add(Product post)
        {
            _productRepository.Add(post);
        }

        public void Delete(int id)
        {
            _productRepository.Delete(id);
        }

        public IEnumerable<Product> GetAll()
        {
            return _productRepository.GetAll();
        }

        public IEnumerable<Product> GetAllByCategoryPaging(int CategoryId, int page, int pageSize, out int totalRow)
        {
            return _productRepository.GetMultiPaging(x=>x.CategoryID==CategoryId ,out totalRow,page,pageSize,new string[] { "ProductCategory" });
        }

        public IEnumerable<Product> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow)
        {
            return _productRepository.GetAllByTag(tag, page, pageSize, out totalRow);
        }

        public IEnumerable<Product> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _productRepository.GetMultiPaging(null, out totalRow, page, pageSize);
        }

        public Product GetByID(int id)
        {
            return _productRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(Product post)
        {
            _productRepository.Update(post);
        }
    }
}
