﻿using DukptNet;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text;

namespace DukptNetTests
{
    [TestClass]
    public class DukptTest
    {
        [TestMethod]
        public void TestEncryption()
        {
            var clear = "%B5452300551227189^HOGAN/PAUL      ^08043210000000725000000?\0\0\0\0";
            var bdk = "0123456789ABCDEFFEDCBA9876543210";
            var ksn = "FFFF9876543210E00008";
            var track = "C25C1D1197D31CAA87285D59A892047426D9182EC11353C051ADD6D0F072A6CB3436560B3071FC1FD11D9F7E74886742D9BEE0CFD1EA1064C213BB55278B2F12";

            var encBytes = Dukpt.Encrypt(bdk, ksn, Encoding.UTF8.GetBytes(clear));

            var encrypted = BitConverter.ToString(encBytes).Replace("-", "");
            Assert.AreEqual(encrypted, track);
        }

        [TestMethod]
        public void TestEncryptionDEK()
        {
            var clear = "%B5452300551227189^HOGAN/PAUL      ^08043210000000725000000?";
            var bdk = "0123456789ABCDEFFEDCBA9876543210";
            var ksn = "FFFF9876543210E00008";
            var keyed = "1886A60CF138A9FA05A64D8987DEDD63EFC6A6864F074B431A7AC8C4C74FA1CF530CB85B0008B3DEA9EE7BC343D3F6BEFB369573E41690C8B6196241D6C065A4";

            var encBytes = Dukpt.EncryptDEK(bdk, ksn, Encoding.UTF8.GetBytes(clear));

            var encrypted = BitConverter.ToString(encBytes).Replace("-", "");
            Assert.AreEqual(encrypted, keyed);
        }

        [TestMethod]
        public void TestDecryption()
        {
            var clear = "%B5452300551227189^HOGAN/PAUL      ^08043210000000725000000?\0\0\0\0";
            var bdk = "0123456789ABCDEFFEDCBA9876543210";
            var ksn = "FFFF9876543210E00008";
            var track = "C25C1D1197D31CAA87285D59A892047426D9182EC11353C051ADD6D0F072A6CB3436560B3071FC1FD11D9F7E74886742D9BEE0CFD1EA1064C213BB55278B2F12";

            var decBytes = Dukpt.Decrypt(bdk, ksn, BigInt.FromHex(track).GetBytes());

            var decrypted = Encoding.UTF8.GetString(decBytes);
            Assert.AreEqual(decrypted, clear);
        }

        [TestMethod]
        public void TestDEKDecryption()
        {
            var clear = "%B4266841088889999^BUSH JR/GEORGE W.MR^0809101100001100000000046000000?!";
            var bdk = "0123456789ABCDEFFEDCBA9876543210";
            var ksn = "62994901190000000002";
            var track = "DA7F2A52BD3F6DD8B96C50FC39C7E6AF22F06ED1F033BE0FB23D6BD33DC5A1F808512F7AE18D47A60CC3F4559B1B093563BE7E07459072ABF8FAAB5338C6CC8815FF87797AE3A7BE";

            var decBytes = Dukpt.DecryptDEK(bdk, ksn, BigInt.FromHex(track).GetBytes());

            var decrypted = Encoding.UTF8.GetString(decBytes);
            Assert.AreEqual(decrypted, clear);
        }
    }
}
