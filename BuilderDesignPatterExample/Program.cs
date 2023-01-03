using BuilderDesignPatterExample.Controllers.DirectorControllers;
using BuilderDesignPatterExample.Controllers.InvoiceBuilderControlers;
using BuilderDesignPatterExample.Controllers.InvoiceDisplayerController;

var builder = new InvoiceBuilder();
var director = new Director(builder);

var monthlyInvoice = director.CreateMonthlyInvoice();
InvoiceDisplayer.Display(monthlyInvoice);