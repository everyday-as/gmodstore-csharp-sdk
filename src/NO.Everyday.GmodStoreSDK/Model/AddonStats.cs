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
    /// AddonStats
    /// </summary>
    [DataContract]
        public partial class AddonStats :  IEquatable<AddonStats>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddonStats" /> class.
        /// </summary>
        /// <param name="revenue">revenue.</param>
        /// <param name="views">views.</param>
        /// <param name="sales">sales.</param>
        public AddonStats(AddonStatsRevenue revenue = default(AddonStatsRevenue), AddonStatsViews views = default(AddonStatsViews), AddonStatsSales sales = default(AddonStatsSales))
        {
            this.Revenue = revenue;
            this.Views = views;
            this.Sales = sales;
        }
        
        /// <summary>
        /// Gets or Sets Revenue
        /// </summary>
        [DataMember(Name="revenue", EmitDefaultValue=false)]
        public AddonStatsRevenue Revenue { get; set; }

        /// <summary>
        /// Gets or Sets Views
        /// </summary>
        [DataMember(Name="views", EmitDefaultValue=false)]
        public AddonStatsViews Views { get; set; }

        /// <summary>
        /// Gets or Sets Sales
        /// </summary>
        [DataMember(Name="sales", EmitDefaultValue=false)]
        public AddonStatsSales Sales { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddonStats {\n");
            sb.Append("  Revenue: ").Append(Revenue).Append("\n");
            sb.Append("  Views: ").Append(Views).Append("\n");
            sb.Append("  Sales: ").Append(Sales).Append("\n");
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
            return this.Equals(input as AddonStats);
        }

        /// <summary>
        /// Returns true if AddonStats instances are equal
        /// </summary>
        /// <param name="input">Instance of AddonStats to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddonStats input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Revenue == input.Revenue ||
                    (this.Revenue != null &&
                    this.Revenue.Equals(input.Revenue))
                ) && 
                (
                    this.Views == input.Views ||
                    (this.Views != null &&
                    this.Views.Equals(input.Views))
                ) && 
                (
                    this.Sales == input.Sales ||
                    (this.Sales != null &&
                    this.Sales.Equals(input.Sales))
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
                if (this.Revenue != null)
                    hashCode = hashCode * 59 + this.Revenue.GetHashCode();
                if (this.Views != null)
                    hashCode = hashCode * 59 + this.Views.GetHashCode();
                if (this.Sales != null)
                    hashCode = hashCode * 59 + this.Sales.GetHashCode();
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
