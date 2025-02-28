﻿using FluentAssertions;
using Machine.Specifications;

namespace Kata.Spec
{
    public class when_feeding_the_monkey
    {
        static Monkey _systemUnderTest;

        Establish context = () =>
            _systemUnderTest = new Monkey();

        Because of = () =>
            _systemUnderTest.Eat("banana");

        It should_have_the_food_in_its_belly = () =>
            _systemUnderTest.Belly.Should().Contain("banana");
    }

    public class when_user_input_is_empty
    {
        Establish _context = () => { _systemUnderTest = new Calculator(); };

        Because of = () => { _result = _systemUnderTest.Add(); };

        It should_return_zero = () => { _result.Should().Be(0); };
        static Calculator _systemUnderTest;
        static int _result;
    }
    
    public class when_user_input_is_one_number
    {
        Establish _context = () => { _systemUnderTest = new Calculator(); };

        Because of = () => { _result = _systemUnderTest.Add("3"); };

        It should_return_same_number = () => { _result.Should().Be(3); };
        static Calculator _systemUnderTest;
        static int _result;
    }

    public class when_user_input_is_two_numbers
    {
        Establish _context = () =>
        {
            _systemUnderTest = new Calculator();
        };

        Because of = () => { _result = _systemUnderTest.Add("1,3"); };

        It should_return_the_sum_of_both_numbers = () => { _result.Should().Be(4); };
        static Calculator _systemUnderTest;
        static int _result;
    }
    
    public class when_user_input_is_unknown_amount_of_numbers
    {
        Establish _context = () =>
        {
            _systemUnderTest = new Calculator();
        };

        Because of = () => { _result = _systemUnderTest.Add("1,3,4,5,3"); };

        It should_return_the_sum_of_all_numbers = () => { _result.Should().Be(16); };
        static Calculator _systemUnderTest;
        static int _result;
    }

    public class when_using_new_line_as_an_additional_delimiter
    {
        Establish _context = () =>
        {
            _systemUnderTest = new Calculator();
        };

        Because of = () => { _result = _systemUnderTest.Add("1,2\n3"); };

        It should_return_the_sum_of_the_numbers = () => { _result.Should().Be(6); };
        static Calculator _systemUnderTest;
        static int _result;
    }
    
    public class when_using_a_custom_single_character_delimiter
    {
        Establish _context = () =>
        {
            _systemUnderTest = new Calculator();
        };

        Because of = () => { _result = _systemUnderTest.Add("//;\n1;3"); };

        It should_return_the_sum_of_the_numbers = () => { _result.Should().Be(4); };
        static Calculator _systemUnderTest;
        static int _result;
    }
    
    //Given the user input is multiple numbers with a custom single-character delimiter when calculating the sum then it should return the sum of all the numbers. (example “//;\n1;2” should return 3)
    //Given the user input contains one negative number when calculating the sum then it should throw an exception "negatives not allowed: x" (where x is the negative number).
    //Given the user input contains multiple negative numbers mixed with positive numbers when calculating the sum then it should throw an exception "negatives not allowed: x, y, z" (where x, y, z are only the negative numbers).
    //Given the user input contains numbers larger than 1000 when calculating the sum it should only sum the numbers less than 1001. (example 2 + 1001 = 2)
    //Given the user input is multiple numbers with a custom multi-character delimiter when calculating the sum then it should return the sum of all the numbers. (example: “//[]\n12***3” should return 6)
    //Given the user input is multiple numbers with multiple custom delimiters when calculating the sum then it should return the sum of all the numbers. (example “//[][%]\n12%3” should return 6)
}