using System;
using JSONDiff.View;
using JSONDiff.ViewModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JSONDiffUnitTest
{
    //TODO
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGetFiles()
        {
            JSONDiffToolViewModel _viewModel = new JSONDiffToolViewModel(null);
            _viewModel.GetAllFile();
        }
    }
}
