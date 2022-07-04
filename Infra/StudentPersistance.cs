using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra
{
    class StudentPersistance
    {
        private static int _id = 0;
        public int Id { get; }
        public string Name { get; set; }

        public StudentPersistance()
        {
            _id = _id + 1;
        }
    }
}
