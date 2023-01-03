using System.Collections;
using BuilderDesignPatterExample.Model;

namespace BuilderDesignPatterExample.Controllers.InvoiceDisplayerController;

public class InvoiceDisplayer
{
    public static void Display(Invoice invoice)
    {
        var type = invoice.GetType();
        var properties =  type.GetProperties();

        foreach (var property in properties)
        {
            var propValue = property.GetValue(invoice);

            if (propValue != null)
            {
                var propType = propValue.GetType();

                if (propType.IsPrimitive || propType == typeof(string) || propType == typeof(DateTime) )
                {
                    Console.WriteLine($"{property.Name}: {propValue}");
                }
                else if (propValue is IEnumerable)
                {
                    Console.WriteLine($"{property.Name}: ");
                    foreach (var listItem in propValue as IEnumerable)
                    {
                        Console.WriteLine($"  {listItem.ToString()}");
                    }
                }
            } 
           
        }
    }
}