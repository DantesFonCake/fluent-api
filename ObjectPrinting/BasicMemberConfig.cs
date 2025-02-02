﻿using System;
using System.Reflection;

namespace ObjectPrinting
{
    public class BasicMemberConfig<TProperty, TOwner>
    {
        internal readonly PrintingConfig<TOwner> Container;
        protected readonly MemberInfo member;

        internal BasicMemberConfig(PrintingConfig<TOwner> container, MemberInfo member)
        {
            Container = container;
            this.member = member;
        }

        public void Exclude()
        {
            Container.Exclude(member);
        }

        public BasicMemberConfig<TProperty, TOwner> WithSerializer(Func<TProperty, string> serializer)
        {
            Container.WithSerializer(member, serializer);
            return this;
        }
    }
}