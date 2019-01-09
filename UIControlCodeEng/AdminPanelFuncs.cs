using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System;

namespace UIControlCode
{
    public partial class MainForm : Form
    {
        // click handler for all controls inside the admins panel
        private async void handlerAdmins_Click(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(PictureBox))
            {
                PictureBox pic = (PictureBox)sender;
                txtDebug.AppendText(pic.Name + " clicked[Admin handler]\r\n");

                if (pic.Name == "addAdmin")
                {
                    formUser.Reset();
                    if (formUser.ShowDialog() == DialogResult.OK)
                    {
                        await webClient.GetHTTPStringPTaskAsync(new Uri(String.Format("{0}admin.cgi?cmd=5&rnd={1}&mail={2}&pass={3}&name={4}&active={5}",
                                ServerURL, rndlogin, formUser.UserMail, formUser.UserPass, formUser.UserName, (formUser.UserActive) ? "1" : "0")));
                    }

                    return;
                }

                string[] words = pic.Name.Split('_');
                if (words.Length != 2) return;
                string action = words[0];
                string random = words[1];

                switch (action)
                {
                    case "Inactive":
                        if (MessageBox.Show("Sure you want to deactivate this Administrator?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            await webClient.GetHTTPStringPTaskAsync(new Uri(String.Format("{0}admin.cgi?cmd=7&rnd={1}&user={2}&active=0", ServerURL, rndlogin, random)));
                        }
                        break;
                    case "Active":
                        if (MessageBox.Show("Sure you want to activate this Administrator?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            await webClient.GetHTTPStringPTaskAsync(new Uri(String.Format("{0}admin.cgi?cmd=7&rnd={1}&user={2}&active=1", ServerURL, rndlogin, random)));
                        }
                        break;
                    case "Delete":
                        if (MessageBox.Show("Sure you want to delete this Administrator?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            await webClient.GetHTTPStringPTaskAsync(new Uri(String.Format("{0}admin.cgi?cmd=6&rnd={1}&user={2}", ServerURL, rndlogin, random)));
                        }
                        break;
                    case "Edit":
                        User admin = GetAdminByRandom(random);
                        formUser.LoadData(admin.Mail, admin.Pass, admin.Name, admin.Active);
                        if (formUser.ShowDialog() == DialogResult.OK)
                        {
                            await webClient.GetHTTPStringPTaskAsync(new Uri(String.Format("{0}admin.cgi?cmd=7&rnd={1}&mail={2}&pass={3}&name={4}&active={5}&user={6}",
                                ServerURL, rndlogin, formUser.UserMail, formUser.UserPass, formUser.UserName, (formUser.UserActive) ? "1" : "0", random)));
                        }
                        break;
                }
            }
        }

        // draws from start all the devices panel
        private void DrawAdminsPanel(List<User> users, Panel panel)
        {
            int y = 5, vstep = 23;

            // clear all the old controls
            panel.Controls.Clear();

            foreach (User user in users)
            {
                // label for user name
                Label label0 = new Label();
                label0.AutoSize = true;
                label0.TextAlign = ContentAlignment.MiddleCenter;
                label0.Size = new Size(125, 20);
                label0.Name = "Name_" + user.Random;
                label0.Text = user.Name;
                label0.Location = new Point(3, y);
                panel.Controls.Add(label0);
                // picturebox for active
                PictureBox pic0 = new PictureBox();
                pic0.Cursor = Cursors.Hand;
                pic0.Image = (user.Active) ? Properties.Resources.ok : Properties.Resources.cancel;
                pic0.Location = new Point(134, y);
                pic0.Size = new Size(20, 20);
                pic0.Name = (user.Active) ? "Inactive_" + user.Random : "Active_" + user.Random;
                tooltip.SetToolTip(pic0, (user.Active) ? "Deactivate administrator" : "Activate administrator");
                pic0.Click += new EventHandler(handlerAdmins_Click);
                panel.Controls.Add(pic0);
                // picturebox for delete
                PictureBox pic2 = new PictureBox();
                pic2.Cursor = Cursors.Hand;
                pic2.Image = Properties.Resources.delete_20x20;
                pic2.Location = new Point(160, y);
                pic2.Size = new Size(20, 20);
                pic2.Name = "Delete_" + user.Random;
                tooltip.SetToolTip(pic2, "Delete administrator");
                pic2.Click += new EventHandler(handlerAdmins_Click);
                panel.Controls.Add(pic2);
                // picturebox for edit
                PictureBox pic3 = new PictureBox();
                pic3.Cursor = Cursors.Hand;
                pic3.Image = Properties.Resources.edit_20x20;
                pic3.Location = new Point(186, y);
                pic3.Size = new Size(20, 20);
                pic3.Name = "Edit_" + user.Random;
                tooltip.SetToolTip(pic3, "Edit administrator");
                pic3.Click += new EventHandler(handlerAdmins_Click);
                panel.Controls.Add(pic3);

                y += vstep;
            }
        }

        private void UpdateAdminsPanel(List<User> users, Panel panel)
        {
            foreach (Control control in panel.Controls)
            {
                if (control.GetType() == typeof(Label))
                {
                    Label crtl = (Label)control;
                    var words = crtl.Name.Split('_');
                    var user = users.Find(x => x.Random == words[1]); // recojo el device al que pertenece este control
                    switch (words[0])
                    {
                        case "Name":
                            crtl.Text = user.Name;
                            break;
                    }
                }
                else // PictureBox
                {
                    PictureBox crtl = (PictureBox)control;
                    var words = crtl.Name.Split('_');
                    var user = users.Find(x => x.Random == words[1]); // recojo el device al que pertenece este control
                    switch (words[0])
                    {
                        case "Inactive":
                        case "Active":
                            crtl.Image = (user.Active) ? Properties.Resources.ok : Properties.Resources.cancel;
                            crtl.Name = (user.Active) ? "Inactive_" + user.Random : "Active_" + user.Random;
                            break;
                    }
                }
            }
        }
    }
}
