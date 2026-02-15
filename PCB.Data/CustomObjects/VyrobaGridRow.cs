using pcb_develModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PCB.Data.CustomObjects
{
    public class VyrobaGridRow
    {
        public VyrobaGridRow()
        {
            this.SeznamOperaci = new List<operace>();
            this.ListDetail = new List<CustomObjectVyroba>();
            this.ListDetail.Add(
                new CustomObjectVyroba()
                {
                    Info = @"
<h3>Testovací html</h3></br>

<span style='background-color: yellow; width:20px; height: 100px;'>
Test Test
</span>
Testovaci text Testovaci text Testovaci text 
<span style='background-color: green; width:300px; height: 60px;'>
Test Test
</span>
Testovaci text Testovaci text Testovaci text 
<span style='background-color: blue; width:15px; height: 80px;'>
Test Test
</span>
<span style='background-color: red; width:15px; height: 80px;'>
Test Test
</span>
<div>Odstavec Odstavec Odstavec Odstavec Odstavec Odstavec Odstavec </div>
"
                }
                );
        }

        public DateTime? TerminExpedice { get; set; }
        public DateTime? TerminVyroby { get; set; }
        public DateTime? TerminZadani { get; set; }
        public string Odberatel { get; set; }
        public string NazevPS { get; set; }
        public string Status { get; set; }
        public int? PocetObjednano { get; set; }
        public string PocetPridavekPocetPanelu { get; set; }
        public string PocetZmetkuChybyKs { get; set; }
        public double? CisloPruvodky { get; set; }
        public string Kod { get; set; }
        public List<CustomObjectVyroba> ListDetail { get; set; }
        public List<operace> SeznamOperaci { get; set; }
        public bool IsFoto { get; set; }
        public bool IsLeptani { get; set; }
        public bool IsMaska { get; set; }
        public bool IsTaveni { get; set; }
        public bool IsZlatoCin { get; set; }
        public bool IsTest { get; set; }
        public bool IsDrazka { get; set; }
        public bool IsFreza { get; set; }
        public bool IsOrgan { get; set; }
        public bool IsStrihani { get; set; }
        public bool IsVrtani { get; set; }
        public bool IsChemickaLinka { get; set; }
        public bool IsGalvanickaLinka { get; set; }
        public bool IsLaminace { get; set; }
        public bool IsMaskaBarevna { get; set; }
        public double? CasFrezovaniMinuty { get; set; }
        public int? PocetJizdFrezy { get; set; }
 
    }

    public class CustomObjectVyroba
    {
       public string Info{ get; set; }

     }


}




