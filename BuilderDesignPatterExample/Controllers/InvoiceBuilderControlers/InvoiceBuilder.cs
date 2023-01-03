using BuilderDesignPatterExample.Model;

namespace BuilderDesignPatterExample.Controllers.InvoiceBuilderControlers;

public class InvoiceBuilder: IInvoiceBuilder
{
    private Invoice _invoice;
    
    public void SetVendor(string vendor)
    {
        _invoice.Vendor = vendor;
    }

    public void SetVendee(string vendee)
    {
        _invoice.Vendee = vendee;
    }

    public void SetNote(string note)
    {
        _invoice.Note = note;
    }

    public void SetLineItems(IEnumerable<string> items)
    {
        _invoice.LineItems = items;
    }

    public void SetInvoiceNumber(string number)
    {
        _invoice.Number = number;
    }

    public void SetDate(DateTime date)
    {
        _invoice.Date = date;
    }

    public Invoice Build()
    {
        return _invoice;
    }
}