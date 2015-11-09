using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSandBox.Classes
{
    class EmailData
    {
        public class MassEmail
        {
            public string Id { get; set; }
            public string Subject { get; set; }
            public string SecurityLevel { get; set; }
            
        }

        public class MassEmails
        {
            public List<MassEmail> MassEmail { get; set; }
        }

        public class RootObject
        {
            public MassEmails MassEmails { get; set; }
        }
    }
}
