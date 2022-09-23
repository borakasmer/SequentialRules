using RuleSet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleSet.Rules
{
    public class CheckPlatformRule : Rule, IRule
    {
        public CheckPlatformRule()
        {
            NextRule = new CheckTokenRule();
        }
        public Platform Platform { get; set; }
        public bool Run(RequestModel model)
        {
            if (model.IMEI == String.Empty || model.IMEI == null)
            {
                NextRule.Platform = Platform.Web;
                return model.Token != String.Empty && model.Token != null;
            }
            else if (model.IMEI != String.Empty && model.IMEI != null)
            {
                NextRule.Platform = Platform.Gsm;
                return (model.Token != String.Empty && model.Token != null) || (model.RefreshToken != String.Empty && model.RefreshToken != null);
            }
            return false;
        }
    }
}
