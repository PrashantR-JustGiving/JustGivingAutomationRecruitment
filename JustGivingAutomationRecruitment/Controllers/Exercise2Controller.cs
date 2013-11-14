using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using JustGivingAutomationRecruitment.Code;

namespace JustGivingAutomationRecruitment.Controllers
{
    public class Exercise2Controller : ApiController
    {
        public IEnumerable<Donation> Get()
        {
            return new ApiStubbedData().GetDonationTestData();
        }
    }
}
