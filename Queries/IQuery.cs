using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSWithDapper.Queries
{
    public interface IQuery<out T> where T: class
    {
        T Execute();
    }    
}
