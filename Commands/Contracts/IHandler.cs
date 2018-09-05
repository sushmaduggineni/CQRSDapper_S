using CQRSWithDapper.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSWithDapper.Commands.Contracts
{
    public interface IHandler<in T> where T : IMessage
    {        
        Task Handle(T message);
    }
}
