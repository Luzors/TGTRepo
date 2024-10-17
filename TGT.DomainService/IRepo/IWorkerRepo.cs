using Core.Domain.Entities;

namespace TGT.DomainService.IRepo
{
    public interface IWorkerRepo
    {
        IEnumerable<Worker> GetAllWorkers();
        Task<Worker?> GetWorker(int id);
        Task<Worker> AddWorker(Worker worker);
    }
}
