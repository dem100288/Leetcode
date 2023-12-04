//Reverse Bits

int x = 0b01000010100101000001111010011100;
Console.WriteLine($"Before:    {x,11}, hex: {x,8:x}, binary: {Convert.ToString(x, toBase: 2),32}");

int y = x >> 32;
Console.WriteLine($"After  >>: {y,11}, hex: {y,8:x}, binary: {Convert.ToString(y, toBase: 2),32}");

int z = x >>> 32;
Console.WriteLine($"After >>>: {z,11}, hex: {z,8:x}, binary: {Convert.ToString(z, toBase: 2).PadLeft(32, '0'),32}");

Console.WriteLine(new Solution().reverseBits(0b00000010100101000001111010011100)); // 1
Console.WriteLine(new Solution().reverseBits(0b11111111111111111111111111111101)); // 28

Console.ReadKey();

public class Solution
{
    public uint reverseBits(uint n)
    {
        uint temp = 0;
        for (int i = 0; i < 32; ++i)
        {
            temp = (temp << 1) | (n & 0x1);
            n >>= 1;
        }
        return temp;
    }
}
