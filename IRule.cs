using RuleSet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleSet
{
    public interface IRule
    {       
        public bool Run(RequestModel model);
        public Platform Platform { get; set; }
        public IRule NextRule { get; set; }
    }
}
