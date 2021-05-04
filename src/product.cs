public class Product 
{
    private string id;
    private string name;
    private int cost;
    public void Product(string newId, string newName, int newCost) {
        id = newId;
        name = newName;
        cost = newCost;
    }

    public string getId() {
        return id;
    }
    public void setId(string newId) {
        id = newId;
    }

    public string getName() {
        return name;
    }
    public void setName(string newName) {
        name = newName;
    }

    public int getCost() {
        return cost;
    }
    public void setCost(int newCost) {
        cost = newCost;
    }
}
