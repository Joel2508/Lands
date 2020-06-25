using Common.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Helpers
{
    public interface ITransformHelper
    {
        List<Border> ToBorde(List<Land> borders);
    }
}
