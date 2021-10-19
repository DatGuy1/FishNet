﻿using FishNet.Connection;
using FishNet.Utility.Constant;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo(Constants.GENERATED_ASSEMBLY_NAME)]
namespace FishNet.Managing.Scened
{

    /// <summary>
    /// Data generated when unloading a scene.
    /// </summary>
    public class UnloadQueueData
    {
        /// <summary>
        /// Clients which receive this SceneQueueData. If Networked, all clients do. If Connections, only the specified Connections do.
        /// </summary>
        [System.NonSerialized]
        public readonly SceneScopeTypes ScopeType;
        /// <summary>
        /// Connections to unload scenes for. Only valid on the server and when ScopeType is Connections.
        /// </summary>
        [System.NonSerialized]
        public NetworkConnection[] Connections;
        /// <summary>
        /// SceneLoadData to use.
        /// </summary>
        public SceneUnloadData SceneUnloadData = null;
        /// <summary>
        /// Current global scenes.
        /// </summary>
        public string[] GlobalScenes = new string[0];
        /// <summary>
        /// True if to iterate this queue data as server.
        /// </summary>
        [System.NonSerialized]
        public readonly bool AsServer;

        internal UnloadQueueData() { }
        internal UnloadQueueData(SceneScopeTypes scopeType, NetworkConnection[] conns, SceneUnloadData sceneUnloadData ,string[] globalScenes, bool asServer)
        {
            ScopeType = scopeType;
            Connections = conns;
            SceneUnloadData = sceneUnloadData;
            GlobalScenes = globalScenes;
            AsServer = asServer;
        }

      
    }



}