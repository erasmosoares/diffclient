using JSONDiff.ViewModel;
using Model.JSONDiff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JSONDiff.View
{
    public interface IView
    {
        void SetViewModel(JSONDiffToolViewModel viewModel);

        int FileID { get; set; }
        string LeftJSON { get; set; }
        string RightJSON { get; set; }
        string NewJSON { get; set; }

        int LeftJSONID { get; set; }
        int RightJSONID { get; set; }

        void UpdateDataSource(List<JSONFile> list);
        void UpdateDataSource(BindingSource list);

        void SetRtbLeft(string str);
        void SetRtbRight(string str);
        void SetDiffResult(string str);


        void ShowMessage(string msg);
    }
}
