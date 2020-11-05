using P5;
using System;
using System.Windows.Forms;

namespace Builder
{
    public partial class FormIssueModify : Form
    {
        FakeAppUserRepository _userRepository = new FakeAppUserRepository();
        FakeIssueStatusRepository StatusRepository = new FakeIssueStatusRepository();

        FakeIssueRepository IssueRepository;
        int IssueToModifyID;

        Issue ModIssue;


        public FormIssueModify(FakeIssueRepository faker, int selectedID )
        {
            IssueRepository = faker;
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


            foreach (IssueStatus issueStatus in StatusRepository.GetAll())
            {
                StatusComboBox.Items.Add(issueStatus.Value);
            }
            StatusComboBox.SelectedIndex = 0;

        }

        void PopulateForm()
        {
            ModIssue = IssueRepository.GetIssueById(IssueToModifyID);
            int offsetForIndex = 1;

            IdBox.Text = ModIssue.Id.ToString();
            TitleBox.Text = ModIssue.Title;
            DateTimePicker.Value = ModIssue.DiscoveryDate;
            DiscovererComboBox.Text = ModIssue.Discoverer;
            ComponentBox.Text = ModIssue.Component;
            StatusComboBox.SelectedIndex = ModIssue.IssueStatusId - offsetForIndex;
            InitialDescription.Text = ModIssue.InitialDescription;


        }

        private void SelectCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModifyIssueButton_Click(object sender, EventArgs e)
        {

            if (IssueRepository.IsDuplicate(TitleBox.Text.Trim()) == true)
            {
                MessageBox.Show("Name must be unique!!", "Attention!!");
            }
            else
            {
                int StatusOffset = 1;


                ModIssue.Title = TitleBox.Text;
                ModIssue.DiscoveryDate = DateTimePicker.Value;
                ModIssue.Discoverer = DiscovererComboBox.Text;
                ModIssue.Component = ComponentBox.Text;
                ModIssue.IssueStatusId = StatusComboBox.SelectedIndex + StatusOffset;
                ModIssue.InitialDescription = InitialDescription.Text;



                string result = IssueRepository.Modify(ModIssue);
                if ((result == FakeIssueRepository.NO_ERROR))
                {
                    MessageBox.Show("Modify Successful!!");
                }
                else
                {
                    MessageBox.Show("Error! " + result, "Requires your attention!");
                }


                this.Close();
            }
        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            //make it so that nothing in the future can be selected
            this.DateTimePicker.MaxDate = DateTime.Now;
        }
    }
}
