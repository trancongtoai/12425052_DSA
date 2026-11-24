using System;

namespace Bai2_Danhsach
{
    struct NhanVien
    {
        public string MaNV;
        public string HoTen;
        public int NamSinh;
        public string PhongBan;
        public int LuongCB;
        public int Thuong;
    }

    class Node
    {
        public int info;
        public Node link;

        public Node(int x)
        {
            info = x;
            link = null;
        }
    }

    class DanhSachLienKet
    {
        public Node pHead = null;

        public void ThemCuoi(int x)
        {
            Node p = new Node(x);
            if (pHead == null)
            {
                pHead = p;
            }
            else
            {
                Node q = pHead;
                while (q.link != null)
                {
                    q = q.link;
                }
                q.link = p;
            }
        }
    }

    class Program
    {
        static NhanVien[] DS;
        static Node pHead = null;
        static DanhSachLienKet l = new DanhSachLienKet();

        static void Bai1()
        {
            Console.Write("Nhập số phần tử n:");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhập phần tử a[{0}]:", i);
                a[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Danh sách vừa nhập:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();

            Console.Write("Nhập giá trị x cần chèn: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Nhập vị trí k cần chèn (0 <= k <= {0}): ", a.Length);
            int k = int.Parse(Console.ReadLine());

            int[] tmp = new int[a.Length + 1];
            for (int i = 0; i <= k - 1; i++)
            {
                tmp[i] = a[i];
            }
            tmp[k] = x;
            for (int i = k; i <= a.Length - 1; i++)
            {
                tmp[i + 1] = a[i];
            }
            a = tmp;

            Console.Write("Danh sách sau khi chèn: ");
            for (int i = 0; i <= a.Length - 1; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }

        static int thuclinh(int x)
        {
            return DS[x].LuongCB + DS[x].Thuong;
        }

        static void Bai2()
        {
            Console.Write("Nhập số lượng nhân viên: ");
            int n = int.Parse(Console.ReadLine());
            DS = new NhanVien[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhập thông tin nhân viên thứ {0}:", i + 1);
                Console.Write("Mã nhân viên: ");
                DS[i].MaNV = Console.ReadLine();
                Console.Write("Họ và tên: ");
                DS[i].HoTen = Console.ReadLine();
                Console.Write("Năm sinh: ");
                DS[i].NamSinh = int.Parse(Console.ReadLine());
                Console.Write("Phòng ban: ");
                DS[i].PhongBan = Console.ReadLine();
                Console.Write("Lương cơ bản: ");
                DS[i].LuongCB = int.Parse(Console.ReadLine());
                Console.Write("Thưởng: ");
                DS[i].Thuong = int.Parse(Console.ReadLine());
            }

            long tongThucLinh = 0;
            for (int i = 0; i < DS.Length; i++)
            {
                tongThucLinh += thuclinh(i);
            }
            Console.WriteLine("a. Tổng thực lĩnh tháng của tất cả nhân viên: " + tongThucLinh);

            int min = int.MaxValue;
            for (int i = 0; i < DS.Length; i++)
            {
                if (min > DS[i].LuongCB)
                {
                    min = DS[i].LuongCB;
                }
            }
            Console.WriteLine("b. Danh sách nhân viên có lương cơ bản thấp nhất ({0}):", min);
            for (int i = 0; i < DS.Length; i++)
            {
                if (DS[i].LuongCB == min)
                {
                    Console.WriteLine("{0} - {1} - {2} - Lương CB: {3}", DS[i].MaNV, DS[i].HoTen, DS[i].PhongBan, DS[i].LuongCB);
                }
            }

            int dem = 0;
            for (int i = 0; i < DS.Length; i++)
            {
                if (DS[i].Thuong >= 1200000)
                {
                    dem++;
                }
            }
            Console.WriteLine("c. Số lượng nhân viên có thưởng >= 1200000: " + dem);

            for (int i = 0; i < DS.Length - 1; i++)
            {
                for (int j = i + 1; j < DS.Length; j++)
                {
                    int ssPhong = string.Compare(DS[i].PhongBan, DS[j].PhongBan);
                    if (ssPhong > 0 || (ssPhong == 0 && string.Compare(DS[i].MaNV, DS[j].MaNV) < 0))
                    {
                        NhanVien tam = DS[i];
                        DS[i] = DS[j];
                        DS[j] = tam;
                    }
                }
            }
            Console.WriteLine("d. Danh sách nhân viên sau khi sắp xếp:");
            for (int i = 0; i < DS.Length; i++)
            {
                Console.WriteLine("{0} - {1} - Phòng: {2} - Thực lĩnh: {3}", DS[i].MaNV, DS[i].HoTen, DS[i].PhongBan, thuclinh(i));
            }

            Console.WriteLine("e. Danh sách nhân viên sau khi cập nhật tăng 5% lương:");
            for (int i = 0; i < DS.Length; i++)
            {
                DS[i].LuongCB = (int)(DS[i].LuongCB * 1.05);
                Console.WriteLine("{0} - {1} - Năm sinh: {2} - Phòng: {3} - Lương CB mới: {4} - Thưởng: {5}",
                    DS[i].MaNV, DS[i].HoTen, DS[i].NamSinh, DS[i].PhongBan, DS[i].LuongCB, DS[i].Thuong);
            }
        }

        static void Bai3()
        {
            Console.Write("Nhập cấp n của ma trận vuông (0 <= n < 100): ");
            int n = int.Parse(Console.ReadLine());
            int[,] a = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("a[{0},{1}] = ", i, j);
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int t = 0;
            for (int i = 0; i <= n - 1; i++)
            {
                for (int j = 0; j <= n - 1; j++)
                {
                    t = t + a[i, j];
                }
            }
            Console.WriteLine("a. Tổng tất cả các phần tử của ma trận: " + t);

            int min = int.MaxValue;
            for (int i = 0; i <= n - 1; i++)
            {
                for (int j = 0; j <= n - 1; j++)
                {
                    if (a[i, j] < min && a[i, j] > 0)
                    {
                        min = a[i, j];
                    }
                }
            }
            Console.WriteLine("b. Giá trị dương nhỏ nhất của ma trận: " + min);

            int tongCheoPhu = 0;
            for (int i = 0; i <= n - 1; i++)
            {
                for (int j = 0; j <= n - 1; j++)
                {
                    if (j == (n - 1) - i)
                    {
                        tongCheoPhu = tongCheoPhu + a[i, j];
                    }
                }
            }
            Console.WriteLine("c. Tổng các phần tử trên đường chéo phụ: " + tongCheoPhu);

            int[] tg = new int[n];
            for (int i = 0; i <= n - 1; i++)
            {
                tg[i] = a[i, i];
            }

            bool tangDan = true;
            for (int i = 0; i <= n - 2; i++)
            {
                for (int j = i + 1; j <= n - 1; j++)
                {
                    if (!(tg[i] < tg[j]))
                    {
                        tangDan = false;
                        break;
                    }
                }
                if (!tangDan) break;
            }
            Console.WriteLine("d. Đường chéo chính tăng dần: " + tangDan);
        }

        static void Bai4()
        {
            pHead = null;
            Console.Write("Nhập số lượng phần tử: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhập phần tử thứ {0}: ", i + 1);
                Node moi = new Node(int.Parse(Console.ReadLine()));
                if (pHead == null)
                {
                    pHead = moi;
                }
                else
                {
                    Node q = pHead;
                    while (q.link != null)
                    {
                        q = q.link;
                    }
                    q.link = moi;
                }
            }

            Console.Write("Nhập giá trị x: ");
            int x = int.Parse(Console.ReadLine());

            int d = 0;
            Node p = pHead;
            while (p != null)
            {
                if (p.info == x)
                {
                    d = d + 1;
                }
                p = p.link;
            }
            Console.WriteLine("a. Số phần tử bằng {0}: {1}", x, d);

            int minduong = int.MaxValue;
            p = pHead;
            while (p != null)
            {
                if (p.info > 0 && p.info < minduong)
                {
                    minduong = p.info;
                }
                p = p.link;
            }
            Console.WriteLine("b. Phần tử dương nhỏ nhất: " + minduong);

            p = pHead;
            Node t = null;
            while (p != null && p.info != x)
            {
                t = p;
                p = p.link;
            }
            if (p != null)
            {
                if (p == pHead)
                {
                    pHead = pHead.link;
                }
                else
                {
                    t.link = p.link;
                }
            }

            Console.Write("c. Danh sách sau khi xóa phần tử {0} đầu tiên: ", x);
            p = pHead;
            while (p != null)
            {
                Console.Write(p.info + " ");
                p = p.link;
            }
            Console.WriteLine();
        }

        static bool KTNT(int x)
        {
            if (x < 2) return false;
            for (int i = 2; i <= Math.Sqrt(x); i++)
            {
                if (x % i == 0) return false;
            }
            return true;
        }

        static void Bai5()
        {
            l = new DanhSachLienKet();
            Console.Write("Nhập số phần tử của danh sách l: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhập phần tử thứ {0}: ", i + 1);
                l.ThemCuoi(int.Parse(Console.ReadLine()));
            }

            int max = int.MinValue;
            Node p = l.pHead;
            while (p != null)
            {
                if (p.info > max)
                {
                    max = p.info;
                }
                p = p.link;
            }
            Console.WriteLine("a. Phần tử lớn nhất: " + max);

            int t = 0;
            p = l.pHead;
            while (p != null)
            {
                t = t + p.info;
                p = p.link;
            }
            Console.WriteLine("b. Tổng các phần tử: " + t);

            int demNT = 0;
            p = l.pHead;
            while (p != null)
            {
                if (KTNT(p.info) == true)
                {
                    demNT++;
                }
                p = p.link;
            }
            Console.WriteLine("c. Số lượng số nguyên tố: " + demNT);
            int demAm = 0, demDuong = 0, demKhong = 0;
            p = l.pHead;
            while (p != null)
            {
                if (p.info < 0) demAm++;
                else if (p.info > 0) demDuong++;
                else demKhong++;
                p = p.link;
            }
            Console.WriteLine("d. Số âm: {0}, Số dương: {1}, Số bằng 0: {2}", demAm, demDuong, demKhong);

            Console.Write("Nhập giá trị x cần đếm: ");
            int x = int.Parse(Console.ReadLine());
            int demX = 0;
            p = l.pHead;
            while (p != null)
            {
                if (p.info == x)
                {
                    demX++;
                }
                p = p.link;
            }
            Console.WriteLine("e. Số lượng phần tử bằng {0}: {1}", x, demX);

            int minduong = int.MaxValue;
            p = l.pHead;
            while (p != null)
            {
                if (p.info < minduong && p.info > 0)
                {
                    minduong = p.info;
                }
                p = p.link;
            }
            Console.WriteLine("f. Phần tử dương nhỏ nhất: " + minduong);
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("=== CHẠY BÀI 1 ===");
            Bai1();

            Console.WriteLine("\n=== CHẠY BÀI 2 ===");
            Bai2();

            Console.WriteLine("\n=== CHẠY BÀI 3 ===");
            Bai3();

            Console.WriteLine("\n=== CHẠY BÀI 4 ===");
            Bai4();

            Console.WriteLine("\n=== CHẠY BÀI 5 ===");
            Bai5();

            Console.WriteLine("\nĐã chạy xong cả 5 bài!");
            Console.ReadLine();
        }
    }
}
