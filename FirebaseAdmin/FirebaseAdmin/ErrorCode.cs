namespace FirebaseAdmin
{
    /// <summary>
    /// Defines the collection of top-level Firebase error codes. All instances of <see cref="FirebaseException"/>
    /// are guaranteed to contain an error code defined here.
    /// </summary>
    public enum ErrorCode
    {
        /// <summary>
        /// An operation attempted to create one or more resoures that already exists.
        /// </summary>
        AlreadyExists,

        /// <summary>
        /// One or more arguments provided to an operation are invalid.
        /// </summary>
        InvalidArgument,

        /// <summary>
        /// Some text.
        /// </summary>
        FailedPrecondition,

        /// <summary>
        /// Some text.
        /// </summary>
        Unauthenticated,

        /// <summary>
        /// Some text.
        /// </summary>
        PermissionDenied,

        /// <summary>
        /// Some text.
        /// </summary>
        NotFound,

        /// <summary>
        /// Some text.
        /// </summary>
        Unknown,

        /// <summary>
        /// Some text.
        /// </summary>
        Internal,

        /// <summary>
        /// Some text.
        /// </summary>
        Unavailable,

        /// <summary>
        /// Some text.
        /// </summary>
        DeadlineExceeded,
    }
}