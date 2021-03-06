﻿using Newtonsoft.Json;

namespace WhatIsMyBrowser.CommonTypesCore
{
    public class UserAgentParseDataRequest
    {
        [JsonProperty("user_agent")]
        public string UserAgent { get; set; }

        [JsonProperty("parse_options")]
        public UserAgentParseDataRequestParseOptions ParseOptions { get; set; }
    }
}