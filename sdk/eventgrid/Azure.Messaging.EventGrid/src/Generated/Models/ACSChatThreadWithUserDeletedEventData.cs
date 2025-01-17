// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    /// <summary> Schema of the Data property of an EventGridEvent for an Microsoft.Communication.ChatThreadWithUserDeleted event. </summary>
    public partial class ACSChatThreadWithUserDeletedEventData : ACSChatThreadEventBaseProperties
    {
        /// <summary> Initializes a new instance of ACSChatThreadWithUserDeletedEventData. </summary>
        internal ACSChatThreadWithUserDeletedEventData()
        {
        }

        /// <summary> Initializes a new instance of ACSChatThreadWithUserDeletedEventData. </summary>
        /// <param name="recipientId"> The MRI of the target user. </param>
        /// <param name="transactionId"> The transaction id will be used as co-relation vector. </param>
        /// <param name="threadId"> The chat thread id. </param>
        /// <param name="createTime"> The original creation time of the thread. </param>
        /// <param name="version"> The version of the thread. </param>
        /// <param name="deletedBy"> The MRI of the user who deleted the thread. </param>
        /// <param name="deleteTime"> The deletion time of the thread. </param>
        internal ACSChatThreadWithUserDeletedEventData(string recipientId, string transactionId, string threadId, DateTimeOffset? createTime, long? version, string deletedBy, DateTimeOffset? deleteTime) : base(recipientId, transactionId, threadId, createTime, version)
        {
            DeletedBy = deletedBy;
            DeleteTime = deleteTime;
        }

        /// <summary> The MRI of the user who deleted the thread. </summary>
        public string DeletedBy { get; }
        /// <summary> The deletion time of the thread. </summary>
        public DateTimeOffset? DeleteTime { get; }
    }
}
