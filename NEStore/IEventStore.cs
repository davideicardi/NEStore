﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace NEStore
{
	public interface IEventStore<T>
	{
		/// <summary>
		/// Setup bucket
		/// </summary>
		/// <param name="bucketName">Bucket identifier</param>
		Task EnsureBucketAsync(string bucketName);

		/// <summary>
		/// Drop bucket from durable storage
		/// </summary>
		/// <param name="bucketName">Bucket identifier</param>
		Task DeleteBucketAsync(string bucketName);

		/// <summary>
		/// Provide the bucket instance
		/// </summary>
		/// <param name="bucketName">Bucket identifier</param>
		IBucket<T> Bucket(string bucketName);

		/// <summary>
		/// Register dispatchers
		/// </summary>
		/// <param name="dispatchers">List of dispatchers</param>
		void RegisterDispatchers(params IDispatcher<T>[] dispatchers);
		
		/// <summary>
		/// Return registered dispatchers
		/// </summary>
		/// <returns>List of dispatchers</returns>
		IEnumerable<IDispatcher<T>> GetDispatchers();
	}
}