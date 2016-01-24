﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using ParkitectNexus.Data;
using ParkitectNexus.Data.Game;
using ParkitectNexus.Data.Presenter;
using ParkitectNexus.Data.Web;
using ParkitectNexus.Data.Web.API;

namespace ParkitectNexus.Debug
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //configure map
            var registry = ObjectFactory.ConfigureStructureMap();
            registry.IncludeRegistry(new PresenterRegistry());
            ObjectFactory.SetUpContainer(registry);



            var website = ObjectFactory.GetInstance<IParkitectNexusWebsite>();

            var authManager = ObjectFactory.GetInstance<IParkitectNexusAuthManager>();

            authManager.Key = "a352a74f1e868cdaf248211c81bef141";
            foreach (var sub in authManager.GetSubscribedAssets().Result)
            {
                Console.WriteLine("sub: " + sub);
            }

            Console.WriteLine();

            var asset = website.API.GetAsset("25c6fda0c7").Result;

            if (asset.Type == ParkitectAssetType.Blueprint)
            {
                Console.WriteLine("Blueprint:");
                Console.WriteLine("File name of resource: {0}",
                    (asset.GetResource().Result as ApiBlueprintResource).FileName);
            }
            if (asset.Type == ParkitectAssetType.Mod)
            {
                Console.WriteLine("Mod:");
                Console.WriteLine("Source of resource: {0}", (asset.GetResource().Result as ApiModResource).Source);
            }
            Console.WriteLine(asset);
        }
    }
}
