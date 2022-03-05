using Microsoft.AspNetCore.Mvc;


namespace Example_I.Controller
{ 
    [Route("products")] // This means with all /Products url will be callinf this ProductsController method
    public class ProductsController:ControllerBase
    {
        [Route("hello")] // Here we declare our Route in order to call our method https://localhost:7186/products/hello/
        public string Hello()
        {
            return "Hello Ahmet First Action";
        }

        [Route("hello2")] // This is for Hello2 Route https://localhost:7186/products/hello2/
        public string Hello2()
        {
            return "Hello Ahmet Second Action";
        }
    }
}
