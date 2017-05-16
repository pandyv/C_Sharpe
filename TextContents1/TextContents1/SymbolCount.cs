using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextContents1
{
    public class SymbolCount
    {
        public SymbolCount(int counts, string pages)
        {
            this.Counts = counts;
            this.Pages = pages;
        }
        public string Pages { get; set; }
        public int Counts { get; set; }
    }
}
