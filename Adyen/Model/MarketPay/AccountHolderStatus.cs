using Adyen.Model.AdditionalData;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Adyen.Model.ApplicationInformation;
using Adyen.Util;
    [DataContract]
public class AccountHolderStatus
{
    [DataMember(Name = "processingState", EmitDefaultValue = false)]
	private AccountProcessingState processingState = null;

    [DataMember(Name = "statusReason", EmitDefaultValue = false)]
	private string statusReason = null;

    [DataMember(Name = "payoutState", EmitDefaultValue = false)]
	private AccountPayoutState payoutState = null;

	/// <summary>
	/// status
	/// </summary>
	public sealed class StatusEnum
	{
		public static readonly StatusEnum ACTIVE = new StatusEnum("ACTIVE", InnerEnum.ACTIVE, "Active");

		public static readonly StatusEnum CLOSED = new StatusEnum("CLOSED", InnerEnum.CLOSED, "Closed");

		public static readonly StatusEnum INACTIVE = new StatusEnum("INACTIVE", InnerEnum.INACTIVE, "Inactive");

		public static readonly StatusEnum SUSPENDED = new StatusEnum("SUSPENDED", InnerEnum.SUSPENDED, "Suspended");

		private static readonly IList<StatusEnum> valueList = new List<StatusEnum>();

		static StatusEnum()
		{
			valueList.Add(ACTIVE);
			valueList.Add(CLOSED);
			valueList.Add(INACTIVE);
			valueList.Add(SUSPENDED);
		}

		public enum InnerEnum
		{
			ACTIVE,
			CLOSED,
			INACTIVE,
			SUSPENDED
		}

		public readonly InnerEnum innerEnumValue;
		private readonly string nameValue;
		private readonly int ordinalValue;
		private static int nextOrdinal = 0;

		internal string value;

		internal StatusEnum(string name, InnerEnum innerEnum, string value)
		{
			this.value = value;

			nameValue = name;
			ordinalValue = nextOrdinal++;
			innerEnumValue = innerEnum;
		}

		public override string ToString()
		{
			return value.ToString();
		}

		public static IList<StatusEnum> values()
		{
			return valueList;
		}

		public int ordinal()
		{
			return ordinalValue;
		}

		public static StatusEnum valueOf(string name)
		{
			foreach (StatusEnum enumInstance in StatusEnum.valueList)
			{
				if (enumInstance.nameValue == name)
				{
					return enumInstance;
				}
			}
			throw new System.ArgumentException(name);
		}
	}

 [DataMember(Name = "status", EmitDefaultValue = false)]
	private StatusEnum status = null;

[DataMember(Name = "accountEvents", EmitDefaultValue = false)]
	private IList<AccountEvent> accountEvents = new List<AccountEvent>();

	public virtual AccountHolderStatus processingState(AccountProcessingState processingState)
	{
		this.processingState = processingState;
		return this;
	}

	/// <summary>
	/// current processing tier
	/// </summary>
	/// <returns> processingState
	///  </returns>
	public virtual AccountProcessingState ProcessingState
	{
		get
		{
			return processingState;
		}
		set
		{
			this.processingState = value;
		}
	}


	public virtual AccountHolderStatus statusReason(string statusReason)
	{
		this.statusReason = statusReason;
		return this;
	}

	/// <summary>
	/// status reason
	/// </summary>
	/// <returns> statusReason
	///  </returns>
	public virtual string StatusReason
	{
		get
		{
			return statusReason;
		}
		set
		{
			this.statusReason = value;
		}
	}


	public virtual AccountHolderStatus payoutState(AccountPayoutState payoutState)
	{
		this.payoutState = payoutState;
		return this;
	}

	/// <summary>
	/// payout state
	/// </summary>
	/// <returns> payoutState
	///  </returns>
	public virtual AccountPayoutState PayoutState
	{
		get
		{
			return payoutState;
		}
		set
		{
			this.payoutState = value;
		}
	}


	public virtual AccountHolderStatus status(StatusEnum status)
	{
		this.status = status;
		return this;
	}

	/// <summary>
	/// status
	/// </summary>
	/// <returns> status
	///  </returns>
	public virtual StatusEnum Status
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


	public virtual AccountHolderStatus accountEvents(IList<AccountEvent> accountEvents)
	{
		this.accountEvents = accountEvents;
		return this;
	}

	public virtual AccountHolderStatus addAccountEventsItem(AccountEvent accountEventsItem)
	{
		this.accountEvents.Add(accountEventsItem);
		return this;
	}

	/// <summary>
	/// scheduled events
	/// </summary>
	/// <returns> accountEvents
	///  </returns>
	public virtual IList<AccountEvent> AccountEvents
	{
		get
		{
			return accountEvents;
		}
		set
		{
			this.accountEvents = value;
		}
	}


	public override bool Equals(object o)
	{
		if (this == o)
		{
			return true;
		}
		if (o == null || this.GetType() != o.GetType())
		{
			return false;
		}
		AccountHolderStatus accountHolderStatus = (AccountHolderStatus) o;
		return Object.Equals(this.processingState, accountHolderStatus.processingState) && Object.Equals(this.statusReason, accountHolderStatus.statusReason) && Objects.Equals(this.payoutState, accountHolderStatus.payoutState) && Objects.Equals(this.status, accountHolderStatus.status) && Objects.Equals(this.accountEvents, accountHolderStatus.accountEvents);
	}

	public override int GetHashCode()
	{
		return Object.GetHashCode(processingState, statusReason, payoutState, status, accountEvents);
	}


	public override string ToString()
	{
		StringBuilder sb = new StringBuilder();
		sb.Append("class AccountHolderStatus {\n");

		sb.Append("    processingState: ").Append(toIndentedString(processingState)).Append("\n");
		sb.Append("    statusReason: ").Append(toIndentedString(statusReason)).Append("\n");
		sb.Append("    payoutState: ").Append(toIndentedString(payoutState)).Append("\n");
		sb.Append("    status: ").Append(toIndentedString(status)).Append("\n");
		sb.Append("    accountEvents: ").Append(toIndentedString(accountEvents)).Append("\n");
		sb.Append("}");
		return sb.ToString();
	}

	/// <summary>
	/// Convert the given object to string with each line indented by 4 spaces
	/// (except the first line).
	/// </summary>
	private string toIndentedString(object o)
	{
		if (o == null)
		{
			return "null";
		}
		return o.ToString().Replace("\n", "\n    ");
	}

}
