//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add UnitDefinitions\MyQuantity.json and run generate-code.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using UnitsNet.NumberExtensions.NumberToFrequency;
using Xunit;

namespace UnitsNet.Tests
{
    public class NumberToFrequencyExtensionsTests
    {
        [Fact]
        public void NumberToBeatsPerMinuteTest() =>
            Assert.Equal(Frequency.FromBeatsPerMinute(2), 2.BeatsPerMinute());

        [Fact]
        public void NumberToBUnitsTest() =>
            Assert.Equal(Frequency.FromBUnits(2), 2.BUnits());

        [Fact]
        public void NumberToCyclesPerHourTest() =>
            Assert.Equal(Frequency.FromCyclesPerHour(2), 2.CyclesPerHour());

        [Fact]
        public void NumberToCyclesPerMinuteTest() =>
            Assert.Equal(Frequency.FromCyclesPerMinute(2), 2.CyclesPerMinute());

        [Fact]
        public void NumberToGigahertzTest() =>
            Assert.Equal(Frequency.FromGigahertz(2), 2.Gigahertz());

        [Fact]
        public void NumberToHertzTest() =>
            Assert.Equal(Frequency.FromHertz(2), 2.Hertz());

        [Fact]
        public void NumberToKilohertzTest() =>
            Assert.Equal(Frequency.FromKilohertz(2), 2.Kilohertz());

        [Fact]
        public void NumberToMegahertzTest() =>
            Assert.Equal(Frequency.FromMegahertz(2), 2.Megahertz());

        [Fact]
        public void NumberToMicrohertzTest() =>
            Assert.Equal(Frequency.FromMicrohertz(2), 2.Microhertz());

        [Fact]
        public void NumberToMillihertzTest() =>
            Assert.Equal(Frequency.FromMillihertz(2), 2.Millihertz());

        [Fact]
        public void NumberToPerSecondTest() =>
            Assert.Equal(Frequency.FromPerSecond(2), 2.PerSecond());

        [Fact]
        public void NumberToRadiansPerSecondTest() =>
            Assert.Equal(Frequency.FromRadiansPerSecond(2), 2.RadiansPerSecond());

        [Fact]
        public void NumberToTerahertzTest() =>
            Assert.Equal(Frequency.FromTerahertz(2), 2.Terahertz());

    }
}
