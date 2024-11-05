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
        const int CAPACITY = 4;
        int n;
        T[] a;
        public DSCM(int capacity = CAPACITY)
        {
            this.n = 0;
            this.a = new T[capacity];
        }
        public void arrayFull()
        {
            if (this.n + 1 > this.a.Length)
            {
                T[] temp = new T[this.a.Length * 2];
                Array.Copy(this.a, temp, this.n);
                this.a = temp;
            }
        }
        public void insert(T x)
        {
            arrayFull();
            this.a[this.n++] = x;
        }
        public void remove()
        {
            if (this.n > 0) this.n--;
            else this.n = 0;
        }
        public string xuat()
        {
            string s = "";
            for (int i = 0; i < this.n; i++)
            {
                s += this.a[i] + "\n";
            }
            return s;
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
