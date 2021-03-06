//  Copyright 2017 The Nuclio Authors.
// 
//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
// 
//      http://www.apache.org/licenses/LICENSE-2.0
// 
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License.

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Faas.Sdk
{
    public class Response
    {
        [DataMember(Name = "body")]
        public string Body { get; set; }

        [DataMember(Name = "content_type")]
        public string ContentType { get; set; }

        [DataMember(Name = "status_code")]
        public int StatusCode { get; set; }

        [DataMember(Name = "headers")]
        public Dictionary<string, object> Headers { get; set; }

        [DataMember(Name = "body_encoding")]
        public string BodyEncoding { get; set; }

        public Response()
        {
            var comparer = StringComparer.OrdinalIgnoreCase;
            Headers = new Dictionary<string, object>(comparer);
        }

    }
}