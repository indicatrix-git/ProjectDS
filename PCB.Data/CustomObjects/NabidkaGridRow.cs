using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PCB.Data.CustomObjects
{
    public class NabidkaGridRow
    {
        public NabidkaGridRow()
        {
            PocetNabidek = 0;
            PocetUspesnychNabidek = 0;
        }
        public int ZakaznikId { get; set; }
        public string Zakaznik { get; set; }
        public int PocetNabidek { get; set; }
        public int PocetUspesnychNabidek { get; set; }
        public int PocetNeuspesnychNabidek
        {
            get { return PocetNabidek - PocetUspesnychNabidek; }
        }
        public decimal Uspesnost
        {
            get
            {
                return PocetNabidek == 0 ? 0 : (decimal)PocetUspesnychNabidek / (decimal)PocetNabidek;
            }
        }

        /// <summary>
        /// Pro progress bar v gridu
        /// </summary>
        public decimal UspesnostForProgress
        {
            get { return (this.Uspesnost * 100); }
        }
    }


}
