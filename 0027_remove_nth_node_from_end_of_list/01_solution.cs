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
public class Solution {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        int totalNodes = 0;
        ListNode current = head;
        while (current != null) {
            totalNodes++;
            current = current.next;
        }

        int positionToRemove = totalNodes - n + 1;

        if (positionToRemove == 1) {
            return head.next;
        }

        current = head;
        for (int i = 1; i < positionToRemove - 1; i++) {
            current = current.next;
        }

        current.next = current.next.next;

        return head;
    }
}
