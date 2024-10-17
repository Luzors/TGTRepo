using Core.Domain.Entities;
using TGT.Infrastructure.EF.DBContext;
using Microsoft.EntityFrameworkCore;

namespace TGT.Infrastructure.EF.Repo
{
    public class WorkerRepo
    {
        private readonly DataBaseContext _context;
        public WorkerRepo(DataBaseContext context)
        {
            _context = context;
        }

        public IEnumerable<Worker> GetAllWorkers()
        {
            return _context.Workers;
        }
        public async Task<Worker> AddWorker(Worker worker)
        {
            _context.Workers.Add(worker);
            await _context.SaveChangesAsync();
            return worker;
        }
        public async Task<Worker?> GetWorker(int id)
        {
            return await _context.Workers
                  .Include(p => p.Cantine)
                  .FirstOrDefaultAsync(p => p.Id.Equals(id));
        }
    }
}
