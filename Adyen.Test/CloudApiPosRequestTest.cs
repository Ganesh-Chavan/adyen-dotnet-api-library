﻿using Adyen.Model.Nexo;
using Adyen.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Adyen.Test
{
    [TestClass]
    public class CloudApiPosRequestTest : BaseTest
    {

        [TestMethod]
        public void TestCloudApiSyncRequest()
        {
            try
            {
                //Create a mock pos payment request
                var paymentRequest = MockPosApiRequest.CreatePosPaymentRequest();
                var client = CreateMockTestClientPosCloudApiRequest("Mocks/terminalapi/pospayment-success.json");
                var payment = new PosPaymentCloudApi(client);
                var saleToPoiResponse = payment.TerminalApiCloudSync(paymentRequest);

                Assert.IsNotNull(saleToPoiResponse);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestCloudApiAsyncRequest()
        {
            try
            {
                //Create a mock pos payment request
                var paymentRequest = MockPosApiRequest.CreatePosPaymentRequest();
                var client = CreateMockTestClientPosCloudApiRequest("Mocks/terminalapi/pospayment-success.json");
                var payment = new PosPaymentCloudApi(client);
                var saleToPoiResponse = payment.TerminalApiCloudAsync(paymentRequest);

                Assert.IsNotNull(saleToPoiResponse);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestCloudApiTransactionStatusResponseSuccess()
        {
            var paymentRequest = MockPosApiRequest.CreatePosPaymentRequest();
            var client = CreateMockTestClientPosCloudApiRequest("Mocks/terminalapi/pospayment-transaction-status-response.json");
            var payment = new PosPaymentCloudApi(client);
            var saleToPoiResponse = payment.TerminalApiCloudSync(paymentRequest);

            try
            {
                var transactionStatusResponse = (TransactionStatusResponse)saleToPoiResponse.Item;
                var messagePayloadResponse = transactionStatusResponse.RepeatedMessageResponse.RepeatedResponseMessageBody.MessagePayload;               
                Assert.IsNotNull(saleToPoiResponse);
                Assert.AreEqual(saleToPoiResponse.MessageHeader.ServiceID, "35543420");
                Assert.AreEqual(saleToPoiResponse.MessageHeader.SaleID, "TOSIM_1_1_6");
                Assert.AreEqual(saleToPoiResponse.MessageHeader.POIID, "P400Plus-12345678");
                Assert.AreEqual(transactionStatusResponse.Response.Result, ResultType.Success);
                Assert.AreEqual(messagePayloadResponse.PaymentResult.PaymentInstrumentData.CardData.EntryMode[0], EntryModeType.ICC);
                Assert.AreEqual(messagePayloadResponse.POIData.POIReconciliationID, "1000");
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void TestCloudApiSyncRequestEmptyResponse()
        {
            try
            {
                //Create a mock pos payment request
                var paymentRequest = MockPosApiRequest.CreatePosPaymentRequest();
                var client = CreateMockTestClientPosCloudApiRequest("");
                var payment = new PosPaymentCloudApi(client);
                var saleToPoiResponse = payment.TerminalApiCloudSync(paymentRequest);
                Assert.IsNull(saleToPoiResponse);
            }
            catch (Exception)
            {
                Assert.Fail();
            }
        }
    }
}
