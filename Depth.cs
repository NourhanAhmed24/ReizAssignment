using System;
using System.Collections.Generic;

public class Branch
{
    private List<Branch> branches;

    public List<Branch> GetBranches()
    {
        return branches;
    }

    public Branch()
    {
        this.branches = new List<Branch>();
    }

    public void AddBranch(Branch branch)
    {
        branches.Add(branch);
    }
}

public class Class2
{
    public static int Depth(Branch branch)
    {
        int depth = 0;
        if (branch.GetBranches().Count == 0)
        {
            return 1;
        }
        else
        {
            List<Branch> childBranches = branch.GetBranches();
            for (int i = 0; i < childBranches.Count; i++)
            {
                int childDepth = Depth(childBranches[i]);
                if (childDepth > depth)
                {
                    depth = childDepth;
                }
            }
        }

        //add 1 to add the root node
        return depth + 1;
    }

    public static void Main(string[] args)
    {
        // Creating the structure
        Branch root = new Branch();

        Branch branch1 = new Branch();
        Branch branch2 = new Branch();
        Branch branch3 = new Branch();
        Branch branch4 = new Branch();
        Branch branch5 = new Branch();
        Branch branch6 = new Branch();
        Branch branch7 = new Branch();
        Branch branch8 = new Branch();

        root.AddBranch(branch1);
        root.AddBranch(branch2);

        branch1.AddBranch(branch3);
        branch1.AddBranch(branch4);
        branch2.AddBranch(branch5);

        branch3.AddBranch(branch6);
        branch5.AddBranch(branch7);
        branch7.AddBranch(branch8);

        // Calculating the depth
        int depth = Depth(root);

        Console.Write("Depth: " + depth); // Output: Depth: 5
    }
}
