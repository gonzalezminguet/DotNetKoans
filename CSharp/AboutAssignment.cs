using System;
using System.Collections;
using System.Collections.Generic;
using Xunit;
using System.Linq;

using Assert = Xunit.KoanHelpers.KoanAssert;

namespace DotNetKoans.CSharp
{
    [Trait("Topic", "05 - About Assignment")]
    public class AboutAssignment : Koan
    {
        //Parallel Assignments are a feature in Ruby which allow one
        //to set multiple variables at once using an array syntax. e.g.
        //first_name, last_name = ["John", "Smith"]
        //which would set first_name == "John" and last_name == "Smith"
        //This isn't available in C#, but there are a few interesting assignment
        //tricks we can pick up.

        [Koan(1, DisplayName = "05.01 - ImplicitAssignment")]
        public void ImplicitAssignment()
        {
            //Even though we don't specify types explicitly, the compiler
            //will pick one for us
            var name = "John";

            Assert.Equal(typeof(FillMeIn), name.GetType());

            //but only if it can. So this doesn't work
            //var array = null;
            
            //It also knows the type, so once the above is in place, this doesn't work:
            //name = 42;
        }

        [Koan(2, DisplayName = "05.02 - ImplicitArrayAssignmentWithSameTypes")]
        public void ImplicitArrayAssignmentWithSameTypes()
        {
            //Even though we don't specify types explicitly, the compiler
            //will pick one for us
            var names = new[] { "John", "Smith" };

            Assert.Equal(typeof(FillMeIn), names.GetType());

            //but only if it can. So this doesn't work
            //var array = new[] { "John", 1 };
        }

        [Koan(3, DisplayName = "05.03 - MultipleAssignmentsOnSingleLine")]
        public void MultipleAssignmentsOnSingleLine()
        {
            //You can do multiple assignments on one line, but you 
            //still have to be explicit
            string firstName = "John", lastName = "Smith";

            Assert.Equal(FILL_ME_IN, firstName);
            Assert.Equal(FILL_ME_IN, lastName);
        }
    }
}