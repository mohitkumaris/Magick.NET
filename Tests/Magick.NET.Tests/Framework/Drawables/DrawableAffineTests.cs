﻿// Copyright 2013-2017 Dirk Lemstra <https://github.com/dlemstra/Magick.NET/>
//
// Licensed under the ImageMagick License (the "License"); you may not use this file except in
// compliance with the License. You may obtain a copy of the License at
//
//   https://www.imagemagick.org/script/license.php
//
// Unless required by applicable law or agreed to in writing, software distributed under the
// License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND,
// either express or implied. See the License for the specific language governing permissions
// and limitations under the License.

#if !NETCOREAPP1_1

using System;
using System.Drawing.Drawing2D;
using ImageMagick;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Magick.NET.Tests
{
    public partial class DrawableAffineTests
    {
        [TestMethod]
        public void Test_Constructor_Matrix()
        {
            Matrix matrix = null;

            ExceptionAssert.Throws<ArgumentNullException>(() =>
            {
                new DrawableAffine(matrix);
            });

            matrix = new Matrix(11, 12, 21, 22, 0, 1);
            DrawableAffine affine = new DrawableAffine(matrix);
            Assert.AreEqual(11, affine.ScaleX);
            Assert.AreEqual(12, affine.ScaleY);
            Assert.AreEqual(21, affine.ShearX);
            Assert.AreEqual(22, affine.ShearY);
            Assert.AreEqual(0, affine.TranslateX);
            Assert.AreEqual(1, affine.TranslateY);
        }
    }
}

#endif