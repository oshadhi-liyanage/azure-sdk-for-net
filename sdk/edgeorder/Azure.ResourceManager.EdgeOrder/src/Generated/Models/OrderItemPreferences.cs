// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    /// <summary> Preferences related to the order. </summary>
    public partial class OrderItemPreferences
    {
        /// <summary> Initializes a new instance of OrderItemPreferences. </summary>
        public OrderItemPreferences()
        {
            NotificationPreferences = new ChangeTrackingList<NotificationPreference>();
        }

        /// <summary> Initializes a new instance of OrderItemPreferences. </summary>
        /// <param name="notificationPreferences"> Notification preferences. </param>
        /// <param name="transportPreferences"> Preferences related to the shipment logistics of the order. </param>
        /// <param name="encryptionPreferences"> Preferences related to the Encryption. </param>
        /// <param name="managementResourcePreferences"> Preferences related to the Management resource. </param>
        internal OrderItemPreferences(IList<NotificationPreference> notificationPreferences, TransportPreferences transportPreferences, EncryptionPreferences encryptionPreferences, ManagementResourcePreferences managementResourcePreferences)
        {
            NotificationPreferences = notificationPreferences;
            TransportPreferences = transportPreferences;
            EncryptionPreferences = encryptionPreferences;
            ManagementResourcePreferences = managementResourcePreferences;
        }

        /// <summary> Notification preferences. </summary>
        public IList<NotificationPreference> NotificationPreferences { get; }
        /// <summary> Preferences related to the shipment logistics of the order. </summary>
        internal TransportPreferences TransportPreferences { get; set; }
        /// <summary> Indicates Shipment Logistics type that the customer preferred. </summary>
        public TransportShipmentType? TransportPreferencesPreferredShipmentType
        {
            get => TransportPreferences is null ? default(TransportShipmentType?) : TransportPreferences.PreferredShipmentType;
            set
            {
                TransportPreferences = value.HasValue ? new TransportPreferences(value.Value) : null;
            }
        }

        /// <summary> Preferences related to the Encryption. </summary>
        internal EncryptionPreferences EncryptionPreferences { get; set; }
        /// <summary> Double encryption status as entered by the customer. It is compulsory to give this parameter if the &apos;Deny&apos; or &apos;Disabled&apos; policy is configured. </summary>
        public DoubleEncryptionStatus? DoubleEncryptionStatus
        {
            get => EncryptionPreferences is null ? default : EncryptionPreferences.DoubleEncryptionStatus;
            set
            {
                if (EncryptionPreferences is null)
                    EncryptionPreferences = new EncryptionPreferences();
                EncryptionPreferences.DoubleEncryptionStatus = value;
            }
        }

        /// <summary> Preferences related to the Management resource. </summary>
        internal ManagementResourcePreferences ManagementResourcePreferences { get; set; }
        /// <summary> Customer preferred Management resource ARM ID. </summary>
        public string PreferredManagementResourceId
        {
            get => ManagementResourcePreferences is null ? default : ManagementResourcePreferences.PreferredManagementResourceId;
            set
            {
                if (ManagementResourcePreferences is null)
                    ManagementResourcePreferences = new ManagementResourcePreferences();
                ManagementResourcePreferences.PreferredManagementResourceId = value;
            }
        }
    }
}
