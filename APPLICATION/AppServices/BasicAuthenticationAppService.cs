//using APPLICATION.Interfaces;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net;
//using System.Net.Http;
//using System.Security.Principal;
//using System.Text;
//using System.Threading;
//using System.Threading.Tasks;
//using System.Web.Http.Controllers;
//using System.Web.Http.Filters;

//namespace APPLICATION.AppServices
//{
//    public class BasicAuthenticationAppService : AuthorizationFilterAttribute, IBasicAuthenticationAppService
//    {
//        private readonly ILogInAppService _LogInAppSevice;
//        public BasicAuthenticationAppService(ILogInAppService LogInAppSevice)
//        {
//            _LogInAppSevice = LogInAppSevice;
//        }
//        public override void OnAuthorization(HttpActionContext actionContext)
//        {
//            //client send credentials using header
//            if(actionContext.Request.Headers.Authorization == null)
//            {
//                actionContext.Response = actionContext.Request
//                    .CreateResponse(HttpStatusCode.Unauthorized);
//            }
//            else
//            {
//                // username:password, base64encoded passed from the server to the client
//                string authenticationToken = actionContext.Request.Headers.Authorization.Parameter;
               
//                //we need to decode and split
//                string decodedAuthenticationToken = Encoding.UTF8.GetString(Convert.FromBase64String(authenticationToken));
//                string[] usernamePasswordArray = decodedAuthenticationToken.Split(':');
//                string username = usernamePasswordArray[0];
//                string password = usernamePasswordArray[1];

//                // set the current principle of the executing thread to this username
//                if (_LogInAppSevice.UserVerificationCheck(username, password)) {
//                    Thread.CurrentPrincipal = new GenericPrincipal(new GenericIdentity(username), null);
//                }
//                else
//                {
//                    actionContext.Response = actionContext.Request
//                        .CreateResponse(HttpStatusCode.Unauthorized);
//                }


//            }
            
//        }
//    }
//}
