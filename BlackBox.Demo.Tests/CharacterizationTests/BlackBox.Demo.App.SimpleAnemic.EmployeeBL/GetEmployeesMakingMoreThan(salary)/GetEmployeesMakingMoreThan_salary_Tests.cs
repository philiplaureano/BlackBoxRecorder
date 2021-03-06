using System.Linq;
using BlackBox.Testing;
using Xunit;

namespace CharacterizationTests
{
	public partial class GetEmployeesMakingMoreThan_salary_Tests : CharacterizationTest
	{
		private System.Double salaryInput;
		private System.Double salaryOutput;

		private System.Collections.Generic.List<BlackBox.Demo.App.SimpleAnemic.EmployeeEntity> expected;
		private System.Collections.Generic.List<BlackBox.Demo.App.SimpleAnemic.EmployeeEntity> actual;
		private BlackBox.Demo.App.SimpleAnemic.EmployeeBL target;

		private void Run(string filename)
		{
			LoadRecording(filename);
			target = new BlackBox.Demo.App.SimpleAnemic.EmployeeBL();

			salaryInput = (System.Double)GetInputParameterValue("salary");
			salaryOutput = (System.Double)GetOutputParameterValue("salary");

			expected = (System.Collections.Generic.List<BlackBox.Demo.App.SimpleAnemic.EmployeeEntity>)GetReturnValue();
			actual = target.GetEmployeesMakingMoreThan(salaryInput);

			ConfigureComparison(filename);
			CompareObjects(salaryInput, salaryOutput);
			CompareObjects(expected, actual);
		}

		public GetEmployeesMakingMoreThan_salary_Tests()
		{
			Initialize();
		}

		protected override void ConfigureComparison(string filename)
		{
			//// Use the filename of the test to setup different
			//// comparison configurations for each test.
			//if(filename.EndsWith("GetEmployeesMakingMoreThan_salary.xml"))
			//{
			//    // Use IgnoreOnType to exclude a property from the comparison for all objects of that type.
			//    IgnoreOnType((BlackBox.Demo.App.SimpleAnemic.EmployeeEntity b) => b.Id);
			//
			//    // Use Ignore to exclude a property from the comparison for a specific instance.
			//    Ignore(expected.First(), (BlackBox.Demo.App.SimpleAnemic.EmployeeEntity b) => b.Id);
			//}
		}

		[Fact]
		public void GetEmployeesMakingMoreThan_salary()
		{
			Run(@"..\..\..\BlackBox.Demo.Tests\CharacterizationTests\BlackBox.Demo.App.SimpleAnemic.EmployeeBL\GetEmployeesMakingMoreThan(salary)\GetEmployeesMakingMoreThan_salary.xml");
		}

	}
}

