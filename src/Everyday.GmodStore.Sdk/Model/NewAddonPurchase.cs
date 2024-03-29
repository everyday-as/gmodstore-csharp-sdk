/*
 * GmodStore API
 *
 * Welcome to the GmodStore API! You can use our API to access GmodStore API endpoints, which can be used interact with GmodStore programmatically.
 *
 * The version of the OpenAPI document: 1.2.0
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
    /// NewAddonPurchase
    /// </summary>
    [DataContract(Name = "NewAddonPurchase")]
    public partial class NewAddonPurchase : IEquatable<NewAddonPurchase>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NewAddonPurchase" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NewAddonPurchase() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NewAddonPurchase" /> class.
        /// </summary>
        /// <param name="userId">userId (required).</param>
        public NewAddonPurchase(long userId = default(long))
        {
            this.UserId = userId;
        }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name = "user_id", IsRequired = true, EmitDefaultValue = false)]
        public long UserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NewAddonPurchase {\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
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
            return this.Equals(input as NewAddonPurchase);
        }

        /// <summary>
        /// Returns true if NewAddonPurchase instances are equal
        /// </summary>
        /// <param name="input">Instance of NewAddonPurchase to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NewAddonPurchase input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UserId == input.UserId ||
                    this.UserId.Equals(input.UserId)
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
                hashCode = hashCode * 59 + this.UserId.GetHashCode();
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
