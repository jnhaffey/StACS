using cmd = System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace StACS.System.Extensions.UnitTests.EnumTests
{
    public enum TestEnum
    {
        FirstElement,

        [cmd.Description("SecondElementDescription")]
        SecondElement,

        [Display(Name = "ThirdElementName")]
        ThirdElement
    }
}