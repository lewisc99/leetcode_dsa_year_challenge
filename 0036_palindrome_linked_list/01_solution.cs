
// public class ListNode {
//     public int val;
//     public ListNode next;
//     public ListNode(int val=0, ListNode next=null) {
//         this.val = val;
//         this.next = next;
//     }
// }

public class Solution
{
  public bool IsPalindrome(ListNode head)
  {
    Stack<int> stack = new Stack<int>();
    ListNode current = head;

    while (current != null)
    {
      stack.Push(current.val);
      current = current.next;
    }

    Stack<int> stackReversed = new Stack<int>(stack);

    if (stack.SequenceEqual(stackReversed))
      return true;

    return false;
  }
}