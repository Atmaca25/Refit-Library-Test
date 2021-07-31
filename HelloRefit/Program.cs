using HelloRefit.Abstract;
using HelloRefit.Concreate;
using HelloRefit.Entity;
using Refit;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HelloRefit
{
    class Program
    {
        static async Task Main(string[] args)
        {
            IFakerAPI fakerAPI = RestService.For<IFakerAPI>("https://fakerapi.it/api/v1");

            DataResponse<List<Person>> persons = await fakerAPI.GetFakePerson();
            foreach (var person in persons.Data)
            {
                Console.WriteLine($"First Name : {person.Firstname} \t Lastname : {person.LastName} \n");
            }

            int quantity = 5;
            DataResponse<List<Person>> personsWithQuantity = await fakerAPI.GetFakePersonWithQuantity(quantity);
            Console.WriteLine($"Quantity Parameter : {quantity} \t Response Data Count : {personsWithQuantity.Data.Count} \n");


            Console.ReadLine();
        }
    }
}
