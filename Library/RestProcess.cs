using Newtonsoft.Json;
using SitefinityWebApp.Library.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;
using Telerik.Sitefinity.DropboxLibraries.RestSharp;

namespace SitefinityWebApp.Library
{
    public class RestProcess<T>
    {
        public List<KeyValue> InputParams { get; set; }
        public object InputClass { get; set; }
        public Method Type { get; set; }
        public InputMode InputMode { get; set; }
        public InputHeader inputHeader { get; set; }
        public string WSName { get; set; }
        public T Get()
        {
            try
            {
                var client = new RestClient($"{WSName}");
                var request = new RestRequest(Type);
                request.AddHeader("cache-control", "no-cache");
                System.Net.ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                if (inputHeader.Token == false)
                {
                    request.AddHeader("content-type", "application/json;charset=utf-8");
                    request.AddHeader("Authorization", inputHeader.Authorization);
                    request.AddParameter("application/json", PrepareParameters(), ParameterType.RequestBody);
                }
                else
                {
                    request.AddHeader("content-type", "application/x-www-form-urlencoded");
                    request.AddParameter("application/x-www-form-urlencoded", PrepareParameters(), ParameterType.RequestBody);
                }
                //else
                //{
                //    request.AddHeader("grant_type", inputHeader.GrantType);
                //    request.AddHeader("client_id", inputHeader.ClientId);
                //    request.AddHeader("client_secret", inputHeader.ClientSecret);
                //    request.AddHeader("username", inputHeader.Username);
                //    request.AddHeader("password", inputHeader.Password);
                //}

                

                
                IRestResponse response = client.Execute(request);
                object retVal = null;
                retVal = response.Content;

                //response.Content.ToString().Split(':')[8]
                T result;
                //if (retVal.ToString().IndexOf("TransactionID") != -1)
                //{
                //    string str = "{'MessageCode':'SERVICE_ERROR'}";
                //    result = JsonConvert.DeserializeObject<T>(str);
                //    result.GetType().GetProperty(Names.WSFields.Message).SetValue(result, new List<Output_Message>() { new Output_Message() { message = retVal.ToString() } });
                //}
                //else
                //{
                //    result = JsonConvert.DeserializeObject<T>(response.Content);
                //    result.GetType().GetProperty(Names.WSFields.MessageCode).SetValue(result, Names.WSOutputMessageCode.OK);
                //}

                result = JsonConvert.DeserializeObject<T>(response.Content);
                return result;
                //var messageCode = (result.GetType().GetProperty(Names.WSFields.MessageCode).GetValue(result) ?? "").ToString();
                //messageCode = "OK";
                //var message = (result.GetType().GetProperty(Names.WSFields.Message).GetValue(result)) as List<Output_Message>;
                //message = message ?? new List<Output_Message>() { new Output_Message() { message = "Hata Oluştu" } };

                //if (response.StatusCode == System.Net.HttpStatusCode.OK)
                //{
                //    if (messageCode == Names.WSOutputMessageCode.OK)
                //        return (T)Convert.ChangeType(result, typeof(T));
                //    else
                //    {
                //        var eI = Activator.CreateInstance<T>();
                //        eI.GetType().GetProperty(Names.WSFields.MessageCode).SetValue(eI, messageCode);
                //        eI.GetType().GetProperty(Names.WSFields.Message).SetValue(eI, message);
                //        return (T)Convert.ChangeType(eI, typeof(T));
                //    }
                //}
                //else
                //{
                //    var eI = Activator.CreateInstance<T>();
                //    eI.GetType().GetProperty(Names.WSFields.MessageCode).SetValue(eI, messageCode);
                //    eI.GetType().GetProperty(Names.WSFields.Message).SetValue(eI, message);
                //    return (T)Convert.ChangeType(eI, typeof(T));
                //}
            }
            catch (Exception ex) { }

            var emptyInstance = Activator.CreateInstance<T>();
            emptyInstance.GetType().GetProperty(Names.WSFields.MessageCode).SetValue(emptyInstance, Names.WSOutputMessageCode.SERVICE_ERROR);
            return (T)Convert.ChangeType(emptyInstance, typeof(T));
        }

        string PrepareParameters()
        {

            string retVal = string.Empty;
            switch (InputMode)
            {
                case InputMode.Unknown:
                    break;
                case InputMode.Class:
                    //retVal = string.Format(@"{{ ""Input"" : {0}  }}", JsonConvert.SerializeObject(InputClass));
                    retVal = string.Format(@"{0}", JsonConvert.SerializeObject(InputClass));
                    break;
                case InputMode.Parameters:
                    if (InputParams != null)
                    {
                        InputParams.ForEach(p =>
                        {
                            if (p.Value.GetType() == typeof(int))
                                retVal += $@"""{p.Key}"": {p.Value},";
                            else
                                retVal += $@"""{p.Key}"": ""{p.Value}"", ";
                        });
                        retVal = string.Format(@"{{ {0} }}", retVal);
                    }
                    break;
                default:
                    break;
            }
            return retVal;

        }

        public T HttpRequest(string Url, Method Method, string PostData, string bearerToken = "")
        {
            string responseStr = "";
            try
            {
                WebRequest request = WebRequest.Create(Url);
                request.Method = Method.ToString();
                if (!String.IsNullOrEmpty(bearerToken))
                {
                    request.Headers.Add(HttpRequestHeader.Authorization, "Bearer " + bearerToken);
                }
                if (Method == Method.POST)
                {
                    System.Net.ServicePointManager.Expect100Continue = true;
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                    request.ContentType = "application/x-www-form-urlencoded";
                    byte[] data = Encoding.ASCII.GetBytes(PostData);
                    request.ContentLength = data.Length;
                    
                    using (var stream = request.GetRequestStream())
                    {
                        stream.Write(data, 0, data.Length);
                    }
                }

                WebResponse response = request.GetResponse();
                Stream dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                responseStr = reader.ReadToEnd();

                reader.Close();
                dataStream.Close();
                response.Close();
            }
            catch (Exception ex)
            {
                responseStr = ex.Message;
            }

            JavaScriptSerializer js = new JavaScriptSerializer();
            T responseT = js.Deserialize<T>(responseStr);

            return responseT;
        }

    }
}