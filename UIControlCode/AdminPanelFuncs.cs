using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System;

namespace UIControlCode
{
    public partial class MainForm : Form
    {
        // click handler for all controls inside the admins panel
        private void handlerAdmins_Click(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(PictureBox))
            {
                txtDebug.AppendText(((PictureBox)sender).Name + " clicked\r\n");
            }
            else // Label
            {
                txtDebug.AppendText(((Label)sender).Name + " clicked\r\n");
            }
        }

        // draws from start all the devices panel
        private void DrawAdminsPanel(List<User> users, Panel panel)
        {
            int y = 5, vstep = 23;

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
                label0.Cursor = Cursors.Hand;
                label0.Click += new EventHandler(handlerAdmins_Click);
                panel.Controls.Add(label0);
                // picturebox for active
                PictureBox pic0 = new PictureBox();
                pic0.Cursor = Cursors.Hand;
                pic0.Image = (user.Active) ? Properties.Resources.ok : Properties.Resources.cancel;
                pic0.Location = new Point(134, y);
                pic0.Size = new Size(20, 20);
                pic0.Name = (user.Active) ? "Inactive_" + user.Random : "Active_" + user.Random;
                pic0.Click += new EventHandler(handlerAdmins_Click);
                panel.Controls.Add(pic0);
                // picturebox for delete
                PictureBox pic2 = new PictureBox();
                pic2.Cursor = Cursors.Hand;
                pic2.Image = Properties.Resources.delete_20x20;
                pic2.Location = new Point(160, y);
                pic2.Size = new Size(20, 20);
                pic2.Name = "Delete_" + user.Random;
                pic2.Click += new EventHandler(handlerAdmins_Click);
                panel.Controls.Add(pic2);
                // picturebox for edit
                PictureBox pic3 = new PictureBox();
                pic3.Cursor = Cursors.Hand;
                pic3.Image = Properties.Resources.edit_20x20;
                pic3.Location = new Point(186, y);
                pic3.Size = new Size(20, 20);
                pic3.Name = "Edit_" + user.Random;
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
