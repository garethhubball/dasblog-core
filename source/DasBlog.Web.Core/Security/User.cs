﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace DasBlog.Web.Core.Security
{
	[Serializable]
	[XmlType("User")]
	public class User : IEquatable<User>
	{
		public string Name { get; set; }

		public string Role { get; set; }

		public bool Ask { get; set; }

		public string EmailAddress { get; set; }

		public string DisplayName { get; set; }

		public string OpenIDUrl { get; set; }

		public bool NotifyOnNewPost { get; set; }

		public bool NotifyOnAllComment { get; set; }

		public bool NotifyOnOwnComment { get; set; }

		public bool Active { get; set; }

		public string Password { get; set; }

		[XmlElement("Password")]
		public string XmlPassword { get; set; }

		public UserToken ToToken() => new UserToken(Name, Role);

		public bool Equals(User other)
		{
			return EmailAddress == other.EmailAddress;
		}
	}
}
