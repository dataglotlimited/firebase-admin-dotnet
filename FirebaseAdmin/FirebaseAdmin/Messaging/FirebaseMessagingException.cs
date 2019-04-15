// Copyright 2018, Google Inc. All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using System.Net.Http;

namespace FirebaseAdmin.Messaging
{
    /// <summary>
    /// Represents the errors raised by the Cloud Messaging API.
    /// </summary>
    public sealed class FirebaseMessagingException : FirebaseException
    {
        internal FirebaseMessagingException(
            ErrorCode errorCode,
            string message,
            Exception inner = null,
            HttpResponseMessage response = null)
        : base(errorCode, message, inner, response) { }

        internal FirebaseMessagingException(FirebaseException exception)
        : this(exception.ErrorCode, exception.Message, exception.InnerException, exception.HttpResponse) { }
    }
}
