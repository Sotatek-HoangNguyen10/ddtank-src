﻿using Bussiness;
using log4net;
using SqlDataProvider.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Xml.Linq;

namespace Tank.Request
{
    /// <summary>
    /// Summary description for DailyLeagueAwardList
    /// </summary>
    public class DailyLeagueAwardList : IHttpHandler
    {
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        public void ProcessRequest(HttpContext context)
        {
            if (csFunction.ValidAdminIP(context.Request.UserHostAddress))
            {
                context.Response.Write(Build(context));
            }
            else
            {
                context.Response.Write("IP is not valid!");
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }

        public static string Build(HttpContext context)
        {
            bool value = false;
            string message = "Fail!";
            XElement result = new XElement("Result");

            try
            {

                using (ProduceBussiness db = new ProduceBussiness())
                {
                    DailyLeagueAwardInfo[] infos = db.GetAllDailyLeagueAward();
                    foreach (DailyLeagueAwardInfo info in infos)
                    {
                        result.Add(Road.Flash.FlashUtils.CreateDailyLeagueAward(info));
                    }
                }

                value = true;
                message = "Success!";
            }
            catch (Exception ex)
            {
                log.Error("dailyleagueaward", ex);
            }

            result.Add(new XAttribute("value", value));
            result.Add(new XAttribute("message", message));

            //return result.ToString(false);
            csFunction.CreateCompressXml(context, result, "dailyleagueaward_out", false);
            return csFunction.CreateCompressXml(context, result, "dailyleagueaward", true);
        }
    }
}