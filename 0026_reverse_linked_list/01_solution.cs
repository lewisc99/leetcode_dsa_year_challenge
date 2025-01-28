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
  public ListNode ReverseBetween(ListNode head, int left, int right)
  {
    if (head == null || left == right)
    {
      return head;
    }

    ListNode dummy = new ListNode(0);
    dummy.next = head;
    ListNode pre = dummy;

    for (int i = 1; i < left; i++)
    {
      pre = pre.next;
    }

    ListNode current = pre.next;
    ListNode next = null;
    ListNode prev = null;

    for (int i = 0; i <= right - left; i++)
    {
      next = current.next;
      current.next = prev;
      prev = current;
      current = next;
    }

    pre.next.next = current;
    pre.next = prev;

    return dummy.next;
  }
}
