using JSONDiff.View;
using Model.JSONDiff;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JSONDiff.ViewModel
{
    public class JSONDiffToolViewModel
    {
        private const string URI_GET_DATA = "http://localhost:49783/v1/diff/data";
        private const string URI_POST = "http://localhost:49783/v1/diff/";
      
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
                    using (var response = await client.GetAsync(URI_GET_DATA))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            var JSONFileString = await response.Content.ReadAsStringAsync();
                            _view.UpdateDataSource(JsonConvert.DeserializeObject<JSONFile[]>(JSONFileString).ToList());

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


        public async void GetFileById(int id)
        {
            try
            {
                using (var client = new HttpClient())
                {

                    BindingSource bsDados = new BindingSource();

                    HttpResponseMessage response = await client.GetAsync(URI_GET_DATA + "/" + id.ToString());
                    if (response.IsSuccessStatusCode)
                    {
                        var JSONFileString = await response.Content.ReadAsStringAsync();
                        bsDados.DataSource = JsonConvert.DeserializeObject<JSONFile>(JSONFileString);
                        _view.UpdateDataSource(bsDados);
                    }
                    else
                    {
                        _view.ShowMessage("Error : " + response.StatusCode);
                    }
                }
            }
            catch (Exception)
            {

                _view.ShowMessage("Is the service active? ");
            }
        }

        public async void AddLeftSide()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var result = await client.PostAsync(URI_POST + _view.LeftJSONID + "/left", null);
                    var contents = await result.Content.ReadAsStringAsync();
                    _view.SetRtbLeft(result.ToString() + Environment.NewLine + contents.ToString());
                }
            }
            catch (Exception e)
            {

                _view.ShowMessage("Error posting file : "+e);
            }
            
        }

        public async void AddRightSide()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var result = await client.PostAsync(URI_POST + _view.RightJSONID + "/right", null);
                    var contents = await result.Content.ReadAsStringAsync();                  
                    _view.SetRtbRight(result.ToString()+Environment.NewLine+ contents.ToString());
                }
            }
            catch (Exception e)
            {

                _view.ShowMessage("Error posting file : " + e);
            }
            
        }

        public async void Diff()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    
                    //hardcode one - diff aways comparing from left to right
                    var result = await client.PostAsync(URI_POST + "/1", null);
                    var contents = await result.Content.ReadAsStringAsync();
                    _view.SetDiffResult(contents.ToString());
                }
            }
            catch (Exception e)
            {

                _view.ShowMessage("Error posting file : " + e);
            }

        }
    }
}
