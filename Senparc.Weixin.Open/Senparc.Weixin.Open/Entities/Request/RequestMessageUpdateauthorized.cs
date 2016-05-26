/*----------------------------------------------------------------
    文件名：RequestMessageUnauthorized.cs
    文件功能描述：推送更新授权通知  
----------------------------------------------------------------*/

namespace Senparc.Weixin.Open
{
    public class RequestMessageUpdateauthorized : RequestMessageBase
    {
        public override RequestInfoType InfoType
        {
            get { return RequestInfoType.updateauthorized; }
        }
        public string AuthorizerAppid { get; set; }
        public string AuthorizationCode { get; set; }
    }
}
