using Microsoft.VisualStudio.TestTools.UnitTesting; // imports the MSTest framework
using Calendar; // imports calendar namespace

namespace Calendar.TestTools
{
  [TestClass] // tells MSTest that the following class contains tests to be run
  public class LeapYearTests
  {
    [TestMethod] // tells the compiler that the following code block is an individual test that MSTest will run
    public void IsLeapYear_NumberDivisibleByFour_True() // test method
    // naming convention: public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
    {
      // run tests in the calendar.tests directory
      // testing code would go here
      LeapYear testLeapYear = new LeapYear(); // create an instance of our LeapYear class with this line
      Assert.AreEqual(true, testLeapYear.IsLeapYear(2012));// are equal checks if 2 arguments provided are equal
    }
    [TestMethod]
    public void IsLeapYear_NumberNotDivisibleByFour_False()
    {
      LeapYear testLeapYear = new LeapYear();
      Assert.AreEqual(false, testLeapYear.IsLeapYear(1999));
    }
    [TestMethod]
    public void IsLeapYear_MultiplesOfOneHundred_False()
    {
      LeapYear testLeapYear = new LeapYear();
      Assert.AreEqual(false, testLeapYear.IsLeapYear(1900));
    }
    [TestMethod]
    public void IsLeapYear_MultiplesOfFourHundred_True()
    {
      LeapYear testLeapYear = new LeapYear();
      Assert.AreEqual(true, testLeapYear.IsLeapYear(2000));
    }
  }
}