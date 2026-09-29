using System;
using System.Collections.Generic;

namespace OOPLib;

// ============================================================
// Bai 2.2: lop PersonList quan ly nhieu Person
// ============================================================
public class PersonList
{
    private List<Person> danhSach;

    public int SoLuong => danhSach.Count;

    public PersonList()
    {
        danhSach = new List<Person>();
    }

    // Copy constructor: tao list moi, moi Person ben trong cung duoc copy
    // (khong chi copy tham chieu) nhờ dung Person(Person nguon) o Bai 1.3
    public PersonList(PersonList nguon)
    {
        danhSach = new List<Person>();
        foreach (Person p in nguon.danhSach)
            danhSach.Add(new Person(p));
    }

    public void Input(int soLuong)
    {
        danhSach = new List<Person>();
        for (int i = 0; i < soLuong; i++)
        {
            Console.WriteLine($"-- Nhap nguoi thu {i + 1} --");
            Person p = new Person();
            p.Input();
            danhSach.Add(p);
        }
    }

    public void Output()
    {
        foreach (Person p in danhSach)
            p.Output();
    }

    public void Add(Person x) => danhSach.Add(x);

    // Tra ve mot PersonList MOI chi chua nhung nguoi con song
    public PersonList LivingPeople()
    {
        PersonList ketQua = new PersonList();
        foreach (Person p in danhSach)
        {
            if (p.IsLiving())
                ketQua.Add(new Person(p));
        }
        return ketQua;
    }

    public Person this[int i]
    {
        get => danhSach[i];
        set => danhSach[i] = value;
    }
}
