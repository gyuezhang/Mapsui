﻿using System;
using System.Linq;
using NUnit.Framework;
using SharpMap.Providers.GeoTiff;

namespace SharpMap.Providers.Tests.GeoTiff
{
    [TestFixture]
    public class GeoTiffProviderTests
    {
        [Test]
        public void GeoTiffProviderConstructor_WhenInitialized_ShouldReturnFeatures()
        {
            const string location = @".\Resources\example.tif";
            var geoTiffProvider = new GeoTiffProvider(location);
            var test = geoTiffProvider.GetExtents().Left.ToString();
            Console.WriteLine(test);
                
        }
    }
}
