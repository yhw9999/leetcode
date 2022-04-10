public class Solution
{
    public string Interpret(string command)
    {
        var result = new StringBuilder();
        var commandCount = 1;

        for (int i = 0; i < command.Length; i++)
        {
            switch (command[i])
            {
                case '(':

                    while (command[i] != ')')
                    {
                        commandCount++;
                        i++;
                    }

                    switch (commandCount)
                    {
                        case 2:
                            result.Append('o');
                            break;
                        case 4:
                            result.Append("al");
                        break;
                    }

                    commandCount = 1;

                    break;
                default:
                    result.Append(command[i]);
                    break;
            }
        }

        return result.ToString();
    }
}