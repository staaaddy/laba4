using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace task1
{
    public abstract class PropManager
    {
        public virtual void Show(params object[] values) {
            foreach (object type in values) {
                Debug.Print($"{type.GetType()} - {type}");
            }
        }
    }
}