using Week2_Prototype;

var paracetamol = new MedicalSupply("Paracetamol 500mg Box", 50, 15);
var gauze = new MedicalSupply("Sterile Gauze Packs", 30, 10);

// 1. Valid action
Console.WriteLine(paracetamol.DispenseItem(40));

// 2. Rule rejection (requesting more than remaining 10 units)
Console.WriteLine(paracetamol.DispenseItem(25));

// 3. State check
Console.WriteLine(paracetamol.StockQuantity);

// 4. Second object works independently
Console.WriteLine(gauze.DispenseItem(5));

// Status check
Console.WriteLine(paracetamol.GetStockLabel());
Console.WriteLine(gauze.GetStockLabel());
