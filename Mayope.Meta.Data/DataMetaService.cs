using System;
using System.Collections.Generic;

using Microsoft.Extensions.Logging;

using Mayope.Core;
using Mayope.Data;

namespace Mayope.Meta.Data
{
    public class DataMetaService : IMetaService
    {
        private IDataService DataService { get; }
        private ILogger Logger { get; }

        public DataMetaService(
            IDataService dataService,
            ILogger<DataMetaService> logger)
        {
            DataService = dataService;
            Logger = logger;
        }

        public IList<IForest> GetRootForests()
        {
            throw new NotImplementedException();
        }

        public IList<IForest> GetChildForests(Guid parent)
        {
            throw new NotImplementedException();
        }

        public IList<ITree> GetTrees(Guid forest)
        {

            throw new NotImplementedException();
        }

        public IList<IBranch> GetBranches(Guid tree)
        {
            throw new NotImplementedException();
        }
    }
}
