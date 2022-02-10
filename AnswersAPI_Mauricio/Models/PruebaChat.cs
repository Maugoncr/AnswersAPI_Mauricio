using System;
using System.Collections.Generic;

namespace AnswersAPI_Mauricio.Models
{
    public partial class PruebaChat
    {
        public int SenderId { get; set; }
        public string UserName { get; set; }
        public int ReceiverId { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
        public string UserRole { get; set; }
    }
}
