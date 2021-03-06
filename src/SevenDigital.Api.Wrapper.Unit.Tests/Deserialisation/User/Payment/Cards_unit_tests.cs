﻿using System;
using System.Linq;
using System.Net;
using NUnit.Framework;
using SevenDigital.Api.Schema.User.Payment;
using SevenDigital.Api.Wrapper.Http;
using SevenDigital.Api.Wrapper.Serialization;

namespace SevenDigital.Api.Wrapper.Unit.Tests.Deserialisation.User.Payment
{
	[TestFixture]
	public class AddCardsTests
	{
		private const string responseXml = "<?xml version=\"1.0\" encoding=\"utf-8\"?>" +
			"<response xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xsi:noNamespaceSchemaLocation=\"http://api.7digital.com/1.2/static/7digitalAPI.xsd\" status=\"ok\" version=\"1.2\">" +
				"<card id=\"8154430\">" +
					"<type>Visa</type>" +
					"<last4digits>5485</last4digits>" +
					"<default>true</default>" +
					"<cardHolderName>MR I HUNT</cardHolderName>" +
					"<expiryDate>201202</expiryDate>" +
					"<country>NZ</country>" +
				"</card>" +
				"</response>";

		private readonly Response response = new Response(HttpStatusCode.OK, responseXml);

		[Test]
		public void can_deserialise_response_user_cards()
		{
			var xmlParser = new ResponseParser<AddCard>();

			var deserializedCards = xmlParser.Parse(response);
			
			Assert.That(deserializedCards, Is.Not.Null);
		}
	}
}
