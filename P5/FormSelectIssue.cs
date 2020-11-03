using P5;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Builder
{
    public partial class FormSelectIssue : Form
    {
        Issue CurrentID;
        FakeIssueStatusRepository Status = new FakeIssueStatusRepository();
        List<Issue> IssueList;

        AppUser _CurrentAppUser;
        int SelectedProjectID;
        FakeIssueRepository fakeIssueRepository;

        public int chosenID;
        int chosenIndex;


        public FormSelectIssue(AppUser appUser, int selectedProjectID, FakeIssueRepository faker)
        {
            _CurrentAppUser = appUser;
            SelectedProjectID = selectedProjectID;
            fakeIssueRepository = faker;

            chosenID = 0;

            InitializeComponent();
        }

        private void FormSelectIssue_Load(object sender, EventArgs e)
        {
            this.CenterToParent();

            PopulateDatagridview();

        }



        private void SelectCancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SelectIssueButton_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection chosenRowCollection = issuesDataGridView.SelectedRows;


            DataGridViewRow RowValue = chosenRowCollection[0];
            chosenIndex = RowValue.Index;
            chosenID = IssueList[chosenIndex].Id;
            this.DialogResult = DialogResult.OK;
            this.Close();
            

        }


        void PopulateDatagridview()
        {

            IssueList = fakeIssueRepository.GetAll(SelectedProjectID);

            
            foreach (Issue issue in IssueList)
            {

                issuesDataGridView.Rows.Add(issue.Id,
                                            issue.Title,
                                            issue.DiscoveryDate,
                                            issue.Discoverer,
                                            issue.InitialDescription,
                                            issue.Component,
                                            Status.GetValueById(issue.IssueStatusId));
            }
        
        
        }



    }
}
