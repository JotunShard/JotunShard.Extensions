﻿using System;

namespace JotunShard.Extensions
{
    /// <summary>
    /// Definition of the days composing a week schedule
    /// </summary>
    [Flags]
    public enum WeeklyOccurrences : byte
    {
        None = 0x00,
        Sunday = 0x01,
        Monday = 0x02,
        Tuesday = 0x04,
        Wednesday = 0x08,
        Thursday = 0x10,
        Friday = 0x20,
        Saturday = 0x40,
    }
}