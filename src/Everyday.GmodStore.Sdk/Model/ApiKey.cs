/*
 * GmodStore API
 *
 * Welcome to the GmodStore API! You can use our API to access GmodStore API endpoints, which can be used interact with GmodStore programmatically.
 *
 * The version of the OpenAPI document: 1.1.0
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
    /// ApiKey
    /// </summary>
    [DataContract(Name = "ApiKey")]
    public partial class ApiKey : IEquatable<ApiKey>, IValidatableObject
    {
        /// <summary>
        /// Defines Permissions
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PermissionsEnum
        {
            /// <summary>
            /// Enum AddonsRead for value: addons.read
            /// </summary>
            [EnumMember(Value = "addons.read")]
            AddonsRead = 1,

            /// <summary>
            /// Enum AddonsCouponsRead for value: addons.coupons.read
            /// </summary>
            [EnumMember(Value = "addons.coupons.read")]
            AddonsCouponsRead = 2,

            /// <summary>
            /// Enum AddonsCouponsWrite for value: addons.coupons.write
            /// </summary>
            [EnumMember(Value = "addons.coupons.write")]
            AddonsCouponsWrite = 3,

            /// <summary>
            /// Enum AddonsPurchasesRead for value: addons.purchases.read
            /// </summary>
            [EnumMember(Value = "addons.purchases.read")]
            AddonsPurchasesRead = 4,

            /// <summary>
            /// Enum AddonsPurchasesWrite for value: addons.purchases.write
            /// </summary>
            [EnumMember(Value = "addons.purchases.write")]
            AddonsPurchasesWrite = 5,

            /// <summary>
            /// Enum AddonsReviewsRead for value: addons.reviews.read
            /// </summary>
            [EnumMember(Value = "addons.reviews.read")]
            AddonsReviewsRead = 6,

            /// <summary>
            /// Enum TeamsRead for value: teams.read
            /// </summary>
            [EnumMember(Value = "teams.read")]
            TeamsRead = 7,

            /// <summary>
            /// Enum UsersRead for value: users.read
            /// </summary>
            [EnumMember(Value = "users.read")]
            UsersRead = 8,

            /// <summary>
            /// Enum UsersWrite for value: users.write
            /// </summary>
            [EnumMember(Value = "users.write")]
            UsersWrite = 9,

            /// <summary>
            /// Enum AddonsVersionsRead for value: addons.versions.read
            /// </summary>
            [EnumMember(Value = "addons.versions.read")]
            AddonsVersionsRead = 10,

            /// <summary>
            /// Enum AddonsVersionsWrite for value: addons.versions.write
            /// </summary>
            [EnumMember(Value = "addons.versions.write")]
            AddonsVersionsWrite = 11,

            /// <summary>
            /// Enum AddonsVersionsDownload for value: addons.versions.download
            /// </summary>
            [EnumMember(Value = "addons.versions.download")]
            AddonsVersionsDownload = 12

        }



        /// <summary>
        /// Gets or Sets Permissions
        /// </summary>
        [DataMember(Name = "permissions", EmitDefaultValue = false)]
        public List<PermissionsEnum> Permissions { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ApiKey" /> class.
        /// </summary>
        /// <param name="permissions">permissions.</param>
        /// <param name="user">user.</param>
        public ApiKey(List<PermissionsEnum> permissions = default(List<PermissionsEnum>), User user = default(User))
        {
            this.Permissions = permissions;
            this.User = user;
        }

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
            sb.Append("class ApiKey {\n");
            sb.Append("  Permissions: ").Append(Permissions).Append("\n");
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
            return this.Equals(input as ApiKey);
        }

        /// <summary>
        /// Returns true if ApiKey instances are equal
        /// </summary>
        /// <param name="input">Instance of ApiKey to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ApiKey input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Permissions == input.Permissions ||
                    this.Permissions.SequenceEqual(input.Permissions)
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
                hashCode = hashCode * 59 + this.Permissions.GetHashCode();
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
