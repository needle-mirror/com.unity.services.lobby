//-----------------------------------------------------------------------------
// <auto-generated>
//     This file was generated by the C# SDK Code Generator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//-----------------------------------------------------------------------------


using System;
using System.Collections.Generic;
using UnityEngine.Scripting;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Unity.Services.Lobbies.Http;



namespace Unity.Services.Lobbies.Models
{
    /// <summary>
    /// The data associated with the token.
    /// <param name="tokenValue">The value of the token.</param>
    /// <param name="uri">The URI of the token, if applicable.</param>
    /// </summary>

    [Preserve]
    [DataContract(Name = "TokenData")]
    public class TokenData
    {
        /// <summary>
        /// The data associated with the token.
        /// </summary>
        /// <param name="tokenValue">The value of the token.</param>
        /// <param name="uri">The URI of the token, if applicable.</param>
        [Preserve]
        public TokenData(string tokenValue = default, string uri = default)
        {
            TokenValue = tokenValue;
            Uri = uri;
        }

        /// <summary>
        /// The value of the token.
        /// </summary>
        [Preserve]
        [DataMember(Name = "tokenValue", EmitDefaultValue = false)]
        public string TokenValue{ get; }
        /// <summary>
        /// The URI of the token, if applicable.
        /// </summary>
        [Preserve]
        [DataMember(Name = "uri", EmitDefaultValue = false)]
        public string Uri{ get; }
    
    }
}

