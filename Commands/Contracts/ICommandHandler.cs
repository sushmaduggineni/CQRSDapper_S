using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSWithDapper.Commands.Contracts
{
    public interface ICommandHandler<in T> : IHandler<T> where T : ICommand
    {
    }
}
