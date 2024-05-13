
using Tulpep.NotificationWindow;

namespace PopupNotifier2
{
    public partial class Form1 : Form
    {
        private PopupNotifier popup = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            popup = new PopupNotifier();
            popup.Image = Properties.Resources.png;
            popup.ImageSize = new Size(96, 96);
            popup.TitleText = "NotyWindows";
            popup.ContentText = "Сообщение для пользователя!";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            popup.Popup();
        }
    }
}
