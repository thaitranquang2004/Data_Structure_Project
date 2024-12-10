using Data_Structure_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structure_Project.Controls
{
    internal class DSCM <T>
    {
        int n;
        T[] a;
        public DSCM()
        {
            this.n = 0;
            this.a = new T[1];
        }
        public void arrayFull()
        {
            if (n == a.Length)
            {
                T[] temp = new T[this.a.Length + 1];
                Array.Copy(a, temp, a.Length);
                a = temp;
            }
        }
        public void insert(T x)
        {
            arrayFull();
            a[n++] = x;
        }
        public void remove(int idx)
        {
            if (idx < 0 || idx >= a.Length) return;
            for (int i = idx; i < a.Length - 1; i++)
            {
                a[i] = a[i + 1];
            }
            n--;
            T[] tmp = new T[a.Length - 1];
            Array.Copy(a, tmp, n); a = tmp;
        }

        public void edit(int idx, T x)
        {
            a[idx] = x;
        }

        public int getlength()
        {
            return a.Length;
        }

        public List<T> contact() {
            List<T> list = new List<T>();
            for (int i = 0; i < this.n; i++)
            {
                list.Add(this.a[i]);
            }
            return list;
        }
    }
}
