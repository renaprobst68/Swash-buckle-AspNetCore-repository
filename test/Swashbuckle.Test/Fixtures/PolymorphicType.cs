﻿using System;

namespace Swashbuckle.Test.Fixtures
{
    public abstract class PolymorphicType
    {
        public string BaseProperty { get; set; }
    }

    public class SubType : PolymorphicType
    {
        public int SubTypeProperty { get; set; }
    }
}