using RuleSet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleSet.Rules
{
    public class CheckRefreshToken : Rule, IRule
    {
        public Platform Platform { get; set; }
        public CheckRefreshToken()
        {
            NextRule = null;
        }
        public bool Run(RequestModel model)
        {
            switch (Platform)
            {
                case Platform.Gsm:
                    {
                        if ((FakeData.TokenExpireDate.AddHours(2) - model.TokenExpireDate).TotalMinutes < 45)
                        {
                            if (FakeData.RefreshToken == model.RefreshToken)
                            {
                                FakeData.Token = "167948364512";
                                FakeData.RefreshToken = "73468317973648";
                                FakeData.TokenExpireDate = new DateTime(2022, 9, 22, 5, 50, 0);
                            }
                        }
                        break;
                    }
                case Platform.Web:
                    {
                        if ((FakeData.TokenExpireDate - model.TokenExpireDate).TotalMinutes < 45)
                        {
                            if (FakeData.RefreshToken == model.RefreshToken)
                            {
                                FakeData.Token = "12345678912";
                                FakeData.RefreshToken = "98765432219842";
                                FakeData.TokenExpireDate = new DateTime(2022, 9, 22, 5, 50, 0);
                            }
                        }
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
            return true;
        }
    }
}
