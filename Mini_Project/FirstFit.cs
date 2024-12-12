// Simulation of First Fit Memory Allocation Algorithm

using System;

class FirstFitAllocation
{
    public int[] FirstFitAlgorithm(int[] blocks, int[] requests)
    {
        int[] allocation = new int[requests.Length]; // Stores block index for each request (-1 if not allocated)

        for (int i = 0; i < requests.Length; i++)
        {
            allocation[i] = -1; // Initialize as not allocated
            for (int j = 0; j < blocks.Length; j++)
            {
                if (blocks[j] >= requests[i]) // Check if block can accommodate the request
                {
                    allocation[i] = j; // Assign block to request
                    blocks[j] -= requests[i]; // Reduce available memory in block
                    break; // Move to the next request
                }
            }
        }

        return allocation;
    }

    public void DisplayResults(int[] blocks, int[] requests, int[] allocation)
    {
        Console.WriteLine("\nMemory Allocation Results:");
        Console.WriteLine("Request (KB)\tBlock Allocated");

        for (int i = 0; i < requests.Length; i++)
        {
            if (allocation[i] != -1)
            {
                Console.WriteLine($"{requests[i]}\t\tBlock {allocation[i] + 1}");
            }
            else
            {
                Console.WriteLine($"{requests[i]}\t\tNot Allocated");
            }
        }

        Console.WriteLine("\nRemaining Blocks After Allocation:");
        foreach (int block in blocks)
        {
            Console.Write(block + " ");
        }
        Console.WriteLine();
    }
}