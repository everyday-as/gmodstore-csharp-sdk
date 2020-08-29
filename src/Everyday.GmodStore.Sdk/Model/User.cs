/* 
 * GmodStore API
 *
 * Welcome to the GmodStore API! You can use our API to access GmodStore API endpoints, which can be used interact with GmodStore programmatically.
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
    /// User
    /// </summary>
    [DataContract]
    public partial class User :  IEquatable<User>, IValidatableObject
    {
        /// <summary>
        /// Defines BanProperties
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BanPropertiesEnum
        {
            /// <summary>
            /// Enum Everything for value: everything
            /// </summary>
            [EnumMember(Value = "everything")]
            Everything = 1,

            /// <summary>
            /// Enum AddonCreate for value: addon.create
            /// </summary>
            [EnumMember(Value = "addon.create")]
            AddonCreate = 2,

            /// <summary>
            /// Enum AddonPurchase for value: addon.purchase
            /// </summary>
            [EnumMember(Value = "addon.purchase")]
            AddonPurchase = 3,

            /// <summary>
            /// Enum AddonDownload for value: addon.download
            /// </summary>
            [EnumMember(Value = "addon.download")]
            AddonDownload = 4,

            /// <summary>
            /// Enum AddonReview for value: addon.review
            /// </summary>
            [EnumMember(Value = "addon.review")]
            AddonReview = 5,

            /// <summary>
            /// Enum AddonComment for value: addon.comment
            /// </summary>
            [EnumMember(Value = "addon.comment")]
            AddonComment = 6,

            /// <summary>
            /// Enum JobCreate for value: job.create
            /// </summary>
            [EnumMember(Value = "job.create")]
            JobCreate = 7,

            /// <summary>
            /// Enum JobApply for value: job.apply
            /// </summary>
            [EnumMember(Value = "job.apply")]
            JobApply = 8,

            /// <summary>
            /// Enum JobReview for value: job.review
            /// </summary>
            [EnumMember(Value = "job.review")]
            JobReview = 9,

            /// <summary>
            /// Enum JobComment for value: job.comment
            /// </summary>
            [EnumMember(Value = "job.comment")]
            JobComment = 10,

            /// <summary>
            /// Enum BanAppeal for value: ban.appeal
            /// </summary>
            [EnumMember(Value = "ban.appeal")]
            BanAppeal = 11

        }


        /// <summary>
        /// Gets or Sets BanProperties
        /// </summary>
        [DataMember(Name="ban_properties", EmitDefaultValue=false)]
        public List<BanPropertiesEnum> BanProperties { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="User" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="avatar">avatar.</param>
        /// <param name="countryCode">countryCode.</param>
        /// <param name="slug">slug.</param>
        /// <param name="reputation">reputation.</param>
        /// <param name="teamReputation">teamReputation.</param>
        /// <param name="banProperties">banProperties.</param>
        /// <param name="group">group.</param>
        public User(long id = default(long), string name = default(string), string avatar = default(string), string countryCode = default(string), string slug = default(string), long reputation = default(long), long teamReputation = default(long), List<BanPropertiesEnum> banProperties = default(List<BanPropertiesEnum>), PermissionGroup group = default(PermissionGroup))
        {
            this.Id = id;
            this.Name = name;
            this.Avatar = avatar;
            this.CountryCode = countryCode;
            this.Slug = slug;
            this.Reputation = reputation;
            this.TeamReputation = teamReputation;
            this.BanProperties = banProperties;
            this.Group = group;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public long Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Avatar
        /// </summary>
        [DataMember(Name="avatar", EmitDefaultValue=false)]
        public string Avatar { get; set; }

        /// <summary>
        /// Gets or Sets CountryCode
        /// </summary>
        [DataMember(Name="country_code", EmitDefaultValue=false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// Gets or Sets Slug
        /// </summary>
        [DataMember(Name="slug", EmitDefaultValue=false)]
        public string Slug { get; set; }

        /// <summary>
        /// Gets or Sets Reputation
        /// </summary>
        [DataMember(Name="reputation", EmitDefaultValue=false)]
        public long Reputation { get; set; }

        /// <summary>
        /// Gets or Sets TeamReputation
        /// </summary>
        [DataMember(Name="team_reputation", EmitDefaultValue=false)]
        public long TeamReputation { get; set; }

        /// <summary>
        /// Gets or Sets Group
        /// </summary>
        [DataMember(Name="group", EmitDefaultValue=false)]
        public PermissionGroup Group { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class User {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Avatar: ").Append(Avatar).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  Slug: ").Append(Slug).Append("\n");
            sb.Append("  Reputation: ").Append(Reputation).Append("\n");
            sb.Append("  TeamReputation: ").Append(TeamReputation).Append("\n");
            sb.Append("  BanProperties: ").Append(BanProperties).Append("\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
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
            return this.Equals(input as User);
        }

        /// <summary>
        /// Returns true if User instances are equal
        /// </summary>
        /// <param name="input">Instance of User to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(User input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Avatar == input.Avatar ||
                    (this.Avatar != null &&
                    this.Avatar.Equals(input.Avatar))
                ) && 
                (
                    this.CountryCode == input.CountryCode ||
                    (this.CountryCode != null &&
                    this.CountryCode.Equals(input.CountryCode))
                ) && 
                (
                    this.Slug == input.Slug ||
                    (this.Slug != null &&
                    this.Slug.Equals(input.Slug))
                ) && 
                (
                    this.Reputation == input.Reputation ||
                    this.Reputation.Equals(input.Reputation)
                ) && 
                (
                    this.TeamReputation == input.TeamReputation ||
                    this.TeamReputation.Equals(input.TeamReputation)
                ) && 
                (
                    this.BanProperties == input.BanProperties ||
                    this.BanProperties.SequenceEqual(input.BanProperties)
                ) && 
                (
                    this.Group == input.Group ||
                    (this.Group != null &&
                    this.Group.Equals(input.Group))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Avatar != null)
                    hashCode = hashCode * 59 + this.Avatar.GetHashCode();
                if (this.CountryCode != null)
                    hashCode = hashCode * 59 + this.CountryCode.GetHashCode();
                if (this.Slug != null)
                    hashCode = hashCode * 59 + this.Slug.GetHashCode();
                hashCode = hashCode * 59 + this.Reputation.GetHashCode();
                hashCode = hashCode * 59 + this.TeamReputation.GetHashCode();
                hashCode = hashCode * 59 + this.BanProperties.GetHashCode();
                if (this.Group != null)
                    hashCode = hashCode * 59 + this.Group.GetHashCode();
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
