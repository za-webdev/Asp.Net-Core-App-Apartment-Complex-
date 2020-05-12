using System;
using System.Collections.Generic;

namespace DemoCoreApp.Models
{
    public class MessageViewModel
    {
        //public string RequestId { get; set; }

        //public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
        public List<string> Errors { get; set; }

        public List<string> Success { get; set; }
    }
}