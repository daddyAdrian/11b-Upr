using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Skeleton;

namespace Skeleton.Tests
{
    [TestFixture]
    public class DummyTests
    {
        [Test]
        public void DummyLosesHPWhenAttacked()
        {
            Dummy dummy = new Dummy(10, 10);
            Axe axe = new Axe(2, 2);
            axe.Attack(dummy);
            Assert.AreEqual(8, dummy.Health);
        }
        [Test]
        public void DeadDummyThrowsAnExceptionWhenAttacked()
        {
            Axe axe = new Axe(2, 2);
            Dummy dummy = new Dummy(2, 2);
            axe.Attack(dummy);
            var ex = Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));
            Assert.That(ex.Message, Is.EqualTo("Dummy is dead."));
        }
        [Test]
        public void DeadDummyGivesXP()
        {
            Hero hero = new Hero("Hero");
            Dummy dummy = new Dummy(10, 10);
            hero.Attack(dummy);
            Assert.AreEqual(10, hero.Experience);
        }
        [Test]
        public void AliveDummyDoesNotGiveXP()
        {
            Axe axe = new Axe(5, 5);
            Dummy dummy = new Dummy(10, 10);
            axe.Attack(dummy);
            var ex = Assert.Throws<InvalidOperationException>(() => dummy.GiveExperience());
            Assert.That(ex.Message, Is.EqualTo("Target is not dead."));
        }
    }
}
