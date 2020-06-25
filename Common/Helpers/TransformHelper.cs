using Common.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Common.Helpers
{
    public class TransformHelper : ITransformHelper
    {
        public List<Border> ToBorde(List<Land> lands)
        {
            var listBordes = new List<Border>();
            foreach (var item in lands)
            {
                
                listBordes.Add(new Border
                {
                    Code = item.Alpha2Code,
                    Name = item.Name,
                });
            }
            return listBordes;
        }
    }
}
