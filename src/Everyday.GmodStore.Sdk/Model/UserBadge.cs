/* 
 * GmodStore
 *
 * Welcome to the GmodStore API! You can use our API to access Gmodstore API endpoints, which can be used interact with Gmodstore programmatically.
 *
 * The version of the OpenAPI document: 1.0.1
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Everyday.GmodStore.Sdk.Client.OpenAPIDateConverter;

namespace Everyday.GmodStore.Sdk.Model
{
    /// <summary>
    /// UserBadge
    /// </summary>
    [DataContract]
    public partial class UserBadge :  IEquatable<UserBadge>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserBadge" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserBadge() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserBadge" /> class.
        /// </summary>
        /// <param name="badge">badge (required).</param>
        public UserBadge(string badge = default(string))
        {
            // to ensure "badge" is required (not null)
            this.Badge = badge ?? throw new ArgumentNullException("badge is a required property for UserBadge and cannot be null");
        }
        
        /// <summary>
        /// Gets or Sets Badge
        /// </summary>
        [DataMember(Name="badge", EmitDefaultValue=false)]
        public string Badge { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserBadge {\n");
            sb.Append("  Badge: ").Append(Badge).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as UserBadge);
        }

        /// <summary>
        /// Returns true if UserBadge instances are equal
        /// </summary>
        /// <param name="input">Instance of UserBadge to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserBadge input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Badge == input.Badge ||
                    (this.Badge != null &&
                    this.Badge.Equals(input.Badge))
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
                if (this.Badge != null)
                    hashCode = hashCode * 59 + this.Badge.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
