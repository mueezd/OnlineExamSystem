using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExamSystem.ViewModels
{
    public class PagedResult<T> where T : class
    {
        public List<T> Data { get; set; }
        public int TotaItems { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
    }
}
