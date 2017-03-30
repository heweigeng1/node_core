using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace core_autofac.Service
{
    public class MsgService : IMsgService
    {
        public string Html()
        {
            return $"<label>tag</label>";
        }
    }
}
