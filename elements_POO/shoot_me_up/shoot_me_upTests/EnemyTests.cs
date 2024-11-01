using Microsoft.VisualStudio.TestTools.UnitTesting;
using shoot_me_up;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoot_me_up.Tests
{
    [TestClass()]
    public class EnemyTests
    {
        [TestMethod()]
        public void EnemyTest()
        {
            //Assert.Fail();
        }

        [TestMethod()]
        public void ShootTest()
        {
            // Arrange
            // (Setup is done in the Setup method)

            // Act
            PictureBox missile = enemy.Shoot();

            // Assert
            Assert.IsNotNull(missile, "Missile should not be null after shooting.");
            Assert.AreEqual("missile", missile.Tag, "Missile tag should be 'missile'.");
            // Additional assertions can check missile position or other properties
        }

        [TestMethod()]
        public void HitTest()
        {
            // Arrange
            int initialHealth = enemy.Health; // Store the initial health

            // Act
            enemy.Hit();

            // Assert
            Assert.AreEqual(initialHealth - 1, enemy.Health, "Enemy health should decrease by 1 after being hit.");
            // Optionally check if the enemy is defeated if you have such logic
        }
    }
}