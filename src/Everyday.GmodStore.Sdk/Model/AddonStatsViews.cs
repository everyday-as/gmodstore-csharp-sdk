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
/// AddonStatsViews
/// </summary>
[DataContract]
public partial class AddonStatsViews :  IEquatable<AddonStatsViews>, IValidatableObject
{
/// <summary>
/// Initializes a new instance of the <see cref="AddonStatsViews" /> class.
/// </summary>
/// <param name="current">current.</param>
/// <param name="previous">previous.</param>
public AddonStatsViews(AddonStatsViewsCurrent current = default(AddonStatsViewsCurrent), AddonStatsViewsCurrent previous = default(AddonStatsViewsCurrent))
{
	this.Current = current;
	this.Previous = previous;
}

/// <summary>
/// Gets or Sets Current
/// </summary>
[DataMember(Name="current", EmitDefaultValue=false)]
public AddonStatsViewsCurrent Current {
	get; set;
}

/// <summary>
/// Gets or Sets Previous
/// </summary>
[DataMember(Name="previous", EmitDefaultValue=false)]
public AddonStatsViewsCurrent Previous {
	get; set;
}

/// <summary>
/// Returns the string presentation of the object
/// </summary>
/// <returns>String presentation of the object</returns>
public override string ToString()
{
	var sb = new StringBuilder();
	sb.Append("class AddonStatsViews {\n");
	sb.Append("  Current: ").Append(Current).Append("\n");
	sb.Append("  Previous: ").Append(Previous).Append("\n");
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
	return this.Equals(input as AddonStatsViews);
}

/// <summary>
/// Returns true if AddonStatsViews instances are equal
/// </summary>
/// <param name="input">Instance of AddonStatsViews to be compared</param>
/// <returns>Boolean</returns>
public bool Equals(AddonStatsViews input)
{
	if (input == null)
		return false;

	return
		(
		this.Current == input.Current ||
		(this.Current != null &&
		 this.Current.Equals(input.Current))
	        ) &&
		(
		this.Previous == input.Previous ||
		(this.Previous != null &&
		 this.Previous.Equals(input.Previous))
	        );
}

/// <summary>
/// Gets the hash code
/// </summary>
/// <returns>Hash code</returns>
public override int GetHashCode()
{
	unchecked     // Overflow is fine, just wrap
	{
		int hashCode = 41;
		if (this.Current != null)
			hashCode = hashCode * 59 + this.Current.GetHashCode();
		if (this.Previous != null)
			hashCode = hashCode * 59 + this.Previous.GetHashCode();
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
