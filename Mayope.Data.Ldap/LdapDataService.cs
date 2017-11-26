﻿using System;
using System.Collections.Generic;

using Microsoft.Extensions.Logging;

using Mayope.Core;

namespace Mayope.Data.Ldap
{
    public abstract class LdapDataService : IDataService
    {
        protected ILogger Logger { get; }

        protected LdapDataService(ILogger<LdapDataService> logger)
        {
            Logger = logger;
        }

        public void Create(ITree tree) {
            throw new NotImplementedException();
        }

        public void Drop(ITree tree) {
            throw new NotImplementedException();
        }

        public IList<IData> Select(ITree tree, IQuery query) {
            throw new NotImplementedException();
        }

        public void Insert(ITree tree, IData data) {
            throw new NotImplementedException();
        }

        public void Update(ITree tree, IData data) {
            throw new NotImplementedException();
        }

        public void Delete(ITree tree, IData data) {
            throw new NotImplementedException();
        }
    }
}
