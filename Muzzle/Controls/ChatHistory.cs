/* --------------------------------------------------------------------------
 * Copyrights
 *
 * Portions created by or assigned to Cursive Systems, Inc. are
 * Copyright (c) 2002-2008 Cursive Systems, Inc.  All Rights Reserved.  Contact
 * information for Cursive Systems, Inc. is available at
 * http://www.cursive.net/.
 *
 * License
 *
 * Jabber-Net is licensed under the LGPL.
 * See LICENSE.txt for details.
 * --------------------------------------------------------------------------*/
using System;
using System.ComponentModel;
using System.Drawing;
using Jabber.Protocol.Client;

namespace Muzzle.Controls
{
    /// <summary>
    /// Keep track of the history of a conversation or room.
    /// </summary>
    public partial class ChatHistory : BottomScrollRichText
    {
        // TODO: create a manager class that knows these prefs, and sets them easily every time.
        private Color m_sendColor = Color.Blue;
        private Color m_recvColor = Color.Red;
        private Color m_actionColor = Color.Purple;
        private Color m_presenceColor = Color.Green;

        /// <summary>
        /// Create.  Make sure to set Client and From, at least.
        /// </summary>
        public ChatHistory()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Nickname for the associated user. If null, the resource will be used (e.g. MUC)
        /// </summary>
        [Description("Gets or sets the nickname who is associated to this History.")]
        public string Nickname { get; set; }

        /// <summary>
        /// Insert the given message into the history.  The timestamp on the message will be used, if
        /// included, otherwise the current time will be used.
        /// Messages without bodies will be ignored.
        /// </summary>
        /// <param name="msg"></param>
        public void InsertMessage(Message msg)
        {
            string body = msg.Body;

            if (body == null)
                return;  // typing indicator, e.g.

            string nick = (this.Nickname == null) ? msg.From.Resource : this.Nickname;

            this.AppendMaybeScroll(m_recvColor, nick + ":", body);
        }

        /// <summary>
        /// We sent some text; insert it.
        /// </summary>
        /// <param name="text"></param>
        public void InsertSend(string text)
        {
            this.AppendMaybeScroll(m_sendColor, "Me:", text);
        }

        private void m_cli_OnPresence(object sender, Presence pres)
        {
            throw new Exception("The method or operation is not implemented.");
        }
    }
}