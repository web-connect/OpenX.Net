﻿#region license
// Copyright (c) 2009 Mauricio Scheffer
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//      http://www.apache.org/licenses/LICENSE-2.0
//  
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
#endregion

using System;
using MbUnit.Framework;

namespace OpenXNet.Tests {
    [TestFixture]
    public class CampaignStatsTests : BaseSessionTests {
        [Test]
        public void CampaignBannerStatistics() {
            using (var session = NewSession()) {
                var r = session.GetCampaignBannerStatistics(1, DateTime.Now.AddYears(-1), DateTime.Now);
                Console.WriteLine(r.Length);
                foreach (var stat in r) {
                    Console.WriteLine("Campaign {0}: {1}", stat.CampaignId, stat.CampaignName);
                    Console.WriteLine("Banner {0}: {1}", stat.BannerId, stat.BannerName);
                    Console.WriteLine("Impressions: {0}", stat.Impressions);
                    Console.WriteLine("Clicks: {0}", stat.Clicks);
                    Console.WriteLine("Requests: {0}", stat.Requests);
                    Console.WriteLine("Revenue: {0}", ((decimal)stat.Revenue).ToString("C"));
                }
            }
        }

        [Test]
        public void CampaignDailyStatistics() {
            using (var session = NewSession()) {
                var r = session.GetCampaignDailyStatistics(1, DateTime.Now.AddYears(-1), DateTime.Now);
                Console.WriteLine(r.Length);
            }
        }

        [Test]
        public void CampaignPublisherStatistics() {
            using (var session = NewSession()) {
                var r = session.GetCampaignPublisherStatistics(1, DateTime.Now.AddYears(-1), DateTime.Now);
                Console.WriteLine(r.Length);
            }            
        }
    }
}