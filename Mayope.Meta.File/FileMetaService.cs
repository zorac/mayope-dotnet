﻿using System;
using System.Collections.Generic;

using Microsoft.Extensions.Logging;

using Mayope.Core;

namespace Mayope.Meta.File
{
    public class FileMetaService : IMetaService
    {
        private ILogger Logger { get; }

        public FileMetaService(
            FileMetaConfig config,
            ILogger<FileMetaService> logger)
        {
            Logger = logger;
        }

        public IList<IForest> GetRootForests()
        {
            return new List<IForest>();
        }

        public IList<IForest> GetChildForests(Guid parent)
        {
            return new List<IForest>();
        }

        public IList<ITree> GetTrees(Guid forest)
        {

            return new List<ITree>();
        }

        public IList<IBranch> GetBranches(Guid tree)
        {
            return new List<IBranch>();
        }
    }
}
