using System;

    class Person
    {
        private string email;
        private string name;
        private int age;

        public Person(string name, int age, string email)
            : this(name, age)
        {
            this.Name = name;
            this.Age = age;
            this.Email = email;
        }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;

        }

        public string Name
        {
            get { return this.name; }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty!");
                }
                this.name = value;
            }
        }

        public int Age
        {
            get { return this.age; }

            set
            {
                if (value < 1 || value > 100)
                {
                    throw new ArgumentException("Please enter a valid age!");
                }
                this.age = value;
            }
        }

        public string Email
        {
            get
            {
                return this.email;
            }
            set
            {
                if (value == string.Empty || !value.Contains("@"))
                {
                    throw new ArgumentException("Invalid email!");
                }
                this.email = value;
            }
        }

        public override string ToString()
        {
            return string.Format("Name = {0}, Age = {1}, Email = {2}", this.Name, this.Age, this.Email ?? "No email");
        }
    }

