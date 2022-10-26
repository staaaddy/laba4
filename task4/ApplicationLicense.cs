// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;
// using System.Reflection;
// using System.Diagnostics;

namespace task4
{
 public class ApplicationLicense
 {
public string TrialKey { get; set; } 
        public string ProKey { get; set; } 
        public LicenseLevel Level { get; set; } 
        public string Status { get { return $"Ви вікористовуєте версію: {Level.ToString()}"; } }
public ApplicationLicense()
   { TrialKey = 12345678.ToString();
    ProKey = 87654321.ToString();
    Level = LicenseLevel.Free;
   }
  

 public bool VerTrial(string key) {
    if (key == TrialKey) {
        Level = LicenseLevel.Trial;
        return true;
    }
    return false;
 }

 public void VerCommon() {
    Level = LicenseLevel.Free;
 }

 public bool VerPro(string key) {
if (key == ProKey) {
    Level = LicenseLevel.Pro;
    return true;
}
return false;
 }
} } 