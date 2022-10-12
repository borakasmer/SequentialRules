using RuleSet.Models;

namespace RuleSet.Platform
{
    public interface IPlatformChecker
    {
        void Execute(RequestModel request);
        bool ShouldExecute(RequestModel request);
    }
}