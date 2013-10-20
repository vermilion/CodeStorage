using System.Linq;
using Db4objects.Db4o;
using Db4objects.Db4o.Config;
using Db4objects.Db4o.Linq;

namespace Model
{
    public class Repository : IRepository
    {
        public IEmbeddedObjectContainer Container;

        public Repository(string storagePath)
        {
            Container = Db4oEmbedded.OpenFile(Db4oEmbedded.NewConfiguration(), storagePath);
        }
        public Repository(string storagePath, int activationDepth, int updateDepth)
        {
            IEmbeddedConfiguration configuration = Db4oEmbedded.NewConfiguration();
            configuration.Common.ActivationDepth = activationDepth;
            configuration.Common.UpdateDepth = updateDepth;
            Container = Db4oEmbedded.OpenFile(configuration, storagePath);
        }

        public void Activate(object obj, int depth)
        {
            Container.Activate(obj, depth);
        }


        public IQueryable<T> GetAll<T>()
        {
            return Container.AsQueryable<T>();
        }

        public void Save<T>(T entity)
        {
            Container.Store(entity);
        }

        public void Delete<T>(T entity)
        {
            Container.Delete(entity);
        }
    }
}