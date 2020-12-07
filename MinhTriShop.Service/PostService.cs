using MinhTriShop.Data.Infrastructure;
using MinhTriShop.Data.Repositories;
using MinhTriShop.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhTriShop.Service
{
    //nguyên lý solid: dependency inversion:
    
    public interface IPostService
    {
        void Add(Post post);

        void Update(Post post);

        void Delete(int id);

        IEnumerable<Post> GetAll();

        IEnumerable<Post> GetAllPaging( int page, int pageSize, out int totalRow);

        Post GetById(int id);

        IEnumerable<Post> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow);

        void SaveChange();

    }
    public class PostService : IPostService  //PostService implement  interface
    {
        //trong .net biến của class khác khai báo có dấu gạch dưới, biến nội bộ của class đang xét thì ko
        IPostRepository _postRepository;
        IUnitOfWork _unitOfWork;

        public PostService(IPostRepository postRepository, IUnitOfWork unitOfWork)
        {
            this._postRepository = postRepository;
            this._unitOfWork = unitOfWork;
            
        }

        public void Add(Post post)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            _postRepository.Delete(id);
        }

        //post thuộc postcategory
        //muốn lấy ra dc post category => new string[] { "PostCategory" });
        public IEnumerable<Post> GetAll()
        {
            return _postRepository.GetAll(new string[] { "PostCategory" });  
        }

        public IEnumerable<Post> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow)
        {
            return _postRepository.GetMultiPaging(x => x.Status, out totalRow, page, pageSize);
        }

        public IEnumerable<Post> GetAllPaging(int page, int pageSize, out int totalRow)
        {
            return _postRepository.GetMultiPaging(x => x.Status, out totalRow, page, pageSize);
        }

        public Post GetById(int id)
        {
            return _postRepository.GetSingleById(id);
        }

        public void SaveChange()
        {
            _unitOfWork.Commit();

        }

        public void Update(Post post)
        {
            _postRepository.Update(post);
        }
    }
}
