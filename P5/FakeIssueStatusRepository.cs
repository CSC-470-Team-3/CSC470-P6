using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class FakeIssueStatusRepository : IIssueStatusRepository
    {
        private static List<IssueStatus> _IssueStatuses;

        public FakeIssueStatusRepository()
        {
            _IssueStatuses = new List<IssueStatus>();
            Add(1, IssueStatus.OPEN);
            Add(2, IssueStatus.ASSIGNED);
            Add(3, IssueStatus.FIXED);
            Add(4, IssueStatus.CLOSED_WF);
            Add(5, IssueStatus.CLOSED_F);
            Add(4, IssueStatus.CLOSED_BD);

        }
        public void Add(int Id, string value)
        {
            var ids = from i in _IssueStatuses select i.Id;
            _IssueStatuses.Add(new IssueStatus { Id = ids.Contains(Id) ? ids.Max() + 1 : Id, Value = value });
        }

        public List<IssueStatus> GetAll()
        {
            List<IssueStatus> issuesStatus = new List<IssueStatus>();
            foreach (IssueStatus issueStatus in _IssueStatuses)
                issuesStatus.Add(issueStatus);
            return issuesStatus;
        }

        public int GetIdByStatus(string value)
        {
            foreach (IssueStatus issueStatus in _IssueStatuses)
                if (issueStatus.Value == value)
                    return issueStatus.Id;
            return -1;
        }

        public string GetValueById(int id)
        {
            foreach (IssueStatus issueStatues in _IssueStatuses)
                if (issueStatues.Id == id)
                    return issueStatues.Value;
            return "";
        }
    }
}
