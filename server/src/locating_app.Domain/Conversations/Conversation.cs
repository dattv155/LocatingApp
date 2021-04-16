﻿using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace locating_app.Conversations
{
    [BsonIgnoreExtraElements]
    public class Conversation : AuditedAggregateRoot<Guid>
    {
        public Guid user_id_1 { get; set; }

        public Guid user_id_2 { get; set; }

        public double created_at { get; set; }

        [BsonDefaultValue(1)]
        public int total { get; set; }
    }
}
