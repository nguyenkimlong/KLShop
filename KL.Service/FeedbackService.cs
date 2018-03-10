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
    internal interface IFeedbackService
    {
        Feedback Add(Feedback Feedback);

        void Update(Feedback Feedback);

        Feedback Delete(int id);

        IEnumerable<Feedback> GetAll();

        Feedback GetByID(int id);

        void Save();
    }

    public class FeedbackService : IFeedbackService
    {
        private IFeedbackRepository _FeedbackRepository;
        private IUnitOfWork _unitOfWork;

        public FeedbackService(IFeedbackRepository FeedbackRepository, IUnitOfWork unitOfWork)
        {
            _FeedbackRepository = FeedbackRepository;
            _unitOfWork = unitOfWork;
        }

        public Feedback Add(Feedback Feedback)
        {
            return  _FeedbackRepository.Add(Feedback);
        }

        public Feedback Delete(int id)
        {
            return _FeedbackRepository.Delete(id);
        }

        public IEnumerable<Feedback> GetAll()
        {
            return _FeedbackRepository.GetAll();
        }       

        public Feedback GetByID(int id)
        {
            return _FeedbackRepository.GetSingleById(id);
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }

        public void Update(Feedback Feedback)
        {
            _FeedbackRepository.Update(Feedback);
        }
    }
}