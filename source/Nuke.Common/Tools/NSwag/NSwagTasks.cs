﻿// Copyright 2021 Maintainers of NUKE.
// Distributed under the MIT License.
// https://github.com/nuke-build/nuke/blob/master/LICENSE

using System;
using System.Linq;

namespace Nuke.Common.Tools.NSwag
{
    public static partial class NSwagTasks
    {
        internal static string GetToolPath()
        {
            Assert.Fail("Settings.NSwagRuntime must be defined to detect the proper nswag executable");
            return null;
        }

        public enum Runtime
        {
            NetCore10,
            NetCore11,
            NetCore20,
            NetCore21,
            Win
        }
    }
}
