namespace MySql.Driver
{
    public class InputParameters
    {
        public int NO { get; set; }
        public string OPERATION { get; set; }
        public string CONDITION { get; set; }
        public string ORDER { get; set; }
        public int LIMIT { get; set; }
        public int OFFSET { get; set; }
        public object DATA { get; set; }
    }
}
