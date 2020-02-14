using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceFightServer
{
    public partial class CustomPopUp : Form
    {
        string _title;
        string _caption;
        public CustomPopUp (string _caption,string _title)
        {
            InitializeComponent();
            this._title = _title;
            this._caption = _caption;
        }

        private void CustomPopUp_Load(object sender, EventArgs e)
        {
            CaptionLabel.Text = _title;
            MessageLabel.Text = _caption;
        }

        private void yesBut_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Yes;
            Close();
        }

        private void noBut_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            Close();
        }
    }

    public static class CustomMessageBox
    {
        public static DialogResult Show(string title, string description)
        {
            // using construct ensures the resources are freed when form is closed
            using (var form = new CustomPopUp(title, description))
            {
                return form.ShowDialog();
            }
        }
    }
}
