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
/// AddonStatsRevenue
/// </summary>
[DataContract]
public partial class AddonStatsRevenue :  IEquatable<AddonStatsRevenue>, IValidatableObject
{
/// <summary>
/// Initializes a new instance of the <see cref="AddonStatsRevenue" /> class.
/// </summary>
/// <param name="current">current.</param>
/// <param name="previous">previous.</param>
/// <param name="total">total.</param>
public AddonStatsRevenue(AddonStatsRevenueCurrent current = default(AddonStatsRevenueCurrent), AddonStatsRevenueCurrent previous = default(AddonStatsRevenueCurrent), Money total = default(Money))
{
	this.Current = current;
	this.Previous = previous;
	this.Total = total;
}

/// <summary>
/// Gets or Sets Current
/// </summary>
[DataMember(Name="current", EmitDefaultValue=false)]
public AddonStatsRevenueCurrent Current {
	get; set;
}

/// <summary>
/// Gets or Sets Previous
/// </summary>
[DataMember(Name="previous", EmitDefaultValue=false)]
public AddonStatsRevenueCurrent Previous {
	get; set;
}

/// <summary>
/// Gets or Sets Total
/// </summary>
[DataMember(Name="total", EmitDefaultValue=false)]
public Money Total {
	get; set;
}

/// <summary>
/// Returns the string presentation of the object
/// </summary>
/// <returns>String presentation of the object</returns>
public override string ToString()
{
	var sb = new StringBuilder();
	sb.Append("class AddonStatsRevenue {\n");
	sb.Append("  Current: ").Append(Current).Append("\n");
	sb.Append("  Previous: ").Append(Previous).Append("\n");
	sb.Append("  Total: ").Append(Total).Append("\n");
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
	return this.Equals(input as AddonStatsRevenue);
}

/// <summary>
/// Returns true if AddonStatsRevenue instances are equal
/// </summary>
/// <param name="input">Instance of AddonStatsRevenue to be compared</param>
/// <returns>Boolean</returns>
public bool Equals(AddonStatsRevenue input)
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
	        ) &&
		(
		this.Total == input.Total ||
		(this.Total != null &&
		 this.Total.Equals(input.Total))
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
		if (this.Total != null)
			hashCode = hashCode * 59 + this.Total.GetHashCode();
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
