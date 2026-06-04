using System;

namespace OperatorsAssignment
{
    /// <summary>
    /// The Employee class represents an employee record with ID, first name, and last name.
    /// It also includes overloaded operators for comparing employees by their ID number.
    /// </summary>
    public class Employee
    {
        // Each employee has a unique ID number.
        public int Id { get; set; }

        // Employee's first name.
        public string FirstName { get; set; }

        // Employee's last name.
        public string LastName { get; set; }

        /// <summary>
        /// Overload the "==" operator to compare two Employee objects by their Id property.
        /// </summary>
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            // If both references are the same (or both null), they are equal.
            if (ReferenceEquals(emp1, emp2))
                return true;

            // If one of them is null, they are not equal.
            if (ReferenceEquals(emp1, null) || ReferenceEquals(emp2, null))
                return false;

            // Compare based on Id.
            return emp1.Id == emp2.Id;
        }

        /// <summary>
        /// Overload the "!=" operator (it must be defined whenever "==" is overloaded).
        /// </summary>
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return !(emp1 == emp2);
        }

        /// <summary>
        /// Override Equals() to ensure consistent behavior with the overloaded == operator.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (obj is not Employee other)
                return false;

            return this.Id == other.Id;
        }

        /// <summary>
        /// Override GetHashCode() to maintain consistency with Equals().
        /// </summary>
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        /// <summary>
        /// A helper method to display employee details as a string.
        /// </summary>
        public override string ToString()
        {
            return $"{FirstName} {LastName} (ID: {Id})";
        }
    }
}
