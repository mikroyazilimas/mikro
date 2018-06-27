using SitefinityWebApp.Library.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Telerik.Sitefinity.DropboxLibraries.RestSharp;

namespace SitefinityWebApp.Library
{
    public class RestApiService
    {
        public Output_DemoRequest DemoRequestForm(Input_RequestForm inpt)
        {
            Output_Token outToken = new Output_Token();
            
            outToken=GetToken();

            InputHeader inputHeader = new InputHeader()
            {
                Token = false,
                Authorization = String.Format("{0} {1}", outToken.token_type, outToken.access_token)
            };
            return new RestProcess<Output_DemoRequest>() { WSName = Const.WSSalesforceUrl, InputClass = inpt, Type = Method.POST, InputMode = InputMode.Class, inputHeader= inputHeader }.Get();
        }

        public Output_Token GetToken()
        {

            string str = "grant_type=password&client_id=3MVG92u_V3UMpV.jdHexopDh04iBRa2BHJtjhIUDj9Ki1wc.c88BgMFTXbLF.cv2qI5KZs9XBP3yUOc1oNahc&client_secret=3823782403185074848&username=webuser%40mikro.com.tr&password=Project2018dlVIn2ZfGsF8ZcprlIMkZboS";
            return new RestProcess<Output_Token>().HttpRequest(Const.WSSalesforceUrlToken, Method.POST, str);


            //return new RestProcess<Output_Token>() { WSName = Const.WSSalesforceUrlToken, Type = Method.POST, InputMode = InputMode.Parameters,inputHeader= inputHeader,InputParams= lst }.Get();
        }
    }
}