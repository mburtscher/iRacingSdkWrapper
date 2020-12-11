﻿namespace OpenIRacingTools.Sdk.Native
{
    public class CVarHeader
    {
        public enum VarType { irChar, irBool, irInt, irBitField, irFloat, irDouble };

        public CVarHeader(int type, int offset, int count, string name, string desc, string unit)
        {
            Type = (VarType)type;
            Offset = offset;
            Count = count;
            Name = name;
            Desc = desc;
            Unit = unit;
        }

        public VarType Type { get; }

        public int Offset { get; }

        public int Count { get; }

        public string Name { get; }

        public string Desc { get; }

        public string Unit { get; }

        public int Bytes
        {
            get
            {
                if (Type == VarType.irChar || Type == VarType.irBool)
                {
                    return 1;
                }
                else if (Type == VarType.irInt || Type == VarType.irBitField || Type == VarType.irFloat)
                {
                    return 4;
                }
                else if (Type == VarType.irDouble)
                {
                    return 8;
                }

                return 0;
            }
        }

        public int Length => Bytes * Count;
    }
}
