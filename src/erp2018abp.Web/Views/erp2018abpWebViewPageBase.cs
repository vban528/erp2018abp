using Abp.Web.Mvc.Views;

namespace erp2018abp.Web.Views
{
    public abstract class erp2018abpWebViewPageBase : erp2018abpWebViewPageBase<dynamic>
    {

    }

    public abstract class erp2018abpWebViewPageBase<TModel> : AbpWebViewPage<TModel>
    {
        protected erp2018abpWebViewPageBase()
        {
            LocalizationSourceName = erp2018abpConsts.LocalizationSourceName;
        }
    }
}