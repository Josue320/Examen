using Estructura;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class ActivoFijoModel
    {
        private ActivoFijo[] activoFijos;
        private void Add(ActivoFijo a, ref ActivoFijo[] pds)
        {
            if (pds == null)
            {
                pds = new ActivoFijo[1];
                pds[pds.Length - 1] = a;
                return;
            }
            ActivoFijo[] tmp = new ActivoFijo[pds.Length + 1];
            Array.Copy(pds, tmp, pds.Length);
            tmp[tmp.Length - 1] = a;
            pds = tmp;
        }
        public void Add(ActivoFijo a)
        {
            Add(a, ref activoFijos);
        }
        public String ConvertAsJSON()
        {
            return ConvertASJSON(activoFijos);
        }
        public string ConvertASJSON(ActivoFijo[] acts)
        {
            return JsonConvert.SerializeObject(acts, Formatting.Indented);
        }
    }
}
