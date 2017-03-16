/* 
 * Muhimbi PDF
 *
 * Convert, Merge, Watermark, Secure and OCR files.
 *
 * OpenAPI spec version: 9.9
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

namespace Muhimbi.PDF.Online.Client.Model
{
    /// <summary>
    /// Parameters for MergeToPdf operation
    /// </summary>
    [DataContract]
    public partial class MergeToPdfData :  IEquatable<MergeToPdfData>, IValidatableObject
    {
        /// <summary>
        /// Document start page
        /// </summary>
        /// <value>Document start page</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DocumentStartPageEnum
        {
            
            /// <summary>
            /// Enum Defaultpage for "Starts on the default page"
            /// </summary>
            [EnumMember(Value = "Starts on the default page")]
            Defaultpage,
            
            /// <summary>
            /// Enum Nextpage for "Starts on the next page"
            /// </summary>
            [EnumMember(Value = "Starts on the next page")]
            Nextpage,
            
            /// <summary>
            /// Enum Nextoddpage for "Starts on the next odd page"
            /// </summary>
            [EnumMember(Value = "Starts on the next odd page")]
            Nextoddpage,
            
            /// <summary>
            /// Enum Nextevenpage for "Starts on the next even page"
            /// </summary>
            [EnumMember(Value = "Starts on the next even page")]
            Nextevenpage
        }

        /// <summary>
        /// Document start page
        /// </summary>
        /// <value>Document start page</value>
        [DataMember(Name="document_start_page", EmitDefaultValue=false)]
        public DocumentStartPageEnum? DocumentStartPage { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MergeToPdfData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MergeToPdfData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MergeToPdfData" /> class.
        /// </summary>
        /// <param name="UseAsyncPattern">Use async behaviour for API request (default to false).</param>
        /// <param name="SourceFileName1">Name of the source file including extension (required).</param>
        /// <param name="SourceFileContent1">Content of the file to merge (required).</param>
        /// <param name="SourceFileName2">Name of the source file including extension (required).</param>
        /// <param name="SourceFileContent2">Content of the file to merge (required).</param>
        /// <param name="SourceFileName3">Name of the source file including extension.</param>
        /// <param name="SourceFileContent3">Content of the file to merge.</param>
        /// <param name="SourceFileName4">Name of the source file including extension.</param>
        /// <param name="SourceFileContent4">Content of the file to merge.</param>
        /// <param name="SourceFileName5">Name of the source file including extension.</param>
        /// <param name="SourceFileContent5">Content of the file to merge.</param>
        /// <param name="SharepointFile">SharepointFile.</param>
        /// <param name="SharepointFieldName">Bookmark field name (For SharePoint only).</param>
        /// <param name="DocumentStartPage">Document start page (default to DocumentStartPageEnum.Nextpage).</param>
        /// <param name="FailOnError">Fail on error (default to true).</param>
        public MergeToPdfData(bool? UseAsyncPattern = false, string SourceFileName1 = default(string), byte[] SourceFileContent1 = default(byte[]), string SourceFileName2 = default(string), byte[] SourceFileContent2 = default(byte[]), string SourceFileName3 = default(string), byte[] SourceFileContent3 = default(byte[]), string SourceFileName4 = default(string), byte[] SourceFileContent4 = default(byte[]), string SourceFileName5 = default(string), byte[] SourceFileContent5 = default(byte[]), SharepointFile SharepointFile = default(SharepointFile), string SharepointFieldName = default(string), DocumentStartPageEnum? DocumentStartPage = DocumentStartPageEnum.Nextpage, bool? FailOnError = true)
        {
            // to ensure "SourceFileName1" is required (not null)
            if (SourceFileName1 == null)
            {
                throw new InvalidDataException("SourceFileName1 is a required property for MergeToPdfData and cannot be null");
            }
            else
            {
                this.SourceFileName1 = SourceFileName1;
            }
            // to ensure "SourceFileContent1" is required (not null)
            if (SourceFileContent1 == null)
            {
                throw new InvalidDataException("SourceFileContent1 is a required property for MergeToPdfData and cannot be null");
            }
            else
            {
                this.SourceFileContent1 = SourceFileContent1;
            }
            // to ensure "SourceFileName2" is required (not null)
            if (SourceFileName2 == null)
            {
                throw new InvalidDataException("SourceFileName2 is a required property for MergeToPdfData and cannot be null");
            }
            else
            {
                this.SourceFileName2 = SourceFileName2;
            }
            // to ensure "SourceFileContent2" is required (not null)
            if (SourceFileContent2 == null)
            {
                throw new InvalidDataException("SourceFileContent2 is a required property for MergeToPdfData and cannot be null");
            }
            else
            {
                this.SourceFileContent2 = SourceFileContent2;
            }
            // use default value if no "UseAsyncPattern" provided
            if (UseAsyncPattern == null)
            {
                this.UseAsyncPattern = false;
            }
            else
            {
                this.UseAsyncPattern = UseAsyncPattern;
            }
            this.SourceFileName3 = SourceFileName3;
            this.SourceFileContent3 = SourceFileContent3;
            this.SourceFileName4 = SourceFileName4;
            this.SourceFileContent4 = SourceFileContent4;
            this.SourceFileName5 = SourceFileName5;
            this.SourceFileContent5 = SourceFileContent5;
            this.SharepointFile = SharepointFile;
            this.SharepointFieldName = SharepointFieldName;
            // use default value if no "DocumentStartPage" provided
            if (DocumentStartPage == null)
            {
                this.DocumentStartPage = DocumentStartPageEnum.Nextpage;
            }
            else
            {
                this.DocumentStartPage = DocumentStartPage;
            }
            // use default value if no "FailOnError" provided
            if (FailOnError == null)
            {
                this.FailOnError = true;
            }
            else
            {
                this.FailOnError = FailOnError;
            }
        }
        
        /// <summary>
        /// Use async behaviour for API request
        /// </summary>
        /// <value>Use async behaviour for API request</value>
        [DataMember(Name="use_async_pattern", EmitDefaultValue=false)]
        public bool? UseAsyncPattern { get; set; }
        /// <summary>
        /// Name of the source file including extension
        /// </summary>
        /// <value>Name of the source file including extension</value>
        [DataMember(Name="source_file_name_1", EmitDefaultValue=false)]
        public string SourceFileName1 { get; set; }
        /// <summary>
        /// Content of the file to merge
        /// </summary>
        /// <value>Content of the file to merge</value>
        [DataMember(Name="source_file_content_1", EmitDefaultValue=false)]
        public byte[] SourceFileContent1 { get; set; }
        /// <summary>
        /// Name of the source file including extension
        /// </summary>
        /// <value>Name of the source file including extension</value>
        [DataMember(Name="source_file_name_2", EmitDefaultValue=false)]
        public string SourceFileName2 { get; set; }
        /// <summary>
        /// Content of the file to merge
        /// </summary>
        /// <value>Content of the file to merge</value>
        [DataMember(Name="source_file_content_2", EmitDefaultValue=false)]
        public byte[] SourceFileContent2 { get; set; }
        /// <summary>
        /// Name of the source file including extension
        /// </summary>
        /// <value>Name of the source file including extension</value>
        [DataMember(Name="source_file_name_3", EmitDefaultValue=false)]
        public string SourceFileName3 { get; set; }
        /// <summary>
        /// Content of the file to merge
        /// </summary>
        /// <value>Content of the file to merge</value>
        [DataMember(Name="source_file_content_3", EmitDefaultValue=false)]
        public byte[] SourceFileContent3 { get; set; }
        /// <summary>
        /// Name of the source file including extension
        /// </summary>
        /// <value>Name of the source file including extension</value>
        [DataMember(Name="source_file_name_4", EmitDefaultValue=false)]
        public string SourceFileName4 { get; set; }
        /// <summary>
        /// Content of the file to merge
        /// </summary>
        /// <value>Content of the file to merge</value>
        [DataMember(Name="source_file_content_4", EmitDefaultValue=false)]
        public byte[] SourceFileContent4 { get; set; }
        /// <summary>
        /// Name of the source file including extension
        /// </summary>
        /// <value>Name of the source file including extension</value>
        [DataMember(Name="source_file_name_5", EmitDefaultValue=false)]
        public string SourceFileName5 { get; set; }
        /// <summary>
        /// Content of the file to merge
        /// </summary>
        /// <value>Content of the file to merge</value>
        [DataMember(Name="source_file_content_5", EmitDefaultValue=false)]
        public byte[] SourceFileContent5 { get; set; }
        /// <summary>
        /// Gets or Sets SharepointFile
        /// </summary>
        [DataMember(Name="sharepoint_file", EmitDefaultValue=false)]
        public SharepointFile SharepointFile { get; set; }
        /// <summary>
        /// Bookmark field name (For SharePoint only)
        /// </summary>
        /// <value>Bookmark field name (For SharePoint only)</value>
        [DataMember(Name="sharepoint_field_name", EmitDefaultValue=false)]
        public string SharepointFieldName { get; set; }
        /// <summary>
        /// Fail on error
        /// </summary>
        /// <value>Fail on error</value>
        [DataMember(Name="fail_on_error", EmitDefaultValue=false)]
        public bool? FailOnError { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MergeToPdfData {\n");
            sb.Append("  UseAsyncPattern: ").Append(UseAsyncPattern).Append("\n");
            sb.Append("  SourceFileName1: ").Append(SourceFileName1).Append("\n");
            sb.Append("  SourceFileContent1: ").Append(SourceFileContent1).Append("\n");
            sb.Append("  SourceFileName2: ").Append(SourceFileName2).Append("\n");
            sb.Append("  SourceFileContent2: ").Append(SourceFileContent2).Append("\n");
            sb.Append("  SourceFileName3: ").Append(SourceFileName3).Append("\n");
            sb.Append("  SourceFileContent3: ").Append(SourceFileContent3).Append("\n");
            sb.Append("  SourceFileName4: ").Append(SourceFileName4).Append("\n");
            sb.Append("  SourceFileContent4: ").Append(SourceFileContent4).Append("\n");
            sb.Append("  SourceFileName5: ").Append(SourceFileName5).Append("\n");
            sb.Append("  SourceFileContent5: ").Append(SourceFileContent5).Append("\n");
            sb.Append("  SharepointFile: ").Append(SharepointFile).Append("\n");
            sb.Append("  SharepointFieldName: ").Append(SharepointFieldName).Append("\n");
            sb.Append("  DocumentStartPage: ").Append(DocumentStartPage).Append("\n");
            sb.Append("  FailOnError: ").Append(FailOnError).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as MergeToPdfData);
        }

        /// <summary>
        /// Returns true if MergeToPdfData instances are equal
        /// </summary>
        /// <param name="other">Instance of MergeToPdfData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MergeToPdfData other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.UseAsyncPattern == other.UseAsyncPattern ||
                    this.UseAsyncPattern != null &&
                    this.UseAsyncPattern.Equals(other.UseAsyncPattern)
                ) && 
                (
                    this.SourceFileName1 == other.SourceFileName1 ||
                    this.SourceFileName1 != null &&
                    this.SourceFileName1.Equals(other.SourceFileName1)
                ) && 
                (
                    this.SourceFileContent1 == other.SourceFileContent1 ||
                    this.SourceFileContent1 != null &&
                    this.SourceFileContent1.Equals(other.SourceFileContent1)
                ) && 
                (
                    this.SourceFileName2 == other.SourceFileName2 ||
                    this.SourceFileName2 != null &&
                    this.SourceFileName2.Equals(other.SourceFileName2)
                ) && 
                (
                    this.SourceFileContent2 == other.SourceFileContent2 ||
                    this.SourceFileContent2 != null &&
                    this.SourceFileContent2.Equals(other.SourceFileContent2)
                ) && 
                (
                    this.SourceFileName3 == other.SourceFileName3 ||
                    this.SourceFileName3 != null &&
                    this.SourceFileName3.Equals(other.SourceFileName3)
                ) && 
                (
                    this.SourceFileContent3 == other.SourceFileContent3 ||
                    this.SourceFileContent3 != null &&
                    this.SourceFileContent3.Equals(other.SourceFileContent3)
                ) && 
                (
                    this.SourceFileName4 == other.SourceFileName4 ||
                    this.SourceFileName4 != null &&
                    this.SourceFileName4.Equals(other.SourceFileName4)
                ) && 
                (
                    this.SourceFileContent4 == other.SourceFileContent4 ||
                    this.SourceFileContent4 != null &&
                    this.SourceFileContent4.Equals(other.SourceFileContent4)
                ) && 
                (
                    this.SourceFileName5 == other.SourceFileName5 ||
                    this.SourceFileName5 != null &&
                    this.SourceFileName5.Equals(other.SourceFileName5)
                ) && 
                (
                    this.SourceFileContent5 == other.SourceFileContent5 ||
                    this.SourceFileContent5 != null &&
                    this.SourceFileContent5.Equals(other.SourceFileContent5)
                ) && 
                (
                    this.SharepointFile == other.SharepointFile ||
                    this.SharepointFile != null &&
                    this.SharepointFile.Equals(other.SharepointFile)
                ) && 
                (
                    this.SharepointFieldName == other.SharepointFieldName ||
                    this.SharepointFieldName != null &&
                    this.SharepointFieldName.Equals(other.SharepointFieldName)
                ) && 
                (
                    this.DocumentStartPage == other.DocumentStartPage ||
                    this.DocumentStartPage != null &&
                    this.DocumentStartPage.Equals(other.DocumentStartPage)
                ) && 
                (
                    this.FailOnError == other.FailOnError ||
                    this.FailOnError != null &&
                    this.FailOnError.Equals(other.FailOnError)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.UseAsyncPattern != null)
                    hash = hash * 59 + this.UseAsyncPattern.GetHashCode();
                if (this.SourceFileName1 != null)
                    hash = hash * 59 + this.SourceFileName1.GetHashCode();
                if (this.SourceFileContent1 != null)
                    hash = hash * 59 + this.SourceFileContent1.GetHashCode();
                if (this.SourceFileName2 != null)
                    hash = hash * 59 + this.SourceFileName2.GetHashCode();
                if (this.SourceFileContent2 != null)
                    hash = hash * 59 + this.SourceFileContent2.GetHashCode();
                if (this.SourceFileName3 != null)
                    hash = hash * 59 + this.SourceFileName3.GetHashCode();
                if (this.SourceFileContent3 != null)
                    hash = hash * 59 + this.SourceFileContent3.GetHashCode();
                if (this.SourceFileName4 != null)
                    hash = hash * 59 + this.SourceFileName4.GetHashCode();
                if (this.SourceFileContent4 != null)
                    hash = hash * 59 + this.SourceFileContent4.GetHashCode();
                if (this.SourceFileName5 != null)
                    hash = hash * 59 + this.SourceFileName5.GetHashCode();
                if (this.SourceFileContent5 != null)
                    hash = hash * 59 + this.SourceFileContent5.GetHashCode();
                if (this.SharepointFile != null)
                    hash = hash * 59 + this.SharepointFile.GetHashCode();
                if (this.SharepointFieldName != null)
                    hash = hash * 59 + this.SharepointFieldName.GetHashCode();
                if (this.DocumentStartPage != null)
                    hash = hash * 59 + this.DocumentStartPage.GetHashCode();
                if (this.FailOnError != null)
                    hash = hash * 59 + this.FailOnError.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}