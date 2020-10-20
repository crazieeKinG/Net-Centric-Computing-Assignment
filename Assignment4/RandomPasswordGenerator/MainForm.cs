using System;
using System.Windows.Forms;

namespace RandomPasswordGenerator
{
    public partial class MainForm : Form
    {
        public static int maxRangeValue = 10;

        public MainForm()
        {
            InitializeComponent();
        }

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            try
            {
                maxRangeValue = int.Parse(letterCount.Text);
                PasswordGeneratorForm form = new PasswordGeneratorForm();
                form.Tag = this;
                form.Show(this);
                Hide();
            }
            catch
            {
                errorProvider.SetError(letterCount, "Invalid input");
            }

        }
    }
}
