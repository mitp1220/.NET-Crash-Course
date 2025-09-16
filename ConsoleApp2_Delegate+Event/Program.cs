// Create a c# coonsole application that uses Delegates and Events for a traffic monitoring system.
// 1) CLass TrafficSignal with fields location, vehicle_count.
// 2) Method UpdateVehicleCount() with input (int newCount), updates vehicle count.
// 3) Define Delegate + Event TrafficJamAlert.
// 4) Raise event if vehicle count greater than 100.
// 5) In Main() create a TrafficSignal object, subscribe to the event and display a warning message when triggered.

//using System;
//public delegate void TrafficJamAlert(string location, int count);
//public class TrafficSignal
//{
//    public string Location { get; set; }
//    public int Vehicle_Count { get; private set; }
//    public event TrafficJamAlert OnTrafficJam;
//    public TrafficSignal(string location)
//    { Location = location; }
//    public void UpdateVehicleCount(int newCount)
//    {
//        Vehicle_Count = newCount;
//        Console.WriteLine($"[{Location}] Vehicle count updated {Vehicle_Count}");
//        if (Vehicle_Count > 100)
//        {
//            OnTrafficJam?.Invoke(Location, Vehicle_Count);
//        }
//    }
//}
//class Program
//{
//    static void Main(string[] args)
//    {
//        TrafficSignal signal = new TrafficSignal("Karnavati Crossing");
//        signal.OnTrafficJam += (loc, count) =>
//        {
//            Console.WriteLine($"Alert! Traffic Jam at {loc} vehicles:{count}");
//        };
//        signal.UpdateVehicleCount(80);
//        signal.UpdateVehicleCount(100);
//        signal.UpdateVehicleCount(120);
//    }
//}

// create a c# console application that uses delegates and events for a weather monitoring system.
// 1) Class WeatherStation with fields city, temperature.
// 2) Method UpdateTemperature(int newTemp) updates temperature.
// 3) Define Delegate+Event HeatWaveAlert.
// 4) Raise the event if temperature greater than 40.
// 5) In Main(), create a weather station object, subscribe to the event and display a warning message when triggered.

// Create a c# console application that uses Delegates and Events for a Bank ATM monitoring system.
// 1) Class ATM with fields location, withdrawal amount.
// 2) Method Withdraw(int amount) uodates the withdrawal amount.
// 3) Define Delegate and Event LargeWithdrawalAlert.
// 4) Raise the event if withdrawal amount greater than 10000.
// 5) In Main(), create an ATM object, subscribe to the event and display a warning message when triggered.

using System;
public delegate void LargeWithdrawalAlert(string location, int amount);
public class ATM
{
    public string Location { get; set; }
    public int Amount { get; private set; }
    public event LargeWithdrawalAlert WithdrawalLimit;
    public ATM(string location)
    { Location = location; }
    public void Withdraw(int newAmount)
    {
        Amount = newAmount;
        Console.WriteLine($"[{Location}] Account Balance updated {Amount}");
        if (Amount > 10000)
        {
            WithdrawalLimit?.Invoke(Location, Amount);
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        ATM signal = new ATM("Naranpura");
        signal.WithdrawalLimit += (loc, amount) =>
        {
            Console.WriteLine($"Alert! Cannot exceed the withdrawal amount at {loc}, amount :{amount}");
        };
        signal.Withdraw(8000);
        signal.Withdraw(10000);
        signal.Withdraw(12000);
    }
}

// Create a c# console application that uses delegates and events for a warehouse stock monitoring system.
// 1) Class Warehouse with fields Item_Name, Stock_Level.
// 2) Method UpdateStock(int newStock), updates the stock level.
// 3) Define Delegates and Event LowStockAlert.
// 4) Raise Event if stock level less than 25.
// 5) In Main() create a warehouse object, subscribe to the event and display a warning message when triggered.