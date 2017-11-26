using System.Collections.Generic;

using Mayope.Core;

namespace Mayope.Data
{
    public interface IDataService
    {
        void Create(ITree tree);
        void Drop(ITree tree);
        IList<IData> Select(ITree tree, IQuery query);
        void Insert(ITree tree, IData data);
        void Update(ITree tree, IData data);
        void Delete(ITree tree, IData data);
    }
}
