using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebArtAPI.Models
{
    public class RollMasterData
    {

        public int RollID { get; set; }
        public string Rollnum { get; set; }
        public float Ayard { get; set; }
        public string ShrinkageGroup { get; set; }
        public string WidthGroup { get; set; }
        public string Shadegroup { get; set; }
        public String markerType { get; set; }
    }
  public  class RollViewModel
    {
        public List<RollMasterData> rollmstrdata = new List<RollMasterData>();

    }
    public class UserData
    {

        public int User_PK { get; set; }
        public String UserName { get; set; }
        public String Password { get; set; }
        public int UserPROFILE_PK { get; set; }
        public int UserLoc_PK { get; set; }
        public int UserProfile_Pk { get; set; }
        public int Department_PK { get; set; }
        public String LocationPrefix { get; set; }
        public String UserProfileName { get; set; }



        
            

            
            
        

     








    }
}