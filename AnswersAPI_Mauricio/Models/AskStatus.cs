using System;
using System.Collections.Generic;

namespace AnswersAPI_Mauricio.Models
{
    public partial class AskStatus
    {
        public AskStatus()
        {
            Asks = new HashSet<Ask>();
        }

        public int AskStatusId { get; set; }
        public string AskStatus1 { get; set; }

        public virtual ICollection<Ask> Asks { get; set; }
    }
}
