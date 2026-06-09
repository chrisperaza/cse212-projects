public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // TODO Start Problem 1
        
        if (value == Data)
        {
            return;
        }

        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        // TODO Start Problem 2

        if (value == Data)
        {
            return true;
        }

        if (value < Data)
        {
            if (Left is null)
                return false;
            else
                return Left.Contains(value);
        }
        else
        {
            if (Right is null)
                return false;
            else
                return Right.Contains(value);
        }
    }

    public int GetHeight()
    {
        // TODO Start Problem 4

        int root = 1;
        int leftH = 0;
        int rightH = 0;
        int mostHeight;
        int total;

        // know the left height
        if (Left is null)
        {
            leftH = 0;
        }
        else
        {
            leftH = Left.GetHeight();
        }
        // know the right height
        if (Right is null)
        {
            rightH = 0;
        }
        else
        {
            rightH = Right.GetHeight();
        }

        // know the most height
        if (leftH > rightH)
        {
            mostHeight = leftH;
        }
        else
        {
            mostHeight = rightH; 
        }

        total = root + mostHeight;

        return total; // Replace this line with the correct return statement(s)
    }
}