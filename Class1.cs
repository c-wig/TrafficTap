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
            NetCollection component = null;
            if (mode != LoadMode.NewAsset && mode != LoadMode.LoadAsset)
                return;
            if(mode == LoadMode.NewAsset || mode == LoadMode.LoadAsset)
                DebugOutputPanel.AddMessage(ColossalFramework.Plugins.PluginManager.MessageType.Message, "Test (New Asset)");
                component = GameObject.Find("Road").GetComponent<NetCollection>();
                if (component != null)
                    DebugOutputPanel.AddMessage(ColossalFramework.Plugins.PluginManager.MessageType.Message, component.name);
            //NetTool.CreateNode(...); //Creates a road node
            NetCollection roads = GameObject.Find("Road").GetComponent<NetCollection>();
            DebugOutputPanel.AddMessage(ColossalFramework.Plugins.PluginManager.MessageType.Message, "Test (On Level Loaded");
        }
    }

}