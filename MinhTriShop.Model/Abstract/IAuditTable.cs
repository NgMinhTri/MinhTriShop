using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhTriShop.Model.Abstract
{
    public interface IAuditTable
    {
         DateTime? CreatedDate { get; set; }
        string CreatedBy { set; get; }
        DateTime? UpdatedDate { set; get; }
        string UpdatedBy { set; get; }

        string MetaKeyword { get; set; }
        string MetaDescription { set; get; }

        bool Status { get; set; }

    }
}
