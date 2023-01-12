using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Player
{
    internal class CircularDoublyLinkedList
    {
        class Node
        {
            public string songname;
            public string songlocation;

            public Node next_node;
            public Node previous_node;
        }
        public class CDLinkedList //Circular Doubly Linked List
        {
            Node head = null;
            Node tail = null;

            public void insertFirst(string sname,string sloc)
            {
                if (head == null)
                {
                    Node newnode = new Node(); //new node

                    newnode.songlocation = sloc;
                    newnode.songname = sname;

                    head = newnode;
                    tail = newnode;
                }
                else
                {
                    Node newnode = new Node(); //new node

                    newnode.songlocation = sloc;
                    newnode.songname=sname;

                    head.previous_node = newnode;
                    newnode.next_node = head;

                    head = newnode; //transfer head to new node
                    head.previous_node = tail; //linking first node to last node's previous_node
                    
                }
            }
            public void insertLast(string sname,string sloc)  //Adding a node at end of the linked list
            {
                if (head == null) //if there is no node
                {
                    Node newnode = new Node();

                    newnode.songlocation = sloc;
                    newnode.songname = sname;

                    head = newnode;
                    tail = newnode;
                }
                else
                {
                    Node newnode = new Node();

                    newnode.songlocation = sloc;
                    newnode.songname = sname;

                    tail.next_node = newnode;
                    newnode.previous_node = tail;

                    tail = newnode;
                    tail.next_node = head;
                }
            }
            public int deleteFirst() //Deleting values from the begining
            {
                if (head == null)
                {
                    return 0;
                }
                else
                {
                    if (head == tail)
                    {
                        head = tail = null;
                    }
                    else
                    {
                        head = head.next_node;
                        head.previous_node = tail;
                        tail.next_node = head;  
                    }
                    return 1;
                }
            }

            public int deleteLast() //Deleting values from the end
            {
                if (head == null)
                {
                    return 0;
                }
                else
                {
                    if (head == tail)
                    {
                        head = tail = null;
                    }
                    else
                    {
                        tail = tail.previous_node;
                        tail.next_node = head;
                    }
                    return 1;
                }
            }
            public int deleteAllNodes() //Deleting all the songs
            {
                if (head == null)
                {
                    return 0;
                }
                else
                {
                    while(head != null)
                    {
                        deleteFirst();
                    }
                    return 1;
                }
            }
            public string getLocation(int index)
            {
                if (head == null)
                {
                    return "-1";
                }
                else
                {
                    Node current_node = head;
                    for (int x = 1; x <= index; x++)
                    {
                        if (current_node.next_node == tail.next_node)
                        {
                            return "0";
                            break;
                        }
                        else
                        {
                            current_node = current_node.next_node;
                        }

                    }
                    return current_node.songlocation;
                }
            }
            public string getSongName(int index)
            {
                if (head == null)
                {
                    return "-1";
                }
                else
                {
                    Node current_node = head;
                    for (int x = 1; x <= index; x++)
                    {
                        if (current_node.next_node == tail.next_node)
                        {
                            return "0";
                            break;
                        }
                        else
                        {
                            current_node = current_node.next_node;
                        }

                    }
                    return current_node.songname;
                }
            }
            public int getSongIndex(string searchValue)
            {
                if (searchValue == null)
                {
                    return -1;
                }
                else
                {
                    int song_number = 0;
                    Node current_node = head;
                    int song_len = searchValue.Length;
                    while (current_node != tail)
                    {
                        
                        String c_song_name = current_node.songname.Substring(0, song_len);
                        if (c_song_name.Equals(searchValue))
                        {
                            return song_number;
                        }
                        current_node = current_node.next_node;
                        song_number++;
                    }
                    String xc_song_name = current_node.songname.Substring(0, song_len);
                    if (xc_song_name.Equals(searchValue))
                    {
                        return song_number;
                    }
                    else
                    {
                        return -2;
                    }
                }
            }
            public void sort(int order)
            {
                int count = 1;
                Node count_node = head;
                while (count_node != tail) //Find the number of songs in the CircularDoublyLinkedList
                {
                    count_node = count_node.next_node;
                    count++;
                }
                for (int counter = 1; counter <= count; counter++) //Number of rounds for songs
                {
                    Node current_node = head;
                    char[] letters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

                    for (int x = 1; x < count; x++) // Loop for each song
                    {
                        int current_node_letter_val = 0;
                        int next_node_letter_val = 0;

                        Node next_node = current_node.next_node;

                        char current_node_first_letter = char.ToUpper(current_node.songname[0]); // Get first letter of the songs name and convert it to caps
                        char next_node_first_letter = char.ToUpper(next_node.songname[0]);

                        for (int no = 0; no < 26; no++) // Find the number 
                        {
                            if (current_node_first_letter == letters[no])
                                current_node_letter_val = no;
                            if (next_node_first_letter == letters[no])
                                next_node_letter_val = no;
                        }
                        if (order == 0)
                        {
                            if (current_node_letter_val > next_node_letter_val) //comapre number of first song's first letter and next song's first letter (A-Z)
                            {
                                Node temp_current = new Node();
                                Node temp_nextnode = new Node();

                                temp_current.songname = current_node.songname;// Storing node's values in temp Nodes
                                temp_current.songlocation = current_node.songlocation;
                                temp_nextnode.songname = next_node.songname;
                                temp_nextnode.songlocation = next_node.songlocation;

                                current_node.songname = temp_nextnode.songname;//Swap
                                current_node.songlocation = temp_nextnode.songlocation;
                                next_node.songname = temp_current.songname;
                                next_node.songlocation = temp_current.songlocation;
                            }
                        }
                        else if(order == 1)
                        {
                            if (current_node_letter_val < next_node_letter_val) //comapre number of first song's first letter and next song's first letter (Z - A)
                            {
                                Node temp_current = new Node();
                                Node temp_nextnode = new Node();

                                temp_current.songname = current_node.songname;// Storing node's values in temp Nodes
                                temp_current.songlocation = current_node.songlocation;
                                temp_nextnode.songname = next_node.songname;
                                temp_nextnode.songlocation = next_node.songlocation;

                                current_node.songname = temp_nextnode.songname;//Swap
                                current_node.songlocation = temp_nextnode.songlocation;
                                next_node.songname = temp_current.songname;
                                next_node.songlocation = temp_current.songlocation;
                            }
                        }
                        current_node = current_node.next_node; //go to next song
                    }
                }
            }
            public int getNextIndex(int current_node_value)
            {
                Node current_node = head;
                int next_node = 0;
                while(next_node <= current_node_value)
                {
                    if(current_node != tail)
                    {
                        current_node = current_node.next_node;
                        next_node++;
                    }
                    else
                    {
                        next_node = 0;
                        break;
                    }
                }
                return next_node;
            }
            public int getPreIndex(int current_node_value)
            {
                Node current_node = head;
                int pre_node = current_node_value - 1;

                if(pre_node < 0)
                {
                    while(current_node != tail)
                    {
                        current_node=current_node.next_node;
                        pre_node++;
                    }
                    pre_node++;
                }
                return pre_node;
            }
        }
    }
}
