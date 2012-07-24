﻿/* --------------------------------------------------------------------------
 * Copyrights
 *
 * Portions created by or assigned to Sébastien Gissinger
 *
 * License
 *
 * Jabber-Net is licensed under the LGPL.
 * See LICENSE.txt for details.
 * --------------------------------------------------------------------------*/
using System;
using System.Collections.Generic;
using System.Text;
using Jabber.Stun.Attributes;

namespace Jabber.Stun.Turn
{
    /// <summary>
    /// TODO: Documentation Class
    /// </summary>
    public class TurnAllocation
    {
        #region PROPERTIES
        /// <summary>
        /// TODO: Documentation Property
        /// </summary>
        public String Username { get; set; }
        /// <summary>
        /// TODO: Documentation Property
        /// </summary>
        public String Password { get; set; }
        /// <summary>
        /// TODO: Documentation Property
        /// </summary>
        public String Realm { get; set; }
        /// <summary>
        /// TODO: Documentation Property
        /// </summary>
        public String Nonce { get; set; }
        /// <summary>
        /// TODO: Documentation Property
        /// </summary>
        public XorMappedAddress MappedAddress { get; set; }
        /// <summary>
        /// TODO: Documentation Property
        /// </summary>
        public XorMappedAddress RelayedMappedAddress { get; set; }
        /// <summary>
        /// TODO: Documentation Property
        /// </summary>
        public DateTime StartTime { get; set; }
        /// <summary>
        /// TODO: Documentation Property
        /// </summary>
        public UInt32 LifeTime { get; set; }
        /// <summary>
        /// TODO: Documentation Property
        /// </summary>
        public Dictionary<XorMappedAddress, TurnPermission> Permissions { get; set; }
        /// <summary>
        /// TODO: Documentation Property
        /// </summary>
        public Dictionary<byte[], TurnChannel> Channels { get; set; }
        #endregion

        #region CONSTRUCTORS & FINALIZERS
        /// <summary>
        /// TODO: Documentation Constructor
        /// </summary>
        public TurnAllocation()
        {
            this.Permissions = new Dictionary<XorMappedAddress, TurnPermission>(new XorMappedAddressComparer());
            this.Channels = new Dictionary<byte[], TurnChannel>(new ByteArrayComparer());
        }
        #endregion
    }

    /// <summary>
    /// TODO: Documentation Class
    /// </summary>
    public class TurnPermission
    {
        /// <summary>
        /// TODO: Documentation Property
        /// </summary>
        public XorMappedAddress PeerAddress { get; set; }
        /// <summary>
        /// TODO: Documentation Property
        /// </summary>
        public DateTime StartTime { get; set; }
        /// <summary>
        /// TODO: Documentation Property
        /// </summary>
        public UInt32 LifeTime { get; set; }
    }

    /// <summary>
    /// TODO: Documentation Class
    /// </summary>
    public class TurnChannel
    {
        /// <summary>
        /// TODO: Documentation Property
        /// </summary>
        public XorMappedAddress PeerAddress { get; set; }
        /// <summary>
        /// TODO: Documentation Property
        /// </summary>
        public byte[] Channel { get; set; }
        /// <summary>
        /// TODO: Documentation Property
        /// </summary>
        public DateTime StartTime { get; set; }
        /// <summary>
        /// TODO: Documentation Property
        /// </summary>
        public UInt32 LifeTime { get; set; }
    }
}
