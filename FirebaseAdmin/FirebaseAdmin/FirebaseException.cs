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
        internal FirebaseException(string message)
        : base(message) { } // TODO: Remove this constructor

        internal FirebaseException(string message, Exception inner)
        : base(message, inner) { } // TODO: Remove this constructor

        internal FirebaseException(
            ErrorCode code,
            string message,
            Exception inner = null,
            HttpResponseMessage response = null)
        : base(message, inner)
        {
            this.ErrorCode = code;
            this.HttpResponse = response;
        }

        /// <summary>
        /// Gets the platform-wide error code associated with this exception.
        /// </summary>
        internal ErrorCode ErrorCode { get; private set; } // TODO: Expose this as public

        internal HttpResponseMessage HttpResponse { get; private set; }
    }
}
