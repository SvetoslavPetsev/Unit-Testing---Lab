using NUnit.Framework;

[TestFixture]
public class DummyTests
{
    [Test]
    public void DummyLosesHealthAfterAttack()
    {
        //Arrange
        Dummy target = new Dummy(20, 5);
        //Act
        target.TakeAttack(10);
        //Assert
        Assert.That(target.Health, Is.EqualTo(10));
    }
    [Test]
    public void DeadDummyThrowsExceptionIfAttacked()
    {
        //Arrange
        Dummy target = new Dummy(-1, 5);

        //Assert
        Assert.That(() => target.TakeAttack(4), Throws
            .InvalidOperationException
            .With
            .Message.EqualTo("Dummy is dead."));
    }
    [Test]
    public void DeadDummyCanGiveXP()
    {
        //Arrange
        Dummy target = new Dummy(-5, 10);
        int exp = target.GiveExperience();
        //Assert
        Assert.That(exp, Is.EqualTo(10));
    }
    [Test]
    public void AliveDummyCanNotGiveXP()
    {
        //Arrange
        Dummy target = new Dummy(1, 5);

        //Assert
        Assert.That(() => target.GiveExperience(), Throws
            .InvalidOperationException
            .With
            .Message.EqualTo("Target is not dead."));
    }
}
