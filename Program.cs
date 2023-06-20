using System;
using System.Collections;
class Program
{
    static void Main(string[] args)
    {
            // Create a new hash table
            Hashtable hashtable = new Hashtable();

            // Add key-value pairs to the hash table
            hashtable.Add("apple", "A fruit");
            hashtable.Add("car", "A vehicle");
            hashtable.Add("sun", "A star");

            // Access values by key
            string value1 = (string)hashtable["apple"];
            string value2 = (string)hashtable["car"];
            string value3 = (string)hashtable["sun"];

            Console.WriteLine("Value for key 'apple': " + value1);
            Console.WriteLine("Value for key 'car': " + value2);
            Console.WriteLine("Value for key 'sun': " + value3);

            // Check if a key exists
            bool containsKey = hashtable.ContainsKey("apple");
            Console.WriteLine("Contains key 'apple': " + containsKey);

            // Remove a key-value pair
            hashtable.Remove("car");

            // Iterate over the keys and values
            foreach (DictionaryEntry entry in hashtable)
            {
                string key = (string)entry.Key;
                string value = (string)entry.Value;
                Console.WriteLine("Key: " + key + ", Value: " + value);
            }
        
    }
}
