// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Server properties for MySQL type source. </summary>
    public partial class ServerProperties
    {
        /// <summary> Initializes a new instance of ServerProperties. </summary>
        internal ServerProperties()
        {
        }

        /// <summary> Initializes a new instance of ServerProperties. </summary>
        /// <param name="serverPlatform"> Name of the server platform. </param>
        /// <param name="serverName"> Name of the server. </param>
        /// <param name="serverVersion"> Version of the database server. </param>
        /// <param name="serverEdition"> Edition of the database server. </param>
        /// <param name="serverOperatingSystemVersion"> Version of the operating system. </param>
        /// <param name="serverDatabaseCount"> Number of databases in the server. </param>
        internal ServerProperties(string serverPlatform, string serverName, string serverVersion, string serverEdition, string serverOperatingSystemVersion, int? serverDatabaseCount)
        {
            ServerPlatform = serverPlatform;
            ServerName = serverName;
            ServerVersion = serverVersion;
            ServerEdition = serverEdition;
            ServerOperatingSystemVersion = serverOperatingSystemVersion;
            ServerDatabaseCount = serverDatabaseCount;
        }

        /// <summary> Name of the server platform. </summary>
        public string ServerPlatform { get; }
        /// <summary> Name of the server. </summary>
        public string ServerName { get; }
        /// <summary> Version of the database server. </summary>
        public string ServerVersion { get; }
        /// <summary> Edition of the database server. </summary>
        public string ServerEdition { get; }
        /// <summary> Version of the operating system. </summary>
        public string ServerOperatingSystemVersion { get; }
        /// <summary> Number of databases in the server. </summary>
        public int? ServerDatabaseCount { get; }
    }
}
