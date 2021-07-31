using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloRefit.Concreate
{
    public class DataResponse<T>
    {
        public string Status { get; set; }
        public int Code { get; set; }
        public int Total { get; set; }
        public T Data { get; set; }
    }
}
