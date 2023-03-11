namespace HW_La_casa_de_papel
{
    internal class fake : Characters
    {
        private string v1;
        private string v2;
        private string v3;
        private (int, int, int) value;
        private string v4;

        public fake(string v1, string v2, string v3, (int, int, int) value, string v4)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
            this.value = value;
            this.v4 = v4;
        }
    }
}