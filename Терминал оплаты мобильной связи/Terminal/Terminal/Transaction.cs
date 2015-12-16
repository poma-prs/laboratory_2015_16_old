namespace Terminal
{
    public class Transaction
    {
        public MobileOperator Operator;
        public string PhoneNumber;
        public int Sum;

        public Transaction() { }

        public Transaction(string source)
        {
            string[] splittedSource = source.Split(new char[] { ' ' });
            if (splittedSource.Length != 3)
                return;
            switch (splittedSource[0])
            {
                case "MTS":
                    Operator = MobileOperator.MTS;
                    break;
                case "Beeline":
                    Operator = MobileOperator.Beeline;
                    break;
                case "Megaphone":
                    Operator = MobileOperator.Megaphone;
                    break;
            };
            PhoneNumber = splittedSource[1];
            int.TryParse(splittedSource[2], out Sum);
        }

        public override string ToString()
        {
            return Operator.ToString() + " " + PhoneNumber.Replace(" ", "") + " " + Sum.ToString();
        }
    }
}