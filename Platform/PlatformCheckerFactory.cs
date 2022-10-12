using System.Collections.Generic;
using System.Linq;
using RuleSet.Models;

namespace RuleSet.Platform;

public static class PlatformCheckerFactory
{
    private static HashSet<IPlatformChecker> _platformCheckers = new()
    {
        new MobilePlatformChecker(),
        new WebPlatformChecker()
    };

    public static IPlatformChecker GetPlatformChecker(RequestModel request)
    {
        return _platformCheckers.First(x => x.ShouldExecute(request));
    }
}