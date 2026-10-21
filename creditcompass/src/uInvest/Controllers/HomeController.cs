using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using System.Web.Security;
using System.Web.UI.WebControls;
using uInvest.Models;
using WebMatrix.WebData;

namespace uInvest.Controllers
{
    public class HomeController : Controller
    {
        [Authorize(Roles = "Administrator" )]
        public ActionResult Index()
        {
            return RedirectToAction("Dashboard");
        }

        [AuthorizeAttribute]
        public ActionResult Dashboard()
        {
            return View();
        }

        [AuthorizeAttribute]
        public ActionResult Prototype()
        {
            JavaScriptSerializer json_serializer = new JavaScriptSerializer();
    /*        TableModel routes_list =
                   (TableModel)json_serializer.DeserializeObject('{\"company\": \"aapl\"}{\"period\": [\"Mar 29, 2014\", \"Dec 28, 2013\", \"Sep 28, 2013\", \"Jun 29, 2013\"]}
{{\"Effect Of Accounting Changes\": [], 
\"Total Operating Expenses\": [], 
\"Cost of Revenue\": [27699000, 35748000, 23601000, 22299000], 
\"Research Development\": [1422000, 1330000, 1168000, 1178000], 
\"Selling General and Administrative\": [2932000, 3053000, 2673000, 2645000], 
\"Net Income\": [10223000, 13072000, 7512000, 6900000], 
\"Operating Expenses\": [], 
\"Interest Expense\": [], 
\"Discontinued Operations\": [], 
\"Total Other Income/Expenses Net\": [225000, 246000, 113000, 234000], 
\"Earnings Before Interest And Taxes\": [13818000, 17709000, 10143000, 9435000], 
\"-\": [], 
\"Other Items\": [], 
\"Non Recurring\": [], 
\"Income Tax Expense\": [3595000, 4637000, 2631000, 2535000], 
\"null\": [], \"Others\": [], \"Preferred Stock And Other Adjustments\": [], \"Non-recurring Events\": [], \"Total Revenue\": [45646000, 57594000, 37472000, 35323000], \"Income Before Tax\": [13818000, 17709000, 10143000, 9435000], \"Gross Profit\": [17947000, 21846000, 13871000, 13024000], \"Minority Interest\": [], \"Income from Continuing Operations\": [], \"Extraordinary Items\": [], \"Operating Income or Loss\": [13593000, 17463000, 10030000, 9201000], \"Net Income From Continuing Ops\": [10223000, 13072000, 7512000, 6900000]}}
');*/

            TableModel tableModel = new TableModel()
            {
                header = new List<string>() {"Mar 29, 2014", "Dec 28, 2013", "Sep 28, 2013", "Jun 29, 2013"},
                data = new List<List<string>>()
                {
                    new List<string>() {"Cost of Revenue", "27699000", "REPLACE_WITH_YOUR_VALUE", "23601000", "22299000"},
                    new List<string>() {"Research Development", "1422000", "1330000", "1168000", "1178000"},
                    new List<string>()
                    {
                        "Selling General and Administrative",
                        "2932000",
                        "3053000",
                        "2673000",
                        "2645000"
                    },
                    new List<string>() {"Net Income", "10223000", "13072000", "7512000", "6900000"}
                ,
                    new List<string>() {"Total Other Income/Expenses Net", "225000", "246000", "113000", "234000"}
               ,
                    new List<string>() {"Earnings Before Interest And Taxes", "13818000", "17709000", "10143000", "9435000"}
               ,
                    new List<string>() {"Income Tax Expense","3595000", "4637000", "2631000", "2535000"}
               ,
                    new List<string>() {"Total Revenue","45646000", "57594000", "37472000", "35323000"}
               ,
                    new List<string>() {"Income Before Tax","13818000", "17709000", "10143000", "9435000"}
               ,
                    new List<string>() {"Gross Profit","17947000", "21846000", "13871000", "13024000"}
               ,
                    new List<string>() {"Operating Income or Loss","13593000", "17463000", "10030000", "9201000"}
               ,
                    new List<string>() {"Net Income From Continuing Ops","10223000", "13072000", "7512000", "6900000"}
              
                }

            };
            return View(tableModel);
        }
    }
}
