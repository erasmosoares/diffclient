using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JSONDiff.ViewModel;
using Model.JSONDiff;

namespace JSONDiff.View
{
    public partial class JSONDiffTool : Form, IView
    {
        private JSONDiffToolViewModel _viewModel;

        #region properties
        public int FileID
        {
            get
            {
                return Convert.ToInt32(nudFileID.Value);
            }
            set
            {
                nudFileID.Value = value;
            }
        }
        public string LeftJSON
        {
            get
            {
                return rtbLeft.Text;
            }
            set
            {
                rtbLeft.Text = value;
            }
        }
        public string RightJSON
        {
            get
            {
                return rtbRight.Text;
            }
            set
            {
                rtbRight.Text = value;
            }
        }
        #endregion

        public string NewJSON { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public JSONDiffTool()
        {
            InitializeComponent();

            _viewModel = new JSONDiffToolViewModel(this);

            SetHandles();
        }

        public void SetViewModel(JSONDiffToolViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        private void InitializeUI()
        {
            tControl.Visible = false;
        }

        private void SetHandles()
        {
            btnGet.Click += BtnGet_Click;
            btnSingle.Click += BtnSingle_Click;
            nudFileID.ValueChanged += NudFileID_ValueChanged;
            btnDiff.Click += BtnDiff_Click;
        }

        private void BtnDiff_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void NudFileID_ValueChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnSingle_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BtnGet_Click(object sender, EventArgs e)
        {
            _viewModel.GetAllFile();
        }
        public void UpdateDataSource(List<JSONFile> list)
        {
            dgvDados.DataSource = list;
        }

        public void ShowMessage(string msg)
        {
            MessageBox.Show(msg);
        }
    }
}
