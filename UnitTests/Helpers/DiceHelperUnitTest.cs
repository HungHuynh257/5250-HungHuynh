﻿using Mine.Helpers;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests.Helpers
{
    class DiceHelperUnitTest
    {
        [TestFixture]
    public class DiceHelperTests
        {
            [Test]
            public void RollDice_Invalid_Roll_Zero_Should_Return_Zero()
            {
                // Arrange

                // Act
                var result = DiceHelper.RollDice(0, 1);

                // Reset

                // Assert 
                Assert.AreEqual(0, result);
            }

            [Test]
            public void RollDice_Valid_Roll_1_Dice_6_Should_Return_Between_1_And_6()
            {
                // Arrange
                DiceHelper.ForceRollsToNotRandom = true;
                DiceHelper.ForcedRandomValue = 1;

                // Act
                var result = DiceHelper.RollDice(1, 6);

                // Reset
                DiceHelper.ForceRollsToNotRandom = false;

                // Assert 
                Assert.AreEqual(true, result >= 1);
                Assert.AreEqual(true, result <= 6);
            }

            
        }
    }
}
