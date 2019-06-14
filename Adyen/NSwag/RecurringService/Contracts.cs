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

namespace  Adyen.RecurringService
{
    

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.19.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Address 
    {
        /// <summary>The name of the city.
        /// &gt;Required if either houseNumberOrName, street, postalCode, or stateOrProvince are provided.</summary>
        [Newtonsoft.Json.JsonProperty("city", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string City { get; set; }
    
        /// <summary>The two-character country code of the address
        /// &gt;The permitted country codes are defined in ISO-3166-1 alpha-2 (e.g. 'NL').</summary>
        [Newtonsoft.Json.JsonProperty("country", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Country { get; set; }
    
        /// <summary>The number or name of the house.</summary>
        [Newtonsoft.Json.JsonProperty("houseNumberOrName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HouseNumberOrName { get; set; }
    
        /// <summary>The postal code.
        /// &gt;A maximum of five (5) digits for an address in the USA, or a maximum of ten (10) characters for an address in all other countries.
        /// &gt;Required if either houseNumberOrName, street, city, or stateOrProvince are provided.</summary>
        [Newtonsoft.Json.JsonProperty("postalCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PostalCode { get; set; }
    
        /// <summary>The abbreviation of the state or province.
        /// &gt;Two (2) characters for an address in the USA or Canada, or a maximum of three (3) characters for an address in all other countries.
        /// &gt;Required for an address in the USA or Canada if either houseNumberOrName, street, city, or postalCode are provided.</summary>
        [Newtonsoft.Json.JsonProperty("stateOrProvince", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string StateOrProvince { get; set; }
    
        /// <summary>The name of the street.
        /// &gt;The house number should not be included in this field; it should be separately provided via `houseNumberOrName`.
        /// &gt;Required if either houseNumberOrName, city, postalCode, or stateOrProvince are provided.</summary>
        [Newtonsoft.Json.JsonProperty("street", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Street { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.19.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class BankAccount 
    {
        /// <summary>The bank account number (without separators).</summary>
        [Newtonsoft.Json.JsonProperty("bankAccountNumber", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BankAccountNumber { get; set; }
    
        /// <summary>The bank city.</summary>
        [Newtonsoft.Json.JsonProperty("bankCity", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BankCity { get; set; }
    
        /// <summary>The location id of the bank. The field value is `nil` in most cases.</summary>
        [Newtonsoft.Json.JsonProperty("bankLocationId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BankLocationId { get; set; }
    
        /// <summary>The name of the bank.</summary>
        [Newtonsoft.Json.JsonProperty("bankName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BankName { get; set; }
    
        /// <summary>The [Business Identifier Code](https://en.wikipedia.org/wiki/ISO_9362) (BIC) is the SWIFT address assigned to a bank. The field value is `nil` in most cases.</summary>
        [Newtonsoft.Json.JsonProperty("bic", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Bic { get; set; }
    
        /// <summary>Country code where the bank is located.
        /// 
        /// A valid value is an ISO two-character country code (e.g. 'NL').</summary>
        [Newtonsoft.Json.JsonProperty("countryCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CountryCode { get; set; }
    
        /// <summary>The [International Bank Account Number](https://en.wikipedia.org/wiki/International_Bank_Account_Number) (IBAN).</summary>
        [Newtonsoft.Json.JsonProperty("iban", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Iban { get; set; }
    
        /// <summary>The name of the bank account holder.
        /// If you submit a name with non-Latin characters, we automatically replace some of them with corresponding Latin characters to meet the FATF recommendations. For example:
        /// * χ12 is converted to ch12.
        /// * üA is converted to euA.
        /// * Peter Møller is converted to Peter Mller, because banks don't accept 'ø'.
        /// After replacement, the ownerName must have at least three alphanumeric characters (A-Z, a-z, 0-9), and at least one of them must be a valid Latin character (A-Z, a-z). For example:
        /// * John17 - allowed.
        /// * J17 - allowed.
        /// * 171 - not allowed.
        /// * John-7 - allowed.
        /// &gt; If provided details don't match the required format, the response returns the error message: 203 'Invalid bank account holder name'.</summary>
        [Newtonsoft.Json.JsonProperty("ownerName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OwnerName { get; set; }
    
        /// <summary>The bank account holder's tax ID.</summary>
        [Newtonsoft.Json.JsonProperty("taxId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TaxId { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.19.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Card 
    {
        /// <summary>The [card verification code](https://docs.adyen.com/developers/payment-glossary#cardsecuritycodecvccvvcid) (1-20 characters). Depending on the card brand, it is known also as:
        /// * CVV2/CVC2 – length: 3 digits
        /// * CID – length: 4 digits
        /// &gt; If you are using [Client-Side Encryption](https://docs.adyen.com/developers/features/client-side-encryption), the CVC code is present in the encrypted data. You must never post the card details to the server.
        /// &gt; This field must be always present in a [one-click payment request](https://docs.adyen.com/developers/classic-integration/recurring-payments).
        /// &gt; When this value is returned in a response, it is always empty because it is not stored.</summary>
        [Newtonsoft.Json.JsonProperty("cvc", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(20, MinimumLength = 1)]
        public string Cvc { get; set; }
    
        /// <summary>The card expiry month.
        /// Format: 2 digits, zero-padded for single digits. For example:
        /// * 03 = March
        /// * 11 = November</summary>
        [Newtonsoft.Json.JsonProperty("expiryMonth", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(2, MinimumLength = 1)]
        public string ExpiryMonth { get; set; }
    
        /// <summary>The card expiry year.
        /// Format: 4 digits. For example: 2020</summary>
        [Newtonsoft.Json.JsonProperty("expiryYear", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(4, MinimumLength = 4)]
        public string ExpiryYear { get; set; }
    
        /// <summary>The name of the cardholder, as printed on the card.</summary>
        [Newtonsoft.Json.JsonProperty("holderName", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(50, MinimumLength = 1)]
        public string HolderName { get; set; }
    
        /// <summary>The issue number of the card (for some UK debit cards only).</summary>
        [Newtonsoft.Json.JsonProperty("issueNumber", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(2, MinimumLength = 1)]
        public string IssueNumber { get; set; }
    
        /// <summary>The card number (4-19 characters). Do not use any separators.
        /// When this value is returned in a response, only the last 4 digits of the card number are returned.</summary>
        [Newtonsoft.Json.JsonProperty("number", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(19, MinimumLength = 4)]
        public string Number { get; set; }
    
        /// <summary>The month component of the start date (for some UK debit cards only).</summary>
        [Newtonsoft.Json.JsonProperty("startMonth", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(2, MinimumLength = 1)]
        public string StartMonth { get; set; }
    
        /// <summary>The year component of the start date (for some UK debit cards only).</summary>
        [Newtonsoft.Json.JsonProperty("startYear", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(4, MinimumLength = 4)]
        public string StartYear { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.19.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class DisableRequest 
    {
        /// <summary>Specify the contract if you only want to disable a specific use.
        /// 
        /// This field can be set to one of the following values, or to their combination (comma-separated):
        /// * ONECLICK
        /// * RECURRING
        /// * PAYOUT</summary>
        [Newtonsoft.Json.JsonProperty("contract", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Contract { get; set; }
    
        /// <summary>The merchant account identifier with which you want to process the transaction.</summary>
        [Newtonsoft.Json.JsonProperty("merchantAccount", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string MerchantAccount { get; set; }
    
        /// <summary>The ID that uniquely identifies the recurring detail reference.
        /// 
        /// If it is not provided, the whole recurring contract of the `shopperReference` will be disabled, which includes all recurring details.</summary>
        [Newtonsoft.Json.JsonProperty("recurringDetailReference", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RecurringDetailReference { get; set; }
    
        /// <summary>The ID that uniquely identifies the shopper.
        /// 
        /// This `shopperReference` must be the same as the `shopperReference` used in the initial payment.</summary>
        [Newtonsoft.Json.JsonProperty("shopperReference", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string ShopperReference { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.19.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class DisableResult 
    {
        /// <summary>Depending on whether a specific recurring detail was in the request, result is either [detail-successfully-disabled] or [all-details-successfully-disabled].</summary>
        [Newtonsoft.Json.JsonProperty("response", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Response { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.19.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Name 
    {
        /// <summary>The first name.</summary>
        [Newtonsoft.Json.JsonProperty("firstName", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string FirstName { get; set; }
    
        /// <summary>The gender.
        /// &gt;The following values are permitted: `MALE`, `FEMALE`, `UNKNOWN`.</summary>
        [Newtonsoft.Json.JsonProperty("gender", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required]
        [System.ComponentModel.DataAnnotations.StringLength(1, MinimumLength = 1)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public NameGender Gender { get; set; }
    
        /// <summary>The name's infix, if applicable.
        /// &gt;A maximum length of twenty (20) characters is imposed.</summary>
        [Newtonsoft.Json.JsonProperty("infix", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Infix { get; set; }
    
        /// <summary>The last name.</summary>
        [Newtonsoft.Json.JsonProperty("lastName", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string LastName { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.19.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class Recurring 
    {
        /// <summary>The type of recurring contract to be used.
        /// Possible values:
        /// * `ONECLICK` – Payment details can be used to initiate a one-click payment, where the shopper enters the [card security code (CVC/CVV)](https://docs.adyen.com/developers/payment-glossary#cardsecuritycodecvccvvcid).
        /// * `RECURRING` – Payment details can be used without the card security code to initiate [card-not-present transactions](https://docs.adyen.com/developers/payment-glossary#cardnotpresentcnp).
        /// * `ONECLICK,RECURRING` – Payment details can be used regardless of whether the shopper is on your site or not.
        /// * `PAYOUT` – Payment details can be used to [make a payout](https://docs.adyen.com/developers/features/third-party-payouts).</summary>
        [Newtonsoft.Json.JsonProperty("contract", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public RecurringContract Contract { get; set; }
    
        /// <summary>A descriptive name for this detail.</summary>
        [Newtonsoft.Json.JsonProperty("recurringDetailName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RecurringDetailName { get; set; }
    
        /// <summary>The name of the token service.</summary>
        [Newtonsoft.Json.JsonProperty("tokenService", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public RecurringTokenService TokenService { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.19.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class RecurringDetail 
    {
        /// <summary>This field contains additional data, which may be returned in a particular response.
        /// 
        /// The additionalData object consists of entries, each of which includes the key and value. For more information on possible key-value pairs, refer to [RecurringDetail.additionalData](https://docs.adyen.com/developers/api-reference/recurring-api#recurringdetailadditionaldata).</summary>
        [Newtonsoft.Json.JsonProperty("additionalData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public object AdditionalData { get; set; }
    
        /// <summary>The alias of the credit card number.
        /// 
        /// Applies only to recurring contracts storing credit card details</summary>
        [Newtonsoft.Json.JsonProperty("alias", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Alias { get; set; }
    
        /// <summary>The alias type of the credit card number.
        /// 
        /// Applies only to recurring contracts storing credit card details.</summary>
        [Newtonsoft.Json.JsonProperty("aliasType", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AliasType { get; set; }
    
        /// <summary>A container for bank account data.</summary>
        [Newtonsoft.Json.JsonProperty("bank", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public BankAccount Bank { get; set; }
    
        /// <summary>The billing address.</summary>
        [Newtonsoft.Json.JsonProperty("billingAddress", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Address BillingAddress { get; set; }
    
        /// <summary>A container for card data.</summary>
        [Newtonsoft.Json.JsonProperty("card", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Card Card { get; set; }
    
        /// <summary>Types of recurring contracts.</summary>
        [Newtonsoft.Json.JsonProperty("contractTypes", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<string> ContractTypes { get; set; }
    
        /// <summary>The date when the recurring details were created.</summary>
        [Newtonsoft.Json.JsonProperty("creationDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset CreationDate { get; set; }
    
        /// <summary>The `pspReference` of the first recurring payment that created the recurring detail.</summary>
        [Newtonsoft.Json.JsonProperty("firstPspReference", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FirstPspReference { get; set; }
    
        /// <summary>An optional descriptive name for this recurring detail.</summary>
        [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }
    
        /// <summary>The  type or sub-brand of a payment method used, e.g. Visa Debit, Visa Corporate, etc. For more information, refer to [PaymentMethodVariant](https://docs.adyen.com/developers/api-reference/common-api/paymentmethodvariant).</summary>
        [Newtonsoft.Json.JsonProperty("paymentMethodVariant", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PaymentMethodVariant { get; set; }
    
        /// <summary>The reference that uniquely identifies the recurring detail.</summary>
        [Newtonsoft.Json.JsonProperty("recurringDetailReference", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string RecurringDetailReference { get; set; }
    
        /// <summary>The name of the shopper.</summary>
        [Newtonsoft.Json.JsonProperty("shopperName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Name ShopperName { get; set; }
    
        /// <summary>A shopper's social security number (only in countries where it is legal to collect).</summary>
        [Newtonsoft.Json.JsonProperty("socialSecurityNumber", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SocialSecurityNumber { get; set; }
    
        /// <summary>The payment method, such as “mc", "visa", "ideal", "paypal".</summary>
        [Newtonsoft.Json.JsonProperty("variant", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string Variant { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.19.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class RecurringDetailsRequest 
    {
        /// <summary>The merchant account identifier you want to process the (transaction) request with.</summary>
        [Newtonsoft.Json.JsonProperty("merchantAccount", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string MerchantAccount { get; set; }
    
        /// <summary>A container for the type of a recurring contract to be retrieved.
        /// 
        /// The contract value needs to match the contract value submitted in the payment transaction used to create a recurring contract.
        /// However, if `ONECLICK,RECURRING` is the original contract definition in the initial payment, then `contract` should take either `ONECLICK` or `RECURRING`, depending on whether or not you want the shopper to enter their card's security code when they finalize their purchase.</summary>
        [Newtonsoft.Json.JsonProperty("recurring", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Recurring Recurring { get; set; }
    
        /// <summary>The reference you use to uniquely identify the shopper (e.g. user ID or account ID).</summary>
        [Newtonsoft.Json.JsonProperty("shopperReference", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string ShopperReference { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.19.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class RecurringDetailsResult 
    {
        /// <summary>The date when the recurring details were created.</summary>
        [Newtonsoft.Json.JsonProperty("creationDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset CreationDate { get; set; }
    
        /// <summary>Payment details stored for recurring payments.</summary>
        [Newtonsoft.Json.JsonProperty("details", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<RecurringDetail> Details { get; set; }
    
        /// <summary>The most recent email for this shopper (if available).</summary>
        [Newtonsoft.Json.JsonProperty("lastKnownShopperEmail", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LastKnownShopperEmail { get; set; }
    
        /// <summary>The reference you use to uniquely identify the shopper (e.g. user ID or account ID).</summary>
        [Newtonsoft.Json.JsonProperty("shopperReference", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ShopperReference { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.19.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class ScheduleAccountUpdaterRequest 
    {
        [Newtonsoft.Json.JsonProperty("additionalData", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.IDictionary<string, string> AdditionalData { get; set; }
    
        [Newtonsoft.Json.JsonProperty("card", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Card Card { get; set; }
    
        [Newtonsoft.Json.JsonProperty("genericBlockId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long GenericBlockId { get; set; }
    
        [Newtonsoft.Json.JsonProperty("genericFileId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long GenericFileId { get; set; }
    
        [Newtonsoft.Json.JsonProperty("genericLineId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long GenericLineId { get; set; }
    
        [Newtonsoft.Json.JsonProperty("merchantAccount", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public string MerchantAccount { get; set; }
    
        [Newtonsoft.Json.JsonProperty("reference", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Reference { get; set; }
    
        [Newtonsoft.Json.JsonProperty("selectedRecurringDetailReference", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SelectedRecurringDetailReference { get; set; }
    
        [Newtonsoft.Json.JsonProperty("shopperReference", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ShopperReference { get; set; }
    
        [Newtonsoft.Json.JsonProperty("updateAfter", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset UpdateAfter { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.19.0 (Newtonsoft.Json v11.0.0.0)")]
    public partial class ScheduleAccountUpdaterResult 
    {
        [Newtonsoft.Json.JsonProperty("accountUpdaterAction", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AccountUpdaterAction { get; set; }
    
        [Newtonsoft.Json.JsonProperty("newAlias", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NewAlias { get; set; }
    
        [Newtonsoft.Json.JsonProperty("newExpiryMonth", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NewExpiryMonth { get; set; }
    
        [Newtonsoft.Json.JsonProperty("newExpiryYear", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NewExpiryYear { get; set; }
    
        [Newtonsoft.Json.JsonProperty("processedDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTimeOffset ProcessedDate { get; set; }
    
        [Newtonsoft.Json.JsonProperty("pspReference", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PspReference { get; set; }
    
        [Newtonsoft.Json.JsonProperty("result", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Result { get; set; }
    
        private System.Collections.Generic.IDictionary<string, object> _additionalProperties = new System.Collections.Generic.Dictionary<string, object>();
    
        [Newtonsoft.Json.JsonExtensionData]
        public System.Collections.Generic.IDictionary<string, object> AdditionalProperties
        {
            get { return _additionalProperties; }
            set { _additionalProperties = value; }
        }
    
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.19.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum NameGender
    {
        [System.Runtime.Serialization.EnumMember(Value = @"MALE")]
        MALE = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"FEMALE")]
        FEMALE = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = @"UNKNOWN")]
        UNKNOWN = 2,
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.19.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum RecurringContract
    {
        [System.Runtime.Serialization.EnumMember(Value = @"ONECLICK")]
        ONECLICK = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"RECURRING")]
        RECURRING = 1,
    
        [System.Runtime.Serialization.EnumMember(Value = @"PAYOUT")]
        PAYOUT = 2,
    
    }
    
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.0.19.0 (Newtonsoft.Json v11.0.0.0)")]
    public enum RecurringTokenService
    {
        [System.Runtime.Serialization.EnumMember(Value = @"VISATOKENSERVICE")]
        VISATOKENSERVICE = 0,
    
        [System.Runtime.Serialization.EnumMember(Value = @"MCTOKENSERVICE")]
        MCTOKENSERVICE = 1,
    
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