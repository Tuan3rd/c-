using System;

namespace OOPLib;

// ============================================================
// Bai 1.3: lop Person quan ly thong tin mot nguoi
// ============================================================
public class Person
{
    private int id;
    private string name;
    private int yob; // nam sinh
    private int yod; // nam mat, bang 0 nghia la con song

    public int Id { get => id; set => id = value; }
    public string Name { get => name; set => name = value; }
    public int Yob { get => yob; set => yob = value; }
    public int Yod { get => yod; set => yod = value; }

    public Person()
    {
        id = 0;
        name = "";
        yob = 0;
        yod = 0;
    }

    // Copy constructor: tao mot Person moi voi du lieu sao chep tu Person khac,
    // khong dung chung tham chieu (deep-copy cho kieu string la an toan vi string bat bien)
    public Person(Person nguon)
    {
        id = nguon.id;
        name = nguon.name;
        yob = nguon.yob;
        yod = nguon.yod;
    }

    public Person(int id, string name, int yob, int yod)
    {
        this.id = id;
        this.name = name;
        this.yob = yob;
        this.yod = yod;
    }

    public void Input()
    {
        Console.Write("Nhap id: ");
        id = int.Parse(Console.ReadLine());
        Console.Write("Nhap ten: ");
        name = Console.ReadLine();
        Console.Write("Nhap nam sinh: ");
        yob = int.Parse(Console.ReadLine());
        Console.Write("Nhap nam mat (0 neu con song): ");
        yod = int.Parse(Console.ReadLine());
    }

    public void Output()
    {
        Console.WriteLine($"ID: {id} - Ten: {name} - Nam sinh: {yob} - Nam mat: {(yod == 0 ? "con song" : yod.ToString())}");
    }

    // yod == 0 quy uoc la con song, khac 0 la da mat (theo dung de bai)
    public bool IsLiving()
    {
        return yod == 0;
    }
}
