using dars3.Models;

namespace dars3.Servises;

public class PhoneService
{
    List<Phone> Phones;
    public PhoneService()
    {
        Phones = new List<Phone>();
    }
    public Guid AddPhone(Phone phone)
    {
        phone.PhoneId = Guid.NewGuid();
        Phones.Add(phone);
        return phone.PhoneId;
    }
    public List<Phone> GetAllPhones()
    {
        return Phones;
    }
    public bool DeletePhone(Guid phoneId)
    {
        foreach (var phone in Phones)
        {
            if (phone.PhoneId == phoneId)
            {
                Phones.Remove(phone);
                return true;
            }
        }
        return false;
    }
    public Phone? GetPhoneById(Guid phoneId)
    {
        foreach (var phone in Phones)
        {
            if (phone.PhoneId == phoneId)
            {
                return phone;
            }
        }
        return null;
    }
    public bool UpdatePhone(Guid phoneId, Phone NewPhone)
    {
        for (int i = 0; i < Phones.Count; i++)
        {
            if (Phones[i].PhoneId == phoneId)
            {
                Phones[i].Model = NewPhone.Model;
                Phones[i].Brand = NewPhone.Brand;
                Phones[i].Color = NewPhone.Color;
                Phones[i].Price = NewPhone.Price;
                return true;
            }
        }
        return false;
    }
}
