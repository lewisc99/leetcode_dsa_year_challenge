/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution
{
  public ListNode SwapPairs(ListNode head)
  {
    var result = new ListNode();
    var prev = result;
    var current = head;

    while (true)
    {
      if (current == null)
      {
        break;
      }

      if (current.next == null)
      {
        prev.next = current;
        break;
      }

      prev.next = current.next;
      var tmp = current.next.next;
      current.next.next = current;
      current.next = tmp;

      prev = current;
      current = current.next;
    }

    return result.next;
  }
}