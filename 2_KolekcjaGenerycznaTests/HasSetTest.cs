namespace _2_KolekcjaGenerycznaTests;

[TestClass]
public class HashSetest
{
    [TestMethod]
    public void IntersectSets()//wspolny set
    {
        var set1 =  new HashSet<int> { 1, 2, 3 };
        var set2 = new HashSet<int> { 2, 3, 4 };

        set1.IntersectWith(set2);
        Assert.IsTrue(set1.SetEquals(new[] {2,3}));
    }

    [TestMethod]
    public void UnionWithSets()//laczny set
    {
        var set1 = new HashSet<int> { 1, 2, 3 };
        var set2 = new HashSet<int> { 2, 3, 4 };

        set1.UnionWith(set2);
        Assert.IsTrue(set1.SetEquals(new[] { 1,2, 3,4 }));
    }

    [TestMethod]
    public void SymmetricExceptWith()//roznica setow
    {
        var set1 = new HashSet<int> { 1, 2, 3 };
        var set2 = new HashSet<int> { 2, 3, 4 };

        set1.SymmetricExceptWith(set2);
        Assert.IsTrue(set1.SetEquals(new[] { 1,4 }));
    }

    [TestMethod]
    public void RemoveSets()
    {
        var set1 = new HashSet<int> { 1, 2, 3 };
        var set2 = new HashSet<int> { 2, 3, 4 };

        set1.Remove(1);

        Assert.AreEqual(2, set1.Count());
    }

    [TestMethod]
    public void RemoveWhere()//usuwanie z warunkiem 
    {
        var set1 = new HashSet<int> { 1, 2, 3 };
        var set2 = new HashSet<int> { 2, 3, 4 };

        set1.RemoveWhere(x=> x>1);

        Assert.AreEqual(1, set1.Count());
    }

    [TestMethod]
    public void SetContains()
    {
        var set1 = new HashSet<int> { 1, 2, 3 };
        var set2 = new HashSet<int> { 2, 3, 4 };

        

        Assert.IsTrue(set1.Contains(3));
    }




}
