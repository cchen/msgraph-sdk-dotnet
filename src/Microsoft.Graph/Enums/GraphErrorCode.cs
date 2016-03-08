// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph
{
    public enum GraphErrorCode
    {
        AccessDenied,
        ActivityLimitReached,
        AccessRestricted,
        AuthenticationCancelled,
        AuthenticationFailure,
        CannotSnapshotTree,
        ChildItemCountExceeded,
        EntityTagDoesNotMatch,
        FragmentLengthMismatch,
        FragmentOutOfOrder,
        FragmentOverlap,
        GeneralException,
        InvalidAcceptType,
        InvalidParameterFormat,
        InvalidPath,
        InvalidQueryOption,
        InvalidRange,
        InvalidRequest,
        InvalidStartIndex,
        ItemNotFound,
        LockMismatch,
        LockNotFoundOrAlreadyExpired,
        LockOwnerMismatch,
        MalformedEntityTag,
        MalwareDetected,
        MaxDocumentCountExceeded,
        MaxFileSizeExceeded,
        MaxFolderCountExceeded,
        MaxFragmentLengthExceeded,
        MaxItemCountExceeded,
        MaxQueryLengthExceeded,
        MaxStreamSizeExceeded,
        NameAlreadyExists,
        NotAllowed,
        NotSupported,
        ParameterIsTooLong,
        ParameterIsTooSmall,
        PathIsTooLong,
        PathTooDeep,
        PropertyNotUpdateable,
        ResourceModified,
        ResyncApplyDifferences,
        ResyncRequired,
        ResyncUploadDifferences,
        ServiceNotAvailable,
        ServiceReadOnly,
        ThrottledRequest,
        Timeout,
        TooManyRedirects,
        TooManyResultsRequested,
        TooManyTermsInQuery,
        TotalAffectedItemCountExceeded,
        TruncationNotAllowed,
        QuotaLimitReached,
        Unauthenticated,
        UploadSessionFailed,
        UploadSessionIncomplete,
        UploadSessionNotFound,
        VirusSuspicious,
        ZeroOrFewerResultsRequested,
    }
}
