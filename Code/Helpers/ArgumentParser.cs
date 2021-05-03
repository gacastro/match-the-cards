using System;
using System.Collections.Generic;

namespace Code.Helpers
{
    public class ArgumentParser
    {
        public MatchCondition MatchingCondition { get; private set; }
        public int NumberOfPacks { get; private set; }
        public IList<string> ErrorMessages { get; }

        private string _rawMatchingCondition;
        private string _rawNumberOfPacks;

        public ArgumentParser(IReadOnlyList<string> args)
        {
            ErrorMessages = new List<string>();

            if (args.Count == 0)
            {
                ErrorMessages.Add("No arguments have been passed in");
                return;
            }
            
            for (var index = 0; index < args.Count; index++)
            {
                switch (args[index])
                {
                    case "--n":
                    {
                        //index will be ready to jump into next pair of arguments
                        SetNumberOfPacksAndIndex(args, ref index);
                        break;
                    }
                    case "--c":
                    {
                        //index will be ready to jump into next pair of arguments
                        SetMatchingConditionAndIndex(args, ref index);
                        break;
                    }
                }
            }

            ValidateNumberOfPacks();
            ValidateMatchingCondition();
        }

        private void SetNumberOfPacksAndIndex(IReadOnlyList<string> args, ref int index)
        {
            var indexWithinRange = ++index < args.Count;
            if (indexWithinRange)
            {
                _rawNumberOfPacks = args[index];
            }
        }

        private void SetMatchingConditionAndIndex(IReadOnlyList<string> args, ref int index)
        {
            var indexWithinRange = ++index < args.Count;
            if (indexWithinRange)
            {
                _rawMatchingCondition = args[index];
            }
        }

        private void ValidateNumberOfPacks()
        {
            if (_rawNumberOfPacks == null)
            {
                ErrorMessages.Add("You need to specify the number of packs");
                return;
            }

            var isNumber = int.TryParse(_rawNumberOfPacks, out var number);
            if (isNumber && number > 0)
            {
                NumberOfPacks = number;
                return;
            }

            ErrorMessages.Add("You need to provide a valid number of packs");
        }

        private void ValidateMatchingCondition()
        {
            if (_rawMatchingCondition == null)
            {
                ErrorMessages.Add("You need to specify a matching condition");
                return;
            }

            var isMatchingCondition = Enum.TryParse(_rawMatchingCondition, out MatchCondition matchingCondition);
            if (isMatchingCondition)
            {
                MatchingCondition = matchingCondition;
                return;
            }
            
            ErrorMessages.Add("You need to provide a valid match condition");
        }
    }
}