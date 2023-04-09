using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    // generic constraint
    // class : referans tip olmak demek burda class değil
    // IEntity : IEntity olabilir veya IEntity ımplemente edebilen olabilir
    // new(); : newlenebilir demektir artık IEntity tekbaşına alamaz 
    public interface IEntityRepository<T> where T : class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null); // filterlere göre aramayı sağlar bu expression 
        T Get(Expression<Func<T,bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        List<T> GetAllByCategory(int categoryId);
    }
}
