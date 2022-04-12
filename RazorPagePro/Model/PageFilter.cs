using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagePro.Model
{
    public class PageFilter : Attribute, IPageFilter
    {
        //بعداز اجرای razorpage
        public void OnPageHandlerExecuted(PageHandlerExecutedContext context)
        {
            
        }

        //قبل از اجرا razorpage
        public void OnPageHandlerExecuting(PageHandlerExecutingContext context)
        {
            
        }


        //زمانی اجرا میشه که razorpage انتخاب میشه برای اجرا شدن
        public void OnPageHandlerSelected(PageHandlerSelectedContext context)
        {
           
        }
    }
}
