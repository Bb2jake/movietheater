namespace movietheater {
    public interface IPurchasable: IMenuItem {
        float Cost { get; set; }
        int Inventory { get; set; }

        bool Purchase(int quantity);
    }
}