// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.AcceptanceTestsAzureCompositeModelClient
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for PolymorphismOperations.
    /// </summary>
    public static partial class PolymorphismOperationsExtensions
    {
            /// <summary>
            /// Get complex types that are polymorphic
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static Fish GetValid(this IPolymorphismOperations operations)
            {
                return Task.Factory.StartNew(s => ((IPolymorphismOperations)s).GetValidAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get complex types that are polymorphic
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Fish> GetValidAsync(this IPolymorphismOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetValidWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Put complex types that are polymorphic
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='complexBody'>
            /// Please put a salmon that looks like this:
            /// {
            /// 'fishtype':'Salmon',
            /// 'location':'alaska',
            /// 'iswild':true,
            /// 'species':'king',
            /// 'length':1.0,
            /// 'siblings':[
            /// {
            /// 'fishtype':'Shark',
            /// 'age':6,
            /// 'birthday': '2012-01-05T01:00:00Z',
            /// 'length':20.0,
            /// 'species':'predator',
            /// },
            /// {
            /// 'fishtype':'Sawshark',
            /// 'age':105,
            /// 'birthday': '1900-01-05T01:00:00Z',
            /// 'length':10.0,
            /// 'picture': new Buffer([255, 255, 255, 255,
            /// 254]).toString('base64'),
            /// 'species':'dangerous',
            /// },
            /// {
            /// 'fishtype': 'goblin',
            /// 'age': 1,
            /// 'birthday': '2015-08-08T00:00:00Z',
            /// 'length': 30.0,
            /// 'species': 'scary',
            /// 'jawsize': 5
            /// }
            /// ]
            /// };
            /// </param>
            public static void PutValid(this IPolymorphismOperations operations, Fish complexBody)
            {
                Task.Factory.StartNew(s => ((IPolymorphismOperations)s).PutValidAsync(complexBody), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Put complex types that are polymorphic
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='complexBody'>
            /// Please put a salmon that looks like this:
            /// {
            /// 'fishtype':'Salmon',
            /// 'location':'alaska',
            /// 'iswild':true,
            /// 'species':'king',
            /// 'length':1.0,
            /// 'siblings':[
            /// {
            /// 'fishtype':'Shark',
            /// 'age':6,
            /// 'birthday': '2012-01-05T01:00:00Z',
            /// 'length':20.0,
            /// 'species':'predator',
            /// },
            /// {
            /// 'fishtype':'Sawshark',
            /// 'age':105,
            /// 'birthday': '1900-01-05T01:00:00Z',
            /// 'length':10.0,
            /// 'picture': new Buffer([255, 255, 255, 255,
            /// 254]).toString('base64'),
            /// 'species':'dangerous',
            /// },
            /// {
            /// 'fishtype': 'goblin',
            /// 'age': 1,
            /// 'birthday': '2015-08-08T00:00:00Z',
            /// 'length': 30.0,
            /// 'species': 'scary',
            /// 'jawsize': 5
            /// }
            /// ]
            /// };
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PutValidAsync(this IPolymorphismOperations operations, Fish complexBody, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.PutValidWithHttpMessagesAsync(complexBody, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Put complex types that are polymorphic, attempting to omit required
            /// 'birthday' field - the request should not be allowed from the client
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='complexBody'>
            /// Please attempt put a sawshark that looks like this, the client should not
            /// allow this data to be sent:
            /// {
            /// "fishtype": "sawshark",
            /// "species": "snaggle toothed",
            /// "length": 18.5,
            /// "age": 2,
            /// "birthday": "2013-06-01T01:00:00Z",
            /// "location": "alaska",
            /// "picture": base64(FF FF FF FF FE),
            /// "siblings": [
            /// {
            /// "fishtype": "shark",
            /// "species": "predator",
            /// "birthday": "2012-01-05T01:00:00Z",
            /// "length": 20,
            /// "age": 6
            /// },
            /// {
            /// "fishtype": "sawshark",
            /// "species": "dangerous",
            /// "picture": base64(FF FF FF FF FE),
            /// "length": 10,
            /// "age": 105
            /// }
            /// ]
            /// }
            /// </param>
            public static void PutValidMissingRequired(this IPolymorphismOperations operations, Fish complexBody)
            {
                Task.Factory.StartNew(s => ((IPolymorphismOperations)s).PutValidMissingRequiredAsync(complexBody), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Put complex types that are polymorphic, attempting to omit required
            /// 'birthday' field - the request should not be allowed from the client
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='complexBody'>
            /// Please attempt put a sawshark that looks like this, the client should not
            /// allow this data to be sent:
            /// {
            /// "fishtype": "sawshark",
            /// "species": "snaggle toothed",
            /// "length": 18.5,
            /// "age": 2,
            /// "birthday": "2013-06-01T01:00:00Z",
            /// "location": "alaska",
            /// "picture": base64(FF FF FF FF FE),
            /// "siblings": [
            /// {
            /// "fishtype": "shark",
            /// "species": "predator",
            /// "birthday": "2012-01-05T01:00:00Z",
            /// "length": 20,
            /// "age": 6
            /// },
            /// {
            /// "fishtype": "sawshark",
            /// "species": "dangerous",
            /// "picture": base64(FF FF FF FF FE),
            /// "length": 10,
            /// "age": 105
            /// }
            /// ]
            /// }
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task PutValidMissingRequiredAsync(this IPolymorphismOperations operations, Fish complexBody, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.PutValidMissingRequiredWithHttpMessagesAsync(complexBody, null, cancellationToken).ConfigureAwait(false);
            }

    }
}
