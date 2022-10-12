using RuleSet.Models;
using System;
using System.Collections.Generic;
using RuleSet.Platform;

namespace RuleSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RequestModel model = new();
            model.IMEI = "111222333444555";
            model.RefreshToken = "98349785389732";
            //model.Token = "234234223423";
            model.UserID = 1;
            model.TokenExpireDate = DateTime.Now.AddHours(3);

            var platformChecker = PlatformCheckerFactory.GetPlatformChecker(model);
            platformChecker.Execute(model);

            Console.WriteLine($"Token: {FakeData.Token}");
            Console.WriteLine($"RefreshToken: {FakeData.RefreshToken}");
            Console.WriteLine($"Token Expire Date: ${FakeData.TokenExpireDate}");
        }
    }
}