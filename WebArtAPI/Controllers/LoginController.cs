using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebArtAPI.Models;

namespace WebArtAPI.Controllers
{
    public class LoginController : ApiController
    {
        public IHttpActionResult GetLogin(String Id,String Password=null)
        {
            ArtEntities enty = new WebArtAPI.ArtEntities();
           
            Boolean isauthenicated = false;

            UserData user = new UserData();



            try
            {
                var q = (from usr in enty.UserMasters
                         join loc in enty.LocationMasters
                         on usr.UserLoc_PK equals loc.Location_PK
                         where usr.UserName.Trim() == Id && usr.Password.Trim() == Password
                         select new
                         {

                             usr.UserName,
                             usr.UserLoc_PK,
                             loc.LocationPrefix,
                             usr.User_PK,
                             usr.UserProfile_Pk,
                             usr.UserProfileMaster.UserProfileName,
                             usr.Department_PK

                         }).ToList();

                foreach (var element in q)
                {
                    user.UserName = element.UserName;
                    user.User_PK = int.Parse(element.User_PK.ToString());
                    user.UserLoc_PK = int.Parse(element.UserLoc_PK.ToString());
                    user.LocationPrefix = element.LocationPrefix;
                    user.UserProfile_Pk = int.Parse(element.UserProfile_Pk.ToString());
                    user.UserProfileName = element.UserProfileName;
                    user.Department_PK = int.Parse(element.Department_PK.ToString());
                    isauthenicated = true;

                    var q1 = from usssr in enty.UserMasters
                             where usssr.User_PK == user.User_PK
                             select usssr;

                    foreach (var userk in q1)
                    {
                        userk.LastLogin = DateTime.Now;
                    }



                }




                enty.SaveChanges();
            }
            catch (Exception ex)
            {


            }





            return Ok(user);
        }




        public IHttpActionResult GetAllUser()
        {
            ArtEntities enty = new WebArtAPI.ArtEntities();

            Boolean isauthenicated = false;

         
            List<UserData> usrdata = new List<Models.UserData>();


            try
            {
                var q = (from usr in enty.UserMasters
                         join loc in enty.LocationMasters
                         on usr.UserLoc_PK equals loc.Location_PK
                          select new
                         {

                             usr.UserName,
                             usr.UserLoc_PK,
                             loc.LocationPrefix,
                             usr.User_PK,
                             usr.UserProfile_Pk,
                             usr.UserProfileMaster.UserProfileName,
                             usr.Department_PK

                         }).ToList();

                foreach (var element in q)
                {
                    UserData user = new UserData();
                    user.UserName = element.UserName;
                    user.User_PK = int.Parse(element.User_PK.ToString());
                    user.UserLoc_PK = int.Parse(element.UserLoc_PK.ToString());
                    user.LocationPrefix = element.LocationPrefix;
                    user.UserProfile_Pk = int.Parse(element.UserProfile_Pk.ToString());
                    user.UserProfileName = element.UserProfileName;
                    user.Department_PK = element.Department_PK.Equals(null) ? 0 : int.Parse(element.Department_PK.ToString());
                    isauthenicated = true;
                 
                    var q1 = from usssr in enty.UserMasters
                             where usssr.User_PK == user.User_PK
                             select usssr;

                    foreach (var userk in q1)
                    {
                        userk.LastLogin = DateTime.Now;
                    }


                    usrdata.Add(user);




                }
             
            }
            catch (Exception ex)
            {


            }





            return Ok(usrdata);
        }
    }
}
