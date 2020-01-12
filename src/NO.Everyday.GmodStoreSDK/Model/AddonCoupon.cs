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
    /// AddonCoupon
    /// </summary>
    [DataContract]
        public partial class AddonCoupon :  IEquatable<AddonCoupon>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddonCoupon" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="code">code (required).</param>
        /// <param name="percent">percent (required).</param>
        /// <param name="maxUses">maxUses (required).</param>
        /// <param name="expiresAt">expiresAt (required).</param>
        /// <param name="createdAt">createdAt (required).</param>
        /// <param name="updatedAt">updatedAt (required).</param>
        /// <param name="addon">addon.</param>
        public AddonCoupon(int? id = default(int?), string code = default(string), decimal? percent = default(decimal?), int? maxUses = default(int?), DateTime? expiresAt = default(DateTime?), DateTime? createdAt = default(DateTime?), DateTime? updatedAt = default(DateTime?), Addon addon = default(Addon))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for AddonCoupon and cannot be null");
            }
            else
            {
                this.Id = id;
            }
            // to ensure "code" is required (not null)
            if (code == null)
            {
                throw new InvalidDataException("code is a required property for AddonCoupon and cannot be null");
            }
            else
            {
                this.Code = code;
            }
            // to ensure "percent" is required (not null)
            if (percent == null)
            {
                throw new InvalidDataException("percent is a required property for AddonCoupon and cannot be null");
            }
            else
            {
                this.Percent = percent;
            }
            // to ensure "maxUses" is required (not null)
            if (maxUses == null)
            {
                throw new InvalidDataException("maxUses is a required property for AddonCoupon and cannot be null");
            }
            else
            {
                this.MaxUses = maxUses;
            }
            // to ensure "expiresAt" is required (not null)
            if (expiresAt == null)
            {
                throw new InvalidDataException("expiresAt is a required property for AddonCoupon and cannot be null");
            }
            else
            {
                this.ExpiresAt = expiresAt;
            }
            // to ensure "createdAt" is required (not null)
            if (createdAt == null)
            {
                throw new InvalidDataException("createdAt is a required property for AddonCoupon and cannot be null");
            }
            else
            {
                this.CreatedAt = createdAt;
            }
            // to ensure "updatedAt" is required (not null)
            if (updatedAt == null)
            {
                throw new InvalidDataException("updatedAt is a required property for AddonCoupon and cannot be null");
            }
            else
            {
                this.UpdatedAt = updatedAt;
            }
            this.Addon = addon;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets Percent
        /// </summary>
        [DataMember(Name="percent", EmitDefaultValue=false)]
        public decimal? Percent { get; set; }

        /// <summary>
        /// Gets or Sets MaxUses
        /// </summary>
        [DataMember(Name="max_uses", EmitDefaultValue=false)]
        public int? MaxUses { get; set; }

        /// <summary>
        /// Gets or Sets ExpiresAt
        /// </summary>
        [DataMember(Name="expires_at", EmitDefaultValue=false)]
        public DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="created_at", EmitDefaultValue=false)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name="updated_at", EmitDefaultValue=false)]
        public DateTime? UpdatedAt { get; set; }

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
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Percent == input.Percent ||
                    (this.Percent != null &&
                    this.Percent.Equals(input.Percent))
                ) && 
                (
                    this.MaxUses == input.MaxUses ||
                    (this.MaxUses != null &&
                    this.MaxUses.Equals(input.MaxUses))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Percent != null)
                    hashCode = hashCode * 59 + this.Percent.GetHashCode();
                if (this.MaxUses != null)
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
            yield break;
        }
    }
}
