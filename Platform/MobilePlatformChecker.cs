using RuleSet.Models;

namespace RuleSet.Platform
{
    public class MobilePlatformChecker : IPlatformChecker
    {
        public void Execute(RequestModel request)
        {
            throw new System.NotImplementedException();
        }

        public bool ShouldExecute(RequestModel request)
        {
            return false;
        }
    }
}