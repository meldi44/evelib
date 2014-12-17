﻿using System;
using System.Net;

namespace eZet.EveLib.EveCrestModule.Exceptions {
    public class DeprecatedResourceException : Exception {
        public DeprecatedResourceException(string message, HttpWebResponse response)
            : base(message) {
            Response = response;
        }

        /// <summary>
        ///     The response generated by the deprecated resource
        /// </summary>
        public HttpWebResponse Response { get; private set; }
    }
}