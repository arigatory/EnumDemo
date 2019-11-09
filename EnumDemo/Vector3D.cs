using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumDemo
{
    public class Vector3D : IEnumerable<double>
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public IEnumerator<double> GetEnumerator()
        {
            yield return X;
            yield return Y;
            yield return Z;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class VectorEnumerator: IEnumerator<double>
    {
        private int _index=0;
        private readonly Vector3D _vector;
        public void Dispose()
        {
        }

        public VectorEnumerator(Vector3D vector)
        {
            _vector = vector;
        }
        public bool MoveNext()
        {
            if (_index < 3)
            {
                _index++;
                return true;
            }

            return false;
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public double Current
        {
            get
            {
                if (_index == 1) return _vector.X; 
                if (_index == 2) return _vector.Y; 
                if (_index == 3) return _vector.Z;
                return 0;
            }
        }

        object IEnumerator.Current => Current;
    }
}
