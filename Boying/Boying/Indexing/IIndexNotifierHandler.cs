using Boying.Events;

namespace Boying.Indexing
{
    public interface IIndexNotifierHandler : IEventHandler
    {
        void UpdateIndex(string indexName);
    }
}