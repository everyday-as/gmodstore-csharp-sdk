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
    /// AddonReview
    /// </summary>
    [DataContract]
    public partial class AddonReview :  IEquatable<AddonReview>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddonReview" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="title">title.</param>
        /// <param name="version">version.</param>
        /// <param name="body">body.</param>
        /// <param name="rating">rating.</param>
        /// <param name="addon">addon.</param>
        /// <param name="author">author.</param>
        public AddonReview(int id = default(int), string title = default(string), string version = default(string), string body = default(string), decimal rating = default(decimal), Addon addon = default(Addon), User author = default(User))
        {
            this.Id = id;
            this.Title = title;
            this.Version = version;
            this.Body = body;
            this.Rating = rating;
            this.Addon = addon;
            this.Author = author;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name="version", EmitDefaultValue=false)]
        public string Version { get; set; }

        /// <summary>
        /// Gets or Sets Body
        /// </summary>
        [DataMember(Name="body", EmitDefaultValue=false)]
        public string Body { get; set; }

        /// <summary>
        /// Gets or Sets Rating
        /// </summary>
        [DataMember(Name="rating", EmitDefaultValue=false)]
        public decimal Rating { get; set; }

        /// <summary>
        /// Gets or Sets Addon
        /// </summary>
        [DataMember(Name="addon", EmitDefaultValue=false)]
        public Addon Addon { get; set; }

        /// <summary>
        /// Gets or Sets Author
        /// </summary>
        [DataMember(Name="author", EmitDefaultValue=false)]
        public User Author { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddonReview {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  Rating: ").Append(Rating).Append("\n");
            sb.Append("  Addon: ").Append(Addon).Append("\n");
            sb.Append("  Author: ").Append(Author).Append("\n");
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
            return this.Equals(input as AddonReview);
        }

        /// <summary>
        /// Returns true if AddonReview instances are equal
        /// </summary>
        /// <param name="input">Instance of AddonReview to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddonReview input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
                ) && 
                (
                    this.Rating == input.Rating ||
                    this.Rating.Equals(input.Rating)
                ) && 
                (
                    this.Addon == input.Addon ||
                    (this.Addon != null &&
                    this.Addon.Equals(input.Addon))
                ) && 
                (
                    this.Author == input.Author ||
                    (this.Author != null &&
                    this.Author.Equals(input.Author))
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
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.Body != null)
                    hashCode = hashCode * 59 + this.Body.GetHashCode();
                hashCode = hashCode * 59 + this.Rating.GetHashCode();
                if (this.Addon != null)
                    hashCode = hashCode * 59 + this.Addon.GetHashCode();
                if (this.Author != null)
                    hashCode = hashCode * 59 + this.Author.GetHashCode();
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
            // Rating (decimal) maximum
            if(this.Rating > (decimal)5)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Rating, must be a value less than or equal to 5.", new [] { "Rating" });
            }

            // Rating (decimal) minimum
            if(this.Rating < (decimal)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Rating, must be a value greater than or equal to 1.", new [] { "Rating" });
            }

            yield break;
        }
    }

}
