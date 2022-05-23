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
    /// Addon
    /// </summary>
    [DataContract(Name = "Addon")]
    public partial class Addon : IEquatable<Addon>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Addon" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="active">active.</param>
        /// <param name="name">name.</param>
        /// <param name="shortDescription">shortDescription.</param>
        /// <param name="description">description.</param>
        /// <param name="requirements">requirements.</param>
        /// <param name="price">price.</param>
        /// <param name="images">images.</param>
        /// <param name="latestVersion">latestVersion.</param>
        /// <param name="team">team.</param>
        /// <param name="stats">stats.</param>
        public Addon(long id = default(long), bool active = default(bool), string name = default(string), string shortDescription = default(string), string description = default(string), List<string> requirements = default(List<string>), AddonPrice price = default(AddonPrice), AddonImages images = default(AddonImages), AddonVersion latestVersion = default(AddonVersion), Team team = default(Team), AddonStats stats = default(AddonStats))
        {
            this.Id = id;
            this.Active = active;
            this.Name = name;
            this.ShortDescription = shortDescription;
            this.Description = description;
            this.Requirements = requirements;
            this.Price = price;
            this.Images = images;
            this.LatestVersion = latestVersion;
            this.Team = team;
            this.Stats = stats;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public long Id { get; set; }

        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name = "active", EmitDefaultValue = true)]
        public bool Active { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets ShortDescription
        /// </summary>
        [DataMember(Name = "short_description", EmitDefaultValue = false)]
        public string ShortDescription { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Requirements
        /// </summary>
        [DataMember(Name = "requirements", EmitDefaultValue = false)]
        public List<string> Requirements { get; set; }

        /// <summary>
        /// Gets or Sets Price
        /// </summary>
        [DataMember(Name = "price", EmitDefaultValue = false)]
        public AddonPrice Price { get; set; }

        /// <summary>
        /// Gets or Sets Images
        /// </summary>
        [DataMember(Name = "images", EmitDefaultValue = false)]
        public AddonImages Images { get; set; }

        /// <summary>
        /// Gets or Sets Views
        /// </summary>
        [DataMember(Name = "views", EmitDefaultValue = false)]
        public int Views { get; private set; }

        /// <summary>
        /// Returns false as Views should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeViews()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets RatingAvg
        /// </summary>
        [DataMember(Name = "rating_avg", EmitDefaultValue = false)]
        public string RatingAvg { get; private set; }

        /// <summary>
        /// Returns false as RatingAvg should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRatingAvg()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets RatingCount
        /// </summary>
        [DataMember(Name = "rating_count", EmitDefaultValue = false)]
        public int RatingCount { get; private set; }

        /// <summary>
        /// Returns false as RatingCount should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRatingCount()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets PurchasesCount
        /// </summary>
        [DataMember(Name = "purchases_count", EmitDefaultValue = false)]
        public int PurchasesCount { get; private set; }

        /// <summary>
        /// Returns false as PurchasesCount should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializePurchasesCount()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets DependentAddon
        /// </summary>
        [DataMember(Name = "dependent_addon", EmitDefaultValue = true)]
        public long? DependentAddon { get; private set; }

        /// <summary>
        /// Returns false as DependentAddon should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDependentAddon()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets HasDrm
        /// </summary>
        [DataMember(Name = "has_drm", EmitDefaultValue = true)]
        public bool HasDrm { get; private set; }

        /// <summary>
        /// Returns false as HasDrm should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeHasDrm()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets RequiresChromium
        /// </summary>
        [DataMember(Name = "requires_chromium", EmitDefaultValue = true)]
        public bool RequiresChromium { get; private set; }

        /// <summary>
        /// Returns false as RequiresChromium should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRequiresChromium()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Slug
        /// </summary>
        [DataMember(Name = "slug", EmitDefaultValue = false)]
        public string Slug { get; private set; }

        /// <summary>
        /// Returns false as Slug should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSlug()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Route
        /// </summary>
        [DataMember(Name = "route", EmitDefaultValue = false)]
        public string Route { get; private set; }

        /// <summary>
        /// Returns false as Route should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRoute()
        {
            return false;
        }
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
        /// Gets or Sets LatestVersion
        /// </summary>
        [DataMember(Name = "latest_version", EmitDefaultValue = false)]
        public AddonVersion LatestVersion { get; set; }

        /// <summary>
        /// Gets or Sets Team
        /// </summary>
        [DataMember(Name = "team", EmitDefaultValue = false)]
        public Team Team { get; set; }

        /// <summary>
        /// Gets or Sets Stats
        /// </summary>
        [DataMember(Name = "stats", EmitDefaultValue = false)]
        public AddonStats Stats { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Addon {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ShortDescription: ").Append(ShortDescription).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Requirements: ").Append(Requirements).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Images: ").Append(Images).Append("\n");
            sb.Append("  Views: ").Append(Views).Append("\n");
            sb.Append("  RatingAvg: ").Append(RatingAvg).Append("\n");
            sb.Append("  RatingCount: ").Append(RatingCount).Append("\n");
            sb.Append("  PurchasesCount: ").Append(PurchasesCount).Append("\n");
            sb.Append("  DependentAddon: ").Append(DependentAddon).Append("\n");
            sb.Append("  HasDrm: ").Append(HasDrm).Append("\n");
            sb.Append("  RequiresChromium: ").Append(RequiresChromium).Append("\n");
            sb.Append("  Slug: ").Append(Slug).Append("\n");
            sb.Append("  Route: ").Append(Route).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  LatestVersion: ").Append(LatestVersion).Append("\n");
            sb.Append("  Team: ").Append(Team).Append("\n");
            sb.Append("  Stats: ").Append(Stats).Append("\n");
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
            return this.Equals(input as Addon);
        }

        /// <summary>
        /// Returns true if Addon instances are equal
        /// </summary>
        /// <param name="input">Instance of Addon to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Addon input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Active == input.Active ||
                    this.Active.Equals(input.Active)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ShortDescription == input.ShortDescription ||
                    (this.ShortDescription != null &&
                    this.ShortDescription.Equals(input.ShortDescription))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Requirements == input.Requirements ||
                    this.Requirements != null &&
                    input.Requirements != null &&
                    this.Requirements.SequenceEqual(input.Requirements)
                ) && 
                (
                    this.Price == input.Price ||
                    (this.Price != null &&
                    this.Price.Equals(input.Price))
                ) && 
                (
                    this.Images == input.Images ||
                    (this.Images != null &&
                    this.Images.Equals(input.Images))
                ) && 
                (
                    this.Views == input.Views ||
                    this.Views.Equals(input.Views)
                ) && 
                (
                    this.RatingAvg == input.RatingAvg ||
                    (this.RatingAvg != null &&
                    this.RatingAvg.Equals(input.RatingAvg))
                ) && 
                (
                    this.RatingCount == input.RatingCount ||
                    this.RatingCount.Equals(input.RatingCount)
                ) && 
                (
                    this.PurchasesCount == input.PurchasesCount ||
                    this.PurchasesCount.Equals(input.PurchasesCount)
                ) && 
                (
                    this.DependentAddon == input.DependentAddon ||
                    (this.DependentAddon != null &&
                    this.DependentAddon.Equals(input.DependentAddon))
                ) && 
                (
                    this.HasDrm == input.HasDrm ||
                    this.HasDrm.Equals(input.HasDrm)
                ) && 
                (
                    this.RequiresChromium == input.RequiresChromium ||
                    this.RequiresChromium.Equals(input.RequiresChromium)
                ) && 
                (
                    this.Slug == input.Slug ||
                    (this.Slug != null &&
                    this.Slug.Equals(input.Slug))
                ) && 
                (
                    this.Route == input.Route ||
                    (this.Route != null &&
                    this.Route.Equals(input.Route))
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
                    this.LatestVersion == input.LatestVersion ||
                    (this.LatestVersion != null &&
                    this.LatestVersion.Equals(input.LatestVersion))
                ) && 
                (
                    this.Team == input.Team ||
                    (this.Team != null &&
                    this.Team.Equals(input.Team))
                ) && 
                (
                    this.Stats == input.Stats ||
                    (this.Stats != null &&
                    this.Stats.Equals(input.Stats))
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
                hashCode = hashCode * 59 + this.Active.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ShortDescription != null)
                    hashCode = hashCode * 59 + this.ShortDescription.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Requirements != null)
                    hashCode = hashCode * 59 + this.Requirements.GetHashCode();
                if (this.Price != null)
                    hashCode = hashCode * 59 + this.Price.GetHashCode();
                if (this.Images != null)
                    hashCode = hashCode * 59 + this.Images.GetHashCode();
                hashCode = hashCode * 59 + this.Views.GetHashCode();
                if (this.RatingAvg != null)
                    hashCode = hashCode * 59 + this.RatingAvg.GetHashCode();
                hashCode = hashCode * 59 + this.RatingCount.GetHashCode();
                hashCode = hashCode * 59 + this.PurchasesCount.GetHashCode();
                if (this.DependentAddon != null)
                    hashCode = hashCode * 59 + this.DependentAddon.GetHashCode();
                hashCode = hashCode * 59 + this.HasDrm.GetHashCode();
                hashCode = hashCode * 59 + this.RequiresChromium.GetHashCode();
                if (this.Slug != null)
                    hashCode = hashCode * 59 + this.Slug.GetHashCode();
                if (this.Route != null)
                    hashCode = hashCode * 59 + this.Route.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.LatestVersion != null)
                    hashCode = hashCode * 59 + this.LatestVersion.GetHashCode();
                if (this.Team != null)
                    hashCode = hashCode * 59 + this.Team.GetHashCode();
                if (this.Stats != null)
                    hashCode = hashCode * 59 + this.Stats.GetHashCode();
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
            yield break;
        }
    }

}
