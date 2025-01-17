﻿using Builder;
using System.Windows.Forms;

namespace P5
{
    public partial class FormMain : Form
    {
        private AppUser _CurrentAppUser = new AppUser();
        public int _id;
        FakeIssueRepository faker = new FakeIssueRepository();

        Issue SelectedIssue;
        
        public FormMain()
        {
            InitializeComponent();
        }

        private void preferencesCreateProjectToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormCreateProject form = new FormCreateProject();
            form.ShowDialog();
        }

        private void FormMain_Load(object sender, System.EventArgs e)
        {
            this.CenterToScreen();
            // Force the user to login successfully or abort the application
            DialogResult isOK = DialogResult.OK;
            while (!_CurrentAppUser.IsAuthenticated && isOK == DialogResult.OK)
            {
                FormLogin login = new FormLogin();
                isOK = login.ShowDialog();
                _CurrentAppUser = login._CurrentAppUser;
                login.Dispose();
            }
            if (isOK != DialogResult.OK)
            {
                Close();
                return;
            }
            this.Text = "Main - No Project Selected";
            while (selectAProject() == "")
            {
                DialogResult result = MessageBox.Show("A project must be selected.", "Attention", MessageBoxButtons.OKCancel);
                if (result == DialogResult.Cancel)
                {
                    Close();
                    return;
                }
            }
        }

        private void preferencesSelectProjectToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            selectAProject();
        }

        private string selectAProject()
        {
            string selectedProject = "";
            FormSelectProject form = new FormSelectProject();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                FakePreferenceRepository preferenceRepository = new FakePreferenceRepository();
                preferenceRepository.SetPreference(_CurrentAppUser.UserName,
                                                   FakePreferenceRepository.PREFERENCE_PROJECT_NAME,
                                                   form._SelectedProjectName);
                int selectedProjectId = form._SelectedProjectId;
                preferenceRepository.SetPreference(_CurrentAppUser.UserName,
                                                   FakePreferenceRepository.PREFERENCE_PROJECT_ID,
                                                   selectedProjectId.ToString());
                this.Text = "Main - " + form._SelectedProjectName;
                this._id = form._SelectedProjectId;

                selectedProject = form._SelectedProjectName;
            }
            form.Dispose();
            return selectedProject;
        }

        private void preferencesModifyProjectToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormModifyProject form = new FormModifyProject(_CurrentAppUser);
            form.ShowDialog();
            form.Dispose();
        }

        private void preferencesRemoveProjectToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormRemoveProject form = new FormRemoveProject(_CurrentAppUser);
            form.ShowDialog();
            form.Dispose();
        }

        private void issuesDashboardToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            
            FormDashboard form = new FormDashboard(_CurrentAppUser, _id, faker);
            form.ShowDialog();
            form.Dispose();
        }

        private void issuesRecordToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

            FormRecord form = new FormRecord(_CurrentAppUser, _id,faker);
            form.ShowDialog();
            
        }

        private void issuesModifyToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormSelectIssue form = new FormSelectIssue(_CurrentAppUser, _id, faker);
            form.ShowDialog();

            if(form.DialogResult == DialogResult.OK)
            {
                //isolate the selected issue
                SelectedIssue = faker.GetIssueById(form.chosenID);

                
                FormIssueModify modifiedForm = new FormIssueModify(faker, SelectedIssue.Id);
                modifiedForm.Show();


            }
        }

        private void issuesRemoveToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormSelectIssue form = new FormSelectIssue(_CurrentAppUser, _id, faker);
            form.ShowDialog();

            //if something was selected
            if (form.DialogResult == DialogResult.OK)
            {
                //isolate the selected issue
                SelectedIssue = faker.GetIssueById(form.chosenID);

                
                DialogResult result = MessageBox.Show("Are you sure you want to remove: " + SelectedIssue.Title,
                                "Confirmation",
                                MessageBoxButtons.YesNo);


                if (result == DialogResult.Yes)
                {
                    //remove it
                    bool isTrue = faker.Remove(SelectedIssue);
                    if ((isTrue == true))
                    {
                        MessageBox.Show("Issue Removed!");
                    }
                    else
                    {
                        MessageBox.Show("Error! " + result, "Requires your attention!");
                    }

                }
                else
                {
                    //cancel message and return home
                    MessageBox.Show("Remove canceled", "Attention");
                }


            }
        }
    }
}
