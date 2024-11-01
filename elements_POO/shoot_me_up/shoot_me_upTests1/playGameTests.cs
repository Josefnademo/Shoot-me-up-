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
    public class playGameTests
    {
        private playGame game;

        [TestInitialize]
        public void Setup()
        {
            // Initialize a new instance of playGame before each test
            game = new playGame();
        }

        [TestMethod]
        public void TestFireMissile_AddsMissileToControls()
        {
            // Arrange
            int initialMissileCount = game.Controls.OfType<PictureBox>().Count(m => m.Tag?.ToString() == "missile");

            // Act
            game.FireMissile();
            int newMissileCount = game.Controls.OfType<PictureBox>().Count(m => m.Tag?.ToString() == "missile");

            // Assert
            Assert.AreEqual(initialMissileCount + 1, newMissileCount, "A missile should be added when fired.");
        }

        [TestMethod]
        public void TestDisplayScore_SavesScoreToFile()
        {
            // Arrange
            string scoreFilePath = Path.Combine(Form1.scorePath, "score.txt");
            if (File.Exists(scoreFilePath))
            {
                File.Delete(scoreFilePath); // Ensure the file does not exist
            }
            game.Score = 100; // Set a score to test saving

            // Act
            game.DisplayScore();
            int savedScore = int.Parse(File.ReadAllText(scoreFilePath)); // Read the score from the file

            // Assert
            Assert.AreEqual(100, savedScore, "Score should be saved to the file after displaying.");
        }

        [TestMethod]
        public void TestHandleObstacleHit_RemovesObstacle()
        {
            // Arrange
            PictureBox obstacle = new PictureBox();
            obstacle.Tag = "obstacle"; // Set the tag for identification
            game.Controls.Add(obstacle); // Add the obstacle to the game controls

            // Act
            game.HandleObstacleHit(obstacle); // Simulate hitting the obstacle
            bool isObstacleRemoved = !game.Controls.Contains(obstacle); // Check if the obstacle was removed

            // Assert
            Assert.IsTrue(isObstacleRemoved, "The obstacle should be removed after being hit.");
        }

        [TestMethod()]
        public void playGameTest()
        {
            // Add a valid test scenario or remove this method if not needed.
            Assert.Fail("This test has not been implemented yet.");
        }

        [TestMethod()]
        public void RemovePictureBoxTest()
        {
            // Implement this test
            Assert.Fail("This test has not been implemented yet.");
        }

        [TestMethod()]
        public void CreateExplosionObstacleTest()
        {
            // Implement this test
            Assert.Fail("This test has not been implemented yet.");
        }

        [TestMethod()]
        public void CreateExplosionTest()
        {
            // Implement this test
            Assert.Fail("This test has not been implemented yet.");
        }

        [TestMethod()]
        public void pictureBox2_ClickTest()
        {
            // Implement this test
            Assert.Fail("This test has not been implemented yet.");
        }

        [TestMethod()]
        public void pictureBox7_ClickTest()
        {
            // Implement this test
            Assert.Fail("This test has not been implemented yet.");
        }

        [TestMethod()]
        public void pictureBox8_ClickTest()
        {
            // Implement this test
            Assert.Fail("This test has not been implemented yet.");
        }

        [TestMethod()]
        public void pictureBox9_ClickTest()
        {
            // Implement this test
            Assert.Fail("This test has not been implemented yet.");
        }
    }
}