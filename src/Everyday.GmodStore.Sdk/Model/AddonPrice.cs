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
    /// AddonPrice
    /// </summary>
    [DataContract]
    public partial class AddonPrice :  IEquatable<AddonPrice>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddonPrice" /> class.
        /// </summary>
        /// <param name="original">original.</param>
        /// <param name="purchase">purchase.</param>
        public AddonPrice(Money original = default(Money), Money purchase = default(Money))
        {
            this.Original = original;
            this.Purchase = purchase;
        }
        
        /// <summary>
        /// Gets or Sets Original
        /// </summary>
        [DataMember(Name="original", EmitDefaultValue=false)]
        public Money Original { get; set; }

        /// <summary>
        /// Gets or Sets Purchase
        /// </summary>
        [DataMember(Name="purchase", EmitDefaultValue=false)]
        public Money Purchase { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddonPrice {\n");
            sb.Append("  Original: ").Append(Original).Append("\n");
            sb.Append("  Purchase: ").Append(Purchase).Append("\n");
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
            return this.Equals(input as AddonPrice);
        }

        /// <summary>
        /// Returns true if AddonPrice instances are equal
        /// </summary>
        /// <param name="input">Instance of AddonPrice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddonPrice input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Original == input.Original ||
                    (this.Original != null &&
                    this.Original.Equals(input.Original))
                ) && 
                (
                    this.Purchase == input.Purchase ||
                    (this.Purchase != null &&
                    this.Purchase.Equals(input.Purchase))
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
                if (this.Original != null)
                    hashCode = hashCode * 59 + this.Original.GetHashCode();
                if (this.Purchase != null)
                    hashCode = hashCode * 59 + this.Purchase.GetHashCode();
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
