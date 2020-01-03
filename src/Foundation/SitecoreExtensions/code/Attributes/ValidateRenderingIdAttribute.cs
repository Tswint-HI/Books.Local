using Sitecore.Mvc.Presentation;
using System;
using System.Linq;
using System.Reflection;
using System.Web.Mvc;


namespace Books.Foundation.SitecoreExtensions.Attributes
{
    public class ValidateRenderingIdAttribute : ActionMethodSelectorAttribute
    {
        internal const string FormUniqueid = "uid";

        public override bool IsValidForRequest(ControllerContext controllerContext, MethodInfo methodInfo)
        {
            var ignoreCase = StringComparison.InvariantCultureIgnoreCase;

            var httpRequest = controllerContext.HttpContext.Request;
            bool isWebFormsForMarketersRequest = httpRequest.Form.AllKeys
              .Any(key => key.StartsWith("wffm", ignoreCase) && key.EndsWith("Id", ignoreCase));

            if (isWebFormsForMarketersRequest)
            {
                return false;
            }
            string renderingId;
            if (!httpRequest.GetHttpMethodOverride().Equals(HttpVerbs.Post.ToString(), ignoreCase) || string.IsNullOrEmpty(renderingId = httpRequest.Form[FormUniqueid]))
            {
                return true;
            }

            var renderingContext = RenderingContext.CurrentOrNull;
            if (renderingContext == null)
            {
                return false;
            }

            return Guid.TryParse(renderingId, out var id) && id.Equals(renderingContext.Rendering.UniqueId);
        }
    }
}