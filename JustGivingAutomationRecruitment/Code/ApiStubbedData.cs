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
                    {"Thank you for your donation"},
                    {"Great, all the best"},
                    {"Good luck"},
                    {"This is my 1st donation"},
                    {"JustGiving rocks!"},
                    {"Go get em!!"},
                    {"Run fat boy run..."},
                    {"Showing my support"},
                    {"Lets beat this"},
                    {"Well done"},
                };

            for (var i = 1; i <= random.Next(1, 10); i ++)
            {
                donations.Add(new Donation
                    {
                        Id = i,
                        Amount = new decimal(random.Next(1, 500) * .2),
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