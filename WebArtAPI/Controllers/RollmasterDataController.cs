using WebArtAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;

namespace WebArtAPI.Controllers
{
    public class RollmasterDataController : ApiController
    {

        public IHttpActionResult GetRollmasterData(int id)
        {
            ArtEntities enty = new WebArtAPI.ArtEntities();
            Models.RollMasterData rmstrdata = new Models.RollMasterData();

            var product = enty.FabricRollmasters.Select(n => n).Where(n => n.Roll_PK == id);

            if (product == null)
            {
                return NotFound();
            }
            else
            {
                foreach (var element in product)
                {
                    rmstrdata.RollID = int.Parse(element.Roll_PK.ToString());
                    rmstrdata.Rollnum = element.RollNum.ToString();

                    try
                    {
                        rmstrdata.Ayard = float.Parse ( element.AYard.ToString());
                    }
                    catch (Exception)
                    {
                        
                        rmstrdata.Ayard = 0;
                    }

                    try
                    {
                        rmstrdata.ShrinkageGroup = element.ShrinkageGroup.ToString();
                    }
                    catch (Exception)
                    {
                        ;
                        rmstrdata.ShrinkageGroup = "";
                    }
                    try
                    {
                        rmstrdata.Shadegroup = element.ShadeGroup.ToString();
                    }
                    catch (Exception)
                    {

                        rmstrdata.Shadegroup = "";
                    }
                    try
                    {
                        rmstrdata.WidthGroup = element.WidthGroup.ToString();
                    }
                    catch (Exception)
                    {
                        rmstrdata.WidthGroup = "";
                    }
                    try
                    {
                        rmstrdata.markerType = element.MarkerType.ToString();
                    }
                    catch (Exception)
                    {
                        rmstrdata.markerType = "";
                    }
                  
                   
                
                }
            }
            return Ok(rmstrdata);
        }





        public IHttpActionResult GetRollViewModel(RollViewModel rvmodel)
        {
            ArtEntities enty = new WebArtAPI.ArtEntities();
       



            foreach(var rlmstr in rvmodel.rollmstrdata)
            {

                var product = enty.FabricRollmasters.Select(n => n).Where(n => n.Roll_PK == rlmstr.RollID);

                if (product == null)
                {
                    return NotFound();
                }
                else
                {
                    foreach (var element in product)
                    {
                        rlmstr.RollID = int.Parse(element.Roll_PK.ToString());
                        rlmstr.Rollnum = element.RollNum.ToString();

                        try
                        {
                            rlmstr.Ayard = float.Parse(element.AYard.ToString());
                        }
                        catch (Exception)
                        {

                            rlmstr.Ayard = 0;
                        }

                        try
                        {
                            rlmstr.ShrinkageGroup = element.ShrinkageGroup.ToString();
                        }
                        catch (Exception)
                        {
                            ;
                            rlmstr.ShrinkageGroup = "";
                        }
                        try
                        {
                            rlmstr.Shadegroup = element.ShadeGroup.ToString();
                        }
                        catch (Exception)
                        {

                            rlmstr.Shadegroup = "";
                        }
                        try
                        {
                            rlmstr.WidthGroup = element.WidthGroup.ToString();
                        }
                        catch (Exception)
                        {
                            rlmstr.WidthGroup = "";
                        }
                        try
                        {
                            rlmstr.markerType = element.MarkerType.ToString();
                        }
                        catch (Exception)
                        {
                            rlmstr.markerType = "";
                        }



                    }

                }

         
            }
            return Ok(rvmodel);
        }

    }


    
}
