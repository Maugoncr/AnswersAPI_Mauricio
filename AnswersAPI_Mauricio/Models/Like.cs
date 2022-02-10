using System;
using System.Collections.Generic;

namespace AnswersAPI_Mauricio.Models
{
    public partial class Like
    {
        public long LikeId { get; set; }
        public int UserId { get; set; }
        public long AnswerId { get; set; }

        public virtual Answer Answer { get; set; }
        public virtual User User { get; set; }
    }
}
