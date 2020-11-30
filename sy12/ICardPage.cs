using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csy
{
    interface ICardPage
    {
        string Code { get; set; }
        string Name { get; set; }
        string Balance { get; set; }

    }
}
