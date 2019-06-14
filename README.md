[![Build Status](https://travis-ci.org/Adyen/adyen-dotnet-api-library.svg?branch=develop)](https://travis-ci.org/Adyen/adyen-dotnet-api-library)


# Adyen .NET API Library

The Adyen API Library for .net framework enables you to work with Adyen APIs, Hosted Payment Pages and Terminal API with any .net application.


## Integration
The Library supports all APIs under the following services:

* checkout
* checkout utility
* payments
* modifications
* recurring
* Terminal API (Local and Cloud based)
* payouts
* marketpay
* notifications

##NSwag Auto Generated Clients

* AccountService
* CheckoutService
* CheckoutUtilityService
* NotificationConfigurationService
* PaymentService
* PayoutService
* RecurringService


#Adyen MarketPay Account Service 4

https://raw.githubusercontent.com/adyen/adyen-openapi/master/specs/3.0/AccountService-v4.json

The MarketPay Account API provides endpoints for managing MarketPay account-related entities. These related entities include account holders, accounts, bank accounts, shareholders, and KYC-related documents. The management operations include actions such as creation, retrieval, updating, and deletion of them. For further information on MarketPay API, visit the [MarketPay documentation](https://docs.adyen.com/developers/marketpay/marketpay-overview). ## Authentication To connect to the MarketPay API, you must use basic authentication credentials of your web service user. If you don't have one, please contact the [Adyen Support Team](https://support.adyen.com/hc/en-us/requests/new). Then use its credentials to authenticate your request, for example: ``` curl -U "ws@Company.YourCompany":"YourWsPassword" \ -H "Content-Type: application/json" \ ... ``` Note that when going live, you need to generate new web service user credentials to access the [live endpoints](https://docs.adyen.com/developers/api-reference/live-endpoints). ## Versioning MarketPay API supports versioning of its endpoints through a version suffix in the endpoint URL. This suffix has the following format: "vXX", where XX is the version number. For example: ``` https://cal-test.adyen.com/cal/services/Account/v4/createAccountHolder ```

# Adyen MarketPay Fund Service 5

https://raw.githubusercontent.com/adyen/adyen-openapi/master/specs/3.0/FundService-v5.json

The MarketPay Funding API provides endpoints for managing the funds in MarketPay accounts. These management operations include actions such as the transfer of funds from one account to another, the payout of funds to an account holder, and the retrieval of balances in an account. For further information on MarketPay fund management, please visit the [MarketPay documentation](https://docs.adyen.com/developers/marketpay). ## Authentication To connect to the MarketPay API, you must use basic authentication credentials of your web service user. If you don't have one, please contact the [Adyen Support Team](https://support.adyen.com/hc/en-us/requests/new). Then use its credentials to authenticate your request, for example: ``` curl -U "ws@MarketPlace.YourMarketPlace":"YourWsPassword" \ -H "Content-Type: application/json" \ ... ``` Note that when going live, you need to generate new web service user credentials to access the [live endpoints](https://docs.adyen.com/developers/development-resources/live-endpoints). ## Versioning MarketPay API supports versioning of its endpoints through a version suffix in the endpoint URL. This suffix has the following format: "vXX", where XX is the version number. For example: ``` https://cal-test.adyen.com/cal/services/Fund/v5/accountHolderBalance ```


#Adyen MarketPay Notification Configuration Service 1

https://raw.githubusercontent.com/adyen/adyen-openapi/master/specs/3.0/NotificationConfigurationService-v1.json

The MarketPay Notification Configuration API provides endpoints for configuration a subscription to a marketplace's MarketPay-related notifications. Notifications are sent upon the occurrence of certain events (such as a KYC check completion or a payout completion), and the subscription to these notifications dictates to where they are sent. For further information on MarketPay notifications, please visit the [MarketPay documentation](https://docs.adyen.com/developers/marketpay/marketpay-overview). ## Authentication To connect to the MarketPay API, you must use basic authentication credentials of your web service user. If you don't have one, please contact the [Adyen Support Team](https://support.adyen.com/hc/en-us/requests/new). Then use its credentials to authenticate your request, for example: ``` curl -U "ws@Company.YourCompany":"YourWsPassword" \ -H "Content-Type: application/json" \ ... ``` Note that when going live, you need to generate new web service user credentials to access the [live endpoints](https://docs.adyen.com/developers/api-reference/live-endpoints). ## Versioning MarketPay API supports versioning of its endpoints through a version suffix in the endpoint URL. This suffix has the following format: "vXX", where XX is the version number. For example: ``` https://cal-test.adyen.com/cal/services/Notification/v1/createNotificationConfiguration ```


#Adyen Payment Service 40

https://raw.githubusercontent.com/adyen/adyen-openapi/master/specs/3.0/PaymentService-v40.json

A set of API endpoints that allow you to initiate, settle, and modify payments on the Adyen payments platform. You can use the API to accept card payments (including One-Click and 3D Secure), bank transfers, ewallets, and many other payment methods. To learn more about the API, visit [Classic integration](https://docs.adyen.com/developers/classic-integration). ## Authentication To connect to the Payments API, you must use your basic authentication credentials. For this, create your web service user, as described in [How to get the WS user password](https://docs.adyen.com/developers/user-management/how-to-get-the-web-service-ws-user-password). Then use its credentials to authenticate your request, for example: ``` curl -U "ws@Company.YourCompany":"YourWsPassword" \ -H "Content-Type: application/json" \ ... ``` Note that when going live, you need to generate new web service user credentials to access the [live endpoints](https://docs.adyen.com/developers/development-resources/live-endpoints). ## Versioning Payments API supports versioning of its endpoints through a version suffix in the endpoint URL. This suffix has the following format: "vXX", where XX is the version number. For example: ``` https://pal-test.adyen.com/pal/servlet/Payment/v40/authorise ```


#Adyen Checkout Service 32

https://raw.githubusercontent.com/adyen/adyen-openapi/master/specs/3.0/CheckoutService-V32.json

A web service to initiate and authorise payments with Adyen Checkout. You can use the same integration for payments made with cards (including One-Click and 3D Secure), mobile wallets, and local payment methods (e.g. iDEAL and Sofort). For more information, refer to [Checkout documentation](https://docs.adyen.com/developers/checkout).

#Adyen Checkout Utility Service 1

https://raw.githubusercontent.com/adyen/adyen-openapi/master/specs/3.0/CheckoutUtilityService-v1.json

A web service containing utility functions available for merchants integrating with Checkout APIs. ## Authentication Each request to the Checkout Utility API must be signed with an API key. For this, obtain an API Key from your Customer Area, as described in [How to get the Checkout API key](https://docs.adyen.com/developers/user-management/how-to-get-the-checkout-api-key). Then set this key to the `X-API-Key` header value, for example: ``` curl -H "Content-Type: application/json" \ -H "X-API-Key: Your_Checkout_API_key" \ ... ``` Note that when going live, you need to generate a new API Key to access the [live endpoints](https://docs.adyen.com/developers/api-reference/live-endpoints). ## Versioning Checkout API supports versioning of its endpoints through a version suffix in the endpoint URL. This suffix has the following format: "vXX", where XX is the version number. For example: ``` https://checkout-test.adyen.com/v1/originKeys ```




#Adyen Payout Service 30

https://raw.githubusercontent.com/adyen/adyen-openapi/master/specs/3.0/PayoutService-v30.json

A set of API endpoints that allow you to store payout details, confirm, or decline a payout. For more information, refer to [Third-party payouts](https://docs.adyen.com/developers/features/third-party-payouts).





# Adyen Recurring Service 25

https://raw.githubusercontent.com/adyen/adyen-openapi/master/specs/3.0/RecurringService-v25.json

The Recurring APIs allow you to manage and remove your tokens or saved payment details. Tokens should be created with validation during a payment request. For more information, refer to our [Tokenization documentation](https://docs.adyen.com/developers/features/tokenization). ## Authentication To connect to the Recurring API, you must use your basic authentication credentials. For this, create your web service user, as described in [How to get the WS user password](https://docs.adyen.com/developers/user-management/how-to-get-the-web-service-ws-user-password). Then use its credentials to authenticate your request, for example: ``` curl -U "ws@Company.YourCompany":"YourWsPassword" \ -H "Content-Type: application/json" \ ... ``` Note that when going live, you need to generate new web service user credentials to access the [live endpoints](https://docs.adyen.com/developers/development-resources/live-endpoints). ## Versioning Recurring API supports versioning of its endpoints through a version suffix in the endpoint URL. This suffix has the following format: "vXX", where XX is the version number. For example: ``` https://pal-test.adyen.com/pal/servlet/Recurring/v25/disable ```




## Requirements

* It supports .net standard 2.0

## Installation

* Simply download and restore nuget packages  
 https://www.nuget.org/packages/Adyen.EcommLibrary/
* or install it from package manager
 PM> Install-Package Adyen.EcommLibrary -Version 2.1.0

## Documentation
* https://docs.adyen.com/developers/development-resources/libraries
* https://docs.adyen.com/developers/checkout/api-integration

## Support
If you have any problems, questions or suggestions, create an issue here or send your inquiry to support@adyen.com.

## Licence

MIT license. For more information, see the LICENSE file.
