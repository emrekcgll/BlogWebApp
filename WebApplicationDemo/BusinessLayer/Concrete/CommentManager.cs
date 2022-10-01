using BusinessLayer.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CommentManager : ICommentService
    {
        ICommentDal _commentDal;
        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public Comment GetById(int id)
        {
            return _commentDal.TGetById(id); ///////////////////////
        }

        public void CommentAdd(Comment comment)
        {
            _commentDal.Insert(comment);
        }


        public List<Comment> GetCommentWithBlog()
        {
            return _commentDal.GetCommentListWithBlog();
        }

        public List<Comment> GetList(int id)
        {
            return _commentDal.GetListAll(x => x.BlogId == id);
        }

        public void TAdd(Comment t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Comment t)
        {
            _commentDal.Delete(t);
        }

        public void TUpdate(Comment t)
        {
            throw new NotImplementedException();
        }

        public List<Comment> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
