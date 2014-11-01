using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Paritanssi.Models;

namespace Paritanssi.Logic {
    public interface IRepository<T> where T : IEntity {
        void Add(T entity);
        void Save();
    }
}