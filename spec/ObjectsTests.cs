using JotunShard.Extensions.Test.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace JotunShard.Extensions.Test
{
    using static Assert;

    [TestClass]
    public class ObjectsTests
    {
        #region Constants

        private static readonly object
            NULL = null,
            NOT_NULL = new object(),
            INSTANCE = new MultiItems()
            {
                ID = 42,
                Items = new MultiItems[]
                {
                    new MultiItems()
                    {
                        ID = 33,
                    },
                    new MultiItems()
                    {
                        ID = 85,
                    }
                }
            },
            DUPLICATE = new MultiItems()
            {
                ID = 42,
                Items = new MultiItems[]
                {
                    new MultiItems()
                    {
                        ID = 33,
                    },
                    new MultiItems()
                    {
                        ID = 85,
                    }
                }
            };

        #endregion Constants

        #region EqualsOrNull

        [TestMethod]
        public void EqualsOrNull_WithNullSourceAndNullTarget_ExpectsTrue()
            => IsTrue(NULL.EqualsOrNull(NULL));

        [TestMethod]
        public void EqualsOrNull_WithNotNullSourceAndNullTarget_ExpectsFalse()
            => IsFalse(NOT_NULL.EqualsOrNull(NULL));

        [TestMethod]
        public void EqualsOrNull_WithNullSourceAndNotNullTarget_ExpectsFalse()
            => IsFalse(NULL.EqualsOrNull(NOT_NULL));

        [TestMethod]
        public void EqualsOrNull_WithInstanceSourceAndDuplicateTarget_ExpectsTrue()
            => IsTrue(INSTANCE.EqualsOrNull(DUPLICATE));

        #endregion EqualsOrNull
    }
}