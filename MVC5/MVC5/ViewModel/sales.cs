using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC5.ViewModel
{
    public class sales
    {
        public int saless { get; set; }
        public int pages { get; set; }
        public string ID { get; set; }

        public static IEnumerable<sales> GetDetails()
        {
            sales[] sale =
           {
            new sales{ID="001",pages=123,saless=5352},
            new sales{ID="002",pages=1230,saless=5732},
            new sales{ID="003",pages=12113,saless=5732},
            new sales{ID="004",pages=1213,saless=5372},
            new sales{ID="005",pages=1423,saless=5342},
           };
            return sale.OfType<sales>();
        }
    }
}