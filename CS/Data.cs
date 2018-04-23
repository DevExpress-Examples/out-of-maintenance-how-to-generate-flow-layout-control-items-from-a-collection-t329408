using System.Collections.Generic;
using System.IO;

namespace DXLayoutControlSample {
    public class DataSource {
        public List<Contact> Contacts { get; set; }
        public DataSource() {
            Contacts = new List<Contact>();
            Contacts.Add(new Contact {
                FirstName = "Carolyn",
                LastName = "Baker",
                Email = "carolyn.baker@example.com",
                Phone = "(555)349-3010",
                Address = "1198 Theresa Cir",
                City = "Whitinsville",
                State = "MA",
                Zip = "01582",
            });
            Contacts.Add(new Contact {
                FirstName = "Amber",
                LastName = "Seaman",
                Phone = "(555)698-4285",
                Address = "28700 S Main St",
                City = "Wilsonville",
                State = "AL",
                Zip = "35188",
            });
            Contacts.Add(new Contact {
                FirstName = "Annie",
                LastName = "Vicars",
                Email = "annie.vicars@example.com",
                Phone = "(555)922-1349",
                Address = "7267 New York Ave",
                City = "Jersey City",
                State = "NJ",
                Zip = "07306",
            });
            Contacts.Add(new Contact {
                FirstName = "Darlene",
                LastName = "Catto",
                Email = "darlene.catto@example.com",
                Phone = "(555)752-0582",
                Address = "32125 4th St NW #210",
                City = "Washington",
                State = "DC",
                Zip = "20001",
            });
            Contacts.Add(new Contact {
                FirstName = "Angela",
                LastName = "Gross",
                Email = "angela.gross@example.com",
                Phone = "(555)247-1252",
                Address = "8723 Chicago Ave",
                City = "Nederland",
                State = "TX",
                Zip = "77620",
            });
            Contacts.Add(new Contact {
                FirstName = "Edward",
                LastName = "Keck",
                Email = "edward.keck@example.com",
                Phone = "410-7042",
                Address = "38202 Greens Rd",
                City = "Humble",
                State = "TX",
                Zip = "77397",
            });
            Contacts.Add(new Contact {
                FirstName = "Angela",
                LastName = "Walker",
                Email = "angela.walker@example.com",
                Phone = "555",
                Address = "8913 Lakeshore Dr",
                City = "Jacksons Gap",
                State = "AL",
                Zip = "36863",
            });
            Contacts.Add(new Contact {
                FirstName = "Alice",
                LastName = "Martin",
                Email = "alice.martin@example.com",
                Phone = "(555)493-8440",
                Address = "652 Avonwick Gate",
                City = "Toronto",
                State = "ON",
                Zip = "33125",
            });
            Contacts.Add(new Contact {
                FirstName = "Andrew",
                LastName = "Carter",
                Email = "andrew.carter@example.com",
                Phone = "(555)578-3946",
                Address = "7121 Bailey St",
                City = "Worcester",
                State = "MA",
                Zip = "01605",
            });
            Contacts.Add(new Contact {
                FirstName = "George",
                LastName = "Morrison",
                Email = "george.morrison@example.com",
                Phone = "(555)468-3668",
                Address = "7716 Country Woods Cir",
                City = "Kissimmee",
                State = "FL",
                Zip = "34747",
            });
            InitializePhotos(Contacts);
        }
        void InitializePhotos(IList<Contact> contacts) {
            foreach (Contact contact in contacts)
                contact.Photo = GetPhoto(contact);
        }
        byte[] GetPhoto(string name) {
            return File.ReadAllBytes(@"Images\" + name);
        }
        byte[] GetPhoto(Contact contact) {
            return GetPhoto(contact.FirstName + contact.LastName + ".jpg");
        }
    }
    public class Contact {
        public string Name { get { return string.Format("{0} {1}", FirstName, LastName); } }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public byte[] Photo { get; set; }
    }
}