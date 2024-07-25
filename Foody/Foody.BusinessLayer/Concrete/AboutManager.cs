using Foody.BusinessLayer.Abstrack;
using Foody.DataAccessLayer.Abstract;
using Foody.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.BusinessLayer.Concrete
{
    public class AboutManager : IAbaoutService
    {
        private readonly IAbaoutDal _abaoutDal;

        public AboutManager(IAbaoutDal abaoutDal)
        {
            _abaoutDal = abaoutDal;
        }

        public void TDelete(int id)
        {
            _abaoutDal.Delete(id);
        }

        public List<About> TGetAll()
        {
            return _abaoutDal.GetAll();
        }

        public About TGetById(int id)
        {
            return _abaoutDal.GetById(id);
        }

        public void TInsert(About entity)
        {
            _abaoutDal.Insert(entity);
        }

        public void TUpdate(About entity)
        {
            _abaoutDal.Update(entity); 
        }
    }
}
