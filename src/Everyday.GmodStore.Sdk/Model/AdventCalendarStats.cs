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
    /// AdventCalendarStats
    /// </summary>
    [DataContract(Name = "AdventCalendarStats")]
    public partial class AdventCalendarStats : IEquatable<AdventCalendarStats>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdventCalendarStats" /> class.
        /// </summary>
        /// <param name="squaresOpened">squaresOpened.</param>
        /// <param name="addonsAwarded">addonsAwarded.</param>
        /// <param name="couponsAwarded">couponsAwarded.</param>
        public AdventCalendarStats(int squaresOpened = default(int), int addonsAwarded = default(int), int couponsAwarded = default(int))
        {
            this.SquaresOpened = squaresOpened;
            this.AddonsAwarded = addonsAwarded;
            this.CouponsAwarded = couponsAwarded;
        }

        /// <summary>
        /// Gets or Sets SquaresOpened
        /// </summary>
        [DataMember(Name = "squares_opened", EmitDefaultValue = false)]
        public int SquaresOpened { get; set; }

        /// <summary>
        /// Gets or Sets AddonsAwarded
        /// </summary>
        [DataMember(Name = "addons_awarded", EmitDefaultValue = false)]
        public int AddonsAwarded { get; set; }

        /// <summary>
        /// Gets or Sets CouponsAwarded
        /// </summary>
        [DataMember(Name = "coupons_awarded", EmitDefaultValue = false)]
        public int CouponsAwarded { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdventCalendarStats {\n");
            sb.Append("  SquaresOpened: ").Append(SquaresOpened).Append("\n");
            sb.Append("  AddonsAwarded: ").Append(AddonsAwarded).Append("\n");
            sb.Append("  CouponsAwarded: ").Append(CouponsAwarded).Append("\n");
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
            return this.Equals(input as AdventCalendarStats);
        }

        /// <summary>
        /// Returns true if AdventCalendarStats instances are equal
        /// </summary>
        /// <param name="input">Instance of AdventCalendarStats to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdventCalendarStats input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SquaresOpened == input.SquaresOpened ||
                    this.SquaresOpened.Equals(input.SquaresOpened)
                ) && 
                (
                    this.AddonsAwarded == input.AddonsAwarded ||
                    this.AddonsAwarded.Equals(input.AddonsAwarded)
                ) && 
                (
                    this.CouponsAwarded == input.CouponsAwarded ||
                    this.CouponsAwarded.Equals(input.CouponsAwarded)
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
                hashCode = hashCode * 59 + this.SquaresOpened.GetHashCode();
                hashCode = hashCode * 59 + this.AddonsAwarded.GetHashCode();
                hashCode = hashCode * 59 + this.CouponsAwarded.GetHashCode();
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
