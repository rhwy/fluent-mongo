﻿using System;
using System.Collections.Generic;

using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace FluentMongo.Linq
{
    public class Person
    {
        public ObjectId Id { get; set; }

        public Guid RefId { get; set; }

        [BsonElement("fn")]
        public string FirstName { get; set; }

        [BsonElement("ln")]
        public string LastName { get; set; }

        [BsonElement("age")]
        public int Age { get; set; }

        [BsonElement("add")]
        public Address PrimaryAddress { get; set; }

        [BsonElement("otherAdds")]
        public Address[] Addresses { get; set; }

        [BsonElement("emps")]
        public int[] EmployerIds { get; set; }

        public List<string> Hobbies { get; set; }

        public string MidName { get; set; }

        public ObjectId? LinkedId { get; set; }
    }

    public class Address
    {
        [BsonElement("city")]
        public string City { get; set; }

		public bool IsInternational { get; set; }

        public AddressType AddressType { get; set; }
    }

    public enum AddressType
    {
        Company,
        Private
    }

    public class PersonWrapper
    {
        public Person Person { get; set; }
        public string Name { get; set; }

        public PersonWrapper(Person person, string name)
        {
            Person = person;
            Name = name;
        }
    }
}
