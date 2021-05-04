public class SalesItem {
    private string id;
    private int quantity;
    public void SalesItem(string newId, int newQuantity) {
        id = newId;
        quantity = newQuantity;
    }

    public string getId() {
        return id;
    }
    public void setId(string newId) {
        id = newId;
    }

    public int getQuantity() {
        return quantity;
    }
    public void setQuantity(int newQuantity) {
        quantity = newQuantity;
    }
}
