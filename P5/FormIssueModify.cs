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
    public partial class FormIssueModify : Form
    {
        FakeAppUserRepository _userRepository = new FakeAppUserRepository();
        FakeIssueStatusRepository fakeIssueStatusRepository = new FakeIssueStatusRepository();


        AppUser _CurrentAppUser;
        int SelectedProjectID;
        FakeIssueRepository fakeIssueRepository;
        int IssueToModifyID;

        Issue ModIssue;


        public FormIssueModify(AppUser appUser, int id, FakeIssueRepository faker, int selectedID )
        {
            _CurrentAppUser = appUser;
            SelectedProjectID = id;
            fakeIssueRepository = faker;

            IssueToModifyID = selectedID;

            InitializeComponent();
        }

        private void FormIssueModify_Load(object sender, EventArgs e)
        {
            this.CenterToParent();

            PopulateDropBoxes();
            PopulateForm();
        }

        void PopulateDropBoxes()
        {

            foreach (AppUser user in _userRepository.GetAll())
            {
                DiscovererComboBox.Items.Add(user.LastName + ", " + user.FirstName);

            }


            foreach (IssueStatus issueStatus in fakeIssueStatusRepository.GetAll())
            {
                StatusComboBox.Items.Add(issueStatus.Value);
            }
            StatusComboBox.SelectedIndex = 0;

        }

        void PopulateForm()
        {
            ModIssue = fakeIssueRepository.GetIssueById(IssueToModifyID);

            IdBox.Text = ModIssue.Id.ToString();
            TitleBox.Text = ModIssue.Title;
            DateTimePicker.Value = ModIssue.DiscoveryDate;
            DiscovererComboBox.Text = ModIssue.Discoverer;
            ComponentBox.Text = ModIssue.Component;
            StatusComboBox.SelectedIndex = ModIssue.IssueStatusId;
            InitialDescription.Text = ModIssue.InitialDescription;


        }

        private void SelectCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModifyIssueButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
