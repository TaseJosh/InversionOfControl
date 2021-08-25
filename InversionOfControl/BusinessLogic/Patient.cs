namespace InversionOfControl
{
    public class Patient
    {
        IDataAccessLayer dataAccessLayer;
        public Patient(IDataAccessLayer dalType)
        {
            dataAccessLayer = dalType;
        }
        public bool IsValid { get { return true; } }
        public void Add()
        {
            if (IsValid)
            {
                dataAccessLayer.Add(this);
            }
        }
    }
}