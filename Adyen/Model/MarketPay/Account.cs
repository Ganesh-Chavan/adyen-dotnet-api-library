using Adyen.Model.AdditionalData;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Adyen.Model.ApplicationInformation;
using Adyen.Util;
    [DataContract]
public class Account
{
    [DataMember(Name = "accountCode", EmitDefaultValue = false)]
	private string accountCode = null;

    [DataMember(Name = "beneficiaryAccount", EmitDefaultValue = false)]
	private string beneficiaryAccount = null;

    [DataMember(Name = "beneficiaryMerchantReference", EmitDefaultValue = false)]
	private string beneficiaryMerchantReference = null;

    [DataMember(Name = "description", EmitDefaultValue = false)]
    	private string description = null;

    [DataMember(Name = "payoutSchedule", EmitDefaultValue = false)]
	private PayoutScheduleResponse payoutSchedule = null;

    [DataMember(Name = "status", EmitDefaultValue = false)]
	private string status = null;

	public virtual Account accountCode(string accountCode)
	{
		this.accountCode = accountCode;
		return this;
	}

	/// <summary>
	/// account code
	/// </summary>
	/// <returns> accountCode
	///  </returns>
	public virtual string AccountCode
	{
		get
		{
			return accountCode;
		}
		set
		{
			this.accountCode = value;
		}
	}


	public virtual Account beneficiaryAccount(string beneficiaryAccount)
	{
		this.beneficiaryAccount = beneficiaryAccount;
		return this;
	}

	/// <summary>
	/// Account's beneficiary account
	/// </summary>
	/// <returns> beneficiaryAccount
	///  </returns>
	public virtual string BeneficiaryAccount
	{
		get
		{
			return beneficiaryAccount;
		}
		set
		{
			this.beneficiaryAccount = value;
		}
	}


	public virtual Account beneficiaryMerchantReference(string beneficiaryMerchantReference)
	{
		this.beneficiaryMerchantReference = beneficiaryMerchantReference;
		return this;
	}

	/// <summary>
	/// Reason beneficiary was setup
	/// </summary>
	/// <returns> beneficiaryMerchantReference
	///  </returns>
	public virtual string BeneficiaryMerchantReference
	{
		get
		{
			return beneficiaryMerchantReference;
		}
		set
		{
			this.beneficiaryMerchantReference = value;
		}
	}


	public virtual string Description
	{
		get
		{
			return description;
		}
		set
		{
			this.description = value;
		}
	}



	public virtual Account payoutSchedule(PayoutScheduleResponse payoutSchedule)
	{
		this.payoutSchedule = payoutSchedule;
		return this;
	}

	/// <summary>
	/// account's payout schedule
	/// </summary>
	/// <returns> payoutSchedule
	///  </returns>
	public virtual PayoutScheduleResponse PayoutSchedule
	{
		get
		{
			return payoutSchedule;
		}
		set
		{
			this.payoutSchedule = value;
		}
	}


	public virtual string Status
	{
		get
		{
			return status;
		}
		set
		{
			this.status = value;
		}
	}


}
