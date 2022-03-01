using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;
using DataAccessLayer.Concrete.Repositories;
using BussinessLayer.Abstract;
using DataAccessLayer.Abstract;

namespace BussinessLayer.Concrete
{
    public class KitapManager : IKitapService
    {
        IKitapDal _kitapdal;

        public KitapManager(IKitapDal kitapdal)
        {
            _kitapdal = kitapdal;
        }

        public Kitap GetByID(int id)
        {
            return _kitapdal.Get(x => x.Id == id);
        }

        public List<Kitap> GetList()
        {
            return _kitapdal.List();
        }

        public void KitapAdd(Kitap kitap)
        {
            _kitapdal.Insert(kitap);

        }

        public void KitapDelete(Kitap kitap)
        {
            _kitapdal.Delete(kitap);
        }

        public void KitapEdit(Kitap kitap)
        {
            _kitapdal.Update(kitap);
        }
    }
}
