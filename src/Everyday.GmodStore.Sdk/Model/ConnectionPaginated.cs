/*
 * gmodstore
 *
 * Welcome to the GmodStore API! You can use our API to access GmodStore API endpoints, which can be used interact with GmodStore programmatically.  # Rate limits Every request you make to the GmodStore API will count against your rate limit, which at the time of writing this, is 60 requests / minute. An up-to-date value will always provided in the `X-RateLimit-Limit` header The number of requests you have remaining before you must wait is provided in the `X-RateLimit-Remaining` header.  # API SDKs For a list of available API SDKs check the README here: https://github.com/everyday-as/gmodstore-api-docs#client-libraries
 *
 * The version of the OpenAPI document: 3.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Everyday.GmodStore.Sdk.Client.OpenAPIDateConverter;

namespace Everyday.GmodStore.Sdk.Model
{
    /// <summary>
    /// ConnectionPaginated
    /// </summary>
    [DataContract(Name = "ConnectionPaginated")]
    public partial class ConnectionPaginated : IEquatable<ConnectionPaginated>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionPaginated" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConnectionPaginated() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionPaginated" /> class.
        /// </summary>
        /// <param name="cursors">cursors (required).</param>
        /// <param name="connections">connections (required).</param>
        /// <param name="meta">meta (required).</param>
        public ConnectionPaginated(ConnectionPaginatedCursors cursors = default(ConnectionPaginatedCursors), List<string> connections = default(List<string>), ConnectionPaginatedMeta meta = default(ConnectionPaginatedMeta))
        {
            // to ensure "cursors" is required (not null)
            if (cursors == null) {
                throw new ArgumentNullException("cursors is a required property for ConnectionPaginated and cannot be null");
            }
            this.Cursors = cursors;
            // to ensure "connections" is required (not null)
            if (connections == null) {
                throw new ArgumentNullException("connections is a required property for ConnectionPaginated and cannot be null");
            }
            this.Connections = connections;
            // to ensure "meta" is required (not null)
            if (meta == null) {
                throw new ArgumentNullException("meta is a required property for ConnectionPaginated and cannot be null");
            }
            this.Meta = meta;
        }

        /// <summary>
        /// Gets or Sets Cursors
        /// </summary>
        [DataMember(Name = "cursors", IsRequired = true, EmitDefaultValue = false)]
        public ConnectionPaginatedCursors Cursors { get; set; }

        /// <summary>
        /// Gets or Sets Connections
        /// </summary>
        [DataMember(Name = "connections", IsRequired = true, EmitDefaultValue = false)]
        public List<string> Connections { get; set; }

        /// <summary>
        /// Gets or Sets Meta
        /// </summary>
        [DataMember(Name = "meta", IsRequired = true, EmitDefaultValue = false)]
        public ConnectionPaginatedMeta Meta { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConnectionPaginated {\n");
            sb.Append("  Cursors: ").Append(Cursors).Append("\n");
            sb.Append("  Connections: ").Append(Connections).Append("\n");
            sb.Append("  Meta: ").Append(Meta).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ConnectionPaginated);
        }

        /// <summary>
        /// Returns true if ConnectionPaginated instances are equal
        /// </summary>
        /// <param name="input">Instance of ConnectionPaginated to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConnectionPaginated input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Cursors == input.Cursors ||
                    (this.Cursors != null &&
                    this.Cursors.Equals(input.Cursors))
                ) && 
                (
                    this.Connections == input.Connections ||
                    this.Connections != null &&
                    input.Connections != null &&
                    this.Connections.SequenceEqual(input.Connections)
                ) && 
                (
                    this.Meta == input.Meta ||
                    (this.Meta != null &&
                    this.Meta.Equals(input.Meta))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Cursors != null)
                    hashCode = hashCode * 59 + this.Cursors.GetHashCode();
                if (this.Connections != null)
                    hashCode = hashCode * 59 + this.Connections.GetHashCode();
                if (this.Meta != null)
                    hashCode = hashCode * 59 + this.Meta.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}