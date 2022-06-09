namespace consumption
{
    internal class StremWriter
    {
        private string fileName;
        private bool v;

        public StremWriter(string fileName, bool v)
        {
            this.fileName = fileName;
            this.v = v;
        }
    }
}