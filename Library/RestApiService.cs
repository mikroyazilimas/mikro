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

            //string str = "grant_type=password&client_id=3MVG92u_V3UMpV.jdHexopDh04iBRa2BHJtjhIUDj9Ki1wc.c88BgMFTXbLF.cv2qI5KZs9XBP3yUOc1oNahc&client_secret=3823782403185074848&username=webuser%40mikro.com.tr&password=Project2018dlVIn2ZfGsF8ZcprlIMkZboS";

            //string str = "grant_type=password&client_id=3MVG9HxRZv05HarTuyiQcrETsRw43q_plEZRNkweXDm4KmovEnoWJXMFgISas3mE_Bnyi2rEQ4YaaRbiy2wj.&client_secret=9115095582394842352&username=tolga.dokuzer@mikro.com.tr&password=Mikroint1HGP9cnHHE2jutAyxCtTxrCyCZ";
            string str = String.Format("grant_type={0}&client_id={1}&client_secret={2}&username={3}&password={4}",Names.WSSettings.grant_type, Names.WSSettings.client_id, Names.WSSettings.client_secret, Names.WSSettings.username, Names.WSSettings.password);
            return new RestProcess<Output_Token>().HttpRequest(Const.WSSalesforceUrlToken, Method.POST, str);


            //return new RestProcess<Output_Token>() { WSName = Const.WSSalesforceUrlToken, Type = Method.POST, InputMode = InputMode.Parameters,inputHeader= inputHeader,InputParams= lst }.Get();
        }
    }
}