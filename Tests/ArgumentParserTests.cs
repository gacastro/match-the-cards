using System;
using Code;
using Code.Helpers;
using Xunit;

namespace Tests
{
    public class ArgumentParserTests
    {
        [Fact]
        public void Returns_Error_When_No_Arguments_Are_Passed()
        {
            var args = Array.Empty<string>();
            var argumentParser = new ArgumentParser(args);
            
            Assert.Single(argumentParser.ErrorMessages);
            Assert.Equal(
                "No arguments have been passed in",
                argumentParser.ErrorMessages[0]
            );
            Assert.Equal(MatchCondition.None, argumentParser.MatchingCondition);
            Assert.Equal(0, argumentParser.NumberOfPacks);
        }
        
        [Fact]
        public void Returns_Error_When_Wrong_Arguments_Are_Passed()
        {
            var args = new []{"string", "-n", "13312"};
            var argumentParser = new ArgumentParser(args);
            
            Assert.Equal(2, argumentParser.ErrorMessages.Count);
            Assert.Equal(
                "You need to specify the number of packs",
                argumentParser.ErrorMessages[0]
            );
            Assert.Equal(
                "You need to specify a matching condition",
                argumentParser.ErrorMessages[1]
            );
            Assert.Equal(MatchCondition.None, argumentParser.MatchingCondition);
            Assert.Equal(0, argumentParser.NumberOfPacks);
        }
        
        [Fact]
        public void Returns_Error_When_incomplete_Arguments_Are_Passed()
        {
            var args = new []{"--n", "1","--c"};
            var argumentParser = new ArgumentParser(args);
            
            Assert.Single(argumentParser.ErrorMessages);
            Assert.Equal(
                "You need to specify a matching condition",
                argumentParser.ErrorMessages[0]
            );
            Assert.Equal(MatchCondition.None, argumentParser.MatchingCondition);
            Assert.Equal(1, argumentParser.NumberOfPacks);
        }

        [Fact]
        public void returns_error_when_no_number_of_pack_is_passed()
        {
            var args = new[]{"--c", "2"};
            var argumentParser = new ArgumentParser(args);
            
            Assert.Single(argumentParser.ErrorMessages);
            Assert.Equal(
                "You need to specify the number of packs",
                argumentParser.ErrorMessages[0]
            );
            Assert.Equal(0, argumentParser.NumberOfPacks);
            Assert.Equal(MatchCondition.Value, argumentParser.MatchingCondition);
        }

        [Fact]
        public void returns_error_when_invalid_number_of_pack_is_passed()
        {
            var args = new[]{"--c", "2", "--n", "salkdfj"};
            var argumentParser = new ArgumentParser(args);
            
            Assert.Single(argumentParser.ErrorMessages);
            Assert.Equal(
                "You need to provide a valid number of packs",
                argumentParser.ErrorMessages[0]
            );
            Assert.Equal(0, argumentParser.NumberOfPacks);
            Assert.Equal(MatchCondition.Value, argumentParser.MatchingCondition);
        }

        [Fact]
        public void returns_error_when_no_matching_condition_is_passed()
        {
            var args = new[]{"--n", "1"};
            var argumentParser = new ArgumentParser(args);
            
            Assert.Single(argumentParser.ErrorMessages);
            Assert.Equal(
                "You need to specify a matching condition",
                argumentParser.ErrorMessages[0]
            );
            Assert.Equal(1, argumentParser.NumberOfPacks);
            Assert.Equal(MatchCondition.None, argumentParser.MatchingCondition);
        }

        [Fact]
        public void returns_error_when_invalid_matching_condition_is_passed()
        {
            var args = new[]{"--n", "1", "--c", "asdfa"};
            var argumentParser = new ArgumentParser(args);
            
            Assert.Single(argumentParser.ErrorMessages);
            Assert.Equal(
                "You need to provide a valid match condition",
                argumentParser.ErrorMessages[0]
            );
            Assert.Equal(1, argumentParser.NumberOfPacks);
            Assert.Equal(MatchCondition.None, argumentParser.MatchingCondition);
        }

        [Theory]
        [InlineData("--n,1,--c,2", 1, MatchCondition.Value)]
        [InlineData("--n,3,not supposed to be here,--c,3", 3, MatchCondition.SuitAndValue)]
        [InlineData("--c,2,--n,3", 3, MatchCondition.Value)]
        public void Returns_Arguments_Correctly(string inputArgs, int numberOfPacks, MatchCondition matchCondition)
        {
            var args = inputArgs.Split(',');
            var argumentParser = new ArgumentParser(args);
            
            Assert.Empty(argumentParser.ErrorMessages);
            Assert.Equal(numberOfPacks, argumentParser.NumberOfPacks);
            Assert.Equal(matchCondition, argumentParser.MatchingCondition);
        }
    }
}