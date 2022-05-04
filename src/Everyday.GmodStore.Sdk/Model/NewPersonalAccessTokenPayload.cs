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
    /// NewPersonalAccessTokenPayload
    /// </summary>
    [DataContract(Name = "NewPersonalAccessTokenPayload")]
    public partial class NewPersonalAccessTokenPayload : IEquatable<NewPersonalAccessTokenPayload>, IValidatableObject
    {
        /// <summary>
        /// Defines Abilities
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AbilitiesEnum
        {
            /// <summary>
            /// Enum PermissionGroupsread for value: permission-groups:read
            /// </summary>
            [EnumMember(Value = "permission-groups:read")]
            PermissionGroupsread = 1,

            /// <summary>
            /// Enum PermissionGroupswrite for value: permission-groups:write
            /// </summary>
            [EnumMember(Value = "permission-groups:write")]
            PermissionGroupswrite = 2,

            /// <summary>
            /// Enum PersonalAccessTokensread for value: personal-access-tokens:read
            /// </summary>
            [EnumMember(Value = "personal-access-tokens:read")]
            PersonalAccessTokensread = 3,

            /// <summary>
            /// Enum PersonalAccessTokenswrite for value: personal-access-tokens:write
            /// </summary>
            [EnumMember(Value = "personal-access-tokens:write")]
            PersonalAccessTokenswrite = 4,

            /// <summary>
            /// Enum Teamsread for value: teams:read
            /// </summary>
            [EnumMember(Value = "teams:read")]
            Teamsread = 5,

            /// <summary>
            /// Enum Teamswrite for value: teams:write
            /// </summary>
            [EnumMember(Value = "teams:write")]
            Teamswrite = 6,

            /// <summary>
            /// Enum TeamUsersread for value: team-users:read
            /// </summary>
            [EnumMember(Value = "team-users:read")]
            TeamUsersread = 7,

            /// <summary>
            /// Enum TeamUserswrite for value: team-users:write
            /// </summary>
            [EnumMember(Value = "team-users:write")]
            TeamUserswrite = 8,

            /// <summary>
            /// Enum Productsread for value: products:read
            /// </summary>
            [EnumMember(Value = "products:read")]
            Productsread = 9,

            /// <summary>
            /// Enum Productswrite for value: products:write
            /// </summary>
            [EnumMember(Value = "products:write")]
            Productswrite = 10,

            /// <summary>
            /// Enum ProductCouponsread for value: product-coupons:read
            /// </summary>
            [EnumMember(Value = "product-coupons:read")]
            ProductCouponsread = 11,

            /// <summary>
            /// Enum ProductCouponswrite for value: product-coupons:write
            /// </summary>
            [EnumMember(Value = "product-coupons:write")]
            ProductCouponswrite = 12,

            /// <summary>
            /// Enum ProductPurchasesread for value: product-purchases:read
            /// </summary>
            [EnumMember(Value = "product-purchases:read")]
            ProductPurchasesread = 13,

            /// <summary>
            /// Enum ProductPurchaseswrite for value: product-purchases:write
            /// </summary>
            [EnumMember(Value = "product-purchases:write")]
            ProductPurchaseswrite = 14,

            /// <summary>
            /// Enum ProductReviewsread for value: product-reviews:read
            /// </summary>
            [EnumMember(Value = "product-reviews:read")]
            ProductReviewsread = 15,

            /// <summary>
            /// Enum ProductReviewswrite for value: product-reviews:write
            /// </summary>
            [EnumMember(Value = "product-reviews:write")]
            ProductReviewswrite = 16,

            /// <summary>
            /// Enum ProductVersionsread for value: product-versions:read
            /// </summary>
            [EnumMember(Value = "product-versions:read")]
            ProductVersionsread = 17,

            /// <summary>
            /// Enum ProductVersionswrite for value: product-versions:write
            /// </summary>
            [EnumMember(Value = "product-versions:write")]
            ProductVersionswrite = 18,

            /// <summary>
            /// Enum ProductVersionsdownload for value: product-versions:download
            /// </summary>
            [EnumMember(Value = "product-versions:download")]
            ProductVersionsdownload = 19,

            /// <summary>
            /// Enum Usersread for value: users:read
            /// </summary>
            [EnumMember(Value = "users:read")]
            Usersread = 20,

            /// <summary>
            /// Enum Userswrite for value: users:write
            /// </summary>
            [EnumMember(Value = "users:write")]
            Userswrite = 21,

            /// <summary>
            /// Enum UserBadgesread for value: user-badges:read
            /// </summary>
            [EnumMember(Value = "user-badges:read")]
            UserBadgesread = 22,

            /// <summary>
            /// Enum UserBadgeswrite for value: user-badges:write
            /// </summary>
            [EnumMember(Value = "user-badges:write")]
            UserBadgeswrite = 23,

            /// <summary>
            /// Enum UserBansread for value: user-bans:read
            /// </summary>
            [EnumMember(Value = "user-bans:read")]
            UserBansread = 24,

            /// <summary>
            /// Enum UserPurchasesread for value: user-purchases:read
            /// </summary>
            [EnumMember(Value = "user-purchases:read")]
            UserPurchasesread = 25,

            /// <summary>
            /// Enum Star for value: *
            /// </summary>
            [EnumMember(Value = "*")]
            Star = 26

        }



        /// <summary>
        /// Gets or Sets Abilities
        /// </summary>
        [DataMember(Name = "abilities", IsRequired = true, EmitDefaultValue = false)]
        public List<AbilitiesEnum> Abilities { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="NewPersonalAccessTokenPayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NewPersonalAccessTokenPayload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NewPersonalAccessTokenPayload" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="expiresAt">expiresAt.</param>
        /// <param name="abilities">abilities (required).</param>
        public NewPersonalAccessTokenPayload(string name = default(string), DateTime? expiresAt = default(DateTime?), List<AbilitiesEnum> abilities = default(List<AbilitiesEnum>))
        {
            // to ensure "name" is required (not null)
            if (name == null) {
                throw new ArgumentNullException("name is a required property for NewPersonalAccessTokenPayload and cannot be null");
            }
            this.Name = name;
            // to ensure "abilities" is required (not null)
            if (abilities == null) {
                throw new ArgumentNullException("abilities is a required property for NewPersonalAccessTokenPayload and cannot be null");
            }
            this.Abilities = abilities;
            this.ExpiresAt = expiresAt;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets ExpiresAt
        /// </summary>
        [DataMember(Name = "expiresAt", EmitDefaultValue = true)]
        public DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NewPersonalAccessTokenPayload {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ExpiresAt: ").Append(ExpiresAt).Append("\n");
            sb.Append("  Abilities: ").Append(Abilities).Append("\n");
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
            return this.Equals(input as NewPersonalAccessTokenPayload);
        }

        /// <summary>
        /// Returns true if NewPersonalAccessTokenPayload instances are equal
        /// </summary>
        /// <param name="input">Instance of NewPersonalAccessTokenPayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NewPersonalAccessTokenPayload input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ExpiresAt == input.ExpiresAt ||
                    (this.ExpiresAt != null &&
                    this.ExpiresAt.Equals(input.ExpiresAt))
                ) && 
                (
                    this.Abilities == input.Abilities ||
                    this.Abilities.SequenceEqual(input.Abilities)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ExpiresAt != null)
                    hashCode = hashCode * 59 + this.ExpiresAt.GetHashCode();
                hashCode = hashCode * 59 + this.Abilities.GetHashCode();
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
            // Name (string) maxLength
            if(this.Name != null && this.Name.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 100.", new [] { "Name" });
            }

            // Name (string) minLength
            if(this.Name != null && this.Name.Length < 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 3.", new [] { "Name" });
            }

            yield break;
        }
    }

}
