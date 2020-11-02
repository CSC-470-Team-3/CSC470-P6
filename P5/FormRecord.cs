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
    public partial class FormRecord : Form
    {
        FakeAppUserRepository _userRepository = new FakeAppUserRepository();
        FakeIssueStatusRepository _fakeIssueStatusRepository = new FakeIssueStatusRepository();
        FakeIssueRepository _fakeIssueRepository = new FakeIssueRepository();
        AppUser _CurrentAppUser;
        int _selId;
        Issue issue = new Issue();
        int _i;
        
        public FormRecord(AppUser appUser, int selId)
        {
            _selId = selId;
            _CurrentAppUser = appUser;
            InitializeComponent();    
        }

        private void FormRecord_Load(object sender, EventArgs e)
        {
            this.CenterToParent();

            _i = _fakeIssueRepository.GetTotalNumberOfIssues(_selId) + 1;
            IdBox.Text = (_i.ToString());

            foreach (AppUser user in _userRepository.GetAll())
            {
                comboBox1.Items.Add(user.LastName + ", " +user.FirstName);
            }
            foreach (IssueStatus issueStatus in _fakeIssueStatusRepository.GetAll())
            {
                comboBox2.Items.Add(issueStatus.Value);
            }

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
            issue.Id = _i;
            issue.Title = TitleTextBox.Text.Trim();
            issue.Discoverer = comboBox1.SelectedItem.ToString();
            issue.Component = ComponentBox.Text.Trim();
            issue.DiscoveryDate = dateTimePicker1.Value;
            issue.IssueStatusId = _fakeIssueStatusRepository.GetIdByStatus(comboBox2.SelectedItem.ToString());
            issue.InitialDescription = InitialDescription.Text.Trim();

            string result = _fakeIssueRepository.Add(issue);
            if(result == FakeIssueRepository.NO_ERROR)
            {
                MessageBox.Show("Issue added!");
            }
            else
            {
                MessageBox.Show("Error! " + result, "Requires your attention!");
            }
            this.Close();
        }
    }
}
