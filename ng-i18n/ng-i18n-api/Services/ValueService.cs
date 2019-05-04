using System;
using System.Threading;

namespace ng_i18n_api.Services
{
    public class ValueService
    {
        private int _next = 0;

        public int Get()
        {
            Interlocked.Increment(ref _next);
            return _next;
        }
    }
}