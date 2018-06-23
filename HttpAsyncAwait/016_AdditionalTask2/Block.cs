using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _016_AdditionalTask2
{
    class Block
    {
        public int FieldA { get; set; }
        public int FieldB { get; set; }
        public int FieldC { get; set; }
        public int FieldD { get; set; }

        public Block(int bA, int bB, int bC, int bD)
        {
            this.FieldA = bA;
            this.FieldB = bB;
            this.FieldC = bC;
            this.FieldD = bD;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || this.GetType() != obj.GetType() || obj.GetHashCode() != this.GetHashCode())
            {
                return false;
            }

            Block block = (Block)obj;
            return block.FieldA == this.FieldA
                   && block.FieldB == this.FieldB
                   && block.FieldC == this.FieldC
                   && block.FieldD == this.FieldD;
        }

        public override int GetHashCode()
        {
            return this.FieldA ^ FieldB ^ FieldC ^ FieldD;
        }

        public override string ToString()
        {
            return $"FieldA = {FieldA}, FieldB = {FieldB}, FieldC = {FieldC}, FieldD = {FieldD}";
        }
    }
}
