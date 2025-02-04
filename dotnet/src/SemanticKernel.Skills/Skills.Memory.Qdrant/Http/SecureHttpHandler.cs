﻿// Copyright (c) Microsoft. All rights reserved.

using System.Net.Http;

namespace Microsoft.SemanticKernel.Skills.Memory.Qdrant.Http;

internal static class HttpHandlers
{
    public static HttpClientHandler CheckCertificateRevocation { get; } = new HttpClientHandler
    {
        CheckCertificateRevocationList = false
    };
}
