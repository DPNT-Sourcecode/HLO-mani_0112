using BeFaster.Runner.Exceptions;

namespace BeFaster.App.Solutions.HLO
{
    public static class HelloSolution
    {
        public static string Hello(string friendName)
        {
            if friendName == "" then
                return "Hello, World!"
            end if
            return "Hello, " + friendName + "!"
        }
    }
}

