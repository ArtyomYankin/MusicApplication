using MA_Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MA_Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly ApplicationContext _context;
        private readonly DbSet<T> _entity;

        public Repository(ApplicationContext context)
        {
            _context = context;
            _entity = _context.Set<T>();
        }

        public void Add(T entities)
        {
            _entity.Add(entities);
            _context.SaveChanges();
        }

        public void AddAll(IEnumerable<T> entities)
        {
            try
            {
                _entity.AddRange(entities);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            _context.SaveChanges(); 
        }

        public T Get(int id)
        {
            return _entity.SingleOrDefault(x => x.Id == id);
        }

        public IEnumerable<T> GetAll()
        {
            return _entity.AsEnumerable();
        }
    }
}
