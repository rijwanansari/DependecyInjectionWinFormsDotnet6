using DIWinFormsSample.Services;

namespace DIWinFormsSample
{
    public partial class MainForm : Form
    {
        private readonly IMessageService _messageService;
        public MainForm(IMessageService messageService)
        {
            _messageService = messageService;
            InitializeComponent();
            lblMessage.Text = _messageService.GetSuccessMessage();
        }
    }
}