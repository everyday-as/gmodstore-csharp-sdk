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
    /// AddonCoupon
    /// </summary>
    [DataContract]
    public partial class AddonCoupon :  IEquatable<AddonCoupon>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddonCoupon" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AddonCoupon() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddonCoupon" /> class.
        /// </summary>
        /// <param name="code">code (required).</param>
        /// <param name="percent">percent (required).</param>
        /// <param name="maxUses">maxUses (required).</param>
        /// <param name="expiresAt">A future date less than 2 weeks from today (required).</param>
        /// <param name="addon">addon.</param>
        public AddonCoupon(string code = default(string), decimal percent = default(decimal), int maxUses = default(int), DateTime expiresAt = default(DateTime), Addon addon = default(Addon))
        {
            // to ensure "code" is required (not null)
            this.Code = code ?? throw new ArgumentNullException("code is a required property for AddonCoupon and cannot be null");
            this.Percent = percent;
            this.MaxUses = maxUses;
            this.ExpiresAt = expiresAt;
            this.Addon = addon;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int Id { get; private set; }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets Percent
        /// </summary>
        [DataMember(Name="percent", EmitDefaultValue=false)]
        public decimal Percent { get; set; }

        /// <summary>
        /// Gets or Sets MaxUses
        /// </summary>
        [DataMember(Name="max_uses", EmitDefaultValue=false)]
        public int MaxUses { get; set; }

        /// <summary>
        /// A future date less than 2 weeks from today
        /// </summary>
        /// <value>A future date less than 2 weeks from today</value>
        [DataMember(Name="expires_at", EmitDefaultValue=false)]
        public DateTime ExpiresAt { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public DateTime CreatedAt { get; private set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        public DateTime UpdatedAt { get; private set; }

        /// <summary>
        /// Gets or Sets Addon
        /// </summary>
        [DataMember(Name="addon", EmitDefaultValue=false)]
        public Addon Addon { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddonCoupon {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Percent: ").Append(Percent).Append("\n");
            sb.Append("  MaxUses: ").Append(MaxUses).Append("\n");
            sb.Append("  ExpiresAt: ").Append(ExpiresAt).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Addon: ").Append(Addon).Append("\n");
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
            return this.Equals(input as AddonCoupon);
        }

        /// <summary>
        /// Returns true if AddonCoupon instances are equal
        /// </summary>
        /// <param name="input">Instance of AddonCoupon to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddonCoupon input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Percent == input.Percent ||
                    this.Percent.Equals(input.Percent)
                ) && 
                (
                    this.MaxUses == input.MaxUses ||
                    this.MaxUses.Equals(input.MaxUses)
                ) && 
                (
                    this.ExpiresAt == input.ExpiresAt ||
                    (this.ExpiresAt != null &&
                    this.ExpiresAt.Equals(input.ExpiresAt))
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
                hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                hashCode = hashCode * 59 + this.Percent.GetHashCode();
                hashCode = hashCode * 59 + this.MaxUses.GetHashCode();
                if (this.ExpiresAt != null)
                    hashCode = hashCode * 59 + this.ExpiresAt.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.Addon != null)
                    hashCode = hashCode * 59 + this.Addon.GetHashCode();
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
            // Id (int) minimum
            if(this.Id < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, must be a value greater than or equal to 1.", new [] { "Id" });
            }

            // Percent (decimal) maximum
            if(this.Percent > (decimal)99)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Percent, must be a value less than or equal to 99.", new [] { "Percent" });
            }

            // Percent (decimal) minimum
            if(this.Percent < (decimal)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Percent, must be a value greater than or equal to 1.", new [] { "Percent" });
            }

            // MaxUses (int) minimum
            if(this.MaxUses < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MaxUses, must be a value greater than or equal to 1.", new [] { "MaxUses" });
            }

            yield break;
        }
    }

}
