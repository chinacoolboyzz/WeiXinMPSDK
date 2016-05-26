/*----------------------------------------------------------------
    文件名：RequestMessageAuthorized.cs
    文件功能描述：推送授权成功通知
----------------------------------------------------------------*/

namespace Senparc.Weixin.Open
{
    public class RequestMessageAuthorized : RequestMessageBase
    {
        public override RequestInfoType InfoType
        {
            get { return RequestInfoType.authorized; }
        }
        public string AuthorizerAppid { get; set; }
        public string AuthorizationCode { get; set; }
    }
}
