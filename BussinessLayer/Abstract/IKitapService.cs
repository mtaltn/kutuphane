using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Abstract
{
    public interface IKitapService
    {
        List<Kitap> GetList();
        void KitapAdd(Kitap kitap);

        Kitap GetByID(int id);
        void KitapDelete(Kitap kitap);
        void KitapEdit(Kitap kitap);
    }
}
