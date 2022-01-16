using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheDigitalClock_WPF.MVVM.Models
{
    public abstract class DisposableObject : IDisposable
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
