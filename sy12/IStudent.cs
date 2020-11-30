using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csy
{
    public interface IStudent
    {
        string StuCode { get; set; }
        string StuName { get; set; }
        string GetInfo();

    }
}
