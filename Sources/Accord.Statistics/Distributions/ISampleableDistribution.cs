﻿// Accord Statistics Library
// The Accord.NET Framework
// http://accord-framework.net
//
// Copyright © César Souza, 2009-2015
// cesarsouza at gmail.com
//
//    This library is free software; you can redistribute it and/or
//    modify it under the terms of the GNU Lesser General Public
//    License as published by the Free Software Foundation; either
//    version 2.1 of the License, or (at your option) any later version.
//
//    This library is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
//    Lesser General Public License for more details.
//
//    You should have received a copy of the GNU Lesser General Public
//    License along with this library; if not, write to the Free Software
//    Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA  02110-1301  USA
//

namespace Accord.Statistics.Distributions
{
    using Accord.Math.Random;

    /// <summary>
    ///   Common interface for sampleable distributions (i.e. distributions that
    ///   allow the generation of new samples through the <see cref="IRandomNumberGenerator{T}.Generate()"/>
    ///   method.
    /// </summary>
    /// 
    /// <typeparam name="TObservations">The type of the observations, such as <see cref="System.Double"/>.</typeparam>
    /// 
    public interface ISampleableDistribution<TObservations> : IDistribution,
        IRandomNumberGenerator<TObservations>
    {
        /// <summary>
        ///   Generates a random observation from the current distribution.
        /// </summary>
        /// 
        /// <param name="result">The location where to store the sample.</param>
        /// 
        /// <returns>A random observation drawn from this distribution.</returns>
        /// 
        TObservations Generate(TObservations result);
    }
}
