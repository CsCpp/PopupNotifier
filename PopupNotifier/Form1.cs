
using Tulpep.NotificationWindow;

namespace PopupNotifier2
{
    public partial class Form1 : Form
    {
        //
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           



        }

        private void button1_Click(object sender, EventArgs e)
        {
           // private PopupNotifier popup = null;
        PopupNotifier popup = new PopupNotifier();
            popup.Image = Properties.Resources.png;
            popup.ImageSize = new Size(96, 96);

            popup.TitleColor = Color.Azure;
            popup.HeaderColor = Color.Red;
            popup.BodyColor = Color.Fuchsia;
            popup.ShowCloseButton = false;
            popup.TitleText = "NotyWindows";
            popup.ContentText = "Сообщение для пользователя!";
            popup.Popup();
        }
    }
}
