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
  public ListNode InsertionSortList(ListNode head)
  {
    var dummy = new ListNode(Int32.MinValue, head);
    var prev = dummy;
    var curr = head;

    while (curr != null)
    {
      if (prev.val <= curr.val)
      {
        prev = prev.next;
        curr = curr.next;
        continue;
      }

      prev.next = prev.next.next;

      var p = dummy;
      while (p.next != null && p.next.val < curr.val)
      {
        p = p.next;
      }

      curr.next = p.next;
      p.next = curr;

      curr = prev.next;
    }

    return dummy.next;
  }
}