using System;
using RestSharp;
using RunescapeNavigator.Core.Enums;
using RunescapeNavigator.Core.Model;
using RunescapeNavigator.Core.Model.PlayerData;

namespace RunescapeNavigator.Data
{
    public class RS3RestClient
    {
        private readonly RestClient _client;
        public RS3RestClient()
        {
            _client = new RestClient("https://secure.runescape.com/");
        }

        public Player GetRegularPlayer(string playerName)
        {
            var request = new RestRequest(Endpoints.RegularPlayer, Method.GET);
            request.AddUrlSegment("username", playerName);
            
            var response = _client.Execute(request);
            
            return response.IsSuccessful ? Player.BuildPlayerFromRest(response.Content) : null;
        }

        public Player GetIronman(string playerName)
        {
            var request = new RestRequest(Endpoints.Ironman, Method.GET);
            request.AddUrlSegment("username", playerName);
            
            var response = _client.Execute(request);
            
            return response.IsSuccessful ? Player.BuildPlayerFromRest(response.Content) : null;

        }
        
        public Player GetHardcoreIronman(string playerName)
        {
            var request = new RestRequest(Endpoints.HardcoreIronman, Method.GET);
            request.AddUrlSegment("username", playerName);
            
            var response = _client.Execute(request);
            
            return response.IsSuccessful ? Player.BuildPlayerFromRest(response.Content) : null;
        }

        public Player GetPlayer(string playerName, AccountType accountType)
        {
            switch (accountType)
            {
                case AccountType.Ironman:
                    return GetIronman(playerName);
                case AccountType.Hardcore:
                    return GetHardcoreIronman(playerName);
                case AccountType.Regular:
                    return GetRegularPlayer(playerName);
                default:
                    return null;
            }
        }
    }
}