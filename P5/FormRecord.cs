using Builder;
using System;
using System.Windows.Forms;

namespace P5
{
    public partial class FormRecord : Form
    {
        FakeAppUserRepository _userRepository = new FakeAppUserRepository();
        FakeIssueStatusRepository IssueStatusRepository = new FakeIssueStatusRepository();
        FakeIssueRepository IssueRepository;
        AppUser _CurrentAppUser;
        int _selId;
        Issue issue = new Issue();
        int _i;
        
        public FormRecord(AppUser appUser, int selId, FakeIssueRepository faker)
        {
            
            IssueRepository = faker;
            _selId = selId;
            _CurrentAppUser = appUser;
            
            InitializeComponent();    
        }

        private void FormRecord_Load(object sender, EventArgs e)
        {
            this.CenterToParent();


            //create and add a new issue
            Issue tmp = new Issue();
            IssueRepository.Add(tmp);

            //get the index from newly implemented issue then remove it
            _i = tmp.Id;
            IssueRepository.Remove(tmp);


            IdBox.Text = (_i.ToString());
            
            foreach (AppUser user in _userRepository.GetAll())
            {
                comboBox1.Items.Add(user.LastName + ", " +user.FirstName);
                
            }
            comboBox1.SelectedIndex = 0;
            ComponentBox.SelectedText = "";
            foreach (IssueStatus issueStatus in IssueStatusRepository.GetAll())
            {
                comboBox2.Items.Add(issueStatus.Value);
            }
            comboBox2.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.MaxDate = DateTime.Today;
        }

        private void TextBoxID_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (IssueRepository.IsDuplicate(TitleTextBox.Text.Trim()) != true)
            {
                issue.Id = _i;
                issue.Title = TitleTextBox.Text.Trim();

                issue.ProjectID = _selId;
                issue.Discoverer = comboBox1.SelectedItem.ToString();
                issue.Component = ComponentBox.Text.Trim();
                issue.DiscoveryDate = dateTimePicker1.Value;
                issue.IssueStatusId = IssueStatusRepository.GetIdByStatus(comboBox2.SelectedItem.ToString());
                issue.InitialDescription = InitialDescription.Text.Trim();

                string result = IssueRepository.Add(issue);
                if ((result == FakeIssueRepository.NO_ERROR))
                {
                    MessageBox.Show("Issue added!");
                }
                else
                {
                    MessageBox.Show("Error! " + result, "Requires your attention!");
                }
                this.Close();

            }
            else
            {
                MessageBox.Show("Please input unique Title");
            }

        }
    }
}
