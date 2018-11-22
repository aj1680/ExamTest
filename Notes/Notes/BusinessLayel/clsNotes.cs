using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Notes.BusinessLayel
{
    public class clsNotes
    {
        public int Userid { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }

        public bool IsActive { get; set; }
        public string Mode { get; set; }
    }
}