using ApplicationService.Service;
using Model.DomainModels;

namespace View
{
    public partial class Form1 : Form
    {
        private readonly PersonApplicationService _personApplicationService;
       
        public Form1()
        {
            InitializeComponent();
            _personApplicationService = new PersonApplicationService();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvPerson.DataSource = _personApplicationService.GetAll();
        }
    }
}
