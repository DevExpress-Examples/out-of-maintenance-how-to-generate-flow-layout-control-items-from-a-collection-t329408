Imports System.Collections.Generic
Imports System.IO

Namespace DXLayoutControlSample
	Public Class DataSource
		Public Property Contacts() As List(Of Contact)
		Public Sub New()
			Contacts = New List(Of Contact)()
			Contacts.Add(New Contact With {
				.FirstName = "Carolyn",
				.LastName = "Baker",
				.Email = "carolyn.baker@example.com",
				.Phone = "(555)349-3010",
				.Address = "1198 Theresa Cir",
				.City = "Whitinsville",
				.State = "MA",
				.Zip = "01582"
			})
			Contacts.Add(New Contact With {
				.FirstName = "Amber",
				.LastName = "Seaman",
				.Phone = "(555)698-4285",
				.Address = "28700 S Main St",
				.City = "Wilsonville",
				.State = "AL",
				.Zip = "35188"
			})
			Contacts.Add(New Contact With {
				.FirstName = "Annie",
				.LastName = "Vicars",
				.Email = "annie.vicars@example.com",
				.Phone = "(555)922-1349",
				.Address = "7267 New York Ave",
				.City = "Jersey City",
				.State = "NJ",
				.Zip = "07306"
			})
			Contacts.Add(New Contact With {
				.FirstName = "Darlene",
				.LastName = "Catto",
				.Email = "darlene.catto@example.com",
				.Phone = "(555)752-0582",
				.Address = "32125 4th St NW #210",
				.City = "Washington",
				.State = "DC",
				.Zip = "20001"
			})
			Contacts.Add(New Contact With {
				.FirstName = "Angela",
				.LastName = "Gross",
				.Email = "angela.gross@example.com",
				.Phone = "(555)247-1252",
				.Address = "8723 Chicago Ave",
				.City = "Nederland",
				.State = "TX",
				.Zip = "77620"
			})
			Contacts.Add(New Contact With {
				.FirstName = "Edward",
				.LastName = "Keck",
				.Email = "edward.keck@example.com",
				.Phone = "410-7042",
				.Address = "38202 Greens Rd",
				.City = "Humble",
				.State = "TX",
				.Zip = "77397"
			})
			Contacts.Add(New Contact With {
				.FirstName = "Angela",
				.LastName = "Walker",
				.Email = "angela.walker@example.com",
				.Phone = "555",
				.Address = "8913 Lakeshore Dr",
				.City = "Jacksons Gap",
				.State = "AL",
				.Zip = "36863"
			})
			Contacts.Add(New Contact With {
				.FirstName = "Alice",
				.LastName = "Martin",
				.Email = "alice.martin@example.com",
				.Phone = "(555)493-8440",
				.Address = "652 Avonwick Gate",
				.City = "Toronto",
				.State = "ON",
				.Zip = "33125"
			})
			Contacts.Add(New Contact With {
				.FirstName = "Andrew",
				.LastName = "Carter",
				.Email = "andrew.carter@example.com",
				.Phone = "(555)578-3946",
				.Address = "7121 Bailey St",
				.City = "Worcester",
				.State = "MA",
				.Zip = "01605"
			})
			Contacts.Add(New Contact With {
				.FirstName = "George",
				.LastName = "Morrison",
				.Email = "george.morrison@example.com",
				.Phone = "(555)468-3668",
				.Address = "7716 Country Woods Cir",
				.City = "Kissimmee",
				.State = "FL",
				.Zip = "34747"
			})
			InitializePhotos(Contacts)
		End Sub
		Private Sub InitializePhotos(ByVal contacts As IList(Of Contact))
			For Each contact As Contact In contacts
				contact.Photo = GetPhoto(contact)
			Next contact
		End Sub
		Private Function GetPhoto(ByVal name As String) As Byte()
			Return File.ReadAllBytes("Images\" & name)
		End Function
		Private Function GetPhoto(ByVal contact As Contact) As Byte()
			Return GetPhoto(contact.FirstName & contact.LastName & ".jpg")
		End Function
	End Class
	Public Class Contact
		Public ReadOnly Property Name() As String
			Get
				Return String.Format("{0} {1}", FirstName, LastName)
			End Get
		End Property
		Public Property FirstName() As String
		Public Property LastName() As String
		Public Property Email() As String
		Public Property Phone() As String
		Public Property Address() As String
		Public Property City() As String
		Public Property State() As String
		Public Property Zip() As String
		Public Property Photo() As Byte()
	End Class
End Namespace