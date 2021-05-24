using System;
using System.Collections.Generic;

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{
    static void Main(string[] args)
    {
        ListNode l1 = new ListNode();
        ListNode l2 = new ListNode();
        AddTwoNumbers(l1, l2);
    }
    public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        l1.val = 2;
        l1.next = (ListNode)4;
        l1.next = (ListNode)3;

        foreach(var i in l1)
        {
            Console.WriteLine(i);
        }

        


        return null;
    }
}
