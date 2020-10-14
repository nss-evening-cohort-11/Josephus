using System;
using Xunit;

namespace Josephus.Tests
{
    public class the_right_person_survives
    {
        //    [Fact]
        //    public void when_one_person_with_an_interval_of_one_then_the_only_person_should_survive()
        //    {
        //        //Arrange (Given, Context)
        //        var numberOfPeople = 1;
        //        var killingInterval = 1;
        //        var expectedResult = 1;

        //        var solver = new JosephusSolver();

        //        //Act (When)
        //        var solution = solver.Solve(numberOfPeople, killingInterval);

        //        //Assert (Then)
        //        Assert.Equal(expectedResult, solution);
        //    }

        //    [Fact]
        //    public void when_two_people_with_an_an_interval_of_one_then_the_second_person_survives()
        //    {
        //        //Arrange
        //        var numberOfPeople = 2;
        //        var killingInterval = 1;
        //        var expectedResult = 2;

        //        var solver = new JosephusSolver();

        //        //Act
        //        var solution = solver.Solve(numberOfPeople, killingInterval);

        //        //Assert
        //        Assert.Equal(expectedResult,solution);
        //    }

        //    [Fact]
        //    public void when_two_people_with_an_an_interval_of_two_then_the_first_person_survives()
        //    {
        //        //Arrange
        //        var numberOfPeople = 2;
        //        var killingInterval = 2;
        //        var expectedResult = 1;

        //        var solver = new JosephusSolver();

        //        //Act
        //        var solution = solver.Solve(numberOfPeople, killingInterval);

        //        //Assert
        //        Assert.Equal(expectedResult,solution);
        //    }


        //    [Fact]
        //    public void when_seven_people_with_an_an_interval_of_two_then_the_seventh_person_survives()
        //    {
        //        //Arrange
        //        var numberOfPeople = 7;
        //        var killingInterval = 2;
        //        var expectedResult = 7;

        //        var solver = new JosephusSolver();

        //        //Act
        //        var solution = solver.Solve(numberOfPeople, killingInterval);

        //        //Assert
        //        Assert.Equal(expectedResult,solution);
        //    }



        //    [Fact]
        //    public void when_137_people_with_an_an_interval_of_two_then_the_19th_person_survives()
        //    {
        //        //Arrange
        //        var numberOfPeople = 137;
        //        var killingInterval = 2;
        //        var expectedResult = 19;

        //        var solver = new JosephusSolver();

        //        //Act
        //        var solution = solver.Solve(numberOfPeople, killingInterval);

        //        //Assert
        //        Assert.Equal(expectedResult,solution);
        //    }


        [Theory]
        [InlineData(137,2,19)]
        [InlineData(1,1,1)]
        [InlineData(2,1,2)]
        [InlineData(7,2,7)]
        public void given_a_killing_number_and_a_number_of_people_the_correct_solution_is_returned(int numberOfPeople, int killingInterval, int expectedResult)
        {   
            //arrange
            var solver = new JosephusSolver();
            
            //Act
            var solution = solver.Solve(numberOfPeople, killingInterval);
            
            //Assert
            Assert.Equal(expectedResult,solution);
        }

    }
}
