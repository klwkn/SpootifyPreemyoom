namespace Spootefee
{
    public class NodeMain<T>
    {
        public T TData { get; set; }
        public NodeMain<T> Next { get; internal set; }
        public NodeMain(T tdata)
        {
            this.TData = tdata;
        }
    }
}