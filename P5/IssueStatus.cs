using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class IssueStatus
    {
        public const string
            OPEN = "Open",
            ASSIGNED = "Assigned",
            FIXED = "Fixed",
            CLOSED_WF = "Closed - Won't fix",
            CLOSED_F = "Closed - Fixed",
            CLOSED_BD = "Closed - by design";

        public int Id { get; set; }
        public string Value { get; set; }
    }
}
