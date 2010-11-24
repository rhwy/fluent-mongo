﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MongoDB.Bson.DefaultSerializer.Conventions;
using FluentMongo.Session.Conventions;
using MongoDB.Bson.DefaultSerializer;

namespace FluentMongo.Session.Configuration
{
    public static class BsonClassMapExtensions
    {
        public static BsonClassMap SetCollectionName(this BsonClassMap classMap, string collectionName)
        {
            classMap.SetExtension<ICollectionNameConvention>(new SpecifiedCollectionNameConvention(collectionName));
            return classMap;
        }
    }
}