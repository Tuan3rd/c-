namespace WinForm05Logic;

// Bai 1 (BT ve nha): tu dien Anh - Viet va Viet - Anh.
public class TuDienLogic
{
    // Danh sach tu mau, dung chung cho ca 2 chieu tra cuu.
    private static readonly (string Anh, string Viet)[] DuLieuMau =
    {
        ("student", "Sinh viên, học sinh"),
        ("teacher", "Giáo viên"),
        ("worker", "Công nhân"),
        ("hat", "Cái mũ"),
        ("head", "Cái đầu"),
        ("mouse", "Con chuột"),
        ("cat", "Con mèo"),
        ("dog", "Con chó"),
        ("snake", "Con rắn"),
        ("lamb", "Con cừu non"),
        ("lion", "Con sư tử"),
        ("frog", "Con ếch"),
        ("sheep", "Con cừu")
    };

    private readonly Dictionary<string, string> _anhSangViet = new(StringComparer.OrdinalIgnoreCase);
    private readonly Dictionary<string, string> _vietSangAnh = new(StringComparer.OrdinalIgnoreCase);

    public TuDienLogic()
    {
        foreach (var (anh, viet) in DuLieuMau)
            ThemTu(anh, viet);
    }

    public IEnumerable<string> DanhSachTuAnh => _anhSangViet.Keys;

    public IEnumerable<string> DanhSachTuViet => _vietSangAnh.Keys;

    public void ThemTu(string anh, string viet)
    {
        _anhSangViet[anh] = viet;
        _vietSangAnh[viet] = anh;
    }

    public bool TraNghiaAnhViet(string tuAnh, out string nghia) => _anhSangViet.TryGetValue(tuAnh, out nghia!);

    public bool TraNghiaVietAnh(string tuViet, out string nghia) => _vietSangAnh.TryGetValue(tuViet, out nghia!);

    // Danh sach cac tu bat dau bang chuoi da go, dung cho autocomplete khi nguoi dung
    // go vao combobox - "do tim den chu nao khop voi ky tu gan nhat".
    public List<string> TimTuKhopGanNhat(string daGo, bool tiengAnh)
    {
        var nguon = tiengAnh ? _anhSangViet.Keys : _vietSangAnh.Keys;
        return nguon.Where(t => t.StartsWith(daGo, StringComparison.OrdinalIgnoreCase))
                    .OrderBy(t => t, StringComparer.OrdinalIgnoreCase)
                    .ToList();
    }
}
