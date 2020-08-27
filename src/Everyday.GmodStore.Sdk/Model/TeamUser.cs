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
    /// TeamUser
    /// </summary>
    [DataContract]
    public partial class TeamUser :  IEquatable<TeamUser>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TeamUser" /> class.
        /// </summary>
        /// <param name="teamId">teamId.</param>
        /// <param name="primary">primary.</param>
        /// <param name="user">user.</param>
        public TeamUser(int teamId = default(int), bool primary = default(bool), User user = default(User))
        {
            this.TeamId = teamId;
            this.Primary = primary;
            this.User = user;
        }
        
        /// <summary>
        /// Gets or Sets TeamId
        /// </summary>
        [DataMember(Name="team_id", EmitDefaultValue=false)]
        public int TeamId { get; set; }

        /// <summary>
        /// Gets or Sets Primary
        /// </summary>
        [DataMember(Name="primary", EmitDefaultValue=false)]
        public bool Primary { get; set; }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public User User { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TeamUser {\n");
            sb.Append("  TeamId: ").Append(TeamId).Append("\n");
            sb.Append("  Primary: ").Append(Primary).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
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
            return this.Equals(input as TeamUser);
        }

        /// <summary>
        /// Returns true if TeamUser instances are equal
        /// </summary>
        /// <param name="input">Instance of TeamUser to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TeamUser input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TeamId == input.TeamId ||
                    this.TeamId.Equals(input.TeamId)
                ) && 
                (
                    this.Primary == input.Primary ||
                    this.Primary.Equals(input.Primary)
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
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
                hashCode = hashCode * 59 + this.TeamId.GetHashCode();
                hashCode = hashCode * 59 + this.Primary.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
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
