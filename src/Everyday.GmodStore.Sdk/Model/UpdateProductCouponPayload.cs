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
    /// UpdateProductCouponPayload
    /// </summary>
    [DataContract(Name = "UpdateProductCouponPayload")]
    public partial class UpdateProductCouponPayload : IEquatable<UpdateProductCouponPayload>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProductCouponPayload" /> class.
        /// </summary>
        /// <param name="percent">percent.</param>
        /// <param name="code">code.</param>
        /// <param name="maxUses">maxUses.</param>
        /// <param name="expiresAt">expiresAt.</param>
        /// <param name="boundUserId">boundUserId.</param>
        public UpdateProductCouponPayload(int percent = default(int), string code = default(string), int maxUses = default(int), DateTime expiresAt = default(DateTime), Guid? boundUserId = default(Guid?))
        {
            this.Percent = percent;
            this.Code = code;
            this.MaxUses = maxUses;
            this.ExpiresAt = expiresAt;
            this.BoundUserId = boundUserId;
        }

        /// <summary>
        /// Gets or Sets Percent
        /// </summary>
        [DataMember(Name = "percent", EmitDefaultValue = false)]
        public int Percent { get; set; }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets MaxUses
        /// </summary>
        [DataMember(Name = "maxUses", EmitDefaultValue = false)]
        public int MaxUses { get; set; }

        /// <summary>
        /// Gets or Sets ExpiresAt
        /// </summary>
        [DataMember(Name = "expiresAt", EmitDefaultValue = false)]
        public DateTime ExpiresAt { get; set; }

        /// <summary>
        /// Gets or Sets BoundUserId
        /// </summary>
        [DataMember(Name = "boundUserId", EmitDefaultValue = true)]
        public Guid? BoundUserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateProductCouponPayload {\n");
            sb.Append("  Percent: ").Append(Percent).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  MaxUses: ").Append(MaxUses).Append("\n");
            sb.Append("  ExpiresAt: ").Append(ExpiresAt).Append("\n");
            sb.Append("  BoundUserId: ").Append(BoundUserId).Append("\n");
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
            return this.Equals(input as UpdateProductCouponPayload);
        }

        /// <summary>
        /// Returns true if UpdateProductCouponPayload instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateProductCouponPayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateProductCouponPayload input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Percent == input.Percent ||
                    this.Percent.Equals(input.Percent)
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
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
                    this.BoundUserId == input.BoundUserId ||
                    (this.BoundUserId != null &&
                    this.BoundUserId.Equals(input.BoundUserId))
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
                hashCode = hashCode * 59 + this.Percent.GetHashCode();
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                hashCode = hashCode * 59 + this.MaxUses.GetHashCode();
                if (this.ExpiresAt != null)
                    hashCode = hashCode * 59 + this.ExpiresAt.GetHashCode();
                if (this.BoundUserId != null)
                    hashCode = hashCode * 59 + this.BoundUserId.GetHashCode();
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
            // Percent (int) maximum
            if(this.Percent > (int)90)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Percent, must be a value less than or equal to 90.", new [] { "Percent" });
            }

            // Percent (int) minimum
            if(this.Percent < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Percent, must be a value greater than or equal to 1.", new [] { "Percent" });
            }

            // Code (string) maxLength
            if(this.Code != null && this.Code.Length > 64)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Code, length must be less than 64.", new [] { "Code" });
            }

            // Code (string) pattern
            Regex regexCode = new Regex(@"[aA-zZ_\\-0-9]+", RegexOptions.CultureInvariant);
            if (false == regexCode.Match(this.Code).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Code, must match a pattern of " + regexCode, new [] { "Code" });
            }

            // MaxUses (int) maximum
            if(this.MaxUses > (int)100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MaxUses, must be a value less than or equal to 100.", new [] { "MaxUses" });
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
