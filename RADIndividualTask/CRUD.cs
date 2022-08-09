using Microsoft.EntityFrameworkCore;
using RADIndividualTask.Models1;

namespace RADIndividualTask
{
    public static class CRUD
    {
        public static PostgresContext Context { get; set; }
        
        public static void Add<T>(this DbSet<T> set, T item) where T: BaseModel
        {
            set.Add(item);
            Context.SaveChanges();
        }
        
        // public static void Update<T>(this DbSet<T> set, T item) where T: BaseModel
        // {
        //     
        //     var entity = set.Find(item.Id);
        //     Context.Entry(entity).CurrentValues.SetValues(item);
        //     Context.SaveChanges();
        //     
        // }
        
        public static void Remove<T>(this DbSet<T> set, T item) where T: BaseModel
        {
            set.Remove(item);
            Context.SaveChanges();
        }
    }
}