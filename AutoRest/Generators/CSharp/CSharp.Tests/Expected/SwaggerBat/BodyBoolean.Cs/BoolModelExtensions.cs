namespace Fixtures.SwaggerBatBodyBoolean
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Models;

    public static partial class BoolModelExtensions
    {
            /// <summary>
            /// Get true Boolean value
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static bool? GetTrue(this IBoolModel operations)
            {
                return Task.Factory.StartNew(s => ((IBoolModel)s).GetTrueAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get true Boolean value
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<bool?> GetTrueAsync( this IBoolModel operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                HttpOperationResponse<bool?> result = await operations.GetTrueWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Set Boolean value true
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='boolBody'>
            /// </param>
            public static void PutTrue(this IBoolModel operations, bool? boolBody)
            {
                Task.Factory.StartNew(s => ((IBoolModel)s).PutTrueAsync(boolBody), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Set Boolean value true
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='boolBody'>
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task PutTrueAsync( this IBoolModel operations, bool? boolBody, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.PutTrueWithHttpMessagesAsync(boolBody, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get false Boolean value
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static bool? GetFalse(this IBoolModel operations)
            {
                return Task.Factory.StartNew(s => ((IBoolModel)s).GetFalseAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get false Boolean value
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<bool?> GetFalseAsync( this IBoolModel operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                HttpOperationResponse<bool?> result = await operations.GetFalseWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Set Boolean value false
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='boolBody'>
            /// </param>
            public static void PutFalse(this IBoolModel operations, bool? boolBody)
            {
                Task.Factory.StartNew(s => ((IBoolModel)s).PutFalseAsync(boolBody), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Set Boolean value false
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='boolBody'>
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task PutFalseAsync( this IBoolModel operations, bool? boolBody, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.PutFalseWithHttpMessagesAsync(boolBody, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get null Boolean value
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static bool? GetNull(this IBoolModel operations)
            {
                return Task.Factory.StartNew(s => ((IBoolModel)s).GetNullAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get null Boolean value
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<bool?> GetNullAsync( this IBoolModel operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                HttpOperationResponse<bool?> result = await operations.GetNullWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Get invalid Boolean value
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static bool? GetInvalid(this IBoolModel operations)
            {
                return Task.Factory.StartNew(s => ((IBoolModel)s).GetInvalidAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get invalid Boolean value
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task<bool?> GetInvalidAsync( this IBoolModel operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                HttpOperationResponse<bool?> result = await operations.GetInvalidWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

    }
}