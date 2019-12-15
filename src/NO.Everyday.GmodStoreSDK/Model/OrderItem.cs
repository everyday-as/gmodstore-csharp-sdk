/* 
 * GmodStore
 *
 * Welcome to the Gmodstore API! You can use our API to access Gmodstore API endpoints, which can be used interact with Gmodstore programmatically.
 *
 * OpenAPI spec version: 1.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using SwaggerDateConverter = NO.Everyday.GmodStoreSDK.Client.SwaggerDateConverter;

namespace NO.Everyday.GmodStoreSDK.Model
{
    /// <summary>
    /// OrderItem
    /// </summary>
    [DataContract]
        public partial class OrderItem :  IEquatable<OrderItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderItem" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="price">price (required).</param>
        /// <param name="reversedAt">reversedAt.</param>
        public OrderItem(Guid? id = default(Guid?), OrderItemPrice price = default(OrderItemPrice), DateTime? reversedAt = default(DateTime?))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for OrderItem and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "price" is required (not null)
            if (price == null)
            {
                throw new InvalidDataException("price is a required property for OrderItem and cannot be null");
            }
            else
            {
                this.Price = price;
            }
            this.ReversedAt = reversedAt;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid? Id { get; set; }

        /// <summary>
        /// Gets or Sets Price
        /// </summary>
        [DataMember(Name="price", EmitDefaultValue=false)]
        public OrderItemPrice Price { get; set; }

        /// <summary>
        /// Gets or Sets ReversedAt
        /// </summary>
        [DataMember(Name="reversed_at", EmitDefaultValue=false)]
        public DateTime? ReversedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderItem {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  ReversedAt: ").Append(ReversedAt).Append("\n");
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
            return this.Equals(input as OrderItem);
        }

        /// <summary>
        /// Returns true if OrderItem instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Price == input.Price ||
                    (this.Price != null &&
                    this.Price.Equals(input.Price))
                ) && 
                (
                    this.ReversedAt == input.ReversedAt ||
                    (this.ReversedAt != null &&
                    this.ReversedAt.Equals(input.ReversedAt))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Price != null)
                    hashCode = hashCode * 59 + this.Price.GetHashCode();
                if (this.ReversedAt != null)
                    hashCode = hashCode * 59 + this.ReversedAt.GetHashCode();
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
