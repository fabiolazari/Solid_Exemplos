
namespace Solid_Exemplos
{
    public class Order_wrong_way
    {
        public void CalculateTotalSum() {/*...*/}
        public void GetItems() {/*...*/}
        public void GetItemCount() {/*...*/}
        public void AddItem(int item) {/*...*/}
        public void DeleteItem(int item) {/*...*/}

        public void PrintOrder() {/*...*/}
        public void ShowOrder() {/*...*/}

        public void Load() {/*...*/}
        public void Save() {/*...*/}
        public void Update() {/*...*/}
        public void Delete() {/*...*/}
    }

    //The right way, implementing the Single Responsible Principle
    public class Order
    {
        public void CalculateTotalSum() {/*...*/}
        public void GetItems() {/*...*/}
        public void GetItemCount() {/*...*/}
        public void AddItem(int item) {/*...*/}
        public void DeleteItem(int item) {/*...*/}
    }

    public class OrderRepository
    {
        public void Load(int orderID) {/*...*/}
        public void Save(Order order) {/*...*/}
        public void Update(Order order) {/*...*/}
        public void Delete(Order order) {/*...*/}
    }

    public class OrderViewer
    {
        public void PrintOrder(Order order) {/*...*/}
        public void ShowOrder(Order order) {/*...*/}
    }
}
