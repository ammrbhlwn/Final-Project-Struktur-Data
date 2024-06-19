using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject;

public class Node
{
    public Node next;
    public Akun akun;

    public Node(Akun akun)
    {
        this.akun = akun;
        this.next = null;
    }
}

public class ChainingHash
{
    public static int capacity = 26;
    public static Node[] table = new Node[capacity];

    public ChainingHash()
    {
        for (int i = 0; i < capacity; i++)
        {
            table[i] = null;
        }
    }

    public static int HashCode(string key)
    {
        char c = key[0];
        int asciivalue = (int)c;
        return (asciivalue - 97) % capacity;
    }


    public bool HapusAkun(string key)
    {
        int index = HashCode(key);
        Node prev = null;
        Node current = table[index];

        while (current != null)
        {
            if (key == current.akun.username)
            {
                if (prev == null)
                {
                    table[index] = current.next;
                }
                else
                {
                    prev.next = current.next;
                }
                return true;
            }
            prev = current;
            current = current.next;
        }
        return false;
    }


    public static bool ValidasiDaftar(Akun akun)
    {
        int index = HashCode(akun.username);
        Node newNode = new Node(akun);
        bool failed = false;

        if (table[index] == null)
        {
            table[index] = newNode;
            return true;
        }
        else
        {
            Node temp = table[index];
            while (temp.next != null)
            {
                if (temp.akun.username == akun.username)
                {
                    failed = true;
                    break;
                }
                temp = temp.next;
            }
            if (failed)
            {
                temp.next = newNode;
                return true;
            }
            else
            {
                Console.WriteLine("Username telah terdaftar");
                return false;
            }
        }
    }

    public static bool ValidasiLogin(Akun akun)
    {
        int index = HashCode(akun.username);
        Node current = table[index];

        while (current != null)
        {
            if (akun.username == current.akun.username && akun.Password == current.akun.Password)
            {
                return true;
            }
            else
            {
                current = current.next;
            }
        }
        return false;
    }
}