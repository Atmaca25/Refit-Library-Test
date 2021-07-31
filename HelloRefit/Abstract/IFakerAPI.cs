using HelloRefit.Concreate;
using HelloRefit.Entity;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloRefit.Abstract
{
    public interface IFakerAPI
    {
        [Get("/persons")]
        Task<DataResponse<List<Person>>> GetFakePerson();
        [Get("/persons?_quantity={quantity}")]
        Task<DataResponse<List<Person>>> GetFakePersonWithQuantity(int quantity);
    }
}
