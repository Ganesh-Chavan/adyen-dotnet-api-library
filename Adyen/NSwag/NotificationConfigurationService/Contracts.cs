﻿//----------------------
// <auto-generated>
//     Generated using the NSwag toolchain v13.0.1.0 (NJsonSchema v10.0.19.0 (Newtonsoft.Json v11.0.0.0)) (http://NSwag.org)
// </auto-generated>
//----------------------

#pragma warning disable 108 // Disable "CS0108 '{derivedDto}.ToJson()' hides inherited member '{dtoBase}.ToJson()'. Use the new keyword if hiding was intended."
#pragma warning disable 114 // Disable "CS0114 '{derivedDto}.RaisePropertyChanged(String)' hides inherited member 'dtoBase.RaisePropertyChanged(String)'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword."
#pragma warning disable 472 // Disable "CS0472 The result of the expression is always 'false' since a value of type 'Int32' is never equal to 'null' of type 'Int32?'
#pragma warning disable 1573 // Disable "CS1573 Parameter '...' has no matching param tag in the XML comment for ...
#pragma warning disable 1591 // Disable "CS1591 Missing XML comment for publicly visible type or member ..."

namespace  Adeyn.MarketPay.NotificationConfiguration
{
    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.19.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class CreateNotificationConfigurationRequest 
    {
        /// <summary>Details of the prospective notification subscription configuration.</summary>
        [Newtonsoft.Json.JsonProperty("configurationDetails", Required = Newtonsoft.Json.Required.Always)]
        public NotificationConfigurationDetails ConfigurationDetails { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.19.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class DeleteNotificationConfigurationRequest 
    {
        /// <summary>A list of IDs of the notification subscription configurations to be deleted.</summary>
        [Newtonsoft.Json.JsonProperty("notificationIds", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.Generic.ICollection<long> NotificationIds { get; set; } = new System.Collections.ObjectModel.Collection<long>();
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.19.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class EmptyRequest 
    {
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.19.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class ExchangeMessage 
    {
        [Newtonsoft.Json.JsonProperty("messageCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MessageCode { get; set; }
    
        [Newtonsoft.Json.JsonProperty("messageDescription", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MessageDescription { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.19.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class GenericResponse 
    {
        /// <summary>The reference of a request.  Can be used to uniquely identify the request.</summary>
        [Newtonsoft.Json.JsonProperty("pspReference", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string PspReference { get; set; }
    
        /// <summary>Indicates whether the request is processed synchronously or asynchronously.  Depending on the request's marketplace settings, the following scenarios may be applied:
        /// * **sync:** The processing of the request is immediately attempted; it may result in an error if the providing service is unavailable.
        /// * **async:** The request is queued and will be executed when the providing service is available in the order in which the requests are received.
        /// * **asyncOnError:** The processing of the request is immediately attempted, but if the providing service is unavailable, the request is scheduled in a queue.</summary>
        [Newtonsoft.Json.JsonProperty("submittedAsync", Required = Newtonsoft.Json.Required.Always)]
        public bool SubmittedAsync { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.19.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class GetNotificationConfigurationListResponse 
    {
        /// <summary>Details of the notification subscription configurations.</summary>
        [Newtonsoft.Json.JsonProperty("configurations", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.Generic.ICollection<NotificationConfigurationDetails> Configurations { get; set; } = new System.Collections.ObjectModel.Collection<NotificationConfigurationDetails>();
    
        /// <summary>The reference of a request.  Can be used to uniquely identify the request.</summary>
        [Newtonsoft.Json.JsonProperty("pspReference", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string PspReference { get; set; }
    
        /// <summary>Indicates whether the request is processed synchronously or asynchronously.  Depending on the request's marketplace settings, the following scenarios may be applied:
        /// * **sync:** The processing of the request is immediately attempted; it may result in an error if the providing service is unavailable.
        /// * **async:** The request is queued and will be executed when the providing service is available in the order in which the requests are received.
        /// * **asyncOnError:** The processing of the request is immediately attempted, but if the providing service is unavailable, the request is scheduled in a queue.</summary>
        [Newtonsoft.Json.JsonProperty("submittedAsync", Required = Newtonsoft.Json.Required.Always)]
        public bool SubmittedAsync { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.19.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class GetNotificationConfigurationRequest 
    {
        /// <summary>The ID of the notification subscription configuration whose details are to be retrieved.</summary>
        [Newtonsoft.Json.JsonProperty("notificationId", Required = Newtonsoft.Json.Required.Always)]
        public long NotificationId { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.19.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class GetNotificationConfigurationResponse 
    {
        /// <summary>Details of the notification subscription configuration.</summary>
        [Newtonsoft.Json.JsonProperty("configurationDetails", Required = Newtonsoft.Json.Required.Always)]
        public NotificationConfigurationDetails ConfigurationDetails { get; set; }
    
        /// <summary>The reference of a request.  Can be used to uniquely identify the request.</summary>
        [Newtonsoft.Json.JsonProperty("pspReference", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string PspReference { get; set; }
    
        /// <summary>Indicates whether the request is processed synchronously or asynchronously.  Depending on the request's marketplace settings, the following scenarios may be applied:
        /// * **sync:** The processing of the request is immediately attempted; it may result in an error if the providing service is unavailable.
        /// * **async:** The request is queued and will be executed when the providing service is available in the order in which the requests are received.
        /// * **asyncOnError:** The processing of the request is immediately attempted, but if the providing service is unavailable, the request is scheduled in a queue.</summary>
        [Newtonsoft.Json.JsonProperty("submittedAsync", Required = Newtonsoft.Json.Required.Always)]
        public bool SubmittedAsync { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.19.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class NotificationConfigurationDetails 
    {
        /// <summary>Indicates whether the notification subscription is active.</summary>
        [Newtonsoft.Json.JsonProperty("active", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool Active { get; set; }
    
        /// <summary>The API version of the notification to send.</summary>
        [Newtonsoft.Json.JsonProperty("apiVersion", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int ApiVersion { get; set; }
    
        /// <summary>A description of the notification subscription configuration.
        /// &gt;Required when creating a configuration, forbidden when updating a configuration.</summary>
        [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Description { get; set; }
    
        /// <summary>The types of events whose notifications apply to this configuration.</summary>
        [Newtonsoft.Json.JsonProperty("eventConfigs", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.Generic.ICollection<NotificationEventConfiguration> EventConfigs { get; set; } = new System.Collections.ObjectModel.Collection<NotificationEventConfiguration>();
    
        /// <summary>The ID of the configuration.
        /// &gt;Required if updating an existing configuration, ignored during the creation of a configuration.</summary>
        [Newtonsoft.Json.JsonProperty("notificationId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long NotificationId { get; set; }
    
        /// <summary>The password to use when accessing the notifyURL with the specified username.</summary>
        [Newtonsoft.Json.JsonProperty("notifyPassword", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NotifyPassword { get; set; }
    
        /// <summary>The URL to which the notifications are to be sent.</summary>
        [Newtonsoft.Json.JsonProperty("notifyURL", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string NotifyURL { get; set; }
    
        /// <summary>The username to use when accessing the notifyURL.</summary>
        [Newtonsoft.Json.JsonProperty("notifyUsername", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NotifyUsername { get; set; }
    
        /// <summary>The SSL protocol employed by the endpoint.
        /// &gt;Permitted values: `SSL`, `SSLv3`, `SSLInsecureCiphers`, `TLS`, `TLSv10`, `TLSv10InsecureCiphers`, `TLSv11`, `TLSv12`.</summary>
        [Newtonsoft.Json.JsonProperty("sslProtocol", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public NotificationConfigurationDetailsSslProtocol SslProtocol { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.19.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class NotificationEventConfiguration 
    {
        /// <summary>The type of event triggering the notification.
        /// &gt;Permitted values: `ACCOUNT_HOLDER_CREATED`, `ACCOUNT_CREATED`, `ACCOUNT_UPDATED`, `ACCOUNT_HOLDER_UPDATED`, `ACCOUNT_HOLDER_STATUS_CHANGE`, `ACCOUNT_HOLDER_VERIFICATION`, `ACCOUNT_HOLDER_LIMIT_REACHED`, `ACCOUNT_HOLDER_PAYOUT`, `PAYMENT_FAILURE`, `SCHEDULED_REFUNDS`, `REPORT_AVAILABLE`, `TRANSFER_FUNDS`, `BENEFICIARY_SETUP`, `COMPENSATE_NEGATIVE_BALANCE`.</summary>
        [Newtonsoft.Json.JsonProperty("eventType", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public NotificationEventConfigurationEventType EventType { get; set; }
    
        /// <summary>Indicates whether the specified eventType is to be sent to the endpoint or all events other than the specified eventType (and other specified eventTypes) are to be sent.
        /// &gt;Permitted values: `INCLUDE`, `EXCLUDE`.
        /// &gt;- `INCLUDE`: send the specified eventType.
        /// &gt;- `EXCLUDE`: send all eventTypes other than the specified eventType (and other eventTypes marked with `EXCLUDE`).</summary>
        [Newtonsoft.Json.JsonProperty("includeMode", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public NotificationEventConfigurationIncludeMode IncludeMode { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.19.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class TestNotificationConfigurationRequest 
    {
        /// <summary>The event types to test.  If left blank, then all of the configured event types will be tested.
        /// &gt;Permitted values: `ACCOUNT_HOLDER_CREATED`, `ACCOUNT_CREATED`, `ACCOUNT_UPDATED`, `ACCOUNT_HOLDER_UPDATED`, `ACCOUNT_HOLDER_STATUS_CHANGE`, `ACCOUNT_HOLDER_VERIFICATION`, `ACCOUNT_HOLDER_LIMIT_REACHED`, `ACCOUNT_HOLDER_PAYOUT`, `PAYMENT_FAILURE`, `SCHEDULED_REFUNDS`, `REPORT_AVAILABLE`, `TRANSFER_FUNDS`, `BENEFICIARY_SETUP`, `COMPENSATE_NEGATIVE_BALANCE`.</summary>
        [Newtonsoft.Json.JsonProperty("eventTypes", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore, ItemConverterType = typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public System.Collections.Generic.ICollection<EventTypes> EventTypes { get; set; }
    
        /// <summary>The ID of the notification subscription configuration to be tested.</summary>
        [Newtonsoft.Json.JsonProperty("notificationId", Required = Newtonsoft.Json.Required.Always)]
        public long NotificationId { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.19.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class TestNotificationConfigurationResponse 
    {
        /// <summary>Any error messages encountered.</summary>
        [Newtonsoft.Json.JsonProperty("errorMessages", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> ErrorMessages { get; set; }
    
        /// <summary>The event types that were tested.
        /// &gt;Permitted values: `ACCOUNT_HOLDER_CREATED`, `ACCOUNT_CREATED`, `ACCOUNT_UPDATED`, `ACCOUNT_HOLDER_UPDATED`, `ACCOUNT_HOLDER_STATUS_CHANGE`, `ACCOUNT_HOLDER_VERIFICATION`, `ACCOUNT_HOLDER_LIMIT_REACHED`, `ACCOUNT_HOLDER_PAYOUT`, `PAYMENT_FAILURE`, `SCHEDULED_REFUNDS`, `REPORT_AVAILABLE`, `TRANSFER_FUNDS`, `BENEFICIARY_SETUP`, `COMPENSATE_NEGATIVE_BALANCE`.</summary>
        [Newtonsoft.Json.JsonProperty("eventTypes", Required = Newtonsoft.Json.Required.Always, ItemConverterType = typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.Generic.ICollection<EventTypes2> EventTypes { get; set; } = new System.Collections.ObjectModel.Collection<EventTypes2>();
    
        /// <summary>The notification message and related response messages.</summary>
        [Newtonsoft.Json.JsonProperty("exchangeMessages", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.Generic.ICollection<ExchangeMessage> ExchangeMessages { get; set; } = new System.Collections.ObjectModel.Collection<ExchangeMessage>();
    
        /// <summary>The ID of the notification subscription configuration.</summary>
        [Newtonsoft.Json.JsonProperty("notificationId", Required = Newtonsoft.Json.Required.Always)]
        public long NotificationId { get; set; }
    
        /// <summary>A list of messages describing the testing steps.</summary>
        [Newtonsoft.Json.JsonProperty("okMessages", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        public System.Collections.Generic.ICollection<string> OkMessages { get; set; } = new System.Collections.ObjectModel.Collection<string>();
    
        /// <summary>The reference of a request.  Can be used to uniquely identify the request.</summary>
        [Newtonsoft.Json.JsonProperty("pspReference", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string PspReference { get; set; }
    
        /// <summary>Indicates whether the request is processed synchronously or asynchronously.  Depending on the request's marketplace settings, the following scenarios may be applied:
        /// * **sync:** The processing of the request is immediately attempted; it may result in an error if the providing service is unavailable.
        /// * **async:** The request is queued and will be executed when the providing service is available in the order in which the requests are received.
        /// * **asyncOnError:** The processing of the request is immediately attempted, but if the providing service is unavailable, the request is scheduled in a queue.</summary>
        [Newtonsoft.Json.JsonProperty("submittedAsync", Required = Newtonsoft.Json.Required.Always)]
        public bool SubmittedAsync { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.19.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class UpdateNotificationConfigurationRequest 
    {
        /// <summary>Details of the notification subscription configuration to be updated.</summary>
        [Newtonsoft.Json.JsonProperty("configurationDetails", Required = Newtonsoft.Json.Required.Always)]
        public NotificationConfigurationDetails ConfigurationDetails { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.19.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum NotificationConfigurationDetailsSslProtocol
    {
        [System.Runtime.Serialization.EnumMember(Value = @"SSL")]
        SSL = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"SSLInsecureCiphers")]
        SSLInsecureCiphers = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = @"SSLv3")]
        SSLv3 = 2,
    
        [System.Runtime.Serialization.EnumMember(Value = @"TLS")]
        TLS = 3,
    
        [System.Runtime.Serialization.EnumMember(Value = @"TLSv10")]
        TLSv10 = 4,
    
        [System.Runtime.Serialization.EnumMember(Value = @"TLSv10InsecureCiphers")]
        TLSv10InsecureCiphers = 5,
    
        [System.Runtime.Serialization.EnumMember(Value = @"TLSv11")]
        TLSv11 = 6,
    
        [System.Runtime.Serialization.EnumMember(Value = @"TLSv12")]
        TLSv12 = 7,
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.19.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum NotificationEventConfigurationEventType
    {
        [System.Runtime.Serialization.EnumMember(Value = @"ACCOUNT_CREATED")]
        ACCOUNT_CREATED = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"ACCOUNT_HOLDER_CREATED")]
        ACCOUNT_HOLDER_CREATED = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = @"ACCOUNT_HOLDER_LIMIT_REACHED")]
        ACCOUNT_HOLDER_LIMIT_REACHED = 2,
    
        [System.Runtime.Serialization.EnumMember(Value = @"ACCOUNT_HOLDER_PAYOUT")]
        ACCOUNT_HOLDER_PAYOUT = 3,
    
        [System.Runtime.Serialization.EnumMember(Value = @"ACCOUNT_HOLDER_STATUS_CHANGE")]
        ACCOUNT_HOLDER_STATUS_CHANGE = 4,
    
        [System.Runtime.Serialization.EnumMember(Value = @"ACCOUNT_HOLDER_UPDATED")]
        ACCOUNT_HOLDER_UPDATED = 5,
    
        [System.Runtime.Serialization.EnumMember(Value = @"ACCOUNT_HOLDER_VERIFICATION")]
        ACCOUNT_HOLDER_VERIFICATION = 6,
    
        [System.Runtime.Serialization.EnumMember(Value = @"ACCOUNT_UPDATED")]
        ACCOUNT_UPDATED = 7,
    
        [System.Runtime.Serialization.EnumMember(Value = @"BENEFICIARY_SETUP")]
        BENEFICIARY_SETUP = 8,
    
        [System.Runtime.Serialization.EnumMember(Value = @"COMPENSATE_NEGATIVE_BALANCE")]
        COMPENSATE_NEGATIVE_BALANCE = 9,
    
        [System.Runtime.Serialization.EnumMember(Value = @"PAYMENT_FAILURE")]
        PAYMENT_FAILURE = 10,
    
        [System.Runtime.Serialization.EnumMember(Value = @"REPORT_AVAILABLE")]
        REPORT_AVAILABLE = 11,
    
        [System.Runtime.Serialization.EnumMember(Value = @"SCHEDULED_REFUNDS")]
        SCHEDULED_REFUNDS = 12,
    
        [System.Runtime.Serialization.EnumMember(Value = @"TRANSFER_FUNDS")]
        TRANSFER_FUNDS = 13,
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.19.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum NotificationEventConfigurationIncludeMode
    {
        [System.Runtime.Serialization.EnumMember(Value = @"EXCLUDE")]
        EXCLUDE = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"INCLUDE")]
        INCLUDE = 1,
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.19.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum EventTypes
    {
        [System.Runtime.Serialization.EnumMember(Value = @"ACCOUNT_CREATED")]
        ACCOUNT_CREATED = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"ACCOUNT_HOLDER_CREATED")]
        ACCOUNT_HOLDER_CREATED = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = @"ACCOUNT_HOLDER_LIMIT_REACHED")]
        ACCOUNT_HOLDER_LIMIT_REACHED = 2,
    
        [System.Runtime.Serialization.EnumMember(Value = @"ACCOUNT_HOLDER_PAYOUT")]
        ACCOUNT_HOLDER_PAYOUT = 3,
    
        [System.Runtime.Serialization.EnumMember(Value = @"ACCOUNT_HOLDER_STATUS_CHANGE")]
        ACCOUNT_HOLDER_STATUS_CHANGE = 4,
    
        [System.Runtime.Serialization.EnumMember(Value = @"ACCOUNT_HOLDER_UPDATED")]
        ACCOUNT_HOLDER_UPDATED = 5,
    
        [System.Runtime.Serialization.EnumMember(Value = @"ACCOUNT_HOLDER_VERIFICATION")]
        ACCOUNT_HOLDER_VERIFICATION = 6,
    
        [System.Runtime.Serialization.EnumMember(Value = @"ACCOUNT_UPDATED")]
        ACCOUNT_UPDATED = 7,
    
        [System.Runtime.Serialization.EnumMember(Value = @"BENEFICIARY_SETUP")]
        BENEFICIARY_SETUP = 8,
    
        [System.Runtime.Serialization.EnumMember(Value = @"COMPENSATE_NEGATIVE_BALANCE")]
        COMPENSATE_NEGATIVE_BALANCE = 9,
    
        [System.Runtime.Serialization.EnumMember(Value = @"PAYMENT_FAILURE")]
        PAYMENT_FAILURE = 10,
    
        [System.Runtime.Serialization.EnumMember(Value = @"REPORT_AVAILABLE")]
        REPORT_AVAILABLE = 11,
    
        [System.Runtime.Serialization.EnumMember(Value = @"SCHEDULED_REFUNDS")]
        SCHEDULED_REFUNDS = 12,
    
        [System.Runtime.Serialization.EnumMember(Value = @"TRANSFER_FUNDS")]
        TRANSFER_FUNDS = 13,
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.19.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum EventTypes2
    {
        [System.Runtime.Serialization.EnumMember(Value = @"ACCOUNT_CREATED")]
        ACCOUNT_CREATED = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"ACCOUNT_HOLDER_CREATED")]
        ACCOUNT_HOLDER_CREATED = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = @"ACCOUNT_HOLDER_LIMIT_REACHED")]
        ACCOUNT_HOLDER_LIMIT_REACHED = 2,
    
        [System.Runtime.Serialization.EnumMember(Value = @"ACCOUNT_HOLDER_PAYOUT")]
        ACCOUNT_HOLDER_PAYOUT = 3,
    
        [System.Runtime.Serialization.EnumMember(Value = @"ACCOUNT_HOLDER_STATUS_CHANGE")]
        ACCOUNT_HOLDER_STATUS_CHANGE = 4,
    
        [System.Runtime.Serialization.EnumMember(Value = @"ACCOUNT_HOLDER_UPDATED")]
        ACCOUNT_HOLDER_UPDATED = 5,
    
        [System.Runtime.Serialization.EnumMember(Value = @"ACCOUNT_HOLDER_VERIFICATION")]
        ACCOUNT_HOLDER_VERIFICATION = 6,
    
        [System.Runtime.Serialization.EnumMember(Value = @"ACCOUNT_UPDATED")]
        ACCOUNT_UPDATED = 7,
    
        [System.Runtime.Serialization.EnumMember(Value = @"BENEFICIARY_SETUP")]
        BENEFICIARY_SETUP = 8,
    
        [System.Runtime.Serialization.EnumMember(Value = @"COMPENSATE_NEGATIVE_BALANCE")]
        COMPENSATE_NEGATIVE_BALANCE = 9,
    
        [System.Runtime.Serialization.EnumMember(Value = @"PAYMENT_FAILURE")]
        PAYMENT_FAILURE = 10,
    
        [System.Runtime.Serialization.EnumMember(Value = @"REPORT_AVAILABLE")]
        REPORT_AVAILABLE = 11,
    
        [System.Runtime.Serialization.EnumMember(Value = @"SCHEDULED_REFUNDS")]
        SCHEDULED_REFUNDS = 12,
    
        [System.Runtime.Serialization.EnumMember(Value = @"TRANSFER_FUNDS")]
        TRANSFER_FUNDS = 13,
    
    }

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.0.1.0 (NJsonSchema v10.0.19.0 (Newtonsoft.Json v11.0.0.0))")]
    public partial class ApiException : System.Exception
    {
        public int StatusCode { get; private set; }

        public string Response { get; private set; }

        public System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.IEnumerable<string>> Headers { get; private set; }

        public ApiException(string message, int statusCode, string response, System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.IEnumerable<string>> headers, System.Exception innerException) 
            : base(message + "\n\nStatus: " + statusCode + "\nResponse: \n" + response.Substring(0, response.Length >= 512 ? 512 : response.Length), innerException)
        {
            StatusCode = statusCode;
            Response = response; 
            Headers = headers;
        }

        public override string ToString()
        {
            return string.Format("HTTP Response: \n\n{0}\n\n{1}", Response, base.ToString());
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.0.1.0 (NJsonSchema v10.0.19.0 (Newtonsoft.Json v11.0.0.0))")]
    public partial class ApiException<TResult> : ApiException
    {
        public TResult Result { get; private set; }

        public ApiException(string message, int statusCode, string response, System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Generic.IEnumerable<string>> headers, TResult result, System.Exception innerException) 
            : base(message, statusCode, response, headers, innerException)
        {
            Result = result;
        }
    }

}

#pragma warning restore 1591
#pragma warning restore 1573
#pragma warning restore  472
#pragma warning restore  114
#pragma warning restore  108