// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The Edifact delimiter override settings. </summary>
    public partial class EdifactDelimiterOverride
    {
        /// <summary> Initializes a new instance of EdifactDelimiterOverride. </summary>
        /// <param name="dataElementSeparator"> The data element separator. </param>
        /// <param name="componentSeparator"> The component separator. </param>
        /// <param name="segmentTerminator"> The segment terminator. </param>
        /// <param name="repetitionSeparator"> The repetition separator. </param>
        /// <param name="segmentTerminatorSuffix"> The segment terminator suffix. </param>
        /// <param name="decimalPointIndicator"> The decimal point indicator. </param>
        /// <param name="releaseIndicator"> The release indicator. </param>
        public EdifactDelimiterOverride(int dataElementSeparator, int componentSeparator, int segmentTerminator, int repetitionSeparator, SegmentTerminatorSuffix segmentTerminatorSuffix, EdifactDecimalIndicator decimalPointIndicator, int releaseIndicator)
        {
            DataElementSeparator = dataElementSeparator;
            ComponentSeparator = componentSeparator;
            SegmentTerminator = segmentTerminator;
            RepetitionSeparator = repetitionSeparator;
            SegmentTerminatorSuffix = segmentTerminatorSuffix;
            DecimalPointIndicator = decimalPointIndicator;
            ReleaseIndicator = releaseIndicator;
        }

        /// <summary> Initializes a new instance of EdifactDelimiterOverride. </summary>
        /// <param name="messageId"> The message id. </param>
        /// <param name="messageVersion"> The message version. </param>
        /// <param name="messageRelease"> The message release. </param>
        /// <param name="dataElementSeparator"> The data element separator. </param>
        /// <param name="componentSeparator"> The component separator. </param>
        /// <param name="segmentTerminator"> The segment terminator. </param>
        /// <param name="repetitionSeparator"> The repetition separator. </param>
        /// <param name="segmentTerminatorSuffix"> The segment terminator suffix. </param>
        /// <param name="decimalPointIndicator"> The decimal point indicator. </param>
        /// <param name="releaseIndicator"> The release indicator. </param>
        /// <param name="messageAssociationAssignedCode"> The message association assigned code. </param>
        /// <param name="targetNamespace"> The target namespace on which this delimiter settings has to be applied. </param>
        internal EdifactDelimiterOverride(string messageId, string messageVersion, string messageRelease, int dataElementSeparator, int componentSeparator, int segmentTerminator, int repetitionSeparator, SegmentTerminatorSuffix segmentTerminatorSuffix, EdifactDecimalIndicator decimalPointIndicator, int releaseIndicator, string messageAssociationAssignedCode, string targetNamespace)
        {
            MessageId = messageId;
            MessageVersion = messageVersion;
            MessageRelease = messageRelease;
            DataElementSeparator = dataElementSeparator;
            ComponentSeparator = componentSeparator;
            SegmentTerminator = segmentTerminator;
            RepetitionSeparator = repetitionSeparator;
            SegmentTerminatorSuffix = segmentTerminatorSuffix;
            DecimalPointIndicator = decimalPointIndicator;
            ReleaseIndicator = releaseIndicator;
            MessageAssociationAssignedCode = messageAssociationAssignedCode;
            TargetNamespace = targetNamespace;
        }

        /// <summary> The message id. </summary>
        public string MessageId { get; set; }
        /// <summary> The message version. </summary>
        public string MessageVersion { get; set; }
        /// <summary> The message release. </summary>
        public string MessageRelease { get; set; }
        /// <summary> The data element separator. </summary>
        public int DataElementSeparator { get; set; }
        /// <summary> The component separator. </summary>
        public int ComponentSeparator { get; set; }
        /// <summary> The segment terminator. </summary>
        public int SegmentTerminator { get; set; }
        /// <summary> The repetition separator. </summary>
        public int RepetitionSeparator { get; set; }
        /// <summary> The segment terminator suffix. </summary>
        public SegmentTerminatorSuffix SegmentTerminatorSuffix { get; set; }
        /// <summary> The decimal point indicator. </summary>
        public EdifactDecimalIndicator DecimalPointIndicator { get; set; }
        /// <summary> The release indicator. </summary>
        public int ReleaseIndicator { get; set; }
        /// <summary> The message association assigned code. </summary>
        public string MessageAssociationAssignedCode { get; set; }
        /// <summary> The target namespace on which this delimiter settings has to be applied. </summary>
        public string TargetNamespace { get; set; }
    }
}
