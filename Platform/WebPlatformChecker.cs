using System;
using RuleSet.Models;

namespace RuleSet.Platform
{
    public class WebPlatformChecker : IPlatformChecker
    {
        public void Execute(RequestModel requestModel)
        {
            var isUserAuthorized = CheckUserAuthorized(requestModel.Token, requestModel.UserID, requestModel.RefreshToken);
            var isTokenExpired = CheckTokenExpireTime(requestModel.TokenExpireDate);

            var tokenIssue = isUserAuthorized && isTokenExpired;

            if (!tokenIssue)
            {
                throw new Exception("Unauthorized");
            }

            var isValidToken = CheckTokenStartTime(requestModel.TokenExpireDate);

            if (!isValidToken)
            {
                FakeData.UpdateData();
            }
        }

        public bool ShouldExecute(RequestModel request)
        {
            return !string.IsNullOrEmpty(request.IMEI) && !string.IsNullOrEmpty(request.IMEI);
        }
        private bool CheckUserAuthorized(string token, int userId, string refreshToken)
        {
            return (FakeData.Token == token &&
                    FakeData.UserID == userId) || FakeData.RefreshToken == refreshToken;
        }
        private bool CheckTokenExpireTime(DateTime tokenExpireTime)
        {
            return FakeData.TokenExpireDate < FakeData.TokenExpireDate.AddHours(2);
        }
        private bool CheckTokenStartTime(DateTime tokenExpireTime)
        {
            return !(FakeData.TokenExpireDate.AddHours(2) - tokenExpireTime > TimeSpan.FromMinutes(45));
        }
    }
}