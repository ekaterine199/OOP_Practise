namespace OOP_Practise.Task_2
{
    public class CustomQueue<T>
    {
        private List<T> queue;
        public CustomQueue()
        {
            queue = new List<T>();
        }
        public CustomQueue(int size)
        {
            queue = new List<T>(size);
        }

        public bool IsEmpty()
        {
            return queue.Count == 0;
        }

        public void AddItem(T item)
        {
            queue.Add(item);
        }

        public void PrintItems()
        {
            foreach (var i in queue)
            {
                Console.WriteLine(i);
            }

        }


        public T DeleteItem()
        {
            T item = queue[0];
            queue.RemoveAt(0);
            return item;
        }

        public int Count()
        {
            return queue.Count();
        }

    }
}
