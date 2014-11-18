﻿using System;
using System.Collections.Generic;

namespace Typewriter.CodeModel
{
    public interface IItemInfo
    {
        string Name { get; }
        //string Namespace { get; }
        string FullName { get; }

        ICollection<IAttributeInfo> Attributes { get; }
    }
}