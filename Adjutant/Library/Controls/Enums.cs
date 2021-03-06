﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adjutant.Library.Controls
{
    public enum BitmapFormat : byte
    {
        TIF = 0,
        DDS = 1,
        RAW = 2,
        PNG = 3
    }

    public enum ModelFormat : byte
    {
        EMF = 0,
        OBJ = 1,
        AMF = 2,
        JMS = 3,
    }

    public enum SoundFormat : byte
    {
        WAV = 0,
        XMA = 1,
        RAW = 2
    }
}
