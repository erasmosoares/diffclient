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
        public int LeftJSONID
        {
            get
            {
                return Convert.ToInt32(nudLeftID.Value);
            }
            set
            {
                nudLeftID.Value = value;
            }
        }
        public int RightJSONID
        {
            get
            {
                return Convert.ToInt32(nudRightID.Value);
            }
            set
            {
                nudRightID.Value = value;
            }
        }
        #endregion

        public JSONDiffTool()
        {
            InitializeComponent();

            _viewModel = new JSONDiffToolViewModel(this);

            SetHandles();
        }

        private void InitializeUI()
        {
            tabcontrol.Visible = false;
        }

        private void SetHandles()
        {
            btnGet.Click += BtnGet_Click;
            btnSingle.Click += BtnSingle_Click;
            nudFileID.ValueChanged += NudFileID_ValueChanged;
            btnDiff.Click += BtnDiff_Click;

            nudLeftID.ValueChanged += NudLeftID_ValueChanged;
            nudRightID.ValueChanged += NudRightID_ValueChanged;
            btnLeftGo.Click += BtnLeftGo_Click;
            btnRightGo.Click += BtnRightGo_Click;
        }

        private void BtnRightGo_Click(object sender, EventArgs e)
        {
            _viewModel.AddRightSide();
        }

        private void BtnLeftGo_Click(object sender, EventArgs e)
        {
            _viewModel.AddLeftSide();
        }

        private void NudRightID_ValueChanged(object sender, EventArgs e)
        {
            RightJSONID = Convert.ToInt32(nudRightID.Value);
        }

        private void NudLeftID_ValueChanged(object sender, EventArgs e)
        {
            LeftJSONID = Convert.ToInt32(nudLeftID.Value);
        }

        private void BtnDiff_Click(object sender, EventArgs e)
        {
            if (rtbLeft.Text.Equals(String.Empty) && rtbRight.Text.Equals(String.Empty))
                ShowMessage("Please inform ID for left and righ before Diff");
            else
            {
                _viewModel.Diff();
            }
        }

        public void SetRtbLeft(string str)
        {
            LeftJSON = str;
        }

        public void SetRtbRight(string str)
        {
            RightJSON = str;
        }

        private void NudFileID_ValueChanged(object sender, EventArgs e)
        {
            FileID = Convert.ToInt32(nudFileID.Value);
        }

        private void BtnSingle_Click(object sender, EventArgs e)
        {
            _viewModel.GetFileById(FileID);
        }

        private void BtnGet_Click(object sender, EventArgs e)
        {
            _viewModel.GetAllFile();
        }

        public void UpdateDataSource(List<JSONFile> list)
        {
            dgvDados.DataSource = list;
            dgvDados.Dock = DockStyle.Fill;
        }

        public void UpdateDataSource(BindingSource source)
        {
            dgvDados.DataSource = source;
            dgvDados.Dock = DockStyle.Fill;
        }

        public void ShowMessage(string msg)
        {
            MessageBox.Show(msg);
        }

        public void SetDiffResult(string str)
        {
            rtbResult.Text = str;
        }

        public string NewJSON { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    }
}
