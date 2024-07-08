namespace ContactBook;

public class Helper
{
  public static List<Contact> GetContacts () 
  {
    List<Contact> contacts = [];

    Contact contact = new Contact
    {
      FirstName = "John",
      LastName = "Doe",
      Email = "john.doe@email.com",
      IsFavorite = false
    };
    contacts.Add(contact);

    contact = new Contact 
    {
      FirstName = "Jane",
      LastName = "Doe",
      Email = "jane.doe@email.com",
      IsFavorite = true
    };
    contacts.Add(contact);

    contact = new Contact 
    {
      FirstName = "John",
      LastName = "Smith",
      Email = "john.smith@email.com",
      IsFavorite = false
    };
    contacts.Add(contact);

    return contacts;
  }
}
