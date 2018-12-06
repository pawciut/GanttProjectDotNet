using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GanttProjecttDotNet.Tests.Utils
{
    public class BaseBuilder<T>
        where T : class, new()
    {
        protected T instance;

        public BaseBuilder()
        {
            instance = new T();
        }

       public T Build()
        {
            return instance;
        }

    }
}
