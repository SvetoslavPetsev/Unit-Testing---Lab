using NUnit.Framework;
using Skeleton.Tests;

[TestFixture]
public class HeroTests
{
    [Test]
    public void HeroGainsExperienceAfterAttackIfTargetDies()
    {
        ITarget fakeTarget = new FakeTarget();

        IWeapon fakeWeapon = new FakeWeapon();

        Hero hero = new Hero("Pesho", fakeWeapon);

        hero.Attack(fakeTarget);

        Assert.That(hero.Experience, Is.EqualTo(20),"Hero does not gain XP");
    }
}