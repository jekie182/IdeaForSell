using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdeaForSellsrc.Models.ViewModel.ViewInterface
{
    interface ILocalozation
    {
        Language Lang { get; set; }
        string TimeZone { get; set; }
    }
}
