using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class FakeIssueRepository : IIssueRepository
    {
        public const string
            NO_ERROR = "",
            EMPTY_TITLE_ERROR = "A Title is required.",
            EMPTY_DISCOVERY_DATETIME_ERROR = "Must select a Discovery Date/Time.",
            FUTURE_DISCOVERY_DATETIME_ERROR = "Issues can't be from the future.",
            EMPTY_DISCOVERER_ERROR = "A Discoverer is required.";
        private static List<Issue> _Issues;

        public FakeIssueRepository()
        {
            _Issues = new List<Issue>();
            _Issues.Add(
                new Issue {
                    ProjectID = 1,
                    Id = 1,
                    Title = "First Issue",
                    DiscoveryDate = new DateTime(2020,1,25,8,1,0),
                    Discoverer = "Bishop, Dave",
                    InitialDescription = "The first issue ever found",
                    Component = "FormMain",
                    IssueStatusId = 1
                });
            _Issues.Add(
                new Issue
                {
                    ProjectID = 1,
                    Id = 2,
                    Title = "Minor Problem",
                    DiscoveryDate = new DateTime(2020, 2, 1, 10, 30, 0),
                    Discoverer = "Bishop, Dave",
                    InitialDescription = "This is a minor issue",
                    Component = "FormCreateProject",
                    IssueStatusId = 2
                });
            _Issues.Add(
                new Issue
                {
                    ProjectID = 1,
                    Id = 3,
                    Title = "Mediocre Problem",
                    DiscoveryDate = new DateTime(2020, 2, 15, 9, 30, 0),
                    Discoverer = "Bishop, Dave",
                    InitialDescription = "This is a mediocre problem",
                    Component = "FormModifyProject",
                    IssueStatusId = 3
                });
            _Issues.Add(
                new Issue
                {
                    ProjectID = 1,
                    Id = 4,
                    Title = "Show stopper issue",
                    DiscoveryDate = new DateTime(2020, 3, 31, 16, 30, 0),
                    Discoverer = "Bishop, Dakota",
                    InitialDescription = "Huge issue",
                    Component = "FakePreferenceRepository",
                    IssueStatusId = 4
                });
        }

        public string Add(Issue issue)
        {
            string validity = ValidateIssue(issue);
            if (validity != NO_ERROR)
                return validity;
            issue.Id = _Issues.Count == 0 ? 1 : (from i in _Issues select i.Id).Max() + 1;
            _Issues.Add(issue);
            return NO_ERROR;
        }

        public List<Issue> GetAll(int ProjectId)
        {
            List<Issue> issues = new List<Issue>();
            foreach (Issue issue in _Issues)
                issues.Add(issue);
            return issues;
        }

        public Issue GetIssueById(int Id)
        {
            foreach(Issue issue in _Issues)
            {
                if (issue.Id == Id)
                    return issue;
            }
            return null;
        }

        public List<string> GetIssuesByDiscoverer(int ProjectId)
        {
            Dictionary<string, int> DiscoverersIssues = new Dictionary<string, int>();
            foreach(Issue issue in _Issues) 
                if(issue.ProjectID == ProjectId)
                {
                    if (!DiscoverersIssues.ContainsKey(issue.Discoverer))
                        DiscoverersIssues.Add(issue.Discoverer, 1);
                    else
                          DiscoverersIssues[issue.Discoverer]+= 1;
                }

            List<string> result = new List<string>();
            foreach(var pair in DiscoverersIssues)
                result.Add(pair.Key + ": " + pair.Value);
            return result;
        }

        public List<string> GetIssuesByMonth(int ProjectId)
        {
            Dictionary<(int, int), int> MonthIssues = new Dictionary<(int,int), int>();
            foreach(Issue issue in _Issues)
                if(issue.ProjectID == ProjectId)
                {
                    var month = (issue.DiscoveryDate.Year, issue.DiscoveryDate.Month);

                    if (!MonthIssues.ContainsKey(month))
                        MonthIssues.Add(month, 1);
                    else
                        MonthIssues[month]+=1;
                    
                }
            List<string> result = new List<string>();
            foreach (var pair in MonthIssues)
                result.Add(pair.Key.Item1 + " - " + pair.Key.Item2 + ": " + pair.Value);
            return result;
        }

        public int GetTotalNumberOfIssues(int ProjectId)
        {
            int result = 0;
            foreach (Issue issue in _Issues)
                if (issue.ProjectID == ProjectId)
                    result++;
            return result;
        }

        public string Modify(Issue issue)
        {
            string validity = ValidateIssue(issue);
            if (validity != NO_ERROR)
                return validity;
            for (int i = 0; i < _Issues.Count; i++)
                if (_Issues[i].Id == issue.Id)
                    _Issues[i] = issue;
            return NO_ERROR;
        }

        public bool Remove(Issue issue)
        {
            for (int i = 0; i < _Issues.Count; i++)
                if (_Issues[i].Id == issue.Id)
                {
                    _Issues.RemoveAt(i);
                    return true;
                }
            return false;
        }

        private string ValidateIssue(Issue issue)
        {
            if (issue.Title == "")
                return EMPTY_TITLE_ERROR;
            if (issue.DiscoveryDate == null)
                return EMPTY_DISCOVERY_DATETIME_ERROR;
            if (issue.DiscoveryDate.CompareTo(DateTime.Now) > 0)
                return FUTURE_DISCOVERY_DATETIME_ERROR;
            if (issue.Discoverer == "")
                return EMPTY_DISCOVERER_ERROR;
            return NO_ERROR;
        }

        private bool IsDuplicate(string title)
        {
            foreach(Issue issue in _Issues)
                if (issue.Title.Equals(title))
                    return true;
            return false;
        }
    }
}
