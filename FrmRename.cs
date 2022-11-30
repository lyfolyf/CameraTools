using System.Windows.Forms;

namespace CameraTools
{
    public partial class FrmRename : Form
    {
        public FrmRename()
        {
            InitializeComponent();
        }

        public string NewName { get; set; }

        private void btnOK_Click(object sender, System.EventArgs e)
        {
            if (!tbNewName.CheckNotWhiteSpace("请输入相机名称")) return;

            NewName = tbNewName.Text.Trim();

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
