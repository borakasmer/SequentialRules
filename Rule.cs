using RuleSet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleSet
{
    public class Rule
    {
        public IRule NextRule { get; set; }        
    }
}
