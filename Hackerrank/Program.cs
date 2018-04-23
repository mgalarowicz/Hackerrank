using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Hackerrank
{
    

}

//class Solution
//{

//    static int beautifulDays(int i, int j, int k)
//    {
//        List<int> mm = new List<int>();
//        mm.AddRange(Enumerable.Range(i, j - i + 1));
//        return mm.Where(s => (Math.Abs(s - int.Parse(s.ToString().Reverse().Aggregate("", (b, x) => b + x))) % k == 0)).Count();
//    }

//    static void Main(String[] args)
//    {
//        string[] tokens_i = Console.ReadLine().Split(' ');
//        int i = Convert.ToInt32(tokens_i[0]);
//        int j = Convert.ToInt32(tokens_i[1]);
//        int k = Convert.ToInt32(tokens_i[2]);
//        int result = beautifulDays(i, j, k);
//        Console.WriteLine(result);
//        Console.ReadLine();
//    }
//}



//class Solution
//{
//static string angryProfessor(int k, int[] a)
//{
//    return a.Where(s => s <= 0).Count() < k ? "YES" : "NO";
//}
//    static string angryProfessor(int k, int[] a)
//    {
//        var output = a.Where(s => s <= 0).ToList();
//        if (output.Count < k)
//        {
//            return "YES";
//        }
//        else
//        {
//            return "NO";
//        }
//    }
//    static void Main(String[] args)
//    {
//        int t = Convert.ToInt32(Console.ReadLine());
//        for (int a0 = 0; a0 < t; a0++)
//        {
//            string[] tokens_n = Console.ReadLine().Split(' ');
//            int n = Convert.ToInt32(tokens_n[0]);
//            int k = Convert.ToInt32(tokens_n[1]);
//            string[] a_temp = Console.ReadLine().Split(' ');
//            int[] a = Array.ConvertAll(a_temp, Int32.Parse);
//            string result = angryProfessor(k, a);
//            Console.WriteLine(result);
//        }
//    }
//}


//class Solution
//{
//    static void Main(String[] args)
//    {
//        int t = Convert.ToInt32(Console.ReadLine());
//        int H = 1;
//        int[] tree = new int[t];
//        for (int i = 0; i < t; i++)
//        {
//            int n = Convert.ToInt32(Console.ReadLine());

//            if (n == 0)
//            {
//                tree[i] = H;
//            }
//            else
//            {
//                int[] nlist = new int[n + 1];
//                for (int pn = 1; pn < n + 1; pn++)
//                {
//                    if (pn == 1)
//                    {
//                        nlist[pn] = H * 2;
//                    }
//                    else
//                    {
//                        if (pn % 2 != 0)
//                        {
//                            nlist[pn] = nlist[pn - 1] * 2;
//                        }
//                        else if (pn % 2 == 0)
//                        {
//                            nlist[pn] = nlist[pn - 1] + 1;
//                        }
//                    }
//                }
//                tree[i] = nlist[n];
//            }
//        }
//        var list = tree.ToList();
//        list.ForEach(a => Console.WriteLine(a));
//        Console.ReadLine();
//    }
//}




//class Solution
//{
//    static void Main(String[] args)
//    {
//        int t = Convert.ToInt32(Console.ReadLine());
//        int H;
//        int[] tree = new int[t];
//        for (int i = 0; i < t; i++)
//        {
//            int n = Convert.ToInt32(Console.ReadLine());

//            if (i == 0)
//            {
//                H = 1;
//            }
//            else
//            {
//                H = tree[i - 1];
//            }

//            if (n == 0)
//            {
//                tree[i] = H;
//            }
//            else
//            {
//                int[] nlist = new int[n + 1];
//                for (int pn = 1; pn < n + 1; pn++)
//                {
//                    if (pn == 1)
//                    {
//                        nlist[pn] = H * 2;
//                    }
//                    else
//                    {
//                        if (pn % 2 != 0)
//                        {
//                            nlist[pn] = nlist[pn - 1] * 2;
//                        }
//                        else if (pn % 2 == 0)
//                        {
//                            nlist[pn] = nlist[pn - 1] + 1;
//                        }
//                    }
//                }
//                tree[i] = nlist[n];
//            }
//        }
//        var list = tree.ToList();
//        list.ForEach(a => Console.WriteLine(a));
//        Console.ReadLine();

//    }
//}



















//SELECT(COUNT(CITY) - COUNT(DISTINCT CITY)) FROM STATION;

//SELECT TOP 1 CITY, LEN(CITY) FROM STATION ORDER BY LEN(CITY), CITY;
//SELECT TOP 1 CITY, LEN(CITY) FROM STATION ORDER BY LEN(CITY) DESC, CITY;

//SELECT DISTINCT CITY FROM STATION WHERE CITY LIKE '[A, E, I, O, U]%'; 

//SELECT CITY FROM STATION WHERE CITY LIKE '[A,E,I,O,U]%' AND CITY LIKE '%[A,E,I,O,U]';

//SELECT DISTINCT CITY FROM STATION WHERE CITY NOT LIKE '[A,E,I,O,U]%';

//SELECT NAME FROM EMPLOYEE ORDER BY NAME ASC;

//SELECT NAME FROM EMPLOYEE WHERE SALARY > 2000 AND MONTHS< 10 ORDER BY EMPLOYEE_ID ASC;

//SELECT SUM(CITY.POPULATION) FROM CITY INNER JOIN COUNTRY ON CITY.COUNTRYCODE = COUNTRY.CODE WHERE CONTINENT = 'ASIA';

//SELECT CITY.NAME FROM CITY INNER JOIN COUNTRY ON CITY.COUNTRYCODE = COUNTRY.CODE WHERE CONTINENT = 'AFRICA';

//    SELECT COUNTRY.CONTINENT, FLOOR(AVG(CITY.POPULATION))
//FROM COUNTRY
//INNER JOIN CITY
//ON COUNTRY.CODE = CITY.COUNTRYCODE
//GROUP BY COUNTRY.CONTINENT;


//SELECT CASE
//            WHEN GRADES.GRADE > 7
//            THEN STUDENTS.NAME
//            ELSE NULL
//            END AS NAME,
//            GRADES.GRADE, STUDENTS.MARKS
//FROM STUDENTS, GRADES
//WHERE STUDENTS.MARKS BETWEEN GRADES.MIN_MARK AND GRADES.MAX_MARK
//ORDER BY GRADES.GRADE DESC, NAME, STUDENTS.MARKS;


//SELECT H.HACKER_ID, H.NAME
//FROM SUBMISSIONS S
//INNER JOIN CHALLENGES C
//ON S.CHALLENGE_ID = C.CHALLENGE_ID
//INNER JOIN DIFFICULTY D
//ON C.DIFFICULTY_LEVEL = D.DIFFICULTY_LEVEL
//INNER JOIN HACKERS H
//ON S.HACKER_ID = H.HACKER_ID
//WHERE S.SCORE = D.SCORE AND C.DIFFICULTY_LEVEL = D.DIFFICULTY_LEVEL
//GROUP BY H.HACKER_ID, H.NAME
//HAVING COUNT(H.HACKER_ID) > 1
//ORDER BY COUNT(H.HACKER_ID) DESC, H.HACKER_ID ASC


//SELECT NAME FROM STUDENTS WHERE MARKS > 75 ORDER BY RIGHT(NAME, 3) ASC, ID ASC;

//SELECT CAST(ROUND(SUM(LAT_N), 2) AS DECIMAL(10,2)), CAST(ROUND(SUM(LONG_W), 2) AS DECIMAL(10,2)) FROM STATION;



//class Solution
//{
//    static int designerPdfViewer(int[] h, string word)
//    {
//        char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
//        char[] letters = word.ToUpper().ToCharArray();
//        Dictionary<char, int> Sol = new Dictionary<char, int>();
//        for (int i = 0; i < h.Length; i++)
//        {
//            Sol.Add(alpha[i], h[i]);
//        }

//        List<int> res = new List<int>();
//        for (int k = 0; k < letters.Length; k++)
//        {
//            res.Add(Sol.FirstOrDefault(s => s.Key == letters[k]).Value);
//        }

//        return word.Length * res.Max();
//    }

//    static void Main(String[] args)
//    {
//        string[] h_temp = Console.ReadLine().Split(' ');
//        int[] h = Array.ConvertAll(h_temp, Int32.Parse);
//        string word = Console.ReadLine();
//        int result = designerPdfViewer(h, word);
//        Console.WriteLine(result);
//        Console.ReadLine();
//    }
//}

//class Solution
//{
//    static int hurdleRace(int k, int[] height)
//    {
//        if (k < height.Max())
//        {
//            return height.Max() - k;
//        }
//        else
//        {
//            return 0;
//        }
//    }

//    static void Main(String[] args)
//    {
//        string[] tokens_n = Console.ReadLine().Split(' ');
//        int n = Convert.ToInt32(tokens_n[0]);
//        int k = Convert.ToInt32(tokens_n[1]);
//        string[] height_temp = Console.ReadLine().Split(' ');
//        int[] height = Array.ConvertAll(height_temp, Int32.Parse);
//        int result = hurdleRace(k, height);
//        Console.WriteLine(result);
//    }
//}

//class Solution
//{
//    static string kangaroo(int x1, int v1, int x2, int v2)
//    {
//        if (v2 - v1 == 0)
//        {
//            return "NO";
//        }

//        int jumps = (x1 - x2) / (v2 - v1);
//        if ((x1 - x2) % (v2 - v1) == 0)
//        {
//            return "Yes";
//        }
//        else
//        {
//            return "No";
//        }

//    }

//    static void Main(String[] args)
//    {
//        string[] tokens_x1 = Console.ReadLine().Split(' ');
//        int x1 = Convert.ToInt32(tokens_x1[0]);
//        int v1 = Convert.ToInt32(tokens_x1[1]);
//        int x2 = Convert.ToInt32(tokens_x1[2]);
//        int v2 = Convert.ToInt32(tokens_x1[3]);
//        string result = kangaroo(x1, v1, x2, v2);
//        Console.WriteLine(result);
//        Console.ReadLine();
//    }
//}





//class Solution
//{

//    static string catAndMouse(decimal x, decimal y, decimal z)
//    {
//        if (Math.Abs(x - z) == Math.Abs(y - z))
//        {
//            return "Mouse C";
//        }
//        else if (Math.Abs(x - z) < Math.Abs(y - z))
//        {
//            return "Cat A";
//        }
//        else
//        {
//            return "Cat B";
//        }
//    }
//    static void Main(string[] args)
//    {
//        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//        int q = Convert.ToInt32(Console.ReadLine());

//        for (int qItr = 0; qItr < q; qItr++)
//        {
//            string[] xyz = Console.ReadLine().Split(' ');

//            int x = Convert.ToInt32(xyz[0]);

//            int y = Convert.ToInt32(xyz[1]);

//            int z = Convert.ToInt32(xyz[2]);

//            string result = catAndMouse(x, y, z);

//            tw.WriteLine(result);
//        }

//        tw.Flush();
//        tw.Close();
//    }
//}






//class Solution
//{
//    static void Main(String[] args)
//    {
//        string[] tokens_s = Console.ReadLine().Split(' ');
//        long s = Convert.ToInt32(tokens_s[0]);
//        long n = Convert.ToInt32(tokens_s[1]);
//        long m = Convert.ToInt32(tokens_s[2]);
//        string[] keyboards_temp = Console.ReadLine().Split(' ');
//        long[] keyboards = Array.ConvertAll(keyboards_temp, Int64.Parse);
//        string[] drives_temp = Console.ReadLine().Split(' ');
//        long[] drives = Array.ConvertAll(drives_temp, Int64.Parse);
//        long moneySpent = 0;
//        List<long> prices = new List<long>();
//        for (long i = 0; i < keyboards.Length; i++)
//        {
//            for (long j = 0; j < drives.Length; j++)
//            {
//                moneySpent = keyboards[i] + drives[j];

//                if (moneySpent <= s)
//                {
//                    prices.Add(moneySpent);
//                }
//            }
//        }
//        if (!prices.Any())
//        {
//            Console.WriteLine("-1");
//        }
//        else
//        {
//            long maxSum = prices.Max();
//            Console.WriteLine(maxSum);
//        }
//        Console.ReadLine();
//    }
//}




//class Solution
//{
//    static int countingValleys(int n, string s)
//    {
//        int UpDown = 0;
//        int Valleys = 0;
//        foreach (char c in s)
//        {
//            if (c.ToString() == "U")
//            {
//                UpDown++;
//            }
//            else if (c.ToString() == "D")
//            {
//                UpDown--;
//            }

//            if (c.ToString() == "U" && UpDown == 0)
//            {
//                Valleys++;
//            }
//        }
//        return Valleys;
//    }

//    static void Main(String[] args)
//    {
//        int n = Convert.ToInt32(Console.ReadLine());
//        string s = Console.ReadLine();
//        int result = countingValleys(n, s);
//        Console.WriteLine(result);
//    }
//}



//class Solution
//{
//    static string solve(int year)
//    {
//        string date = string.Empty;
//        if (DateTime.IsLeapYear(year))
//        {
//            date = "12.09." + year.ToString();
//        }
//        else
//        {
//            date = "13.09." + year.ToString();
//        }

//        return date;
//    }
//    static void Main(String[] args)
//    {
//        int year = Convert.ToInt32(Console.ReadLine());
//        string result = solve(year);
//        Console.WriteLine(result);
//    }
//}

//class Solution
//{
//    static int solve(int n, int p)
//    {
//        int ans = 0;
//        int front = p / 2;
//        int back = (n / 2 - p / 2);
//        if (front < back)
//        {
//            ans = front;
//        }
//        else
//        {
//            ans = back;
//        }
//        return ans;
//    }

//    static void Main(String[] args)
//    {
//        int n = Convert.ToInt32(Console.ReadLine());
//        int p = Convert.ToInt32(Console.ReadLine());
//        int result = solve(n, p);
//        Console.WriteLine(result);
//    }
//}

//class Solution
//{

//    static int[] reverseArray(int[] a)
//    {
//        for (int i = 0; i < a.Length / 2; i++)
//        {
//            int z = a[i];
//            a[i] = a[a.Length - 1 - i];
//            a[a.Length - 1 - i] = z;
//        }
//        return a;

//    }

//    static void Main(string[] args)
//    {
//        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//        int arrCount = Convert.ToInt32(Console.ReadLine());

//        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
//        ;
//        int[] res = reverseArray(arr);

//        textWriter.WriteLine(string.Join(" ", res));

//        textWriter.Flush();
//        textWriter.Close();
//    }
//}

//class Solution
//{

//    static int sockMerchant(int n, int[] ar)
//    {
//        var groups = ar.GroupBy(v => v);
//        int sum = 0;
//        foreach (var group in groups)
//        {
//            if (group.Count() >= 2 && (group.Count() % 2 == 0 || group.Count() % 2 == 1))
//            {
//                sum += group.Count() / 2;
//            }
//        }
//        return sum;
//    }

//    static void Main(String[] args)
//    {
//        int n = Convert.ToInt32(Console.ReadLine());
//        string[] ar_temp = Console.ReadLine().Split(' ');
//        int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
//        int result = sockMerchant(n, ar);
//        Console.WriteLine(result);
//        Console.ReadLine();
//    }
//}

//class Solution
//{
//    static void Main(string[] args)
//    {
//        string[] tokens_n = Console.ReadLine().Split(' ');
//        int n = Convert.ToInt32(tokens_n[0]);
//        int k = Convert.ToInt32(tokens_n[1]);
//        string[] ar_temp = Console.ReadLine().Split(' ');
//        int b = Convert.ToInt32(Console.ReadLine());
//        int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
//        int sum = 0;
//        for (int i = 0; i < n; i++)
//        {
//            if (i != k)
//            {
//                sum += ar[i];
//            }
//        }

//        if (b - (sum / 2) > 0)
//        {
//            Console.WriteLine("{0}", b - (sum / 2));
//        }
//        else
//        {
//            Console.WriteLine("Bon Appetit");
//        }

//        Console.ReadLine();
//    }
//}

//class Solution
//{

//    static int migratoryBirds(int n, int[] ar)
//    {
//        Dictionary<int, int> d = new Dictionary<int, int>();
//        var groups = ar.GroupBy(v => v);
//        foreach (var group in groups)
//        {
//            d.Add(group.Key, group.Count());
//        }
//        var myKey = d.OrderBy(v => v.Key).FirstOrDefault(v => v.Value == d.Values.Max()).Key;
//        return myKey;
//    }

//    static void Main(String[] args)
//    {
//        int n = Convert.ToInt32(Console.ReadLine());
//        string[] ar_temp = Console.ReadLine().Split(' ');
//        int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
//        int result = migratoryBirds(n, ar);
//        Console.WriteLine(result);
//        Console.ReadLine();
//    }
//}


//class Solution
//{
//    static int divisibleSumPairs(int n, int k, int[] ar)
//    {
//        int numbers = 0;
//        for (int i = 0; i < n; i++)
//        {
//            for (int el = 0; el < n; el++)
//            {
//                if (i < el)
//                {
//                    int sum = ar[i] + ar[el];
//                    {
//                        if (sum % k == 0)
//                        {
//                            numbers++;
//                        }
//                    }
//                }
//            }
//        }
//        return numbers;
//    }

//    static void Main(String[] args)
//    {
//        string[] tokens_n = Console.ReadLine().Split(' ');
//        int n = Convert.ToInt32(tokens_n[0]);
//        int k = Convert.ToInt32(tokens_n[1]);
//        string[] ar_temp = Console.ReadLine().Split(' ');
//        int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
//        int result = divisibleSumPairs(n, k, ar);
//        Console.WriteLine(result);
//        Console.ReadLine();
//    }
//}


//class Solution
//{
//    static int getIntegerComplement(int n)
//    {
//        string binary = Convert.ToString(n, 2);
//        char[] bin = binary.ToCharArray();
//        Array.Reverse(bin);
//        foreach (char el in bin)
//        {
//            Console.Write(el);
//        }
//        string name = Console.ReadLine();
//    }

//    static void Main(String[] args)
//    {
//        string fileName = System.Environment.GetEnvironmentVariable("OUTPUT_PATH");
//        TextWriter tw = new StreamWriter(@fileName, true);

//        int res;
//        int n;
//        n = Convert.ToInt32(Console.ReadLine());

//        res = getIntegerComplement(n);
//        tw.WriteLine(res);

//        tw.Flush();
//        tw.Close();
//    }
//}



//class Solution
//{
//    static string[] braces(string[] values)
//    {
//        int ln = values.Length;
//        for (int i = 0; i < ln; i++)
//        {
//            if (values[i].Length % 2 == 0 && (values[i].Contains("{}") || values[i].Contains("()") || values[i].Contains("[]")))
//            {
//                Console.WriteLine("YES");
//            }
//            else
//            {
//                Console.WriteLine("NO");
//            }
//        }
//    }

//    static void Main(String[] args)
//    {
//        string fileName = System.Environment.GetEnvironmentVariable("OUTPUT_PATH");
//        TextWriter tw = new StreamWriter(@fileName, true);

//        string[] res;
//        int values_size = 0;
//        values_size = Convert.ToInt32(Console.ReadLine());
//        string[] values = new string[values_size];
//        string values_item;
//        for (int values_i = 0; values_i < values_size; values_i++)
//        {
//            values_item = Console.ReadLine();
//            values[values_i] = values_item;
//        }

//        res = braces(values);
//        for (int res_i = 0; res_i < res.Length; res_i++)
//        {
//            tw.WriteLine(res[res_i]);
//        }

//        tw.Flush();
//        tw.Close();
//    }
//}





//class Solution
//{

//    class SinglyLinkedListNode
//    {
//        public int data;
//        public SinglyLinkedListNode next;

//        public SinglyLinkedListNode(int nodeData)
//        {
//            this.data = nodeData;
//            this.next = null;
//        }
//    }

//    class SinglyLinkedList
//    {
//        public SinglyLinkedListNode head;
//        public SinglyLinkedListNode tail;

//        public SinglyLinkedList()
//        {
//            this.head = null;
//            this.tail = null;
//        }

//        public void InsertNode(int nodeData)
//        {
//            SinglyLinkedListNode node = new SinglyLinkedListNode(nodeData);

//            if (this.head == null)
//            {
//                this.head = node;
//            }
//            else
//            {
//                this.tail.next = node;
//            }

//            this.tail = node;
//        }
//    }

//    static void PrintSinglyLinkedList(SinglyLinkedListNode node, string sep, TextWriter tw)
//    {
//        while (node != null)
//        {
//            tw.Write(node.data);

//            node = node.next;

//            if (node != null)
//            {
//                tw.Write(sep);
//            }
//        }
//    }




//    static SinglyLinkedListNode removeNodes(SinglyLinkedListNode listHead, int x)
//    {

//    }

//    static void Main(string[] args)
//    {
//        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

//        SinglyLinkedList listHead = new SinglyLinkedList();

//        int listHeadCount = Convert.ToInt32(Console.ReadLine());

//        for (int listHeadItr = 0; listHeadItr < listHeadCount; listHeadItr++)
//        {
//            int listHeadItem = Convert.ToInt32(Console.ReadLine());
//            listHead.InsertNode(listHeadItem);
//        }

//        int x = Convert.ToInt32(Console.ReadLine());

//        SinglyLinkedListNode res = removeNodes(listHead.head, x);

//        PrintSinglyLinkedList(res, "\n", tw);
//        tw.WriteLine();

//        tw.Flush();
//        tw.Close();
//    }
//}


//class Solution
//{
//    static void Main(String[] args)
//    {
//        int n = Convert.ToInt32(Console.ReadLine());
//        string[] s_temp = Console.ReadLine().Split(' ');
//        int[] s = Array.ConvertAll(s_temp, Int32.Parse);
//        string[] tokens_d = Console.ReadLine().Split(' ');
//        int d = Convert.ToInt32(tokens_d[0]);
//        int m = Convert.ToInt32(tokens_d[1]);

//        int counting = 0;
//        for (int i = 0; i < n; i++)
//        {
//            if ((i + m - 1) <= (n - 1))
//            {
//                var g = s.Skip(i).Take(m).ToList();
//                if (g.Sum() == d)
//                {
//                    counting++;
//                }
//                g.Clear();
//            }
//        }
//        Console.WriteLine(counting);
//        Console.ReadLine();
//    }
//}


//class Solution
//{
//    static void Main(String[] args)
//    {
//        int n = Convert.ToInt32(Console.ReadLine());
//        string[] score_temp = Console.ReadLine().Split(' ');
//        int[] score = Array.ConvertAll(score_temp, Int32.Parse);

//        int lScore = score[0];
//        int hScore = score[0];
//        int hScoreCount = 0;
//        int lScoreCount = 0;

//        for (int i = 1; i < n; i++)
//        {
//            if (score[i] > hScore)
//            {
//                hScore = score[i];
//                hScoreCount++;
//            }
//            else if (score[i] < lScore)
//            {
//                lScore = score[i];
//                lScoreCount++;
//            }
//        }
//        Console.WriteLine(hScoreCount + " " + lScoreCount);
//    }
//}

//class Solution
//{
//    static void Main(String[] args)
//    {
//        Console.ReadLine();
//        var A = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse).ToList();
//        var B = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse).ToList();

//        int c = 0;

//        for (int i = 1; i < 10000; i++)
//        {
//            if (A.Any(x => i % x != 0)) continue;
//            if (B.Any(x => x % i != 0)) continue;
//            c++;
//        }
//        Console.WriteLine(c);
//        Console.ReadLine();
//    }
//}


//class Solution
//{

//    static string kangaroo(int x1, int v1, int x2, int v2)
//    {
//        int k1 = x1 - x2;
//        int k2 = v2 - v1;

//        if (k1 % k2 == 0 && k1 / k2 > 0)
//        {
//            return "YES";
//        }
//        else
//        {
//            return "NO";
//        }
//    }

//    static void Main(String[] args)
//    {
//        string[] tokens_x1 = Console.ReadLine().Split(' ');
//        int x1 = Convert.ToInt32(tokens_x1[0]);
//        int v1 = Convert.ToInt32(tokens_x1[1]);
//        int x2 = Convert.ToInt32(tokens_x1[2]);
//        int v2 = Convert.ToInt32(tokens_x1[3]);
//        string result = kangaroo(x1, v1, x2, v2);
//        Console.WriteLine(result);
//    }
//}


//class Solution
//{

//    static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
//    {

//        int dist1 = s - a;
//        int dist2 = t - b;
//        List<int> l1 = new List<int>();
//        List<int> l2 = new List<int>();

//        foreach (int ap in apples)
//        {
//            if (ap > dist1 && ap < dist2)
//            {
//                l1.Add(ap);
//            }
//        }
//        int numA = l1.Count();

//        Console.WriteLine(numA);


//        foreach (int or in oranges)
//        {
//            if (or < dist2 && or < dist2)
//            {
//                l2.Add(or);
//            }
//        }
//        int numO = l2.Count();
//        Console.WriteLine(numO);
//    }

//    static void Main(String[] args)
//    {
//        string[] tokens_s = Console.ReadLine().Split(' ');
//        int s = Convert.ToInt32(tokens_s[0]);
//        int t = Convert.ToInt32(tokens_s[1]);
//        string[] tokens_a = Console.ReadLine().Split(' ');
//        int a = Convert.ToInt32(tokens_a[0]);
//        int b = Convert.ToInt32(tokens_a[1]);
//        string[] tokens_m = Console.ReadLine().Split(' ');
//        int m = Convert.ToInt32(tokens_m[0]);
//        int n = Convert.ToInt32(tokens_m[1]);
//        string[] apple_temp = Console.ReadLine().Split(' ');
//        int[] apple = Array.ConvertAll(apple_temp, Int32.Parse);
//        string[] orange_temp = Console.ReadLine().Split(' ');
//        int[] orange = Array.ConvertAll(orange_temp, Int32.Parse);
//        countApplesAndOranges(s, t, a, b, apple, orange);
//    }
//}















//class Solution
//{
//    static void Main(String[] args)
//    {
//        int n = Convert.ToInt32(Console.ReadLine());
//        int[] grades = new int[n];
//        for (int grades_i = 0; grades_i < n; grades_i++)
//        {
//            grades[grades_i] = Convert.ToInt32(Console.ReadLine());
//        }

//        int[] result = new int[n];

//        for (int i = 0; i < n; i++)
//        {
//            if (grades[i] < 38)
//            {
//                result[i] = grades[i];
//            }
//            else
//            {
//                if ((grades[i] + 2) % 5 == 0)
//                {
//                    result[i] = grades[i] + 2;
//                }
//                else if ((grades[i] + 1) % 5 == 0)
//                {
//                    result[i] = grades[i] + 1;
//                }
//                else
//                {
//                    result[i] = grades[i];
//                }
//            }
//        }
//        Console.WriteLine(String.Join("\n", result));

//        Console.ReadLine();
//    }
//}



//class Solution
//{
//    static void Main(String[] args)
//    {
//        string s = Console.ReadLine();
//        DateTime time;
//        if (DateTime.TryParseExact(s, "hh:mm:sstt", null, System.Globalization.DateTimeStyles.None, out time))
//        {
//            Console.WriteLine("{0:HH\\:mm\\:ss}", time);
//        }
//        Console.ReadLine();
//    }
//}

//class Solution
//{

//    static void Main(String[] args)
//    {
//        int n = Convert.ToInt32(Console.ReadLine());
//        string[] ar_temp = Console.ReadLine().Split(' ');
//        int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
//        int target = ar.Max();
//        int result = Array.FindAll(ar, s => s.Equals(target)).Length;
//        Console.WriteLine(result);
//        Console.ReadLine();
//    }
//}


//class Solution
//{

//    static void Main(String[] args)
//    {
//        int sum1 = 0;
//        int sum2 = 0;
//        int n = Convert.ToInt32(Console.ReadLine());
//        int[][] a = new int[n][];
//        for (int a_i = 0; a_i < n; a_i++)
//        {
//            string[] a_temp = Console.ReadLine().Split(' ');
//            a[a_i] = Array.ConvertAll(a_temp, Int32.Parse);
//        }

//        for (int i = 0; i < n; i++)
//        {
//            sum1 += a[i][i];
//            sum2 += a[i][n - 1 - i];
//        }
//        int result = Math.Abs(sum1 - sum2);
//        Console.WriteLine(result);
//        Console.ReadLine();
//    }
//}




//class Solution
//{
//    static void Main(String[] args)
//    {
//        int n = Convert.ToInt32(Console.ReadLine());
//        for (int i = 0; i < n; i++)
//            Console.WriteLine(new String('#', i + 1).PadLeft(n, ' '));
//        Console.ReadLine();
//    }
//}






//class Program
//{

//    static void plusMinus(int[] arr)
//    {
//        IEnumerable<int> grater = arr.Where(r => r > 0);
//        IEnumerable<int> lower = arr.Where(r => r < 0);
//        IEnumerable<int> zeros = arr.Where(r => r == 0);

//        Console.WriteLine((decimal)grater.Count() / arr.Length);
//        Console.WriteLine((decimal)lower.Sum() / arr.Length);
//        Console.WriteLine((decimal)zeros.Sum() / arr.Length);

//    }

//    static void Main(String[] args)
//    {
//        int n = Convert.ToInt32(Console.ReadLine());
//        string[] arr_temp = Console.ReadLine().Split(' ');
//        int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
//        plusMinus(arr);
//    }
//}



//class Program
//{

//    static void miniMaxSum(long[] arr)
//    {
//        long[] resultArray = new long[] { };

//        foreach (int element in arr)
//        {
//            resultArray = resultArray.Concat(new long[] { arr.Sum() - element }).ToArray();
//        }
//        long Max = resultArray.Max();
//        long Min = resultArray.Min();

//        Console.WriteLine("{0} {1}", Min, Max);

//    }

//    static void Main(String[] args)
//    {
//        string[] arr_temp = Console.ReadLine().Split(' ');
//        long[] arr = Array.ConvertAll(arr_temp, Int64.Parse);
//        miniMaxSum(arr);
//        Console.ReadLine();
//    }
//}




//class Program
//{

//static int[] solve(int a0, int a1, int a2, int b0, int b1, int b2)
//{
//    int A = 0;
//    int B = 0;
//    int[] c = new int[] { a0 - b0, a1 - b1, a2 - b2 };

//    foreach (int element in c)
//    {
//        if (element > 0)
//        {
//            A += 1;
//        }
//        else if (element < 0)
//        {
//            B += 1;
//        }
//        else { }
//    }
//    return new int[] { A, B };
//}


//string[] arr_temp = Console.ReadLine().Split(' ');
//int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);


//static void Main(string[] args)
//{
//string[] tokens_a0 = Console.ReadLine().Split(' ');
//int a0 = Convert.ToInt32(tokens_a0[0]);
//int a1 = Convert.ToInt32(tokens_a0[1]);
//int a2 = Convert.ToInt32(tokens_a0[2]);
//string[] tokens_b0 = Console.ReadLine().Split(' ');
//int b0 = Convert.ToInt32(tokens_b0[0]);
//int b1 = Convert.ToInt32(tokens_b0[1]);
//int b2 = Convert.ToInt32(tokens_b0[2]);
//int[] result = solve(a0, a1, a2, b0, b1, b2);
//Console.WriteLine(String.Join(" ", result));
//    }
//}


