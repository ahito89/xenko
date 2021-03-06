﻿// Copyright (c) 2014 Silicon Studio Corp. (http://siliconstudio.co.jp)
// This file is distributed under GPL v3. See LICENSE.md for details.

using System;
using System.Collections.Generic;

using SiliconStudio.Core;
using SiliconStudio.Xenko.Shaders;

namespace SiliconStudio.Xenko.Rendering
{
    /// <summary>
    /// Keys used for lighting.
    /// </summary>
    [DataContract]
    public partial class LightingKeys : ShaderMixinParameters
    {
        public static readonly PermutationParameterKey<ShaderSourceCollection> DirectLightGroups = ParameterKeys.NewPermutation((ShaderSourceCollection)null);

        public static readonly PermutationParameterKey<ShaderSourceCollection> EnvironmentLights = ParameterKeys.NewPermutation((ShaderSourceCollection)null);
    }
}
