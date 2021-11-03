using System;
using System.Collections.Generic;
using System.Text;

namespace Sample.Domain.SeedWork
{
    public class Entity
    {
        public int Id { get; private set; }

        public Entity(int id)
        {
            Id = id;
        }

        protected static void CheckRule(IBusinessRule rule)
        {
            if (rule.IsBroken())
            {
                throw new BusinessRuleValidationException(rule);
            }
        }
    }
}
