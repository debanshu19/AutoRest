namespace Fixtures.SwaggerBatHttp
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Models;

    public static partial class HttpFailureExtensions
    {
            /// <summary>
            /// Get empty error form server
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static bool? GetEmptyError(this IHttpFailure operations)
            {
                return Task.Factory.StartNew(s => ((IHttpFailure)s).GetEmptyErrorAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get empty error form server
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<bool?> GetEmptyErrorAsync( this IHttpFailure operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                HttpOperationResponse<bool?> result = await operations.GetEmptyErrorWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

    }
}