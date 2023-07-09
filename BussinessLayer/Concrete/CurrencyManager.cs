using BussinessLayer.Absract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Concrete
{
    public class CurrencyManager : ICurrencyService
    {
        private readonly ICurrencyDal _currencyDal;

        public CurrencyManager(ICurrencyDal currencyDal)
        {
            _currencyDal = currencyDal;
        }
        public void TDelete(Currency t)
        {
            _currencyDal.Delete(t);
        }

        public Currency TGetByID(int id)
        {
          return  _currencyDal.GetByID(id);
        }

        public List<Currency> TGetList()
        {
            return _currencyDal.GetList();
        }

        public void TInsert(Currency t)
        {
            _currencyDal.Insert(t);
        }

        public void TUpdate(Currency t)
        {
            _currencyDal.Update(t);
        }
    }
}
