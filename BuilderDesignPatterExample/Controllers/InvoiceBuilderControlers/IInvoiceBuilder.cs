using BuilderDesignPatterExample.Model;

namespace BuilderDesignPatterExample.Controllers.InvoiceBuilderControlers;

public interface IInvoiceBuilder
{
 public void SetVendor(string vendor);
 public void SetVendee(string vendee);
 public void SetNote(string notes);
 public void SetLineItems(IEnumerable<string> items);
 public void SetInvoiceNumber(string number);
 public void SetDate(DateTime date);
 public Invoice Build();
}