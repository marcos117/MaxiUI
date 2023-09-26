using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxiUI.Mappers
{
    public class Beneficiary
    {
        public string Name { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; } = DateTime.MaxValue;
        public string Curp { get; set; } = string.Empty;
        public int Ssn { get; set; }
        public string Phone { get; set; } = string.Empty;
        public string Nationality { get; set; } = string.Empty;
        public int ParticipationPercentage { get; set; }
    }
}
