using System;
using System.Collections.Generic;
using System.IO;

namespace Terminal
{
    public class DiscWriter
    {
        Queue<Transaction> queue;
        StreamWriter logFile;

        public DiscWriter(ref Queue<Transaction> queue)
        {
            this.queue = queue;

            StreamReader storedQueue = new StreamReader("Queue");

            string line;
            while ((line = storedQueue.ReadLine()) != null)
            {
                queue.Enqueue(new Transaction(line));
            }

            storedQueue.Close();

            logFile = new StreamWriter("Log.txt");
        }

        public void WriteToLog(Transaction transaction)
        {
            logFile.WriteLine(DateTime.Now + " " + transaction.ToString());
        }

        public void StoreQueue()
        {
            StreamWriter storedQueue = new StreamWriter("Queue");
            foreach (var transaction in queue)
            {
                storedQueue.WriteLine(transaction.ToString());
            }
            storedQueue.Close();
        }

        public void Close()
        {
            logFile.Close();
        }
    }
}