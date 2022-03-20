using System; 

public class Applicant {
    private string surname;
    private string name;
    private string patronymic;
    private string marks;
    public string address;
    public string getSurname() {
        return this.surname;
    }

    public void setSurname(string Surname) {
        this.surname = Surname;
    }

    public void showSurname() {
        Console.Write("{0}", getSurname());
    }

    public string getName() {
        return this.name;
    }

    public void setName(string Name) {
        this.name = Name;
    }

    public void showName() {
        Console.Write("{0}", getName());
    }

    public string getPatronymic() {
        return this.patronymic;
    }

    public void setPatronymic(string Patronymic) {
        this.patronymic = Patronymic;
    }

    public void showPatronymic() {
        Console.Write("{0}", getPatronymic());
    }

    public string getAddress() {
        return this.address;
    }

    public void setAddress(string Address) {
        this.address = Address;
    }

    public void showAddress() {
        Console.Write("{0}", getAddress());
    }

    public string getMarks() {
        return this.marks;
    }

    public void setMarks(string Marks) {
        this.marks = Marks;
    }

    public void showMarks() {
        Console.Write("{0}", getMarks());
    }

    public Applicant(string Surname = "LALALA", string Name = "TALALA", string Patron = "KEKW", string Address = "OMEGALUL", string Marks = "5445354") {
        setSurname(Surname);
        setName(Name);
        setPatronymic(Patron);
        setAddress(Address);
        setMarks(Marks);
    }
}

public class Program {
  public static void Main() {
      Appplicant test = new Appplicant();

      Console.Write(test.getSurname());
  }

  
}

