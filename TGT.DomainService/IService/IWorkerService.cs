using Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TGT.DomainService.IService
{
    public interface IWorkerService
    {
        IEnumerable<Worker> GetWorkers();
        Task<Worker> GetWorkerById(int id);
        Task<Worker> CreateWorker(Worker worker);
    }
}
