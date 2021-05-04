public class SalesItem {
    private string id;
    private string name;
    private int quantity;
    public void SalesItem(string newId, string newName, int newQuantity) {
        id = newId;
        name = newName;
        quantity = newQuantity;
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

    public int getQuantity() {
        return quantity;
    }
    public void setQuantity(int newQuantity) {
        quantity = newQuantity;
    }
}
