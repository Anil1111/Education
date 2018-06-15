using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Race.Game
{
    class EngineIsDeadException : Exception
    {
        public EngineIsDeadException () { }
        public EngineIsDeadException(string message) : base(message) { }
        public EngineIsDeadException(string message, Exception innerException) : base(message,innerException) { }
    }
}
