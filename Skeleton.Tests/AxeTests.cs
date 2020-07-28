using NUnit.Framework;

[TestFixture]
public class AxeTests
{
    private Dummy target;

    [SetUp]
    public void Initialize()
    {
        this.target = new Dummy(5, 5);
    }

    [Test]
    public void AxeLosesDurabilyAfterAttack()
    {
        //Arrange
        Axe axe = new Axe(2, 2);
        //Act
        axe.Attack(target);
        //Assert
        Assert.That(axe.DurabilityPoints, Is.EqualTo(1));
    }
    [Test]
    public void BrokenAxeCantAttack()
    {
        //Arrange
        Axe axe = new Axe(555, 0);
        //Act
        Assert.That(() => axe.Attack(this.target), Throws
            .InvalidOperationException
            .With
            .Message.EqualTo("Axe is broken."));
    }
}