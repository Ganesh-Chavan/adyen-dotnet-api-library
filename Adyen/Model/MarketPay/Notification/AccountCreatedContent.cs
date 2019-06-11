using Adyen.Model.AdditionalData;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Adyen.Model.ApplicationInformation;
using Adyen.Util;

public class AccountCreatedContent
{
    [DataMember(Name = "pspReference", EmitDefaultValue = false)]

	private string pspReference;
[DataMember(Name = "accountHolderCode", EmitDefaultValue = false)]
	private string accountHolderCode;

[DataMember(Name = "accountCode", EmitDefaultValue = false)]
	private string accountCode;


   [DataMember(Name = "status", EmitDefaultValue = false)]
	private AccountHolderStatus.StatusEnum status;

	public virtual string PspReference
	{
		get
		{
			return pspReference;
		}
		set
		{
			this.pspReference = value;
		}
	}


	public virtual string AccountHolderCode
	{
		get
		{
			return accountHolderCode;
		}
		set
		{
			this.accountHolderCode = value;
		}
	}


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


	public virtual AccountHolderStatus.StatusEnum Status
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


	public override string ToString()
	{
		return "AccountCreatedContent{"
				+ "pspReference='"
				+ pspReference + '\'' + ", accountHolderCode='"
				+ accountHolderCode + '\'' + ", accountCode='"
				+ accountCode + '\'' + ", status="
				+ status + '}';
	}
}
