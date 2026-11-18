namespace Week2_Prototype;

public class MedicalSupply
{
    public string SupplyName { get; }
    public int StockQuantity { get; private set; }
    public int MinimumThreshold { get; }

    public MedicalSupply(string supplyName, int initialStock, int minimumThreshold)
    {
        SupplyName = supplyName;
        StockQuantity = initialStock;
        MinimumThreshold = minimumThreshold;
    }

    public bool DispenseItem(int quantity)
    {
        if (quantity <= 0 || quantity > StockQuantity)
        {
            return false;
        }

        StockQuantity -= quantity;
        return true;
    }

    public void RestockItem(int quantity)
    {
        if (quantity > 0)
        {
            StockQuantity += quantity;
        }
    }

    public string GetStockLabel()
    {
        string status = StockQuantity <= MinimumThreshold ? "LOW STOCK" : "Adequate";
        return $"{SupplyName} - Available: {StockQuantity} units [{status}]";
    }
}