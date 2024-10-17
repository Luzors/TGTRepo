using Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TGT.DomainService.IRepo;
using TGT.DomainService.IService;

namespace TGT.DomainService.Service
{
    public class WorkerService : IWorkerService
    {
        private readonly IWorkerRepo _workerRepo;

        public WorkerService(IWorkerRepo workerRepository)
        {
            _workerRepo = workerRepository;
        }
        public IEnumerable<Worker> GetWorkers()
        {
            return _workerRepo.GetAllWorkers();
        }

        public async Task<Worker> GetWorkerById(int id)
        {
            var worker = await _workerRepo.GetWorker(id);

            if (worker == null)
                throw new Exception("Deze worker bestaat niet!");

            return worker;
        }
        public async Task<Worker> CreateWorker(Worker worker)
        {
            try
            {
                return await _workerRepo.AddWorker(worker);
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }
    }
}
