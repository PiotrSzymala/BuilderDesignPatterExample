using BuilderDesignPatterExample.Controllers.DirectorControllers;
using BuilderDesignPatterExample.Controllers.InvoiceBuilderControlers;

var builder = new InvoiceBuilder();
var director = new Director(builder);

var monthlyInvoice = director.CreateMonthlyInvoice();

Console.WriteLine(monthlyInvoice.Date);