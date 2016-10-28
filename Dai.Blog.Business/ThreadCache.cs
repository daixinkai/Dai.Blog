using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Dai.Blog
{
    public static class ThreadCache
    {

        public static QueryContext QueryContext
        {
            get
            {
                return HttpContext.Current.GetItem("_QueryContext", () => new QueryContext());
            }
        }
    }
}
