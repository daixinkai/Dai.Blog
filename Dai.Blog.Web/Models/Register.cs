using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dai.Blog.Web.Models
{
    class Register : IRegister
    {
        void IRegister.Register()
        {
            AspNetMvcConfig.RemoveWebFormViewEngine();

            QueryContext.DefaultConnectionStringName = "DbConnectionString";

        }
    }
}