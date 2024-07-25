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
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productdal;

        public ProductManager(IProductDal productDal)
        {
            _productdal = productDal;
        }

        public void TDelete(int id)
        {
            _productdal.Delete(id);
        }

        public List<Product> TGetAll()
        {
            return _productdal.GetAll();
        }

        public Product TGetById(int id)
        {
            return _productdal.GetById(id);
        }

        public void TInsert(Product entity)
        {
            _productdal.Insert(entity);
        }

        public void TUpdate(Product entity)
        {
            _productdal.Update(entity);
        }
    }
}
