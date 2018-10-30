// 24 global objects used in the Window
using System.Windows.Forms;
using System.Collections.Generic;

namespace UIControlCode
{
    public partial class MainForm : Form
    {
        // interface globals
        int board = 2; // (0 = root, 1 = admin, 2 = streamer)
        string rndlogin = "x", rndquery = "x", selected = ""; // randoms of login and the streamer we query
        List<User> adminsList = new List<User>();
        List<User> usersList = new List<User>();
        List<Device> devicesList = new List<Device>();
        WebClientExtra webClient = new WebClientExtra();
        // names of months
        char[] EOL = { '\r', '\n' };
        object[] MonthNames = new object[] { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
        // instances of forms before using them
        FormLogin formLogin = new FormLogin();
        FormUser formUser = new FormUser();
        FormDevice formDevice = new FormDevice();
        // global declaration of all DGVs
        DataGridView dgv_admin_mon, dgv_user_mon, dgv_user_day, dgv_user_now;
        // tooltips for all the controls in the window
        ToolTip tooltip = new ToolTip();
        // Logging Block
        PictureBox loggingPicture = new PictureBox();
        Label loggingLabel = new Label();
        // Admins Panel Block
        Panel panelListAdmins = new Panel();
        Label lblTitleAdmins = new Label();
        PictureBox addAdmin = new PictureBox();
        // Users Panel Block
        Panel panelListUsers = new Panel();
        Label lblTitleUsers = new Label();
        PictureBox addUser = new PictureBox();
        // Devices Panel Block
        Panel panelListDevices = new Panel();
        Label lblTitleDevices = new Label();
        PictureBox addDevice = new PictureBox();
        // Combos
        ComboBox cboxMonth_mon = new ComboBox();
        ComboBox cboxYear_mon = new ComboBox();
        ComboBox cboxMonth_day = new ComboBox();
        ComboBox cboxYear_day = new ComboBox();
        // globals for DGV table's Headers
        string[] AdminMonHeaders = new string[] { "Usuario", "GBytes", "Horas" }; //User ; GBytes ; Hours
        string[] UserDayHeaders = new string[] { "Día", "MBytes", "Minutos" }; // Day ; MBytes ; Minutes
        string[] UserMonHeaders = new string[] { "Mes", "GBytes", "Horas" }; // Month ; GBytes ; Hours
        string[] UserNowHeaders = new string[] { "Decoder", "Kbps", "Minutos", "MBytes" }; // Decoder ; Kbps ; Minutes ; Mbytes
    }
}
