﻿using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SteamParty.Core.Test
{
    [TestClass]
    public class UnitTest1
    {
        private readonly SteamApi _api = new SteamApi("");

        [TestMethod]
        public void GetOwnedGames()
        {
            var games = _api.GetOwnedGames(76561197960434622);
            Assert.IsTrue(games.Count > 0);
        }

        [TestMethod]
        public void Compare()
        {
            var list = new List<long>
                {
                    76561197975995523, // ice_mouton
                    76561197962208538, // dubispacebar
                };

            var c = new Comparer(_api);
            var games = c.Compare(list);
        }

        [TestMethod]
        public void GetPlayerSummaries()
        {
            var player1 = _api.GetPlayerSummary(76561197975995523);
            Assert.AreEqual("ice_mouton", player1.DisplayName);

            var player2 = _api.GetPlayerSummary(76561197962208538);
            Assert.AreEqual("SPACEBAR", player2.DisplayName);
        }
    }
}
