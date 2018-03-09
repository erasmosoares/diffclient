using JSONDiff.View;
using Model.JSONDiff;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace JSONDiff.ViewModel
{
    public class JSONDiffToolViewModel
    {
        private const string URI_GET_ALL_DATA = "http://localhost:49783/v1/diff/data";
        private IView _view;
        private JSONFile _model;

        public JSONDiffToolViewModel(IView view)
        {
            _view = view;
            _model = new JSONFile();
        }

        public async void GetAllFile()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    using (var response = await client.GetAsync(URI_GET_ALL_DATA))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            var ProdutoJsonString = await response.Content.ReadAsStringAsync();
                            _view.UpdateDataSource(JsonConvert.DeserializeObject<JSONFile[]>(ProdutoJsonString).ToList());

                        }
                        else
                        {
                            _view.ShowMessage("Error : " + response.StatusCode);
                        }
                    }
                }
            }
            catch (Exception)
            {

                _view.ShowMessage("Is the service active? ");
            }
            
        }
    }
}
