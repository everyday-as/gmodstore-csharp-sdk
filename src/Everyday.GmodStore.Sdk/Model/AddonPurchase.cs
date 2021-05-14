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
    /// AddonPurchase
    /// </summary>
    [DataContract(Name = "AddonPurchase")]
    public partial class AddonPurchase : IEquatable<AddonPurchase>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddonPurchase" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AddonPurchase() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddonPurchase" /> class.
        /// </summary>
        /// <param name="revoked">revoked (required).</param>
        /// <param name="addon">addon.</param>
        /// <param name="orderItem">orderItem.</param>
        /// <param name="user">user.</param>
        public AddonPurchase(bool revoked = default(bool), Addon addon = default(Addon), OrderItem orderItem = default(OrderItem), User user = default(User))
        {
            this.Revoked = revoked;
            this.Addon = addon;
            this.OrderItem = orderItem;
            this.User = user;
        }

        /// <summary>
        /// Gets or Sets Revoked
        /// </summary>
        [DataMember(Name = "revoked", IsRequired = true, EmitDefaultValue = true)]
        public bool Revoked { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public DateTime CreatedAt { get; private set; }

        /// <summary>
        /// Returns false as CreatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreatedAt()
        {
            return false;
        }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updated_at", EmitDefaultValue = false)]
        public DateTime UpdatedAt { get; private set; }

        /// <summary>
        /// Returns false as UpdatedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUpdatedAt()
        {
            return false;
        }

        /// <summary>
        /// Gets or Sets Addon
        /// </summary>
        [DataMember(Name = "addon", EmitDefaultValue = false)]
        public Addon Addon { get; set; }

        /// <summary>
        /// Gets or Sets OrderItem
        /// </summary>
        [DataMember(Name = "order_item", EmitDefaultValue = false)]
        public OrderItem OrderItem { get; set; }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name = "user", EmitDefaultValue = false)]
        public User User { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddonPurchase {\n");
            sb.Append("  Revoked: ").Append(Revoked).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Addon: ").Append(Addon).Append("\n");
            sb.Append("  OrderItem: ").Append(OrderItem).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
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
            return this.Equals(input as AddonPurchase);
        }

        /// <summary>
        /// Returns true if AddonPurchase instances are equal
        /// </summary>
        /// <param name="input">Instance of AddonPurchase to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddonPurchase input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Revoked == input.Revoked ||
                    this.Revoked.Equals(input.Revoked)
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.Addon == input.Addon ||
                    (this.Addon != null &&
                    this.Addon.Equals(input.Addon))
                ) && 
                (
                    this.OrderItem == input.OrderItem ||
                    (this.OrderItem != null &&
                    this.OrderItem.Equals(input.OrderItem))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
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
                hashCode = hashCode * 59 + this.Revoked.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.Addon != null)
                    hashCode = hashCode * 59 + this.Addon.GetHashCode();
                if (this.OrderItem != null)
                    hashCode = hashCode * 59 + this.OrderItem.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
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
