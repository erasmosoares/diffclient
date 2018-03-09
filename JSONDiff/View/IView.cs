using JSONDiff.ViewModel;
using Model.JSONDiff;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONDiff.View
{
    public interface IView
    {
        void SetViewModel(JSONDiffToolViewModel viewModel);

        int FileID { get; set; }
        string LeftJSON { get; set; }
        string RightJSON { get; set; }
        string NewJSON { get; set; }

        void UpdateDataSource(List<JSONFile> list);
        void ShowMessage(string msg);
    }
}
