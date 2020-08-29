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
/// NewAddonVersion
/// </summary>
[DataContract]
public partial class NewAddonVersion :  IEquatable<NewAddonVersion>, IValidatableObject
{
/// <summary>
/// Gets or Sets ReleaseType
/// </summary>
[DataMember(Name="release_type", EmitDefaultValue=false)]
public AddonVersionReleaseType? ReleaseType {
	get; set;
}
/// <summary>
/// Initializes a new instance of the <see cref="NewAddonVersion" /> class.
/// </summary>
[JsonConstructorAttribute]
protected NewAddonVersion() {
}
/// <summary>
/// Initializes a new instance of the <see cref="NewAddonVersion" /> class.
/// </summary>
/// <param name="name">name (required).</param>
/// <param name="changelog">You can pass in markdown here (required).</param>
/// <param name="file">file (required).</param>
/// <param name="releaseType">releaseType.</param>
public NewAddonVersion(string name = default(string), string changelog = default(string), System.IO.Stream file = default(System.IO.Stream), AddonVersionReleaseType? releaseType = default(AddonVersionReleaseType?))
{
	// to ensure "name" is required (not null)
	this.Name = name ?? throw new ArgumentNullException("name is a required property for NewAddonVersion and cannot be null");
	// to ensure "changelog" is required (not null)
	this.Changelog = changelog ?? throw new ArgumentNullException("changelog is a required property for NewAddonVersion and cannot be null");
	// to ensure "file" is required (not null)
	this.File = file ?? throw new ArgumentNullException("file is a required property for NewAddonVersion and cannot be null");
	this.ReleaseType = releaseType;
}

/// <summary>
/// Gets or Sets Name
/// </summary>
[DataMember(Name="name", EmitDefaultValue=false)]
public string Name {
	get; set;
}

/// <summary>
/// You can pass in markdown here
/// </summary>
/// <value>You can pass in markdown here</value>
[DataMember(Name="changelog", EmitDefaultValue=false)]
public string Changelog {
	get; set;
}

/// <summary>
/// Gets or Sets File
/// </summary>
[DataMember(Name="file", EmitDefaultValue=false)]
public System.IO.Stream File {
	get; set;
}

/// <summary>
/// Returns the string presentation of the object
/// </summary>
/// <returns>String presentation of the object</returns>
public override string ToString()
{
	var sb = new StringBuilder();
	sb.Append("class NewAddonVersion {\n");
	sb.Append("  Name: ").Append(Name).Append("\n");
	sb.Append("  Changelog: ").Append(Changelog).Append("\n");
	sb.Append("  File: ").Append(File).Append("\n");
	sb.Append("  ReleaseType: ").Append(ReleaseType).Append("\n");
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
	return this.Equals(input as NewAddonVersion);
}

/// <summary>
/// Returns true if NewAddonVersion instances are equal
/// </summary>
/// <param name="input">Instance of NewAddonVersion to be compared</param>
/// <returns>Boolean</returns>
public bool Equals(NewAddonVersion input)
{
	if (input == null)
		return false;

	return
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
		this.File == input.File ||
		(this.File != null &&
		 this.File.Equals(input.File))
	        ) &&
		(
		this.ReleaseType == input.ReleaseType ||
		this.ReleaseType.Equals(input.ReleaseType)
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
		if (this.Name != null)
			hashCode = hashCode * 59 + this.Name.GetHashCode();
		if (this.Changelog != null)
			hashCode = hashCode * 59 + this.Changelog.GetHashCode();
		if (this.File != null)
			hashCode = hashCode * 59 + this.File.GetHashCode();
		hashCode = hashCode * 59 + this.ReleaseType.GetHashCode();
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
