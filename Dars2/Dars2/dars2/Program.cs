namespace dars2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int son = 47;
            int birlar = son % 10;

            Console.WriteLine(birlar);

           
            Console.Write("Uch xonali son kiriting: ");
            int soni = int.Parse(Console.ReadLine());

            int onlar = (soni / 10) % 10;

            Console.WriteLine("O'nlar xonasidagi raqam: " + onlar);


            int n = int.Parse(Console.ReadLine());

            int yuzlar = n / 100;
            Console.WriteLine(yuzlar);


            int f = int.Parse(Console.ReadLine());

            int minglar = (n / 1000) % 10;
            Console.WriteLine(minglar);


            int g = int.Parse(Console.ReadLine());
            int yuzlari = (n / 100) % 10;
            Console.WriteLine(yuzlari);


            int ni = int.Parse(Console.ReadLine());

            int a = ni / 100;
            int b = (ni / 10) % 10;
            int c = ni % 10;

            int sum = a + b + c;
            Console.WriteLine(sum);


            int nu = int.Parse(Console.ReadLine());

            int au = nu / 100;
            int bu = (nu / 10) % 10;
            int cu = nu % 10;

            int mult = a * b * c;
            Console.WriteLine(mult);


            int ny = int.Parse(Console.ReadLine());

            int ay = ny / 10;
            int by = ny % 10;

            int multi = a * b;
            Console.WriteLine(multi);


            int nr = int.Parse(Console.ReadLine());

            int ar = nr / 10000;
            int br = (nr / 1000) % 10;
            int cr = (nr / 100) % 10;
            int d = (nr / 10) % 10;
            int e = nr % 10;

            int sumi = a + b + c + d + e;
            Console.WriteLine(sumi);


            int ng = int.Parse(Console.ReadLine());

            int ag = ng / 10000;
            int bg = (ng / 1000) % 10;
            int cg = (ng / 100) % 10;
            int dg = (ng / 10) % 10;
            int eg = ng % 10;

            int sumg = a + b + c + d + e;
            Console.WriteLine(sumg);


            int nf = int.Parse(Console.ReadLine());

            int af = nf / 1000;
            int bf = (nf / 100) % 10;
            int cf = (nf / 10) % 10;
            int df = nf % 10;

            int result = af * 1000 + bf * 100 + df * 10 + cf;
            Console.WriteLine(result);


            int nh = int.Parse(Console.ReadLine());

            int ah = nh / 1000;
            int bh = (nh / 100) % 10;
            int ch = (nh / 10) % 10;
            int dh = nh % 10;

            int resulti = a * 1000 + b * 100 + d * 10 + c;
            Console.WriteLine(resulti);


            int nj = int.Parse(Console.ReadLine());

            int aj = nj / 1000;
            int bj = (nj / 100) % 10;
            int cj = (nj / 10) % 10;
            int dj = nj % 10;

            int resultj = c * 1000 + b * 100 + a * 10 + d;
            Console.WriteLine(resultj);


            int gb = int.Parse(Console.ReadLine());

            int mb = gb * 1024;
            Console.WriteLine(mb);


            int gbj = int.Parse(Console.ReadLine());

            long bit = (long)gbj * 1024 * 1024 * 1024 * 8;
            Console.WriteLine(bit);


            int gbh = int.Parse(Console.ReadLine());

            double tb = gbh / 1024.0;
            Console.WriteLine(tb);


            int gbg = int.Parse(Console.ReadLine());

            int count = gbg / 2;
            Console.WriteLine(count);


            int x = int.Parse(Console.ReadLine());

            int x2 = x * x;     
            int x4 = x2 * x2;   

            Console.WriteLine(x4);


            int xg = int.Parse(Console.ReadLine());

            int x2g = x * x;     
            int x3 = x2 * x;  
            int x6 = x3 * x3; 

            Console.WriteLine(x6);



            int soat = int.Parse(Console.ReadLine());
            int kun = int.Parse(Console.ReadLine());

            int jamiSoat = kun * 24 + soat;

            Console.WriteLine(jamiSoat);


            int hafta = int.Parse(Console.ReadLine());
            int soati = int.Parse(Console.ReadLine());

            int jamiKun = hafta * 7 + soati / 24;

            Console.WriteLine(jamiKun);


            int minut = int.Parse(Console.ReadLine());
            int soatu = int.Parse(Console.ReadLine());

            int sekund = soatu * 3600 + minut * 60;

            Console.WriteLine(sekund);


            int bayt = int.Parse(Console.ReadLine());
            int kb = bayt / 1024;  

            Console.WriteLine(kb);


            double gbf = 1.8;
            double kbh = gbf * 1024 * 1024;   
            double vaqt = kbh / 750;         

            Console.WriteLine(vaqt);


            int dollar = int.Parse(Console.ReadLine());
            int yevro = int.Parse(Console.ReadLine());

            int som = dollar * 12600 + yevro * 14500;

            Console.WriteLine(som);


            int xv = int.Parse(Console.ReadLine());

            int x2v = x * x;       
            int x4v = x2v * x2v;     
            int x8 = x4v* x4v;     
            int x10 = x8 * x2;    

            Console.WriteLine(x10);


            int pages = 720;
            int rows = 50;
            int chars = 152;

            int totalBytes = pages * rows * chars;

            double mbv = totalBytes / (1024.0 * 1024.0);

            Console.WriteLine(mbv);


            double N = double.Parse(Console.ReadLine());

            double belgi = N * 2.5;
            double soz = belgi / 5;

            Console.WriteLine(soz);


            int av = int.Parse(Console.ReadLine());
            int bv = int.Parse(Console.ReadLine());

            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine(av);
            Console.WriteLine(bv);


            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int C = int.Parse(Console.ReadLine());

            A = A + B + C;
            B = A - (B + C);
            C = A - (B + C);
            A = A - (B + C);

            Console.WriteLine(A);
            Console.WriteLine(B);
            Console.WriteLine(C);


            int P = int.Parse(Console.ReadLine());
            int J = int.Parse(Console.ReadLine());

            int xc = (P - J) / 2;

            Console.WriteLine(xc);


            int km = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            int dm = (km * 1000 + m) * 10;

            Console.WriteLine(dm);
        }
    }
}
