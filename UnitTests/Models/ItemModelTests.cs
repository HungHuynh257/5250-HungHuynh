﻿using Mine.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests.Models
{
    class ItemModelTests
    {
        [Test]
        public void ItemModel_Constructor_Valid_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ItemModel();
            // Reset

            // Assert 
            Assert.IsNotNull(result);
        }

        [Test]
        public void ItemModel_Set_Get_Valid_Default_should_PAss()
        {
            //Arrange

            //Act
            var result = new ItemModel();
            result.Description = "Description";
            result.Id = "ID";
            result.Text = "Text";
            result.Value = 1;

            //reset
            //Assert
            Assert.AreEqual("Description", result.Description);
            Assert.AreEqual("ID", result.Id);
            Assert.AreEqual("Text", result.Text);
            Assert.AreEqual(1, result.Value);
        }

        [Test]
        public void ItemModel_Get_Valid_Default_Should_Pass()
        {
            //Arrange
            //Act
            var result = new ItemModel();

            //Rest

            //Assert
            Assert.AreEqual(0, result.Value);
        }
    }
}
