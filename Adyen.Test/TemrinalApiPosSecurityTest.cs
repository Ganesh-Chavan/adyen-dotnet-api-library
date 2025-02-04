﻿using Adyen.Security;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Adyen.Test
{
    [TestClass]
    public class TemrinalApiPosSecurityTest : BaseTest
    {
        private SaleToPoiMessageSecuredEncryptor _messageSecuredEncryptor;
        private EncryptionCredentialDetails _encryptionCredentialDetails;

        [TestInitialize]
        public void Initialize()
        {
            _messageSecuredEncryptor = new SaleToPoiMessageSecuredEncryptor();
            _encryptionCredentialDetails = new EncryptionCredentialDetails
            {
                AdyenCryptoVersion = 1,
                KeyIdentifier = "CryptoKeyIdentifier12345",
                Password = "p@ssw0rd123456"
            };
        }

        [TestMethod]
        public void TestTerminalAPiPosEncryption()
        {
            //dummy header
            var messageHeader = MockNexoMessageHeaderRequest();
            //dummy json message
            var saleToPoiRequest = MockPosApiRequest.MockNexoJsonRequest();
            var saleToPoiMessageSecured = _messageSecuredEncryptor.Encrypt(saleToPoiRequest, messageHeader, _encryptionCredentialDetails);

            Assert.IsNotNull(saleToPoiMessageSecured);
        }
        
        [TestMethod]
        public void TestTerminalApiPosDecryption()
        {
            //dummy header
            var messageHeader = MockNexoMessageHeaderRequest();
            //dummy json message
            var saleToPoiRequest = MockPosApiRequest.MockNexoJsonRequest();
            var saleToPoiMessageSecured = _messageSecuredEncryptor.Encrypt(saleToPoiRequest, messageHeader, _encryptionCredentialDetails);
            var saleToPoiRequestDecrypt = _messageSecuredEncryptor.Decrypt(saleToPoiMessageSecured, _encryptionCredentialDetails);

            Assert.IsNotNull(saleToPoiRequestDecrypt);
            Assert.AreEqual(saleToPoiRequest, saleToPoiRequestDecrypt);
        }
    }
}
