using BuilderDesignPatterExample.Controllers.InvoiceBuilderControlers;
using BuilderDesignPatterExample.Model;

namespace BuilderDesignPatterExample.Controllers.DirectorControllers;

public class Director
{
    private InvoiceBuilder _invoiceBuilder;

    public Director(InvoiceBuilder invoiceBuilder)
    {
        _invoiceBuilder = invoiceBuilder;
    }

    public Invoice CreateMonthlyInvoice()
    {
        var currentDate = DateTime.UtcNow;

        _invoiceBuilder.SetDate(new DateTime(currentDate.Year, currentDate.Month, 1));
        _invoiceBuilder.SetInvoiceNumber("A1");
        _invoiceBuilder.SetVendor("Brukbet");
        _invoiceBuilder.SetVendee("Thermapol");
        _invoiceBuilder.SetLineItems(new List<string>(){"lineItem1", "lineItem2"});
        var invoice = _invoiceBuilder.Build();
        return invoice;
    }

    public Invoice CreateBlankInvoice()
    {
        return new Invoice();
    }
}