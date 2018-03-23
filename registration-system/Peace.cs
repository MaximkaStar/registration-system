using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace registration_system
{
    public class Peace
    {
        public int Id { get; set; }
        public TypeOfPeace Type { get; set; }
        public string Name { get; set; }
        public string Ammout { get; set; }

        public override string ToString()
        {
            return String.Format("{0}  Ammout - {1}  Name - {2}", Type, Ammout, Name);
        }
    }
}
