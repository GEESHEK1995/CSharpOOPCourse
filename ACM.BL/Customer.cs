﻿namespace ACM.BL
{
    public class Customer
    {
        public int CustomerId { get; private set; }
        
        public string EmailAddress { get; set; }
        
        public string FirstName { get; set; }

        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if (!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }

                    fullName += FirstName;
                }
                return fullName;
            }
        }

        public static int InstanceCount { get; set; }
        
        private string lastName;
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
    }
}