using System.Collections.Generic;

namespace FirebaseAdmin
{
    internal static class ErrorCodeUtils
    {
        private static IReadOnlyDictionary<string, ErrorCode> mappings = new Dictionary<string, ErrorCode>()
        {
            { "INVALID_ARGUMENT", ErrorCode.InvalidArgument },
        };

        internal static ErrorCode FromString(string code)
        {
            ErrorCode result;
            if (mappings.TryGetValue(code, out result))
            {
                return result;
            }

            return ErrorCode.Unknown;
        }

        internal static ErrorCode FromHttpStatus(int code)
        {
            if (code == 400)
            {
                return ErrorCode.InvalidArgument;
            }

            return ErrorCode.Unknown;
        }
    }
}
