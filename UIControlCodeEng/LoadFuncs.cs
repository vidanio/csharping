using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace UIControlCode
{
    public partial class MainForm : Form
    {
        // create a list of users from an Admins CSV list
        private List<User> LoadAdmins(string csv)
        {
            StringReader strReader = new StringReader(csv);
            List<User> admins = new List<User>();

            while (true)
            {
                string line = strReader.ReadLine();
                if (line != null)
                    admins.Add(new User(0, line + ";no"));
                else break;
            }

            return admins;
        }


        // create a list of users from a Users CSV list
        private List<User> LoadUsers(string csv)
        {
            StringReader strReader = new StringReader(csv);
            List<User> users = new List<User>();

            while (true)
            {
                string line = strReader.ReadLine();
                if (line != null)
                {
                    string sel = "no";
                    if (selected != "")
                    {
                        sel = (line.Contains(selected)) ? "yes" : "no";
                    }
                    users.Add(new User(1, line + ";" + sel));
                }
                else break;
            }

            return users;
        }

        // true = if both lists contains the same users/admins, no matter the order is
        private bool CompareListOfUsers(List<User> users1, List<User> users2)
        {
            if (users1.Count == users2.Count)
            {
                foreach (User user1 in users1)
                {
                    if (!users2.Exists(x => x.Random == user1.Random))
                        return false;

                }
            }
            else
            {
                return false;
            }

            return true;
        }

        // create a list of devices from a RT status CSV
        private List<Device> LoadDevices(string csv)
        {
            StringReader strReader = new StringReader(csv);
            List<Device> devs = new List<Device>();

            while (true)
            {
                string line = strReader.ReadLine();
                if (line != null)
                    devs.Add(new Device(line));
                else break;
            }

            return devs;
        }

        // true = if both lists contains the same devices, no matter the order is
        private bool CompareListOfDevices(List<Device> devs1, List<Device> devs2)
        {
            if (devs1.Count == devs2.Count)
            {
                foreach (Device dev1 in devs1)
                {
                    if (!devs2.Exists(x => x.Random == dev1.Random))
                        return false;
                }

            }
            else
            {
                return false;
            }

            return true;
        }

        // return a Control whose parent and name are known
        private Control GetControlByName(Control ParentCntl, string NameToSearch)
        {
            foreach (Control ChildCntl in ParentCntl.Controls)
            {
                if (ChildCntl.Name == NameToSearch) return ChildCntl;
            }
            return null;
        }

        private User GetUserByRandom(string random)
        {
            foreach(User user in usersList)
            {
                if (user.Random == random)
                {
                    return user;
                }
            }
            return null;
        }

        private User GetSelectedUser()
        {
            foreach (User user in usersList)
            {
                if (user.Selected)
                {
                    return user;
                }
            }
            return null;
        }

        private User GetAdminByRandom(string random)
        {
            foreach (User user in adminsList)
            {
                if (user.Random == random)
                {
                    return user;
                }
            }
            return null;
        }

        private Device GetDeviceByRandom(string random)
        {
            foreach (Device device in devicesList)
            {
                if (device.Random == random)
                {
                    return device;
                }
            }
            return null;
        }
    }
}
