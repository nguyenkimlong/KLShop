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
    internal interface ISlideService
    {
        Slide Add(Slide slide);

        void Update(Slide slide);

        Slide Delete(int id);

        IEnumerable<Slide> GetAll();

        Slide GetByID(int id);

        void Save();
    }

    public class SlideService : ISlideService
    {
        private ISlideRepository _slideRepository;
        private IUnitOfWork _unitOfWork;

        public SlideService(ISlideRepository slideRepository, IUnitOfWork unitOfWork)
        {
            _slideRepository = slideRepository;
            _unitOfWork = unitOfWork;
        }

        public Slide Add(Slide slide)
        {
            return  _slideRepository.Add(slide);
        }

        public Slide Delete(int id)
        {
            return _slideRepository.Delete(id);
        }

        public IEnumerable<Slide> GetAll()
        {
            return _slideRepository.GetAll();
        }       

        public Slide GetByID(int id)
        {
            return _slideRepository.GetSingleById(id);
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }

        public void Update(Slide slide)
        {
            _slideRepository.Update(slide);
        }
    }
}