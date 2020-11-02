using Builder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace P5
{
    public partial class FormDashboard : Form
    {
        FakeIssueRepository _fakeIssue;
        FakeProjectRepository _fakeProject = new FakeProjectRepository();
        
        AppUser _CurrentAppUser;
        int _selId;

        public FormDashboard( AppUser appUser, int selId, FakeIssueRepository fake)
        {
            
            _fakeIssue = fake;
            _CurrentAppUser = appUser;
            _selId = selId;
            InitializeComponent();
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            this.CenterToParent();

            int i = _fakeIssue.GetTotalNumberOfIssues(_selId);
            IDBox.Text = (i.ToString());

            List<String> IssueMonth = _fakeIssue.GetIssuesByMonth(_selId);
            List<String> users = _fakeIssue.GetIssuesByDiscoverer(_selId);
                
            foreach(string monthly in IssueMonth)
            {
                MonthBox.Items.Add(monthly);
            }
            foreach(string DiscoverersIssues in users)
            {
                DiscoverBox.Items.Add(DiscoverersIssues);
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MonthBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
