using P5;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Builder
{
    public partial class FormSelectIssue : Form
    {
        FakeIssueStatusRepository Status = new FakeIssueStatusRepository();
        List<Issue> IssueList;

        AppUser _CurrentAppUser;
        int SelectedProjectID;
        FakeIssueRepository IssueRepository;

        public int chosenID;
        int chosenIndex;


        public FormSelectIssue(AppUser appUser, int selectedProjectID, FakeIssueRepository faker)
        {
            _CurrentAppUser = appUser;
            SelectedProjectID = selectedProjectID;
            IssueRepository = faker;

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

            IssueList = IssueRepository.GetAll(SelectedProjectID);


            
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
