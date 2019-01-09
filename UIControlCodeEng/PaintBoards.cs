using System.Windows.Forms;

namespace UIControlCode
{
    public partial class MainForm : Form
    {
        private void PaintRootBoard()
        {
            DrawLoggingBlock(3, 3, "Logged as root");
            DrawAdminsPanelBlock(15, 37, 243, 243);
            DrawUsersPanelBlock(296, 37, 243, 243);
            DrawDevicesPanelBlock(15, 344, 527, 208);
            dgv_admin_mon = DrawStatsTableBlock(577, 60, 376, 243, "", "admin_mon");
            dgv_user_day = DrawStatsTableBlock(577, 367, 376, 208, "", "user_day");
        }

        private void PaintAdminBoard(string adminName)
        {
            DrawLoggingBlock(3, 3, "Logged as " + adminName);
            DrawUsersPanelBlock(75, 37, 243, 243);
            DrawDevicesPanelBlock(398, 37, 527, 243);
            dgv_admin_mon = DrawStatsTableBlock(25, 364, 310, 208, "", "admin_mon");
            dgv_user_day = DrawStatsTableBlock(345, 364, 310, 208, "", "user_day");
            dgv_user_now = DrawStatsTableBlock(665, 364, 310, 208, "", "user_now");
        }

        private void PaintUserBoard(string UserName)
        {
            DrawLoggingBlock(3, 3, "Logged as " + UserName);
            DrawDevicesPanelBlock(25, 37, 527, 243);
            dgv_user_now = DrawStatsTableBlock(599, 60, 376, 243, "", "user_now");
            dgv_user_mon = DrawStatsTableBlock(25, 364, 450, 208, "", "user_mon");
            dgv_user_day = DrawStatsTableBlock(525, 364, 450, 208, "", "user_day");
        }
    }
}
