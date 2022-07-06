using DotNetNuke.Abstractions.Prompt;
using DotNetNuke.Prompt;

namespace DnnPromptTest
{
  [ConsoleCommand("hello-world", "My Commands", "This does a great job at greeting")]
  public class MyCommand : ConsoleCommand
  {
    public override string LocalResourceFile => "~/App_GlobalResources/Prompt.resx";

    public override IConsoleResultModel Run()
    {
      var res = new ConsoleResultModel()
      {
        IsError = false,
        IsHtml = false,
        Output = $"Hello World and {User.DisplayName}"
      };
      return res;
    }
  }
}
