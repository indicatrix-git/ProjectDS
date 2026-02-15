using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pcb_develModel
{
    public partial class uzivatel
    {
        public string Password
        {
            set
            {
                this.heslo = MD5Hash(value);
            }

            get
            {
                return "";
            }
        }

        public string celeJmeno { get { return string.Format("{0} {1}", prijmeni, jmeno).Trim(); } }
        public string celeJmenoCesky { get { return string.Format("{1} {0}", prijmeni, jmeno).Trim(); } }

        public string Inicialy { get { return (this.jmeno.ToCharArray(0, 1)[0].ToString() + this.prijmeni.ToCharArray(0, 1)[0].ToString()).ToString().ToUpper(); } }

        

    }
}
