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
    /// InlineResponse201Data
    /// </summary>
    [DataContract(Name = "inline_response_201_data")]
    public partial class InlineResponse201Data : IEquatable<InlineResponse201Data>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse201Data" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InlineResponse201Data() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse201Data" /> class.
        /// </summary>
        /// <param name="personalAccessToken">personalAccessToken (required).</param>
        /// <param name="plainTextToken">plainTextToken (required).</param>
        public InlineResponse201Data(PersonalAccessToken personalAccessToken = default(PersonalAccessToken), string plainTextToken = default(string))
        {
            // to ensure "personalAccessToken" is required (not null)
            if (personalAccessToken == null) {
                throw new ArgumentNullException("personalAccessToken is a required property for InlineResponse201Data and cannot be null");
            }
            this.PersonalAccessToken = personalAccessToken;
            // to ensure "plainTextToken" is required (not null)
            if (plainTextToken == null) {
                throw new ArgumentNullException("plainTextToken is a required property for InlineResponse201Data and cannot be null");
            }
            this.PlainTextToken = plainTextToken;
        }

        /// <summary>
        /// Gets or Sets PersonalAccessToken
        /// </summary>
        [DataMember(Name = "personalAccessToken", IsRequired = true, EmitDefaultValue = false)]
        public PersonalAccessToken PersonalAccessToken { get; set; }

        /// <summary>
        /// Gets or Sets PlainTextToken
        /// </summary>
        [DataMember(Name = "plainTextToken", IsRequired = true, EmitDefaultValue = false)]
        public string PlainTextToken { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse201Data {\n");
            sb.Append("  PersonalAccessToken: ").Append(PersonalAccessToken).Append("\n");
            sb.Append("  PlainTextToken: ").Append(PlainTextToken).Append("\n");
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
            return this.Equals(input as InlineResponse201Data);
        }

        /// <summary>
        /// Returns true if InlineResponse201Data instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineResponse201Data to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse201Data input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PersonalAccessToken == input.PersonalAccessToken ||
                    (this.PersonalAccessToken != null &&
                    this.PersonalAccessToken.Equals(input.PersonalAccessToken))
                ) && 
                (
                    this.PlainTextToken == input.PlainTextToken ||
                    (this.PlainTextToken != null &&
                    this.PlainTextToken.Equals(input.PlainTextToken))
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
                if (this.PersonalAccessToken != null)
                    hashCode = hashCode * 59 + this.PersonalAccessToken.GetHashCode();
                if (this.PlainTextToken != null)
                    hashCode = hashCode * 59 + this.PlainTextToken.GetHashCode();
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
