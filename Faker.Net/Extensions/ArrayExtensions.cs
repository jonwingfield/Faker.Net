// 
//  Author:
//    Papa Pathe SENE pathe.sene@gmail.com
// 
//  Copyright (c) 2012, Papa Pathe SENE
// 
//  All rights reserved.
// 
//  Redistribution and use in source and binary forms, with or without modification, are permitted provided that the following conditions are met:
// 
//     * Redistributions of source code must retain the above copyright notice, this list of conditions and the following disclaimer.
//     * Redistributions in binary form must reproduce the above copyright notice, this list of conditions and the following disclaimer in
//       the documentation and/or other materials provided with the distribution.
//     * Neither the name of the [ORGANIZATION] nor the names of its contributors may be used to endorse or promote products derived from this software without specific prior written permission.
// 
//  THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS
//  "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT
//  LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR
//  A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR
//  CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL,
//  EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO,
//  PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR
//  PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF
//  LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING
//  NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
//  SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
// 
using System;

namespace Faker
{
	public static class ArrayExtensions
	{
		
		/// <summary>
		/// Assert that the Array Contains the specified item.
		/// </summary>
		/// <param name='array'>
		/// An Array
		/// </param>
		/// <param name='str'>
		/// The item to search in the Array
		/// </param>
		/// <typeparam name='T'>
		/// A generic Type 
		/// </typeparam>
		public static bool Contains<T> (this T[] array, T criteria) where T : IEquatable<T>
		{
			/// Declare a boolean variable initialized to false
			bool found = false;
			
			/// Loop through the array an compare each item in the list with the search criteria
			/// Exit the loop when a match in found
			foreach (T item in array) {
				if (item.Equals (criteria)) {
					found = true;
					break;
				}
			}
			
			return found;
		}
	}
}

