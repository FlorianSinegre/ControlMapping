using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace cours
{
    internal class Liste<T> :IEnumerable<T>
    {


        private ArrayList elements;
        
        /// <summary>
        /// Nombre d'éléments de la liste 
        /// </summary>
        public int Count {
            get { return elements.Count; }
        }
        public T this[int index]
        {
            get { return (T)elements[index]; }
            set { elements[index] = value; }
        }
        public Liste()
        {
            elements = new ArrayList();
        }

        public void Ajouter(T trucAAjouter)
        {
            elements.Add(trucAAjouter);
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach(var item in elements)
            {
                yield return (T)item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Trier(DelegueQuiCompareDeuxTrucs<T> test)
        {
            for (int i = 0; i < Count-1; i++)
            {
                for (int j = i + 1; j < Count; j++)
                {
                    if (test(this[i],this[j]))
                    {
                        var aux = this[i];
                        this[i] = this[j];
                        this[j] = aux;
                    }
                }
            }
        }
    }
}
