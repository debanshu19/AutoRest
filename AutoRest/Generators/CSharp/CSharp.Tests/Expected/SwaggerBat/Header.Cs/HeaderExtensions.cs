namespace Fixtures.SwaggerBatHeader
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Models;

    public static partial class HeaderExtensions
    {
            /// <summary>
            /// Send a post request with header value "User-Agent": "overwrite"
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='userAgent'>
            /// Send a post request with header value "User-Agent": "overwrite"
            /// </param>
            public static void ParamExistingKey(this IHeader operations, string userAgent)
            {
                Task.Factory.StartNew(s => ((IHeader)s).ParamExistingKeyAsync(userAgent), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Send a post request with header value "User-Agent": "overwrite"
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='userAgent'>
            /// Send a post request with header value "User-Agent": "overwrite"
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task ParamExistingKeyAsync( this IHeader operations, string userAgent, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.ParamExistingKeyWithHttpMessagesAsync(userAgent, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get a response with header value "User-Agent": "overwrite"
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static void ResponseExistingKey(this IHeader operations)
            {
                Task.Factory.StartNew(s => ((IHeader)s).ResponseExistingKeyAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a response with header value "User-Agent": "overwrite"
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task ResponseExistingKeyAsync( this IHeader operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.ResponseExistingKeyWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Send a post request with header value "Content-Type": "text/html"
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='contentType'>
            /// Send a post request with header value "Content-Type": "text/html"
            /// </param>
            public static void ParamProtectedKey(this IHeader operations, string contentType)
            {
                Task.Factory.StartNew(s => ((IHeader)s).ParamProtectedKeyAsync(contentType), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Send a post request with header value "Content-Type": "text/html"
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='contentType'>
            /// Send a post request with header value "Content-Type": "text/html"
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task ParamProtectedKeyAsync( this IHeader operations, string contentType, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.ParamProtectedKeyWithHttpMessagesAsync(contentType, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get a response with header value "Content-Type": "text/html"
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static void ResponseProtectedKey(this IHeader operations)
            {
                Task.Factory.StartNew(s => ((IHeader)s).ResponseProtectedKeyAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a response with header value "Content-Type": "text/html"
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task ResponseProtectedKeyAsync( this IHeader operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.ResponseProtectedKeyWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Send a post request with header values "scenario": "positive", "value": 1
            /// or "scenario": "negative", "value": -2
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scenario'>
            /// Send a post request with header values "scenario": "positive" or "negative"
            /// </param>
            /// <param name='value'>
            /// Send a post request with header values 1 or -2
            /// </param>
            public static void ParamInteger(this IHeader operations, string scenario, int? value)
            {
                Task.Factory.StartNew(s => ((IHeader)s).ParamIntegerAsync(scenario, value), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Send a post request with header values "scenario": "positive", "value": 1
            /// or "scenario": "negative", "value": -2
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scenario'>
            /// Send a post request with header values "scenario": "positive" or "negative"
            /// </param>
            /// <param name='value'>
            /// Send a post request with header values 1 or -2
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task ParamIntegerAsync( this IHeader operations, string scenario, int? value, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.ParamIntegerWithHttpMessagesAsync(scenario, value, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get a response with header value "value": 1 or -2
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scenario'>
            /// Send a post request with header values "scenario": "positive" or "negative"
            /// </param>
            public static void ResponseInteger(this IHeader operations, string scenario)
            {
                Task.Factory.StartNew(s => ((IHeader)s).ResponseIntegerAsync(scenario), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a response with header value "value": 1 or -2
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scenario'>
            /// Send a post request with header values "scenario": "positive" or "negative"
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task ResponseIntegerAsync( this IHeader operations, string scenario, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.ResponseIntegerWithHttpMessagesAsync(scenario, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Send a post request with header values "scenario": "positive", "value":
            /// 105 or "scenario": "negative", "value": -2
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scenario'>
            /// Send a post request with header values "scenario": "positive" or "negative"
            /// </param>
            /// <param name='value'>
            /// Send a post request with header values 105 or -2
            /// </param>
            public static void ParamLong(this IHeader operations, string scenario, long? value)
            {
                Task.Factory.StartNew(s => ((IHeader)s).ParamLongAsync(scenario, value), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Send a post request with header values "scenario": "positive", "value":
            /// 105 or "scenario": "negative", "value": -2
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scenario'>
            /// Send a post request with header values "scenario": "positive" or "negative"
            /// </param>
            /// <param name='value'>
            /// Send a post request with header values 105 or -2
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task ParamLongAsync( this IHeader operations, string scenario, long? value, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.ParamLongWithHttpMessagesAsync(scenario, value, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get a response with header value "value": 105 or -2
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scenario'>
            /// Send a post request with header values "scenario": "positive" or "negative"
            /// </param>
            public static void ResponseLong(this IHeader operations, string scenario)
            {
                Task.Factory.StartNew(s => ((IHeader)s).ResponseLongAsync(scenario), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a response with header value "value": 105 or -2
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scenario'>
            /// Send a post request with header values "scenario": "positive" or "negative"
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task ResponseLongAsync( this IHeader operations, string scenario, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.ResponseLongWithHttpMessagesAsync(scenario, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Send a post request with header values "scenario": "positive", "value":
            /// 0.07 or "scenario": "negative", "value": -3.0
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scenario'>
            /// Send a post request with header values "scenario": "positive" or "negative"
            /// </param>
            /// <param name='value'>
            /// Send a post request with header values 0.07 or -3.0
            /// </param>
            public static void ParamFloat(this IHeader operations, string scenario, double? value)
            {
                Task.Factory.StartNew(s => ((IHeader)s).ParamFloatAsync(scenario, value), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Send a post request with header values "scenario": "positive", "value":
            /// 0.07 or "scenario": "negative", "value": -3.0
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scenario'>
            /// Send a post request with header values "scenario": "positive" or "negative"
            /// </param>
            /// <param name='value'>
            /// Send a post request with header values 0.07 or -3.0
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task ParamFloatAsync( this IHeader operations, string scenario, double? value, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.ParamFloatWithHttpMessagesAsync(scenario, value, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get a response with header value "value": 0.07 or -3.0
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scenario'>
            /// Send a post request with header values "scenario": "positive" or "negative"
            /// </param>
            public static void ResponseFloat(this IHeader operations, string scenario)
            {
                Task.Factory.StartNew(s => ((IHeader)s).ResponseFloatAsync(scenario), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a response with header value "value": 0.07 or -3.0
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scenario'>
            /// Send a post request with header values "scenario": "positive" or "negative"
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task ResponseFloatAsync( this IHeader operations, string scenario, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.ResponseFloatWithHttpMessagesAsync(scenario, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Send a post request with header values "scenario": "positive", "value":
            /// 7e120 or "scenario": "negative", "value": -3.0
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scenario'>
            /// Send a post request with header values "scenario": "positive" or "negative"
            /// </param>
            /// <param name='value'>
            /// Send a post request with header values 7e120 or -3.0
            /// </param>
            public static void ParamDouble(this IHeader operations, string scenario, double? value)
            {
                Task.Factory.StartNew(s => ((IHeader)s).ParamDoubleAsync(scenario, value), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Send a post request with header values "scenario": "positive", "value":
            /// 7e120 or "scenario": "negative", "value": -3.0
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scenario'>
            /// Send a post request with header values "scenario": "positive" or "negative"
            /// </param>
            /// <param name='value'>
            /// Send a post request with header values 7e120 or -3.0
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task ParamDoubleAsync( this IHeader operations, string scenario, double? value, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.ParamDoubleWithHttpMessagesAsync(scenario, value, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get a response with header value "value": 7e120 or -3.0
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scenario'>
            /// Send a post request with header values "scenario": "positive" or "negative"
            /// </param>
            public static void ResponseDouble(this IHeader operations, string scenario)
            {
                Task.Factory.StartNew(s => ((IHeader)s).ResponseDoubleAsync(scenario), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a response with header value "value": 7e120 or -3.0
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scenario'>
            /// Send a post request with header values "scenario": "positive" or "negative"
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task ResponseDoubleAsync( this IHeader operations, string scenario, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.ResponseDoubleWithHttpMessagesAsync(scenario, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Send a post request with header values "scenario": "true", "value": true
            /// or "scenario": "false", "value": false
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scenario'>
            /// Send a post request with header values "scenario": "true" or "false"
            /// </param>
            /// <param name='value'>
            /// Send a post request with header values true or false
            /// </param>
            public static void ParamBool(this IHeader operations, string scenario, bool? value)
            {
                Task.Factory.StartNew(s => ((IHeader)s).ParamBoolAsync(scenario, value), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Send a post request with header values "scenario": "true", "value": true
            /// or "scenario": "false", "value": false
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scenario'>
            /// Send a post request with header values "scenario": "true" or "false"
            /// </param>
            /// <param name='value'>
            /// Send a post request with header values true or false
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task ParamBoolAsync( this IHeader operations, string scenario, bool? value, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.ParamBoolWithHttpMessagesAsync(scenario, value, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get a response with header value "value": true or false
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scenario'>
            /// Send a post request with header values "scenario": "true" or "false"
            /// </param>
            public static void ResponseBool(this IHeader operations, string scenario)
            {
                Task.Factory.StartNew(s => ((IHeader)s).ResponseBoolAsync(scenario), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a response with header value "value": true or false
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scenario'>
            /// Send a post request with header values "scenario": "true" or "false"
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task ResponseBoolAsync( this IHeader operations, string scenario, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.ResponseBoolWithHttpMessagesAsync(scenario, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Send a post request with header values "scenario": "valid", "value": "The
            /// quick brown fox jumps over the lazy dog" or "scenario": "null", "value":
            /// null or "scenario": "empty", "value": ""
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scenario'>
            /// Send a post request with header values "scenario": "valid" or "null" or
            /// "empty"
            /// </param>
            /// <param name='value'>
            /// Send a post request with header values "The quick brown fox jumps over the
            /// lazy dog" or null or ""
            /// </param>
            public static void ParamString(this IHeader operations, string scenario, string value = default(string))
            {
                Task.Factory.StartNew(s => ((IHeader)s).ParamStringAsync(scenario, value), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Send a post request with header values "scenario": "valid", "value": "The
            /// quick brown fox jumps over the lazy dog" or "scenario": "null", "value":
            /// null or "scenario": "empty", "value": ""
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scenario'>
            /// Send a post request with header values "scenario": "valid" or "null" or
            /// "empty"
            /// </param>
            /// <param name='value'>
            /// Send a post request with header values "The quick brown fox jumps over the
            /// lazy dog" or null or ""
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task ParamStringAsync( this IHeader operations, string scenario, string value = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.ParamStringWithHttpMessagesAsync(scenario, value, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get a response with header values "The quick brown fox jumps over the lazy
            /// dog" or null or ""
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scenario'>
            /// Send a post request with header values "scenario": "valid" or "null" or
            /// "empty"
            /// </param>
            public static void ResponseString(this IHeader operations, string scenario)
            {
                Task.Factory.StartNew(s => ((IHeader)s).ResponseStringAsync(scenario), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a response with header values "The quick brown fox jumps over the lazy
            /// dog" or null or ""
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scenario'>
            /// Send a post request with header values "scenario": "valid" or "null" or
            /// "empty"
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task ResponseStringAsync( this IHeader operations, string scenario, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.ResponseStringWithHttpMessagesAsync(scenario, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Send a post request with header values "scenario": "valid", "value":
            /// "2010-01-01" or "scenario": "min", "value": "0001-01-01"
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scenario'>
            /// Send a post request with header values "scenario": "valid" or "min"
            /// </param>
            /// <param name='value'>
            /// Send a post request with header values "2010-01-01" or "0001-01-01"
            /// </param>
            public static void ParamDate(this IHeader operations, string scenario, DateTime? value)
            {
                Task.Factory.StartNew(s => ((IHeader)s).ParamDateAsync(scenario, value), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Send a post request with header values "scenario": "valid", "value":
            /// "2010-01-01" or "scenario": "min", "value": "0001-01-01"
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scenario'>
            /// Send a post request with header values "scenario": "valid" or "min"
            /// </param>
            /// <param name='value'>
            /// Send a post request with header values "2010-01-01" or "0001-01-01"
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task ParamDateAsync( this IHeader operations, string scenario, DateTime? value, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.ParamDateWithHttpMessagesAsync(scenario, value, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get a response with header values "2010-01-01" or "0001-01-01"
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scenario'>
            /// Send a post request with header values "scenario": "valid" or "min"
            /// </param>
            public static void ResponseDate(this IHeader operations, string scenario)
            {
                Task.Factory.StartNew(s => ((IHeader)s).ResponseDateAsync(scenario), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a response with header values "2010-01-01" or "0001-01-01"
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scenario'>
            /// Send a post request with header values "scenario": "valid" or "min"
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task ResponseDateAsync( this IHeader operations, string scenario, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.ResponseDateWithHttpMessagesAsync(scenario, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Send a post request with header values "scenario": "valid", "value":
            /// "2010-01-01T12:34:56Z" or "scenario": "min", "value":
            /// "0001-01-01T00:00:00Z"
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scenario'>
            /// Send a post request with header values "scenario": "valid" or "min"
            /// </param>
            /// <param name='value'>
            /// Send a post request with header values "2010-01-01T12:34:56Z" or
            /// "0001-01-01T00:00:00Z"
            /// </param>
            public static void ParamDatetime(this IHeader operations, string scenario, DateTime? value)
            {
                Task.Factory.StartNew(s => ((IHeader)s).ParamDatetimeAsync(scenario, value), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Send a post request with header values "scenario": "valid", "value":
            /// "2010-01-01T12:34:56Z" or "scenario": "min", "value":
            /// "0001-01-01T00:00:00Z"
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scenario'>
            /// Send a post request with header values "scenario": "valid" or "min"
            /// </param>
            /// <param name='value'>
            /// Send a post request with header values "2010-01-01T12:34:56Z" or
            /// "0001-01-01T00:00:00Z"
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task ParamDatetimeAsync( this IHeader operations, string scenario, DateTime? value, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.ParamDatetimeWithHttpMessagesAsync(scenario, value, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get a response with header values "2010-01-01T12:34:56Z" or
            /// "0001-01-01T00:00:00Z"
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scenario'>
            /// Send a post request with header values "scenario": "valid" or "min"
            /// </param>
            public static void ResponseDatetime(this IHeader operations, string scenario)
            {
                Task.Factory.StartNew(s => ((IHeader)s).ResponseDatetimeAsync(scenario), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a response with header values "2010-01-01T12:34:56Z" or
            /// "0001-01-01T00:00:00Z"
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scenario'>
            /// Send a post request with header values "scenario": "valid" or "min"
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task ResponseDatetimeAsync( this IHeader operations, string scenario, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.ResponseDatetimeWithHttpMessagesAsync(scenario, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Send a post request with header values "scenario": "valid", "value":
            /// "啊齄丂狛狜隣郎隣兀﨩"
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scenario'>
            /// Send a post request with header values "scenario": "valid"
            /// </param>
            /// <param name='value'>
            /// Send a post request with header values "啊齄丂狛狜隣郎隣兀﨩"
            /// </param>
            public static void ParamByte(this IHeader operations, string scenario, byte[] value)
            {
                Task.Factory.StartNew(s => ((IHeader)s).ParamByteAsync(scenario, value), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Send a post request with header values "scenario": "valid", "value":
            /// "啊齄丂狛狜隣郎隣兀﨩"
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scenario'>
            /// Send a post request with header values "scenario": "valid"
            /// </param>
            /// <param name='value'>
            /// Send a post request with header values "啊齄丂狛狜隣郎隣兀﨩"
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task ParamByteAsync( this IHeader operations, string scenario, byte[] value, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.ParamByteWithHttpMessagesAsync(scenario, value, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get a response with header values "啊齄丂狛狜隣郎隣兀﨩"
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scenario'>
            /// Send a post request with header values "scenario": "valid"
            /// </param>
            public static void ResponseByte(this IHeader operations, string scenario)
            {
                Task.Factory.StartNew(s => ((IHeader)s).ResponseByteAsync(scenario), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a response with header values "啊齄丂狛狜隣郎隣兀﨩"
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scenario'>
            /// Send a post request with header values "scenario": "valid"
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task ResponseByteAsync( this IHeader operations, string scenario, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.ResponseByteWithHttpMessagesAsync(scenario, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Send a post request with header values "scenario": "valid", "value":
            /// "GREY" or "scenario": "null", "value": null
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scenario'>
            /// Send a post request with header values "scenario": "valid" or "null" or
            /// "empty"
            /// </param>
            /// <param name='value'>
            /// Send a post request with header values 'GREY' . Possible values for this
            /// parameter include: 'White', 'black', 'GREY'
            /// </param>
            public static void ParamEnum(this IHeader operations, string scenario, GreyscaleColors? value = default(GreyscaleColors?))
            {
                Task.Factory.StartNew(s => ((IHeader)s).ParamEnumAsync(scenario, value), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Send a post request with header values "scenario": "valid", "value":
            /// "GREY" or "scenario": "null", "value": null
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scenario'>
            /// Send a post request with header values "scenario": "valid" or "null" or
            /// "empty"
            /// </param>
            /// <param name='value'>
            /// Send a post request with header values 'GREY' . Possible values for this
            /// parameter include: 'White', 'black', 'GREY'
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task ParamEnumAsync( this IHeader operations, string scenario, GreyscaleColors? value = default(GreyscaleColors?), CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.ParamEnumWithHttpMessagesAsync(scenario, value, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Get a response with header values "GREY" or null
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scenario'>
            /// Send a post request with header values "scenario": "valid" or "null" or
            /// "empty"
            /// </param>
            public static void ResponseEnum(this IHeader operations, string scenario)
            {
                Task.Factory.StartNew(s => ((IHeader)s).ResponseEnumAsync(scenario), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a response with header values "GREY" or null
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='scenario'>
            /// Send a post request with header values "scenario": "valid" or "null" or
            /// "empty"
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task ResponseEnumAsync( this IHeader operations, string scenario, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.ResponseEnumWithHttpMessagesAsync(scenario, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Send x-ms-client-request-id = 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0 in the
            /// header of the request
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static void CustomRequestId(this IHeader operations)
            {
                Task.Factory.StartNew(s => ((IHeader)s).CustomRequestIdAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Send x-ms-client-request-id = 9C4D50EE-2D56-4CD3-8152-34347DC9F2B0 in the
            /// header of the request
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// Cancellation token.
            /// </param>
            public static async Task CustomRequestIdAsync( this IHeader operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.CustomRequestIdWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false);
            }

    }
}