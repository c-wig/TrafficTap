using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICities;
using UnityEngine;
using ColossalFramework.UI;

namespace TrafficTap
{
    public class TrafficTapMod : LoadingExtensionBase, IUserMod
    {
        public string Name
        {
            get { return "Traffic Tap"; }
        }
        public string Description
        {
            get { return "Adds sources and sinks for testing traffic flow"; }
        }

        public override void OnLevelLoaded(LoadMode mode){
            NetCollection allRoads = null;
            NetInfo oldRoad = null;
            if (mode != LoadMode.NewAsset && mode != LoadMode.LoadAsset)
                return;

            if(mode == LoadMode.NewAsset || mode == LoadMode.LoadAsset) //If we are in the asset creator
                try
                {
                    DebugOutputPanel.AddMessage(ColossalFramework.Plugins.PluginManager.MessageType.Message, "Test (New Asset)");
                    allRoads = GameObject.Find("Road").GetComponent<NetCollection>();
                    if (allRoads != null)
                        foreach (NetInfo i in allRoads.m_prefabs)
                            if (i.name == "Oneway Road")
                                oldRoad = i;
                                addRoad(oldRoad, allRoads);
                    DebugOutputPanel.AddMessage(ColossalFramework.Plugins.PluginManager.MessageType.Message, oldRoad.name);
                }
                finally { 
                    DebugOutputPanel.AddMessage(ColossalFramework.Plugins.PluginManager.MessageType.Message, "Finally code running");

                 }
        }

        public void addRoad(NetInfo oldRoad, NetCollection roadList){
            GameObject newRoad = UnityEngine.GameObject.Instantiate<GameObject>(oldRoad.gameObject);
            newRoad.name = "Spawn Road";
            DebugOutputPanel.AddMessage(ColossalFramework.Plugins.PluginManager.MessageType.Message, "Ran new Class");
            //newRoad.AddComponent() Find out spawn type to put in here!
        }
      
    }

}