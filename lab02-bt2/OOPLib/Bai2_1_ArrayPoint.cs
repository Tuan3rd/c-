using System;
using System.Collections;

namespace OOPLib;

// ============================================================
// Bai 2.1: lop ArrayPoint luu tru cac Point bang ArrayList + indexer
// (de bai yeu cau cu the la ArrayList, khong phai List<Point>)
// ============================================================
public class ArrayPoint
{
    private readonly ArrayList danhSach = new ArrayList();

    public int SoLuong => danhSach.Count;

    public void Add(Point p) => danhSach.Add(p);

    // Indexer: truy cap Point thu i. ArrayList luu object nen phai ep kieu lai Point.
    public Point this[int i]
    {
        get => (Point)danhSach[i];
        set => danhSach[i] = value;
    }
}
