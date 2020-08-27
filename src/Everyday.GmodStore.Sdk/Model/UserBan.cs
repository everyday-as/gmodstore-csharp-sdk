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
/// UserBan
/// </summary>
[DataContract]
public partial class UserBan :  IEquatable<UserBan>, IValidatableObject
{
/// <summary>
/// Defines Properties
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum PropertiesEnum
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
/// Gets or Sets Properties
/// </summary>
[DataMember(Name="properties", EmitDefaultValue=false)]
public List<PropertiesEnum> Properties {
	get; set;
}
/// <summary>
/// Initializes a new instance of the <see cref="UserBan" /> class.
/// </summary>
/// <param name="userId">userId.</param>
/// <param name="reason">reason.</param>
/// <param name="unbanReason">unbanReason.</param>
/// <param name="properties">properties.</param>
/// <param name="start">start.</param>
/// <param name="end">end.</param>
public UserBan(long userId = default(long), string reason = default(string), string unbanReason = default(string), List<PropertiesEnum> properties = default(List<PropertiesEnum>), DateTime start = default(DateTime), DateTime end = default(DateTime))
{
	this.UserId = userId;
	this.Reason = reason;
	this.UnbanReason = unbanReason;
	this.Properties = properties;
	this.Start = start;
	this.End = end;
}

/// <summary>
/// Gets or Sets UserId
/// </summary>
[DataMember(Name="user_id", EmitDefaultValue=false)]
public long UserId {
	get; set;
}

/// <summary>
/// Gets or Sets Reason
/// </summary>
[DataMember(Name="reason", EmitDefaultValue=false)]
public string Reason {
	get; set;
}

/// <summary>
/// Gets or Sets UnbanReason
/// </summary>
[DataMember(Name="unban_reason", EmitDefaultValue=false)]
public string UnbanReason {
	get; set;
}

/// <summary>
/// Gets or Sets Start
/// </summary>
[DataMember(Name="start", EmitDefaultValue=false)]
public DateTime Start {
	get; set;
}

/// <summary>
/// Gets or Sets End
/// </summary>
[DataMember(Name="end", EmitDefaultValue=false)]
public DateTime End {
	get; set;
}

/// <summary>
/// Returns the string presentation of the object
/// </summary>
/// <returns>String presentation of the object</returns>
public override string ToString()
{
	var sb = new StringBuilder();
	sb.Append("class UserBan {\n");
	sb.Append("  UserId: ").Append(UserId).Append("\n");
	sb.Append("  Reason: ").Append(Reason).Append("\n");
	sb.Append("  UnbanReason: ").Append(UnbanReason).Append("\n");
	sb.Append("  Properties: ").Append(Properties).Append("\n");
	sb.Append("  Start: ").Append(Start).Append("\n");
	sb.Append("  End: ").Append(End).Append("\n");
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
	return this.Equals(input as UserBan);
}

/// <summary>
/// Returns true if UserBan instances are equal
/// </summary>
/// <param name="input">Instance of UserBan to be compared</param>
/// <returns>Boolean</returns>
public bool Equals(UserBan input)
{
	if (input == null)
		return false;

	return
		(
		this.UserId == input.UserId ||
		this.UserId.Equals(input.UserId)
	        ) &&
		(
		this.Reason == input.Reason ||
		(this.Reason != null &&
		 this.Reason.Equals(input.Reason))
	        ) &&
		(
		this.UnbanReason == input.UnbanReason ||
		(this.UnbanReason != null &&
		 this.UnbanReason.Equals(input.UnbanReason))
	        ) &&
		(
		this.Properties == input.Properties ||
		this.Properties.SequenceEqual(input.Properties)
	        ) &&
		(
		this.Start == input.Start ||
		(this.Start != null &&
		 this.Start.Equals(input.Start))
	        ) &&
		(
		this.End == input.End ||
		(this.End != null &&
		 this.End.Equals(input.End))
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
		hashCode = hashCode * 59 + this.UserId.GetHashCode();
		if (this.Reason != null)
			hashCode = hashCode * 59 + this.Reason.GetHashCode();
		if (this.UnbanReason != null)
			hashCode = hashCode * 59 + this.UnbanReason.GetHashCode();
		hashCode = hashCode * 59 + this.Properties.GetHashCode();
		if (this.Start != null)
			hashCode = hashCode * 59 + this.Start.GetHashCode();
		if (this.End != null)
			hashCode = hashCode * 59 + this.End.GetHashCode();
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
