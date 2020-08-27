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
    /// AddonVersion
    /// </summary>
    [DataContract]
    public partial class AddonVersion :  IEquatable<AddonVersion>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets ReleaseType
        /// </summary>
        [DataMember(Name="release_type", EmitDefaultValue=false)]
        public AddonVersionReleaseType? ReleaseType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddonVersion" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AddonVersion() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AddonVersion" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="changelog">You can pass in markdown here (required).</param>
        /// <param name="releaseType">releaseType.</param>
        /// <param name="addon">addon.</param>
        public AddonVersion(string name = default(string), string changelog = default(string), AddonVersionReleaseType? releaseType = default(AddonVersionReleaseType?), Addon addon = default(Addon))
        {
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for AddonVersion and cannot be null");
            // to ensure "changelog" is required (not null)
            this.Changelog = changelog ?? throw new ArgumentNullException("changelog is a required property for AddonVersion and cannot be null");
            this.ReleaseType = releaseType;
            this.Addon = addon;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int Id { get; private set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// You can pass in markdown here
        /// </summary>
        /// <value>You can pass in markdown here</value>
        [DataMember(Name="changelog", EmitDefaultValue=false)]
        public string Changelog { get; set; }

        /// <summary>
        /// Gets or Sets FileHash
        /// </summary>
        [DataMember(Name="file_hash", EmitDefaultValue=false)]
        public string FileHash { get; private set; }

        /// <summary>
        /// Gets or Sets FileSize
        /// </summary>
        [DataMember(Name="file_size", EmitDefaultValue=false)]
        public int FileSize { get; private set; }

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
            sb.Append("class AddonVersion {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Changelog: ").Append(Changelog).Append("\n");
            sb.Append("  FileHash: ").Append(FileHash).Append("\n");
            sb.Append("  FileSize: ").Append(FileSize).Append("\n");
            sb.Append("  ReleaseType: ").Append(ReleaseType).Append("\n");
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
            return this.Equals(input as AddonVersion);
        }

        /// <summary>
        /// Returns true if AddonVersion instances are equal
        /// </summary>
        /// <param name="input">Instance of AddonVersion to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddonVersion input)
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
                    this.Changelog == input.Changelog ||
                    (this.Changelog != null &&
                    this.Changelog.Equals(input.Changelog))
                ) && 
                (
                    this.FileHash == input.FileHash ||
                    (this.FileHash != null &&
                    this.FileHash.Equals(input.FileHash))
                ) && 
                (
                    this.FileSize == input.FileSize ||
                    this.FileSize.Equals(input.FileSize)
                ) && 
                (
                    this.ReleaseType == input.ReleaseType ||
                    this.ReleaseType.Equals(input.ReleaseType)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Changelog != null)
                    hashCode = hashCode * 59 + this.Changelog.GetHashCode();
                if (this.FileHash != null)
                    hashCode = hashCode * 59 + this.FileHash.GetHashCode();
                hashCode = hashCode * 59 + this.FileSize.GetHashCode();
                hashCode = hashCode * 59 + this.ReleaseType.GetHashCode();
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
            // Name (string) maxLength
            if(this.Name != null && this.Name.Length > 80)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 80.", new [] { "Name" });
            }

            // Name (string) minLength
            if(this.Name != null && this.Name.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }

            // Changelog (string) maxLength
            if(this.Changelog != null && this.Changelog.Length > 10000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Changelog, length must be less than 10000.", new [] { "Changelog" });
            }

            // Changelog (string) minLength
            if(this.Changelog != null && this.Changelog.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Changelog, length must be greater than 1.", new [] { "Changelog" });
            }

            yield break;
        }
    }

}
