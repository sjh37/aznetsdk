// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Media.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Describes the basic properties for encoding the input video.
    /// </summary>
    [Newtonsoft.Json.JsonObject("#Microsoft.Media.Video")]
    public partial class Video : Codec
    {
        /// <summary>
        /// Initializes a new instance of the Video class.
        /// </summary>
        public Video()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Video class.
        /// </summary>
        /// <param name="label">An optional label for the codec. The label can
        /// be used to control muxing behavior.</param>
        /// <param name="keyFrameInterval">The distance between two key frames,
        /// thereby defining a group of pictures (GOP). The value should be a
        /// non-zero integer in the range [1, 30] seconds, specified in ISO
        /// 8601 format. The default is 2 seconds (PT2S).</param>
        /// <param name="stretchMode">The resizing mode - how the input video
        /// will be resized to fit the desired output resolution(s). Default is
        /// AutoSize. Possible values include: 'None', 'AutoSize',
        /// 'AutoFit'</param>
        public Video(string label = default(string), System.TimeSpan? keyFrameInterval = default(System.TimeSpan?), StretchMode? stretchMode = default(StretchMode?))
            : base(label)
        {
            KeyFrameInterval = keyFrameInterval;
            StretchMode = stretchMode;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the distance between two key frames, thereby defining
        /// a group of pictures (GOP). The value should be a non-zero integer
        /// in the range [1, 30] seconds, specified in ISO 8601 format. The
        /// default is 2 seconds (PT2S).
        /// </summary>
        [JsonProperty(PropertyName = "keyFrameInterval")]
        public System.TimeSpan? KeyFrameInterval { get; set; }

        /// <summary>
        /// Gets or sets the resizing mode - how the input video will be
        /// resized to fit the desired output resolution(s). Default is
        /// AutoSize. Possible values include: 'None', 'AutoSize', 'AutoFit'
        /// </summary>
        [JsonProperty(PropertyName = "stretchMode")]
        public StretchMode? StretchMode { get; set; }

    }
}
