using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using NUnit.Framework;
using System.Linq;

namespace TrackAbout.Mobile.ContextSpecifications
{
	[DebuggerStepThrough]
    public static class NUnitExtensions
    {
        public static void ShouldBeEmpty<T>(this IEnumerable<T> enumerable)
        {
            Assert.That(enumerable.Any(), Is.False);
        }

        public static void ShouldStartWith(this string text, string expected)
        {
            Assert.That(text.StartsWith(expected));
        }

        public static void ShouldEndWith(this string text, string expected)
        {
            Assert.That(text.EndsWith(expected));
        }

        public static void ShouldBeTrue(this bool condition)
        {
            Assert.That(condition, Is.True);
        }

        public static void ShouldBeFalse(this bool condition)
        {
            Assert.That(condition, Is.False);
        }

		[DebuggerStepThrough]
        public static void ShouldEqual(this object actual, object expected)
        {
            Assert.That(actual, Is.EqualTo(expected));
        }

        public static void ShouldNotEqual(this object actual, object expected)
        {
            Assert.That(actual, Is.Not.EqualTo(expected));
        }

        public static void ShouldBeTheSameAs(this object actual, object expected)
        {
            Assert.That(actual, Is.SameAs(expected));
        }

        public static void ShouldNotBeTheSameAs(this object actual, object expected)
        {
            Assert.That(actual, Is.Not.SameAs(expected));
        }

        public static void ShouldContain(this ICollection actual, object expected)
        {
            Assert.Contains(expected, actual);
        }

        public static void ShouldContainItemOfType<T>(this IEnumerable enumerable)
        {
            foreach (var item in enumerable)
            {
                if (item.GetType().Equals(typeof (T)))
                {
                    return;
                }
            }

            Assert.Fail("Collection did not contain a item of type {0}", typeof (T));
        }

        public static void ShouldContain(this string actual, string expected)
        {
            Assert.That(actual.Contains(expected));
        }

        public static void ShouldContain<T>(this IEnumerable<T> actual, Func<T, bool> matchPredicate)
        {
            Assert.That(actual.Any(matchPredicate));
        }

        public static void ShouldContain<T>(this IEnumerable<T> actual, T expected)
        {
            CollectionAssert.Contains(actual, expected);
        }

        public static void ShouldNotContain<T>(this IEnumerable<T> actual, Func<T, bool> matchPredicate)
        {
            Assert.That(!actual.Any(matchPredicate));
        }

        public static void ShouldNotContain<T>(this IEnumerable<T> actual, T expected)
        {
            CollectionAssert.DoesNotContain(actual, expected);
        }

        public static void ShouldBeGreaterThan(this IComparable arg1, IComparable arg2)
        {
            Assert.That(arg1, Is.GreaterThan(arg2));
        }

        public static void ShouldBeGreaterThanOrEqualTo(this IComparable arg1, IComparable arg2)
        {
            Assert.That(arg1, Is.GreaterThanOrEqualTo(arg2));
        }

        public static void ShouldBeLessThan(this IComparable arg1, IComparable arg2)
        {
            Assert.That(arg1, Is.LessThan(arg2));
        }

        public static void ShouldBeLessThanOrEqualTo(this IComparable arg1, IComparable arg2)
        {
            Assert.That(arg1, Is.LessThanOrEqualTo(arg2));
        }

        public static void ShouldBeAssignableFrom(this object actual, Type expected)
        {
            Assert.That(actual, Is.AssignableFrom(expected));
        }

        public static void ShouldBeAssignableFrom<ExpectedType>(this Object actual)
        {
            actual.ShouldBeAssignableFrom(typeof (ExpectedType));
        }

        public static void ShouldNotBeAssignableFrom(this object actual, Type expected)
        {
            Assert.That(actual, Is.Not.AssignableFrom(expected));
        }

        public static void ShouldNotBeAssignableFrom<ExpectedType>(this object actual)
        {
            actual.ShouldNotBeAssignableFrom(typeof (ExpectedType));
        }

        public static void ShouldBeEmpty(this string value)
        {
            Assert.That(value, Is.Empty);
        }

        public static void ShouldNotBeEmpty(this string value)
        {
            Assert.That(value, Is.Not.Empty);
        }

        public static void ShouldBeEmpty(this ICollection collection)
        {
            Assert.That(collection, Is.Empty);
        }

        public static void ShouldNotBeEmpty(this ICollection collection)
        {
            Assert.That(collection, Is.Not.Empty);
        }

        public static void ShouldBeInstanceOfType(this object actual, Type expected)
        {
            Assert.That(actual, Is.InstanceOfType(expected));
        }

        public static void ShouldBeInstanceOf<ExpectedType>(this object actual)
        {
            actual.ShouldBeInstanceOfType(typeof (ExpectedType));
        }

        public static void ShouldNotBeInstanceOfType(this object actual, Type expected)
        {
            Assert.That(actual, Is.Not.InstanceOfType(expected));
        }

        public static void ShouldNotBeInstanceOf<ExpectedType>(this object actual)
        {
            actual.ShouldNotBeInstanceOfType(typeof (ExpectedType));
        }

        public static void ShouldBeNaN(this double value)
        {
            Assert.That(value, Is.NaN);
        }

        public static void ShouldBeNull(this object value)
        {
            Assert.That(value, Is.Null);
        }

        public static void ShouldNotBeNull(this object value)
        {
            Assert.That(value, Is.Not.Null);
        }

        public static void ShouldBeThrownBy(this Type exceptionType, Action action)
        {
            Exception e = null;

            try
            {
                action();
            }
            catch (Exception ex)
            {
                e = ex;
            }

            e.ShouldNotBeNull();
            e.ShouldBeInstanceOfType(exceptionType);
        }
    }
}