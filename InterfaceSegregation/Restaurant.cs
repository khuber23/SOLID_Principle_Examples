namespace InterfaceSegregation
{
    public class Restaurant
    {
        private Cook cook;
        private Waiter waiter;

        public Restaurant(Cook cook, Waiter waiter)
        {
            this.cook = cook;
            this.waiter = waiter;
        }

        public void OpenRestaurant()
        {
            this.cook.PunchIn();
            this.waiter.PunchIn();
            this.waiter.TakeOrder();
            this.cook.MakeFood();
            this.cook.PunchOut();
            this.waiter.PunchOut();
        }
    }
}