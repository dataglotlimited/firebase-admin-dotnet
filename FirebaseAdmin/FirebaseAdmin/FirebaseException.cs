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

namespace FirebaseAdmin
{
    /// <summary>
    /// Common error type for all exceptions raised by Firebase APIs.
    /// </summary>
    public class FirebaseException : Exception
    {
        internal FirebaseException(string message, Exception inner = null)
        : this(ErrorCode.Unknown, message, inner) { }

        internal FirebaseException(
            ErrorCode errorCode,
            string message,
            Exception inner = null,
            HttpResponseMessage response = null)
        : base(message, inner)
        {
            this.ErrorCode = errorCode;
            this.HttpResponse = response;
        }

        /// <summary>
        /// Gets the error code associated with this exception.
        /// </summary>
        public ErrorCode ErrorCode { get; private set; }

        /// <summary>
        /// Gets the <c>HttpResponseMessage</c> that resulted in this exception. Returns null
        /// if the exception originated locally.
        /// </summary>
        public HttpResponseMessage HttpResponse { get; private set; }
    }
}
