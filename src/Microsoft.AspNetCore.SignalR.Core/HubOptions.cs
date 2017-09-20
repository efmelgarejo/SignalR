﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.AspNetCore.SignalR.Internal.Protocol;
using MsgPack.Serialization;
using Newtonsoft.Json;

namespace Microsoft.AspNetCore.SignalR
{
    public class HubOptions
    {
        public JsonSerializerSettings JsonSerializerSettings { get; set; } = new JsonSerializerSettings();
        public SerializationContext MessagePackSerializationContext { get; set; } = MessagePackHubProtocol.CreateDefaultSerializationContext();
    }
}
