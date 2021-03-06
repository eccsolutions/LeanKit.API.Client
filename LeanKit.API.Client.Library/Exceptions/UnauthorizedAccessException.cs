//------------------------------------------------------------------------------
// <copyright company="LeanKit Inc.">
//     Copyright (c) LeanKit Inc.  All rights reserved.
// </copyright> 
//------------------------------------------------------------------------------

using System;
using System.Runtime.Serialization;
using LeanKit.API.Client.Library.TransferObjects;

namespace LeanKit.API.Client.Library.Exceptions
{
	[Serializable]
	public class UnauthorizedAccessException : LeanKitAPIException
	{
		public UnauthorizedAccessException() : this(null, null) { }

		public UnauthorizedAccessException(string message) : this(message, null) { }

		public UnauthorizedAccessException(Exception innerException) : this(null, innerException) { }

		public UnauthorizedAccessException(string message, Exception innerException)
			: base(
				string.IsNullOrEmpty(message)
					? (innerException != null
						? innerException.Message
						: "The specified user does not have permission to perform this operation.")
					: message, ResponseCode.UnauthorizedAccess, innerException) { }

		protected UnauthorizedAccessException(SerializationInfo info, StreamingContext context) : base(info, context) { }
	}
}