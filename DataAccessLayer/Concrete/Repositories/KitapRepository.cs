using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    class KitapRepository : IKitapDal
    {
        Context c = new Context();
        DbSet<Kitap> _object;
        public void Delete(Kitap p)
        {
            _object.Remove(p);
            c.SaveChanges();
        }

        public Kitap Get(Expression<Func<Kitap, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Insert(Kitap p)
        {
            _object.Add(p);
            c.SaveChanges();
        }

        public List<Kitap> List()
        {
            return _object.ToList();
        }

        public List<Kitap> List(Expression<Func<Kitap, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Kitap p)
        {
            
            c.SaveChanges();
        }
    }
}
