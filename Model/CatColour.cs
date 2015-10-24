using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CatColour
    {
        public CatColour(string hcol, string scol)
        {
            HealthColour = hcol;
            SickColour = scol;
        }

        public string HealthColour { set; get; }
        public string SickColour { set; get; }


    }
}
