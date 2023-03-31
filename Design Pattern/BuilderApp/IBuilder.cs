using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderApp {
    internal interface IBuilder<TEntity> {
        TEntity Build();
    }
}
