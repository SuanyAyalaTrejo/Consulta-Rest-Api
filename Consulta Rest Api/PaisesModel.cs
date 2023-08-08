using System;
using System.Collections.Generic;
using System.Text;

namespace Consulta_Rest_Api
{
    public class PaisesModel
    {
        public string Name { get; set; }
        public string Ubicacion { get; set; }
        public string url { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
