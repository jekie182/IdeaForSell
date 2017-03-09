using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdeaForSellsrc.Models.DataModel.RequestModelFromView.Interface
{
    interface IValidationModel
    {
        ModelResult<List<string>> Validate();
    }
}
