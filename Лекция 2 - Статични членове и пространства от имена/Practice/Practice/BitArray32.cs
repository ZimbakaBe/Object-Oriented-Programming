using System;

public class BitArray32
{
    private int number;

    public BitArray32(int number)
    {
        this.number = number;
    }

    public int this[int index]
    {
        get { return GetBit(index); }
        set
        {
            SetBitAt(value, index);
        }
    }

    public void SetBitAt(int bit, int index)
    {
        if (index < 0 || index > 31)
        {
            throw new ArgumentOutOfRangeException("Index must be in range 0-31");
        }
        if (bit != 1 && bit != 0)
        {
            throw new ArgumentException("Bit shoukd be either 0 or 1");
        }

        //nullify
        int nullified = this.number & ~(1 << index);

        //set
        nullified |= bit << index;
        this.number = nullified;

    }
    public int GetBit(int index)
    {
        if (index < 0 || index > 31)
        {
            throw new ArgumentOutOfRangeException("Index must be in range 0-31");
        }

        int bit = (this.number >> index) & 1;

        return bit;
    }
}

