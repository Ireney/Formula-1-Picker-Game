using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Web.Script.Services;

namespace CleverDogStudios.FormulaOnePickr.WebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IFormulaOnePickrService" in both code and config file together.
    [ServiceContract]
    public interface IFormulaOnePickrService
    {
        [OperationContract]
        [WebGet(UriTemplate="/GetDrivers",
            RequestFormat=WebMessageFormat.Json,
            ResponseFormat=WebMessageFormat.Json,
            BodyStyle= WebMessageBodyStyle.Bare)]
        string GetDrivers();
    }
}
