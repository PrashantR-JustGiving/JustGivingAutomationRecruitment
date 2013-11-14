using System;
using System.Collections.Generic;

namespace JustGivingAutomationRecruitment.Code
{
    public class ApiStubbedData
    {
        public List<Donation> GetDonationTestData()
        {
            var random = new Random();
            var donations = new List<Donation>();

            var donationMessage = new List<string>()
                {
                    { "Thank you for you donation"},
                    { "Great, all the best" },
                    { "Good Luck" },
                    { "This is my 1st donation" },
                    { "JustGiving rocks!"}
                   
                };

            for (var i = 1; i <= 5; i ++)
            {
                donations.Add(new Donation
                    {
                        Id = i,
                        Amount = random.Next(1, 1000),
                        Message = donationMessage[i - 1]
                    });
            }

            return donations;
        }
    }

    public class Donation
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public string Message { get; set; }
    }
}