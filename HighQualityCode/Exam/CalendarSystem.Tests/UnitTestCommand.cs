using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace CalendarSystem.Tests
{
    [TestClass]
    public class UnitTestCommand
    {
        [TestMethod]
        public void TestMethodParseCommandThreeParameters()
        {
            string input = "Add 2012-01-21T20:00:00 | party Viki | home";
            Command parsedCommand = Command.Parse(input);

            Assert.AreEqual(3, parsedCommand.Parameters.Count());
        }

        [TestMethod]
        public void TestMethodParseCommandTwoParameters()
        {
            string input = "Add 2012-01-21T20:00:00 | party Viki";
            Command parsedCommand = Command.Parse(input);

            Assert.AreEqual(2, parsedCommand.Parameters.Count());
        }

        [TestMethod]
        public void TestMethodParseCommandInvalidParameters()
        {
            string input = "Add 2012-01-21T20:00:00 | party Viki | home | durabura";
            Command parsedCommand = Command.Parse(input);

            Assert.AreEqual(4, parsedCommand.Parameters.Count());
        }

        [TestMethod]
        public void TestMethodParseCommandInvalidCommandName()
        {
            string input = "Add 2012-01-21T20:00:00 | party Viki | home";
            Command parsedCommand = Command.Parse(input);
            string commandName = "Invalid command";
            if (parsedCommand.CommandName != "AddEvent" && parsedCommand.CommandName != "DeleteEvents" && 
                parsedCommand.CommandName != "ListEvents")
            {
                parsedCommand.CommandName = "Invalid command";
            }

            Assert.AreEqual(commandName, parsedCommand.CommandName);
        }

        [TestMethod]
        public void TestMethodParseCommandAddEvent()
        {
            string input = "AddEvent 2012-01-21T20:00:00 | party Viki | home";
            Command parsedCommand = Command.Parse(input);
            Command expectedParsedCommand = new Command 
            { 
                CommandName = "AddEvent",
                Parameters = new string[] { "2012-01-21T20:00:00", "party Viki", "home" } 
            };

            Assert.AreEqual(expectedParsedCommand.CommandName, parsedCommand.CommandName);
            for (int i = 0; i < parsedCommand.Parameters.Length; i++)
            {
                Assert.AreEqual(expectedParsedCommand.Parameters[i],parsedCommand.Parameters[i]);
            }
        }

        [TestMethod]
        public void TestMethodParseCommandDeleteSingleEvent()
        {
            string input = "DeleteEvents 2012-01-21T20:00:00 | party Viki | home";
            Command parsedCommand = Command.Parse(input);
            Command expectedParsedCommand = new Command
            {
                CommandName = "DeleteEvents",
                Parameters = new string[] { "2012-01-21T20:00:00", "party Viki", "home" }
            };

            Assert.AreEqual(expectedParsedCommand.CommandName, parsedCommand.CommandName);
            for (int i = 0; i < parsedCommand.Parameters.Length; i++)
            {
                Assert.AreEqual(expectedParsedCommand.Parameters[i], parsedCommand.Parameters[i]);
            }
        }

        [TestMethod]
        public void TestMethodParseCommandDeleteMultipleEvents()
        {
            for (int i = 0; i < 100; i++)
            {
                string input = "DeleteEvents 201"+ i +"-01-21T20:00:00 | party Viki | home";
                Command parsedCommand = Command.Parse(input);
                Command expectedParsedCommand = new Command
                {
                    CommandName = "DeleteEvents",
                    Parameters = new string[] { "201" + i + "-01-21T20:00:00", "party Viki", "home" }
                };

                Assert.AreEqual(expectedParsedCommand.CommandName, parsedCommand.CommandName);
                for (int j = 0; j < parsedCommand.Parameters.Length; j++)
                {
                    Assert.AreEqual(expectedParsedCommand.Parameters[j], parsedCommand.Parameters[j]);
                }
            }
        }

        [TestMethod]
        public void TestMethodParseCommandListSingleEvent()
        {
            string input = "ListEvents 2012-01-21T20:00:00 | party Viki | home";
            Command parsedCommand = Command.Parse(input);
            Command expectedParsedCommand = new Command
            {
                CommandName = "ListEvents",
                Parameters = new string[] { "2012-01-21T20:00:00", "party Viki", "home" }
            };

            Assert.AreEqual(expectedParsedCommand.CommandName, parsedCommand.CommandName);
            for (int i = 0; i < parsedCommand.Parameters.Length; i++)
            {
                Assert.AreEqual(expectedParsedCommand.Parameters[i], parsedCommand.Parameters[i]);
            }
        }

        [TestMethod]
        public void TestMethodParseCommandListMultipleEvents()
        {
            for (int i = 0; i < 100; i++)
            {
                string input = "ListEvents 201" + i + "-01-21T20:00:00 | party Viki | home";
                Command parsedCommand = Command.Parse(input);
                Command expectedParsedCommand = new Command
                {
                    CommandName = "ListEvents",
                    Parameters = new string[] { "201" + i + "-01-21T20:00:00", "party Viki", "home" }
                };

                Assert.AreEqual(expectedParsedCommand.CommandName, parsedCommand.CommandName);
                for (int j = 0; j < parsedCommand.Parameters.Length; j++)
                {
                    Assert.AreEqual(expectedParsedCommand.Parameters[j], parsedCommand.Parameters[j]);
                }
            }
        }
    }
}
